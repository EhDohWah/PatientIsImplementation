using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PatientIsImplementation
{
    internal class Patients: XPObject
    {
        public Patients(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _IDCard;
        public string IDCard
        {
            get { return _IDCard; }
            set { SetPropertyValue(nameof(IDCard), ref _IDCard, value); }
        }

        private string _FingerPrintID;

        public string FingerPrintID
        {
            get { return _FingerPrintID; }
            set { SetPropertyValue(nameof(FingerPrintID), ref _FingerPrintID, value); }
        }

        private DateTime _AdmissionDate;

        public DateTime AdmissionDate
        {
            get { return _AdmissionDate; }
            set { SetPropertyValue(nameof(AdmissionDate), ref _AdmissionDate, value); }
        }

        private string _FullName;
        
        public string FullName
        {
            get { return _FullName; }
            set { SetPropertyValue(nameof(FullName), ref _FullName, value); }
        }

        private string _MotherName;

        public string MotherName 
        {
            get { return _MotherName; }
            set { SetPropertyValue(nameof(MotherName), ref _MotherName, value); }
        }

        private string _FatherName;
        public string FatherName
        {
            get { return _FatherName; }
            set { SetPropertyValue(nameof(FatherName), ref _FatherName, value); }
        }


        private string _SpouseName;

        public string SpouseName
        {
            get { return _SpouseName; }
            set { SetPropertyValue(nameof(SpouseName), ref _SpouseName, value); }
        }

        private string _Gender;

        public string Gender
        {
            get { return _Gender; }
            set { SetPropertyValue(nameof(Gender), ref _Gender, value); }
        }


        private int _DOB_year;
        public int DOB_year
        {
            get { return _DOB_year; }
            set { SetPropertyValue(nameof(DOB_year), ref _DOB_year, value); }
        }

        private int _DOB_month;
        public int DOB_month
        {
            get { return _DOB_month; }
            set { SetPropertyValue(nameof(DOB_month), ref _DOB_month, value); }
        }


        private int _DOB_day;

        public int DOB_day
        {
            get { return _DOB_day; }
            set { SetPropertyValue(nameof(DOB_day), ref _DOB_day, value); }
        }

        string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { SetPropertyValue(nameof(PhoneNumber), ref _PhoneNumber, value); }
        }


        private string _AddressCode;

        public string AddressCode { 
            get { return _AddressCode; }
            set { SetPropertyValue(nameof(AddressCode), ref _AddressCode, value); }
        }

        private string _AddressOther;

        public string AddressOther
        {
            get { return _AddressOther; }
            set { SetPropertyValue(nameof(AddressOther), ref _AddressOther, value); }
        }

        private string _Note;

        public string Note { 
            get { return _Note; }
            set { SetPropertyValue(nameof(Note), ref _Note, value); }
        }

        private DateTime _LastModified;

        public DateTime LastModified
        {
            get { return _LastModified; }
            set { SetPropertyValue(nameof(LastModified), ref _LastModified, value); }
        }


        private DateTime _LastSync;

        public DateTime LastSync
        {
            get { return _LastSync; }
            set { SetPropertyValue(nameof(LastSync), ref _LastSync, value); }
        }
    }
}
