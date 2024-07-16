using DevExpress.Xpo;
using libzkfpcsharp;
using PatientIsImplementation.Models;
using PatientIsImplementation.UiComponents;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZKTecoFingerPrintScanner_Implementation.Helpers;

namespace PatientIsImplementation.Menu
{
    public partial class IdentifyPatientForm : Form
    {

        // Create an instance (object) of zkfp class;
        public Home home = new Home(null, null, 0, 0);
        IntPtr FormHandle = IntPtr.Zero;

        int RegisterCount = 0;
        int regTempLen = 0;
        public static int iFid = 1;
        static byte[] RegTmp = new byte[2048];
        public static bool bIdentify = false;

        //For DoCaputer method.
        byte[][] RegTmps = new byte[3][];
        public static byte[] CapTmp = new byte[2048];
        int cbCapTmp;
        bool IsRegister = false;
        public static byte[] dbString = new byte[2048];


        const int REGISTER_FINGER_COUNT = 3;
        bool bIsTimeToDie = false;


        public int mfpWidth = 0;
        public int mfpHeight = 0;


        // Thread 
        Thread captureThread = null;

        byte[] FPBuffer;   // Image Buffer
        private int selectedDeviceIndex;


        public IdentifyPatientForm()
        {
            InitializeComponent();

        }


        private void IdentifyForm_Load(object sender, EventArgs e)
        {
            TitleMain mainTitle = new TitleMain();
            mainTitle.Dock = DockStyle.Fill;
            pnlIdTitle.Controls.Add(mainTitle);

            connectDevice();
            btnIdentify_Click();
            FormHandle = this.Handle;


        }


        void connectDevice()
        {
            //int initializeCallBackCode = fpInstance.Initialize();
            if (Home.statuscode >= zkfp.ZKFP_ERR_OK)
            {
                //int nCount = Home.fpInstance.GetDeviceCount();
                //if (nCount > 0)
                //{
                //    // Assuming you want to connect to the first available device automatically
                //    int selectedDeviceIndex = 0;
                //}
                //else
                //{
                //    int finalizeCount = Home.fpInstance.Finalize();
                //    MessageBox.Show("No device available.");
                //    return;
                //}

                // Connect to the fingerprint device
                int openDeviceCallBackCode = Home.fpInstance.OpenDevice(Home.selectedDeviceIndex);
                if (zkfp.ZKFP_ERR_OK != openDeviceCallBackCode)
                {
                    MessageBox.Show($"Unable to connect with the device! (Return Code: {openDeviceCallBackCode} )");
                    return;
                }

                RegisterCount = 0;
                regTempLen = 0;
                iFid = 1;

                for (int i = 0; i < REGISTER_FINGER_COUNT; i++)
                {
                    RegTmps[i] = new byte[2048];
                }

                byte[] paramValue = new byte[4];


                // Retrieve the fingerprint image width 
                int size = 4;
                Home.fpInstance.GetParameters(1, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

                // Retrieve the fingerprint image height
                size = 4;
                Home.fpInstance.GetParameters(2, paramValue, ref size);
                zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

                FPBuffer = new byte[mfpWidth * mfpHeight];


                // Create a thread to retrieve any new fingerprint and handle device events
                captureThread = new Thread(new ThreadStart(DoCapture));
                captureThread.IsBackground = true;
                captureThread.Start();

                bIsTimeToDie = false;

                // If connection is successful, show the device NO.
                Data_Layer.Connect();

                // Connected Successfully
                MessageBox.Show("Fingerprint Device Connected Successfully!");
                //toolStripStatusLabel1.Text = "The device is successfully connected";
                //toolStripStatusLabel1.BackColor = Color.FromArgb(79, 208, 154);

                //tbcPatientInfo.Visible = true;

                string devSN = Home.fpInstance.devSn;
                //lblConnectionStatus.Text = "Connected \nDevice S.No: " + devSN;
                //UpdateDeviceStatus("Connected \nDevice S.No: " + devSN); // Update device status on the UI
            }
            else
            {

                //MessageBox.Show($"Unable to initialize the device. Unable to load the algorithms! Please Connect the device");
                //home.toolStripStatusLabelMessage.Text = "$\"Unable to initialize the device. Unable to load the algorithms! Please Connect the device\"";
                //home.toolStripStatusLabelMessage.BackColor = Color.FromArgb(230, 112, 134);
            }
        }

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;



        public void DoCapture()
        {
            try
            {
                while (!bIsTimeToDie)
                {
                    cbCapTmp = 2048;
                    int ret = Home.fpInstance.AcquireFingerprint(FPBuffer, CapTmp, ref cbCapTmp);

                    if (ret == zkfp.ZKFP_ERR_OK)
                    {
                        SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                    }
                    Thread.Sleep(100);
                }
            }
            catch { }

        }

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);


        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    // All your registration and verification code needs to be handled here

                    DisplayFingerPrintImage();
                    if (bIdentify)
                    {
                        // Clear data
                        //tbxFingerPrintId.Clear();
                        //tbxFullName.Clear();
                        //tbxMotherName.Clear();
                        //tbxFatherName.Clear();
                        //tbxSpouseName.Clear();
                        //tbxGender.Clear();
                        //tbxDOB.Clear();
                        //tbxPhoneNumber.Clear();

                        // Read data
                        MatchFingerprintAsync();

                    }

                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }

        private async Task MatchFingerprintAsync()
        {
            await Task.Run(() =>
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var query = uow.Query<Patients>()
                            .Join(uow.Query<Addresses>(),
                                  patient => patient.AddressCode,
                                  address => address.AddressCode,
                                  (patient, address) => new { Patient = patient, Address = address });

                    foreach (var data in query)
                    {
                        int fID = 1;
                        dbString = zkfp.Base64String2Blob(data.Patient.FingerPrintID);
                        Home.fpInstance.AddRegTemplate(fID, dbString);

                        int ret = zkfp.ZKFP_ERR_OK;
                        int fid = 0;
                        ret = Home.fpInstance.Match(CapTmp, dbString);
                        if (0 < ret)
                        {
                            // Update UI on the main thread
                            BeginInvoke(new Action(() =>
                            {
                                // Patient information
                                tsslIdStatus.Text = "Identification Success";
                                tsslIdStatus.BackColor = Color.FromArgb(79, 208, 154);
                                tbxIDcard.Text = data.Patient.IDCard;
                                tbxFingerPrintId.Text = data.Patient.FingerPrintID;
                                tbxFullName.Text = data.Patient.FullName;
                                tbxMotherName.Text = data.Patient.MotherName;
                                tbxFatherName.Text = data.Patient.FatherName;
                                tbxSpouseName.Text = data.Patient.SpouseName;
                                tbxGender.Text = data.Patient.Gender;
                                dtpDOB.Value = new DateTime(data.Patient.DOB_year, data.Patient.DOB_month, data.Patient.DOB_day);
                                tbxPhoneNumber.Text = data.Patient.PhoneNumber;

                                // Patient Address
                                tbxAddressCode.Text = data.Address.AddressCode;
                                tbxSectionName.Text = data.Address.SectionName_EN;
                                tbxVillageCode.Text = data.Address.VillageCode;
                                tbxVillageNEN.Text = data.Address.VillageName_EN;
                                tbxVillageNMM.Text = data.Address.VillageName_MM;
                                tbxVillageNK.Text = data.Address.VillageName_KAREN;
                                tbxDisctrictCode.Text = data.Address.DistrictCode;
                                tbxRegionCode.Text = data.Address.RegionCode;
                                tbxProvinceCode.Text = data.Address.ProvinceCode;
                                tbxCountryCode.Text = data.Address.CountryCode;

                            }));

                            int deleteCode = Home.fpInstance.DelRegTemplate(fid);
                            // <---- REMOVE FINGERPRINT
                            if (deleteCode != zkfp.ZKFP_ERR_OK)
                            {
                                btnIdentify_Click();
                            }
                            // Exit the loop after successful identification
                            break;
                        }
                        // Add an else condition if you want to handle identification failures
                        else
                        {
                            // Update UI on the main thread
                            BeginInvoke(new Action(() =>
                            {
                                tsslIdStatus.Text = "No Records Found!";
                                tsslIdStatus.BackColor = Color.FromArgb(230, 112, 134);
                                tbxIDcard.Text = "";
                                tbxFingerPrintId.Text = "";
                                tbxFullName.Text = "";
                                tbxMotherName.Text = "";
                                tbxFatherName.Text = "";
                                tbxSpouseName.Text = "";
                                tbxGender.Text = "";
                                dtpDOB.Value = DateTime.Now;
                                tbxPhoneNumber.Text = "";

                                tbxAddressCode.Text = "";
                                tbxSectionName.Text = "";
                                tbxVillageCode.Text = "";
                                tbxVillageNEN.Text = "";
                                tbxVillageNMM.Text = "";
                                tbxVillageNK.Text = "";
                                tbxDisctrictCode.Text = "";
                                tbxCountryCode.Text = "";
                                tbxRegionCode.Text = "";
                                tbxProvinceCode.Text = "";
                                tbxCountryCode.Text = "";
                            }));
                        }
                    }
                }
            });
        }



        private void IdentifyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnDisconnect(sender, null);
        }

        private void ClearImage()
        {
            picFPImg.Image = null;
            //pbxImage2.Image = null;
        }

        private void btnDisconnect(object sender, EventArgs e)
        {
            int result = Home.fpInstance.CloseDevice();  // Close the connection
            bIsTimeToDie = true;
            RegisterCount = 0;
            Home.nCount = -2;
            //DisconnectFingerPrintCounter();

            if (captureThread == null || !captureThread.IsAlive)
            {
                // Show "connect to the device"
                MessageBox.Show("Connect to the device.");
            }
            else
            {
                // If captureThread is running, abort it
                captureThread.Abort();
            }

            if (result == zkfp.ZKFP_ERR_OK)
            {
                result = Home.fpInstance.Finalize();   // Clear the resources
                if (result == zkfp.ZKFP_ERR_OK)
                {
                    // Reset any variables and data if necessary
                    ClearImage();

                    //btnDisconnect.Visible = false;
                    //tbcPatientInfo.Visible = false;
                    //toolStripStatusLabel1.Text = "Please click the 'CONNECT' button to connect the device.";
                    //toolStripStatusLabel1.BackColor = Color.FromArgb(230, 112, 134);
                }
            }
        }

        private void btnIdentify_Click()
        {
            if (!bIdentify)
            {
                bIdentify = true;

                tsslIdStatus.Text = "Press the finger to identificaiton";
                tsslIdStatus.BackColor = Color.FromArgb(79, 208, 154);
            }
        }


        public void DisplayFingerPrintImage()
        {
            //Bitmap fingerPrintImage = GetImage(FPBuffer, fpInstance.imageWidth, fpInstance.imageHeight);
            //Rectangle cropRect = new Rectangle(0, 0, picFPImg.Width / 2, picFPImg.Height / 2);
            //Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);
            //using (Graphics g = Graphics.FromImage(target))
            //{
            //    g.DrawImage(fingerPrintImage, new Rectangle(0, 0, target.Width, target.Height), cropRect, GraphicsUnit.Pixel);
            //}
            //this.picFPImg.Image = target;

            // OPTIMIZED METHOD
            MemoryStream ms = new MemoryStream();
            BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
            Bitmap bmp = new Bitmap(ms);
            this.picFPImg.Image = bmp;
        }

        private void tbcPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPatient.SelectedTab == tbpPersonalInfo)
            {
                tbpPersonalInfo.BackColor = Color.Red;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate tbxsearch IDCard
            if (string.IsNullOrEmpty(tbxSearchIDcard.Text))
            {
                MessageBox.Show("Please Enter Patient IDCard Number!");
                tbxSearchIDcard.Focus();
                return;
            }

            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var query = from patient in uow.Query<Patients>()
                                join address in uow.Query<Addresses>()
                                on patient.AddressCode equals address.AddressCode
                                where patient.IDCard == tbxSearchIDcard.Text.Trim()
                                select new { Patient = patient, Address = address };

                    // Check if the query result is empty
                    if (!query.Any())
                    {
                        MessageBox.Show("No patient found with the provided ID card number", "Invalid ID Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxSearchIDcard.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("A record found!", "Patient detail information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // If query is not empty, continue with your logic to process the results
                    foreach (var data in query)
                    {
                        // Display patient personal data
                        tbxIDcard.Text = tbxSearchIDcard.Text;
                        tbxFullName.Text = data.Patient.FullName;
                        tbxMotherName.Text = data.Patient.MotherName;
                        tbxFatherName.Text = data.Patient.FatherName;
                        tbxSpouseName.Text = data.Patient.SpouseName;
                        tbxGender.Text = data.Patient.Gender;
                        dtpDOB.Value = new DateTime(data.Patient.DOB_year, data.Patient.DOB_month, data.Patient.DOB_day);
                        tbxPhoneNumber.Text = data.Patient.PhoneNumber;

                        // Display addresses
                        tbxAddressCode.Text = data.Address.AddressCode;
                        tbxSectionName.Text = data.Address.SectionName_EN;
                        tbxVillageCode.Text = data.Address.VillageCode;
                        tbxVillageNEN.Text = data.Address.VillageName_EN;
                        tbxVillageNMM.Text = data.Address.VillageName_MM;
                        tbxVillageNK.Text = data.Address.VillageName_KAREN;
                        tbxDisctrictCode.Text = data.Address.DistrictCode;
                        tbxProvinceCode.Text = data.Address.ProvinceCode;
                        tbxRegionCode.Text = data.Address.RegionCode;
                        tbxCountryCode.Text = data.Address.CountryCode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
