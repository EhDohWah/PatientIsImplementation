using DevExpress.Xpo;
using PatientIsImplementation.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PatientIsImplementation.login
{
    public partial class UserRegisterForm : UserControl
    {
        public static int role;
        private const int SaltSize = 16;
        private const int HashSize = 20;
        private const int Iterations = 10000;

        public UserRegisterForm()
        {
            InitializeComponent();

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

        private void btnURRegister_Click(object sender, EventArgs e)
        {


            //validate tbxURUsername using regular express && check if empty or not 
            if (string.IsNullOrEmpty(tbxURUsername.Text))
            {
                errorProviderUR.SetError(tbxURUsername, "This field is required");
                MessageBox.Show("Please enter username.", "Empty username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(tbxURUsername.Text, @"^[a-zA-Z]+$"))
            {
                errorProviderUR.SetError(tbxURUsername, "Username can only contain letters");
                MessageBox.Show("Username can only contain letters.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxURUsername.Text.Length < 2)
            {
                errorProviderUR.SetError(tbxURPassword, "The username must be at least 2 characters.");
                MessageBox.Show("Username must be at least 2 characters.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username already exists in the database
            using (var uow = new UnitOfWork())
            {
                var existingUser = uow.Query<Users>().FirstOrDefault(u => u.Username == tbxURUsername.Text);
                if (existingUser != null)
                {
                    errorProviderUR.SetError(tbxURUsername, "Username already exists");
                    MessageBox.Show("Username already exists. Please type a new username.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // validate password with 8 characters and must be strong enough 

            if (string.IsNullOrEmpty(tbxURPhoneNumber.Text))
            {
                errorProviderUR.SetError(tbxURPhoneNumber, "This field is required");
                MessageBox.Show("Please enter phonenumber.", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validate phone number length
            if (tbxURPhoneNumber.Text.Length != 10)
            {
                errorProviderUR.SetError(tbxURPhoneNumber, "Phone number must be 10 digits long");
                MessageBox.Show("Phone number must be 10 digits long.", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate phone number format using regular expression
            if (!Regex.IsMatch(tbxURPhoneNumber.Text, @"^\d{10}$"))
            {
                errorProviderUR.SetError(tbxURPhoneNumber, "Phone number must contain digits only");
                MessageBox.Show("Phone number must contatin digits only.", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password length
            if (string.IsNullOrEmpty(tbxURPassword.Text))
            {
                errorProviderUR.SetError(tbxURPassword, "This field is required");
                MessageBox.Show("Please enter password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxURPassword.Text.Length < 8)
            {
                errorProviderUR.SetError(tbxURPassword, "Password must be at least 8 characters long");
                MessageBox.Show("Password must be at least 8 characters long", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tbxURConfirmPassword.Text))
            {
                errorProviderUR.SetError(tbxURConfirmPassword, "This field is required");
                MessageBox.Show("Please enter the password to confirm.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxURPassword.Text != tbxURConfirmPassword.Text)
            {
                errorProviderUR.SetError(tbxURConfirmPassword, "Passwords do not match");
                MessageBox.Show("Please enter the same password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Input validation for date of birth
            if (string.IsNullOrEmpty(dtpURDOB.Value.ToString("yyyy-mm-dd")))
            {
                errorProviderUR.SetError(tbxURConfirmPassword, "This field is required");
                return;
            }

            if (dtpURDOB.Value.Year >= 2006)
            {
                errorProviderUR.SetError(dtpURDOB, "Date of birth must be before 2006");
                MessageBox.Show("Date of birth must be before 2006", "Date of Birth", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(cbxUserRole.Text))
            {
                errorProviderUR.SetError(cbxUserRole, "This field is required");
                MessageBox.Show("Please select the role.", "User Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (cbxUserRole.Text == "Admin")
            {
                role = 1;
            }
            else if (cbxUserRole.Text == "HQ-Data-Staff")
            {
                role = 2;
            }
            else
            {
                role = 3;
            }



            int autoId = 1; // Default value if no records exist

            // Query the database for the highest existing OfflinePID and increment it by one
            using (var uow = new UnitOfWork())
            {
                try
                {
                    var users = new XPQuery<Users>(uow);
                    var maxId = users.Max(p => (int?)p.Id); // Cast to nullable int
                    if (maxId != null)
                    {
                        autoId = maxId.Value + 1;
                    }
                }
                catch
                {
                    autoId = 1;
                }
            }


            using (UnitOfWork uow = new UnitOfWork())
            {
                var users = new Users(uow);
                users.Id = autoId;
                users.Username = tbxURUsername.Text;
                users.PhoneNumber = tbxURPhoneNumber.Text;
                users.Password = HashPassword(tbxURPassword.Text);
                users.LastLogin = DateTime.Now;
                users.DOB = dtpURDOB.Value.Date;
                users.UserRole = role;


                try
                {
                    uow.CommitChanges();
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxURUsername.Clear();
                    tbxURPhoneNumber.Clear();
                    tbxURPassword.Clear();
                    tbxURConfirmPassword.Clear();
                    dtpURDOB.Value = DateTime.Now;
                    cbxUserRole.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration failed. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void chBoxPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxPasswordShow.Checked == true)
            {
                tbxURPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxURPassword.UseSystemPasswordChar = true;
            }
        }

        private void chBoxConfirmPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxConfirmPasswordShow.Checked == true)
            {
                tbxURConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxURConfirmPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
