using DevExpress.Xpo;
using PatientIsImplementation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientIsImplementation.login.ForgotPassword
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnForgotNext_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(tbxPhoneNumber.Text))
            {
                errorProviderForgot.SetError(tbxPhoneNumber, "This field is required");
                return;
            }

            using (UnitOfWork uow = new UnitOfWork()) 
            {
                var user = uow.Query<Users>().FirstOrDefault(x => x.PhoneNumber == tbxPhoneNumber.Text.Trim());
                if (user == null)
                {
                    MessageBox.Show("User does not exist");
                    return;
                } else if ( user.DOB == dtpDOBForgotPassword.Value.Date)
                {
                    this.Hide();
                    ConfirmForgotPassword confirmForgotPassword = new ConfirmForgotPassword(user.PhoneNumber);
                    confirmForgotPassword.ShowDialog();
                    this.Close();
                } else
                {
                    MessageBox.Show("Please Enter the date of birth correctly!");
                }

            }




        }
    }
}
