using DevExpress.Xpo;
using libzkfpcsharp;
using PatientIsImplementation.Admin;
using PatientIsImplementation.Menu;
using PatientIsImplementation.Models;
using PatientIsImplementation.UiComponents;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PatientIsImplementation
{
    public partial class Home : Form
    {

        public static zkfp fpInstance = new zkfp();
        public static int statuscode = -1;
        public static int selectedDeviceIndex;
        public static int nCount;
        public string message;
        public string username;
        public string userRole;
        public static int roleNo;
        private int userId;

        public Home(string message, string username, int role, int uId)
        {
            InitializeComponent();

            this.message = message;
            this.username = username;
            roleNo = role;
            if (role == 1)
            {
                this.userRole = "Admin";
            }
            else if (role == 2)
            {
                this.userRole = "HQ-Data-Staff";
                btnAdmin.Enabled = false;
            }
            else
            {
                this.userRole = "Clinical Staff";
                btnAdmin.Enabled = false;
                btnEdit.Enabled = false;
            }
            userId = uId;
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Main main = new Main();
        //    main.ShowDialog();

        //}

        private void Home_Load(object sender, EventArgs e)
        {
            TitleMain mainTitle = new TitleMain();
            mainTitle.Dock = DockStyle.Fill;
            pnlMenuTitle.Controls.Add(mainTitle);
            toolStripStatusLabelMessage.Text = "Successfully Logged in.";
            toolStripStatusLabelMessage.BackColor = Color.FromArgb(79, 208, 154);
            lblUsername.Text = this.username;
            lblRoleShow.Text = this.userRole;

            // Start the timer and set its interval (e.g., every 1000 milliseconds)
            timer.Interval = 1000; // 1 second
            timer.Start();
        }


        /*
            Name: Entry_Button_click
         
        */
        private void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {

                nCount = fpInstance.GetDeviceCount();
                if (nCount > 0)
                {
                    selectedDeviceIndex = 0;
                    //MessageBox.Show("Device connected!");
                    RegisterPatientForm registerForm = new RegisterPatientForm(userId);
                    registerForm.ShowDialog();
                    //toolStripStatusMessage.Text = "Hello World";
                }
                else
                {
                    zkfp2.Terminate();
                    MessageBox.Show("No device available.", "Device Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found. Please try again");

                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            statuscode = fpInstance.Initialize();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            nCount = fpInstance.GetDeviceCount();
            if (nCount > 0)
            {
                selectedDeviceIndex = 0;
                //MessageBox.Show("Device connected!");
                IdentifyPatientForm identifyForm = new IdentifyPatientForm();
                identifyForm.ShowDialog();
                //toolStripStatusMessage.Text = "Hello World";
            }
            else
            {
                zkfp2.Terminate();
                MessageBox.Show("No device available.", "Device Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm(userId, username);
            adminMainForm.ShowDialog();


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            // Show the main form again and close the current form

            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var user = uow.Query<Users>()
                       .FirstOrDefault(p => p.Id == userId);

                    user.LastLogout = DateTime.Now;
                    uow.CommitChanges();
                }
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
                this.Close();

            }
            catch
            {
                MessageBox.Show("Logout Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            EditPatientForm editForm = new EditPatientForm();
            editForm.ShowDialog();

        }


    }
}
