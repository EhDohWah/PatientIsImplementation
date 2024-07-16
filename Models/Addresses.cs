using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientIsImplementation.Models
{
    internal class Addresses: XPObject 
    {
        public Addresses(Session session): base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _AddressCode;
        public string AddressCode
        {
            get { return _AddressCode; }
            set { SetPropertyValue(nameof(AddressCode), ref _AddressCode, value); }
        }

        private string _SectionName_EN;

        public string SectionName_EN
        {
            get { return _SectionName_EN; }
            set { SetPropertyValue(nameof(SectionName_EN), ref _SectionName_EN, value); }
        }

        private string _VillageCode;

        public string VillageCode
        {
            get { return _VillageCode; }
            set { SetPropertyValue(nameof(VillageCode), ref _VillageCode, value); }
        }

        private string _VillageName_EN;

        public string VillageName_EN
        {
            get { return _VillageName_EN; }
            set { SetPropertyValue(nameof(VillageName_EN), ref _VillageName_EN, value); }
        }

        private string _VillageName_MM;

        public string VillageName_MM
        {
            get { return _VillageName_MM; }
            set { SetPropertyValue(nameof(VillageName_MM), ref _VillageName_MM, value); }
        }

        private string _VillageName_KAREN;

        public string VillageName_KAREN
        {
            get { return _VillageName_KAREN; }
            set { SetPropertyValue(nameof(VillageName_KAREN), ref _VillageName_KAREN, value); }
        }

        private string _DistrictCode;

        public string DistrictCode
        {
            get { return _DistrictCode; }
            set { SetPropertyValue(nameof(DistrictCode), ref _DistrictCode, value); }
        }

        private string _DistrictName_EN;

        public string DistrictName_EN
        {
            get { return _DistrictName_EN; }
            set { SetPropertyValue(nameof(DistrictName_EN), ref _DistrictName_EN, value); }
        }

        private string _ProvinceCode;

        public string ProvinceCode
        {
            get { return _ProvinceCode; }
            set { SetPropertyValue(nameof(ProvinceCode), ref _ProvinceCode, value); }
        }

        private string _ProvinceName_EN;

        public string ProvinceName_EN
        {
            get { return _ProvinceName_EN; }
            set { SetPropertyValue(nameof(ProvinceName_EN), ref _ProvinceName_EN, value); }
        }

        private string _RegionCode;

        public string RegionCode
        {
            get { return _RegionCode; }
            set { SetPropertyValue(nameof(RegionCode), ref _RegionCode, value); }
        }

        private string _RegionName_EN;

        public string RegionName_EN
        {
            get { return _RegionName_EN; }
            set { SetPropertyValue(nameof(RegionName_EN), ref _RegionName_EN, value); }
        }

        private string _CountryCode;

        public string CountryCode
        {
            get { return _CountryCode; }
            set { SetPropertyValue(nameof(CountryCode), ref _CountryCode, value); }
        }

        private string _CountryName_EN;

        public string CountryName_EN
        {
            get { return _CountryName_EN; }
            set { SetPropertyValue(nameof(CountryName_EN), ref _CountryName_EN, value); }
        }

        private string _VillageGPSLat;

        public string VillageGPSLat
        {
            get { return _VillageGPSLat; }
            set { SetPropertyValue(nameof(VillageGPSLat), ref _VillageGPSLat, value); }
        }

        private string _VillageGPSLong;

        public string VillageGPSLong
        {
            get { return _VillageGPSLong; }
            set { SetPropertyValue(nameof(VillageGPSLong), ref _VillageGPSLong, value); }
        }

        private string _SubdistrictCode;
        
        public string SubdistrictCode
        {
            get { return _SubdistrictCode; }
            set { SetPropertyValue(nameof(SubdistrictCode), ref _SubdistrictCode, value); }
        }

        private string _SubdistrictName_EN;

        public string SubdistrictName_EN
        {
            get { return _SubdistrictName_EN; }
            set { SetPropertyValue(nameof(SubdistrictName_EN), ref _SubdistrictName_EN, value); }
        }
    }
}
