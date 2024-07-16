using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace PatientIsImplementation.Models
{
    public class Users: XPObject
    {
        public Users(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { SetPropertyValue(nameof(Id), ref _Id, value); }
        }

        private string _Username;

        // Username
        public string Username
        {
            get { return _Username; }
            set { SetPropertyValue(nameof(Username), ref _Username, value); }
        }

        private string _PhoneNumber;

        // Phone Number
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { SetPropertyValue(nameof(PhoneNumber), ref _PhoneNumber ,value); }
        }

        private DateTime _DOB;


        // Date of Birth
        public DateTime DOB
        {
            get { return _DOB; }
            set { SetPropertyValue(nameof(DOB), ref _DOB ,value); }
        }

        private string _Password;

        // Password
        public string Password
        {
            get { return _Password; }
            set { SetPropertyValue(nameof(Password), ref _Password ,value); }
        }
        
        private DateTime _LastLogin;

        // Last Login
        public DateTime LastLogin
        {
            get { return _LastLogin; }
            set { SetPropertyValue(nameof(LastLogin), ref _LastLogin ,value); }
        }

        private DateTime _LastLogout;


        // Last Logout
        public DateTime LastLogout
        {
            get { return _LastLogout; }
            set { SetPropertyValue(nameof(LastLogout), ref _LastLogout ,value); }
        }

        
        private int _UserRole;

        // User Role
        public int UserRole
        {
            get { return _UserRole; }
            set { SetPropertyValue(nameof(UserRole), ref _UserRole, value); }
        }

        
    }
}
