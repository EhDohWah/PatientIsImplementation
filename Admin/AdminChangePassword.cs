using DevExpress.Xpo;
using PatientIsImplementation.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PatientIsImplementation.Admin
{
    public partial class AdminChangePassword : Form
    {
        public int userid;
        public string username;
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int Iterations = 10000;
        public AdminChangePassword(int id, string username)
        {
            InitializeComponent();
            this.userid = id;
            lblAdminName.Text = username;
        }


        private void chbOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOldPassword.Checked == true)
            {
                tbxOldPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxOldPassword.UseSystemPasswordChar = true;
            }
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

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            for (int i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void chBoxNewPasswordShow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chBoxNewPasswordShow.Checked == true)
            {
                tbxNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void chBoxConfirmPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfirmPasswordShow.Checked == true)
            {
                tbxConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Validate password length
            if (string.IsNullOrEmpty(tbxOldPassword.Text))
            {
                errorProviderOldPassword.SetError(tbxOldPassword, "This field is required");
                MessageBox.Show("Please enter old password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var user = uow.Query<Users>().FirstOrDefault(u => u.Id == userid);

                    if (!(VerifyPassword(tbxOldPassword.Text, user.Password)))
                    {
                        errorProviderOldPassword.SetError(tbxOldPassword, "The old password does not match");
                        MessageBox.Show("Please enter correct old password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (tbxNewPassword.Text.Length < 8)
            {
                errorProviderNewPassword.SetError(tbxNewPassword, "Password must be at least 8 characters long");
                MessageBox.Show("Password must be at least 8 characters long", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tbxNewPassword.Text))
            {
                errorProviderNewPassword.SetError(tbxNewPassword, "This field is required");
                MessageBox.Show("Please enter the new password.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tbxConfirmPassword.Text))
            {
                errorProviderConfirmPassword.SetError(tbxConfirmPassword, "This field is required");
                MessageBox.Show("Please enter the new password again to confirm.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (tbxNewPassword.Text != tbxConfirmPassword.Text)
            {
                errorProviderConfirmPassword.SetError(tbxNewPassword, "Passwords do not match");
                MessageBox.Show("Please enter the same password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (UnitOfWork uow = new UnitOfWork())
            {
                var user = uow.Query<Users>().FirstOrDefault(u => u.Id == userid);

                user.Password = HashPassword(tbxConfirmPassword.Text);

                try
                {
                    uow.CommitChanges();
                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to change password. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
