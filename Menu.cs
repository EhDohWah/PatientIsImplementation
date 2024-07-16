using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using libzkfpcsharp;
using PatientIsImplementation.Admin;
using PatientIsImplementation.Menu;
using PatientIsImplementation.UiComponents;
using PatientIsImplementation.Models;

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
            if (role == 1 )
            {
                this.userRole = "Admin";
            } else if ( role == 2 )
            {
                this.userRole = "HQ-Data-Staff";
            } else
            {
                this.userRole = "Clinical Staff";
            }
            userId = uId;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
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
            pnlTitle.Controls.Add(mainTitle);
            toolStripStatusLabelMessage.Text = "Successfully Logged in.";
            toolStripStatusLabelMessage.BackColor = Color.FromArgb(79, 208, 154);
            lblOperatorUsername.Text = this.username;
            lblHomeRoleValue.Text = this.userRole;

            // Start the timer and set its interval (e.g., every 1000 milliseconds)
            timer.Interval = 1000; // 1 second
            timer.Start();
        }


        /*
            Name: Entry_Button_click
         
        */
        private void btnEntry_Click(object sender, EventArgs e)
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
                MessageBox.Show("No device available.");
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
                MessageBox.Show("No device available.");
                return;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (roleNo == 1)
            {
                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.ShowDialog();
            } else
            {
                MessageBox.Show("You are not allowed for this operation!", "Not Accessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

            } catch {
                MessageBox.Show("Logout Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (roleNo == 2)
            {
                EditPatientForm editForm = new EditPatientForm();
                editForm.ShowDialog();
            } else
            {

                MessageBox.Show("You are not allowed for this operation!", "Not Accessible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
