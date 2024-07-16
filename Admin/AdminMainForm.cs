using DevExpress.Xpo;
using PatientIsImplementation.login;
using PatientIsImplementation.UiComponents;
using System;
using System.IO;
using System.Windows.Forms;

namespace PatientIsImplementation.Admin
{
    public partial class AdminMainForm : Form
    {
        public int userid;
        public string username;
        public AdminMainForm(int id, string name)
        {
            InitializeComponent();
            TitleMain adminmainTitle = new TitleMain();
            adminmainTitle.Dock = DockStyle.Fill;
            pnlTitle.Controls.Add(adminmainTitle);
            this.userid = id;
            this.username = name;
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }

        void exportToCsv(string filepath)
        {
            using (StreamWriter write = new StreamWriter(filepath))
            {
                write.WriteLine("IDCard,FingerPrintID,AdmissionDate,FullName,MotherPID,MotherName,FatherName,SpouseName,Gender,AddressCode,DOB_year,DOB_month,DOB_Day,PhoneNumber");

                using (UnitOfWork uow = new UnitOfWork())
                {
                    //Query command
                    XPQuery<Patients> patients = new XPQuery<Patients>(uow);


                    //Bind data to the "VS" components 
                    foreach (Patients data in patients)
                    {
                        write.WriteLine($"{data.IDCard},{data.FingerPrintID},{data.AdmissionDate},{data.FullName},{null},{data.MotherName},{data.FatherName},{data.SpouseName},{data.Gender},{data.AddressCode},{data.DOB_year},{data.DOB_month},{data.DOB_day},{data.PhoneNumber}");
                    }
                }

            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                string fileName = Path.GetFileName(filePath);
                exportToCsv(filePath);
                MessageBox.Show("File exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("File was not exported successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdminPasswordChange_Click(object sender, EventArgs e)
        {
            AdminChangePassword adminChangePassword = new AdminChangePassword(userid, username);
            adminChangePassword.ShowDialog();
        }
    }
}
