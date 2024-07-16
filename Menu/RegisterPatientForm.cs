using DevExpress.Xpo;
using libzkfpcsharp;
using PatientIsImplementation.Models;
using PatientIsImplementation.UiComponents;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using ZKTecoFingerPrintScanner_Implementation.Helpers;

namespace PatientIsImplementation.Menu
{
    // RegisterForm  class
    public partial class RegisterPatientForm : Form
    {
        // Create an instance (object) of zkfp class;
        public Home home = new Home(null, null, 0, 0);

        IntPtr FormHandle = IntPtr.Zero;
        int RegisterCount = 0;
        int regTempLen = 0;
        public static int iFid = 1;
        byte[] RegTmp = new byte[2048];


        //For DoCaputer method.
        byte[][] RegTmps = new byte[3][];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp;
        bool IsRegister = false;


        const int REGISTER_FINGER_COUNT = 3;
        bool bIsTimeToDie = false;


        public int mfpWidth = 0;
        public int mfpHeight = 0;


        // Thread 
        Thread captureThread = null;

        byte[] FPBuffer;   // Image Buffer
        private int selectedDeviceIndex;


        // UserID
        public static int userID;


        public RegisterPatientForm(int Id)
        {
            InitializeComponent();
            DisconnectFingerPrintCounter();
            userID = Id;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            connectDevice();

            TitleMain mainTitle = new TitleMain();
            mainTitle.Dock = DockStyle.Fill;
            pnlRgTitle.Controls.Add(mainTitle);

            //tbcPatientInfo.Visible = false;
            btnCaptuerFP_Click(sender, null);
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
                    //MessageBox.Show($"Unable to connect with the device! (Return Code: {openDeviceCallBackCode} )");
                    MessageBox.Show("Error found. Please try again");
                    Home.statuscode = -1;
                    Close();
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
                //MessageBox.Show("Fingerprint Device Connected Successfully!");
                toolStripStatusLabel1.Text = "The device is successfully connected";
                toolStripStatusLabel1.BackColor = Color.FromArgb(79, 208, 154);

                tbcPatientInfo.Visible = true;

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


        // Method to handle captured fingerprint


        private void btnCaptuerFP_Click(object sender, EventArgs e)
        {
            if (!IsRegister)
            {
                ClearImage();
                IsRegister = true;
                RegisterCount = 0;
                regTempLen = 0;
                toolStripStatusLabel1.Text = "Please press your finger " + REGISTER_FINGER_COUNT + " times to register";

                lblFingerPrintCount.Visible = true;
                lblFingerPrintCount.Text = REGISTER_FINGER_COUNT.ToString();
            }
        }


        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    // All your registration and verification code needs to be handled here

                    DisplayFingerPrintImage();

                    if (IsRegister)
                    {
                        // Code to be executed in case of registration
                        #region -------- IF REGISTERED FINGERPRINT --------

                        int ret = zkfp.ZKFP_ERR_OK;
                        int fid = 0, score = 0;
                        ret = Home.fpInstance.Identify(CapTmp, ref fid, ref score);
                        if (RegisterCount > 0 && Home.fpInstance.Match(CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                        {
                            toolStripStatusLabel1.Text = "Please press the same finger " + REGISTER_FINGER_COUNT + " times for enrollment";

                            return;
                        }
                        Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);

                        RegisterCount++;
                        if (RegisterCount >= REGISTER_FINGER_COUNT)
                        {

                            RegisterCount = 0;
                            ret = GenerateRegisteredFingerPrint();   // <--- GENERATE FINGERPRINT TEMPLATE



                            if (zkfp.ZKFP_ERR_OK == ret)
                            {

                                ret = AddTemplateToMemory();        //  <--- LOAD TEMPLATE TO MEMORY
                                if (zkfp.ZKFP_ERR_OK == ret)         // <--- ENROLL SUCCESSFULL
                                {
                                    string fingerPrintTemplate = string.Empty;
                                    zkfp.Blob2Base64String(RegTmp, regTempLen, ref fingerPrintTemplate);
                                    // GET THE TEMPLATE HERE : fingerPrintTemplate
                                    tbxIDcard.Text = GenerateIDCard(fingerPrintTemplate);
                                    tbxFPid.Text = fingerPrintTemplate;

                                    toolStripStatusLabel1.Text = fingerPrintTemplate;

                                    DisconnectFingerPrintCounter();
                                }
                                else
                                    toolStripStatusLabel1.Text = "Failed to add template";

                            }


                            IsRegister = false;
                            return;
                        }
                        else
                        {
                            int remainingCont = REGISTER_FINGER_COUNT - RegisterCount;
                            lblFingerPrintCount.Text = remainingCont.ToString();
                            string message = "Please provide your fingerprint " + remainingCont + " more time(s)";

                            toolStripStatusLabel1.Text = message;

                        }
                        #endregion
                        // Checkout the 'Registration Case' explained below
                    }
                    else
                    {
                        // Code to be executed in case of fingerprint verification 
                        // and any random fingerprint 
                        // Checkout the 'Identification and Match' case explained below 
                    }

                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }



        private void btnDisconnect(object sender, EventArgs e)
        {
            int result = Home.fpInstance.CloseDevice();  // Close the connection
            bIsTimeToDie = true;
            RegisterCount = 0;
            Home.nCount = -2;
            DisconnectFingerPrintCounter();

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
                    toolStripStatusLabel1.Text = "Please click the 'CONNECT' button to connect the device.";
                    toolStripStatusLabel1.BackColor = Color.FromArgb(230, 112, 134);
                }
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

        public static Bitmap GetImage(byte[] buffer, int width, int height)
        {
            Bitmap output = new Bitmap(width, height);
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = output.LockBits(rect, ImageLockMode.ReadWrite, output.PixelFormat);
            IntPtr ptr = bmpData.Scan0;

            Marshal.Copy(buffer, 0, ptr, buffer.Length);
            output.UnlockBits(bmpData);

            return output;
        }

        private void ClearImage()
        {
            picFPImg.Image = null;
            //pbxImage2.Image = null;
        }

        private int GenerateRegisteredFingerPrint()
        {
            return Home.fpInstance.GenerateRegTemplate(RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref regTempLen);
        }

        private int AddTemplateToMemory()
        {
            return Home.fpInstance.AddRegTemplate(iFid, RegTmp);
        }

        private void DisconnectFingerPrintCounter()
        {
            lblFingerPrintCount.Text = REGISTER_FINGER_COUNT.ToString();
            lblFingerPrintCount.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if the currently selected tab is not the last one
            if (tbcPatientInfo.SelectedIndex < tbcPatientInfo.TabCount - 1)
            {
                // Move to the next tab
                tbcPatientInfo.SelectedIndex++;
            }
            else
            {
                // Optionally, if you want to loop back to the first tab when reaching the last one:
                // tbcPatientInfo.SelectedIndex = 0;

                // Alternatively, if you want to display a message when reaching the last tab:
                MessageBox.Show("You have reached the last tab.", "End of Tabs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnDisconnect(sender, null);

        }

        private void tbxFPid_TextChanged(object sender, EventArgs e)
        {
            tbxFullName.Focus();
        }



        public static string GenerateIDCard(string fingerprintID)
        {
            // Decode the base64 encoded fingerprint ID text
            byte[] fingerprintBytes = Convert.FromBase64String(fingerprintID);
            string decodedFingerprintID = Encoding.UTF8.GetString(fingerprintBytes);

            // Calculate the hash code of the fingerprint ID
            int hashCode = decodedFingerprintID.GetHashCode();

            // Generate a unique 8-character alphanumeric ID using the hash code
            string uniqueID = Math.Abs(hashCode).ToString("X8");

            // Truncate the ID to 8 characters
            if (uniqueID.Length > 8)
                uniqueID = uniqueID.Substring(0, 8);

            // Ensure the ID is exactly 8 characters long
            uniqueID = uniqueID.PadRight(8, '0');

            // Concatenate "ID-" with the generated unique ID
            string idCard = "ID-" + uniqueID;

            // Ensure the ID card is exactly 10 characters long
            idCard = idCard.PadRight(10, '0');

            return idCard;
        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            //validation
            if (string.IsNullOrEmpty(tbxFullName.Text))
            {
                errorProvider.SetError(tbxFullName, "This field is required");
                return;
            }

            if (string.IsNullOrEmpty(cbxGender.Text))
            {
                errorProvider.SetError(cbxGender, "This field is required");
                return;
            }


            if (string.IsNullOrEmpty(tbxPhone.Text))
            {
                errorProvider.SetError(tbxPhone, "This field is required");
                return;
            }


            using (UnitOfWork uow = new UnitOfWork())
            {
                // Validate and set address properties
                if (!string.IsNullOrEmpty(tbxAddressCode.Text) && tbxAddressCode.Text.Length > 5)
                {

                    // Check if the address code is unique
                    if (uow.Query<Addresses>().Any(a => a.AddressCode == tbxAddressCode.Text))
                    {
                        MessageBox.Show("Address code must be unique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Abort operation or handle accordingly
                    }
                }
                else
                {
                    MessageBox.Show("Address code must be meaningful and at least 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Abort operation or handle accordingly
                }
            }





            int histId = 1;

            //Create and save a new data object
            using (UnitOfWork uow = new UnitOfWork())
            {
                // Save Patient data
                var patients = new Patients(uow);
                patients.IDCard = tbxIDcard.Text;
                patients.FingerPrintID = tbxFPid.Text;
                patients.AdmissionDate = DateTime.Now;
                patients.FullName = tbxFullName.Text;
                patients.MotherName = tbxMotherName.Text;
                patients.FatherName = tbxFatherName.Text;
                patients.SpouseName = tbxSpouseName.Text;
                patients.Gender = cbxGender.Text;
                patients.DOB_year = dtpDOB.Value.Year;
                patients.DOB_month = dtpDOB.Value.Month;
                patients.DOB_day = dtpDOB.Value.Day;
                patients.PhoneNumber = tbxPhone.Text;



                // Save data into History table

                var historyrecord = new History(uow);
                var history = new XPQuery<History>(uow);
                var maxOfflinePIDObj = history.Max(p => (int?)p.Hist_Id); // Cast to nullable int
                if (maxOfflinePIDObj != null)
                {
                    histId = maxOfflinePIDObj.Value + 1;
                }
                historyrecord.Hist_Id = histId;
                historyrecord.User_Id = userID;
                historyrecord.Patient_IDCard = tbxIDcard.Text;
                historyrecord.Checkin_Date = DateTime.Now;



                // Save Address data

                var address = new Addresses(uow);
                address.AddressCode = tbxAddressCode.Text;
                address.SectionName_EN = tbxSectionName.Text;
                address.VillageCode = tbxVillageCode.Text;
                address.VillageName_EN = tbxVillageNEn.Text;
                address.VillageName_MM = tbxVillageNMM.Text;
                address.VillageName_KAREN = tbxVillageNKaren.Text;
                address.ProvinceCode = tbxProvinceCode.Text;
                address.ProvinceCode = tbxProvinceCode.Text;
                address.RegionCode = tbxRegionCode.Text;
                address.CountryCode = tbxContryCode.Text;
                address.DistrictCode = tbxDistrictCode.Text;
                patients.AddressCode = tbxAddressCode.Text;



                try
                {
                    uow.CommitChanges();
                    tbxFPid.Clear();
                    tbxFullName.Clear();
                    tbxMotherName.Clear();
                    tbxFatherName.Clear();
                    tbxSpouseName.Clear();
                    cbxGender.SelectedIndex = -1;
                    dtpDOB.Value = DateTime.Now;
                    tbxPhone.Clear();
                    ClearImage();
                    MessageBox.Show("Registration Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcPatientInfo.SelectedIndex--;

                    int deleteCode = Home.fpInstance.DelRegTemplate(iFid);
                    if (deleteCode != zkfp.ZKFP_ERR_OK)
                    {
                        toolStripStatusLabel1.Text = "A recorded is successfully saved in the database";
                        toolStripStatusLabel1.BackColor = Color.FromArgb(79, 208, 154);
                        btnCaptuerFP_Click(sender, null);
                    }
                    iFid = 1;
                    try
                    {

                        if (deleteCode != zkfp.ZKFP_ERR_OK)
                        {
                            MessageBox.Show($"Unable to delete the template! (Return Code: {deleteCode} )");
                        }

                        btnCaptuerFP_Click(sender, null);
                        iFid = 1;
                    }
                    catch { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {

            //validation
            if (string.IsNullOrEmpty(tbxFullName.Text))
            {
                errorProvider.SetError(tbxFullName, "This field is required");
                MessageBox.Show("Please Enter Full Name.", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxFullName.Focus();
                return;
            }

            if (tbxFullName.Text.Length < 2)
            {
                errorProviderFullName.SetError(tbxFullName, "The username must be at least 2 characters.");
                MessageBox.Show("Username must be at least 2 characters.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cbxGender.Text))
            {
                errorProvider.SetError(cbxGender, "This field is required");
                MessageBox.Show("Please select Gender", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxGender.Focus();
                return;
            }


            if (string.IsNullOrEmpty(tbxPhone.Text))
            {
                errorProvider.SetError(tbxPhone, "This field is required");
                MessageBox.Show("Please enter Phone Number", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxPhone.Focus();
                return;
            }


            if (string.IsNullOrEmpty(tbxAddressCode.Text))
            {
                errorProvider.SetError(tbxAddressCode, "This field is required");
                MessageBox.Show("Please enter addressCode", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxAddressCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxSectionName.Text))
            {
                errorProvider.SetError(tbxSectionName, "This field is required");
                MessageBox.Show("Please Enter Section Name.", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxSectionName.Focus();
                return;
            }


            // Check if the address code matches the pattern
            if (!Regex.IsMatch(tbxAddressCode.Text, @"^\d{5}-[A-Za-z]+$"))
            {
                MessageBox.Show("Address code must consist of 5 digits followed by characters (letters). Example: 12345-Aa\r\n98765-AbCd\r\n00000-XyZ", "Error format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAddressCode.Focus();
                return;
            }

            // Validate phone number format using regular expression
            if (!Regex.IsMatch(tbxPhone.Text, @"^\d{10}$"))
            {
                errorProviderPhone.SetError(tbxPhone, "Phone number must contain digits only");
                MessageBox.Show("Phone number must contatin digits only.", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxPhone.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number with 10 digits");
                return;
            }

            int histId = 1;

            //Create and save a new data object
            using (UnitOfWork uow = new UnitOfWork())
            {

                // Save Address data

                var address = new Addresses(uow);
                address.AddressCode = tbxAddressCode.Text;
                address.SectionName_EN = tbxSectionName.Text;
                address.VillageCode = tbxVillageCode.Text;
                address.VillageName_EN = tbxVillageNEn.Text;
                address.VillageName_MM = tbxVillageNMM.Text;
                address.VillageName_KAREN = tbxVillageNKaren.Text;
                address.DistrictCode = tbxDistrictCode.Text;
                address.ProvinceCode = tbxProvinceCode.Text;
                address.RegionCode = tbxRegionCode.Text;
                address.CountryCode = tbxContryCode.Text;

                uow.CommitChanges();

                // Save Patient data
                var patients = new Patients(uow);
                patients.IDCard = tbxIDcard.Text;
                patients.FingerPrintID = tbxFPid.Text;
                patients.AdmissionDate = DateTime.Now;
                patients.FullName = tbxFullName.Text;
                patients.MotherName = tbxMotherName.Text;
                patients.FatherName = tbxFatherName.Text;
                patients.SpouseName = tbxSpouseName.Text;
                patients.Gender = cbxGender.Text;
                patients.DOB_year = dtpDOB.Value.Year;
                patients.DOB_month = dtpDOB.Value.Month;
                patients.DOB_day = dtpDOB.Value.Day;
                patients.PhoneNumber = tbxPhone.Text;
                patients.AddressCode = tbxAddressCode.Text;

                // History Table

                var historyrecord = new History(uow);
                var history = new XPQuery<History>(uow);
                var maxOfflinePIDObj = history.Max(p => (int?)p.Hist_Id); // Cast to nullable int
                if (maxOfflinePIDObj != null)
                {
                    histId = maxOfflinePIDObj.Value + 1;
                }
                historyrecord.Hist_Id = histId;
                historyrecord.User_Id = userID;
                historyrecord.Patient_IDCard = tbxIDcard.Text;
                historyrecord.Checkin_Date = DateTime.Now;

                try
                {
                    uow.CommitChanges();
                    tbxIDcard.Clear();
                    tbxFPid.Clear();
                    tbxFullName.Clear();
                    tbxMotherName.Clear();
                    tbxFatherName.Clear();
                    tbxSpouseName.Clear();
                    cbxGender.SelectedIndex = -1;
                    dtpDOB.Value = DateTime.Now;
                    tbxPhone.Clear();

                    //Address clear
                    tbxAddressCode.Clear();
                    tbxSectionName.Clear();
                    tbxVillageCode.Clear();
                    tbxVillageNEn.Clear();
                    tbxVillageNMM.Clear();
                    tbxVillageNKaren.Clear();
                    tbxProvinceCode.Clear();
                    tbxRegionCode.Clear();
                    tbxContryCode.Clear();
                    tbxDistrictCode.Clear();
                    tbxAddressCode.Clear();



                    ClearImage();
                    MessageBox.Show("Registration Successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcPatientInfo.SelectedIndex = 0;
                    int deleteCode = Home.fpInstance.DelRegTemplate(iFid);
                    if (deleteCode != zkfp.ZKFP_ERR_OK)
                    {
                        toolStripStatusLabel1.Text = "A recorded is successfully saved in the database";
                        toolStripStatusLabel1.BackColor = Color.FromArgb(79, 208, 154);
                        btnCaptuerFP_Click(sender, null);
                    }
                    iFid = 1;
                    try
                    {

                        if (deleteCode != zkfp.ZKFP_ERR_OK)
                        {
                            MessageBox.Show($"Unable to delete the template! (Return Code: {deleteCode} )");
                        }

                        btnCaptuerFP_Click(sender, null);
                        iFid = 1;
                    }
                    catch { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void btnGenerateIDcard_Click(object sender, EventArgs e)
        {


            // Generate a random number
            bool test = true;

            Random random = new Random();
            int randomNumber = random.Next(10000000, 99999999); // Generate a random 8-digit number

            // Concatenate "ID-" with the generated random number
            string idCard = randomNumber.ToString();


            while (test)
            {
                string generatedId = GenerateIDCard(idCard);

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var patient = uow.Query<Patients>().FirstOrDefault(x => x.IDCard == generatedId);

                    if (patient == null)
                    {
                        tbxIDcard.Text = generatedId;
                        test = false;
                    }

                }

            }

        }
    }
}
