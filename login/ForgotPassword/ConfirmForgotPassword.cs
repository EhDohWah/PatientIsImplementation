using DevExpress.Xpo;
using PatientIsImplementation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientIsImplementation.login.ForgotPassword
{
    public partial class ConfirmForgotPassword : Form
    {

        public string PhoneNumber;
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int Iterations = 10000;

        public ConfirmForgotPassword(string phoneNumber)
        {
            InitializeComponent();
            this.PhoneNumber = phoneNumber;
        }

        public static string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            string hashedPassword = Convert.ToBase64String(hashBytes);
            return hashedPassword;
        }

        private void chBxNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxNewPassword.Checked == true)
            {
                tbxNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void chBxConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxConfirmPassword.Checked == true)
            {
                tbxConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNewPassword.Text))
            {
                errorProviderNewPassword.SetError(tbxNewPassword, "This field is required");
                return;
            }

            if (string.IsNullOrEmpty(tbxConfirmPassword.Text))
            {
                errorProviderNewPassword.SetError(tbxConfirmPassword, "This field is required");
                return;
            }

            if (tbxNewPassword.Text != tbxConfirmPassword.Text)
            {
                errorProviderNewPassword.SetError(tbxConfirmPassword, "Passwords do not match");
                return;
            }


            using (UnitOfWork uow = new UnitOfWork())
            {
                var user = uow.Query<Users>().FirstOrDefault(x => x.PhoneNumber == PhoneNumber);
                
                //MessageBox.Show("User exist");
                user.Password = HashPassword(tbxNewPassword.Text);
                try
                {
                   uow.CommitChanges();
                   this.Hide();
                   MessageBox.Show("Password Successfully Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   Main main = new Main(); 
                   main.ShowDialog();
                   this.Close(); 
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Unsuccessfully! Password did not chagne. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
              

            }


        }

        
    }
}
