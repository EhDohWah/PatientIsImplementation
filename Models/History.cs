using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientIsImplementation.Models
{
    internal class History: XPObject
    {
        public History(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private int _Hist_Id;
        public int Hist_Id
        {
            get { return _Hist_Id; }
            set { SetPropertyValue(nameof(Hist_Id), ref _Hist_Id, value); }
        }

        private int _User_Id;

        public int User_Id { 
            get { return _User_Id; }
            set { SetPropertyValue(nameof(User_Id), ref _User_Id, value); }
        }

        private string _Patient_IDCard;

        public string Patient_IDCard
        {
            get { return _Patient_IDCard; }
            set { SetPropertyValue(nameof(Patient_IDCard), ref _Patient_IDCard, value); }
        }

        private DateTime _Checkin_date;

        public DateTime Checkin_Date
        {
            get { return _Checkin_date;}
            set { SetPropertyValue(nameof(Checkin_Date), ref _Checkin_date, value); }
        }

        private string _Remark;

        public string Remark
        {
            get { return _Remark; }
            set { SetPropertyValue(nameof(Remark), ref _Remark, value); }
        }
    }
}
