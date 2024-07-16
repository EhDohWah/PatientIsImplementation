using DevExpress.Xpo;
using PatientIsImplementation.login.ForgotPassword;
using PatientIsImplementation.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PatientIsImplementation.login
{
    public partial class loginForm : UserControl
    {

        public static string Username, Password;
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int Iterations = 10000;
        public string message;

        public Main mainForm;

        public loginForm(Main mainForm)
        {
            InitializeComponent();
            Data_Layer.Connect();
            this.mainForm = mainForm;
        }



        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowPassword.Checked == true)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUsername.Text) && string.IsNullOrEmpty(tbxPassword.Text))
            {
                MessageBox.Show("Please enter your Username and password!", "Empty input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (UnitOfWork uow = new UnitOfWork())
            {
                var user = uow.Query<Users>().FirstOrDefault(x => x.Username == tbxUsername.Text);
                if (user == null)
                {
                    MessageBox.Show("User does not exist", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (tbxUsername.Text.Trim().ToLower() == user.Username.ToLower() && VerifyPassword(tbxPassword.Text, user.Password))
                {
                    message = "success";
                    user.LastLogin = DateTime.Now;
                    uow.CommitChanges();

                    mainForm.Hide();
                    Home home = new Home(message, user.Username, user.UserRole, user.Id);
                    home.ShowDialog();
                    mainForm.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Failed log in", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgot = new ForgotPasswordForm();
            forgot.ShowDialog();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, null);
            }

        }

        //private void lblRegister_Click(object sender, EventArgs e)
        //{
        //    Register registerForm = new Register();
        //    registerForm.ShowDialog();
        //}

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



    }
}
