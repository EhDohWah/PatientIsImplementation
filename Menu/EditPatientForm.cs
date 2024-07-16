using DevExpress.Xpo;
using PatientIsImplementation.Models;
using PatientIsImplementation.UiComponents;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PatientIsImplementation.Menu
{
    public partial class EditPatientForm : Form
    {
        public static string idcard;
        private int selectedDeviceIndex;

        public EditPatientForm()
        {
            InitializeComponent();
            // Set the minimum date


        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            TitleMain mainTitle = new TitleMain();
            mainTitle.Dock = DockStyle.Fill;
            pnlEditTitle.Controls.Add(mainTitle);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Validate tbxsearch IDCard
            if (string.IsNullOrEmpty(tbxSearchIDcard.Text))
            {
                MessageBox.Show("Please Enter Patient IDCard Number!");
                tbxSearchIDcard.Focus();
                return;
            }

            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var query = from patient in uow.Query<Patients>()
                                join address in uow.Query<Addresses>()
                                on patient.AddressCode equals address.AddressCode
                                where patient.IDCard == tbxSearchIDcard.Text.Trim()
                                select new { Patient = patient, Address = address };

                    // Check if the query result is empty
                    if (!query.Any())
                    {
                        MessageBox.Show("No patient found with the provided ID card number", "Invalid ID Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxSearchIDcard.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("A record found!", "Patient detail information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // If query is not empty, continue with your logic to process the results
                    foreach (var data in query)
                    {
                        // Display patient personal data
                        tbxFullName.Text = data.Patient.FullName;
                        tbxMotherName.Text = data.Patient.MotherName;
                        tbxFatherName.Text = data.Patient.FatherName;
                        tbxSpouseName.Text = data.Patient.SpouseName;
                        cbxGender.SelectedIndex = data.Patient.Gender == "Male" ? 0 : (data.Patient.Gender == "Female" ? 1 : -1);
                        dtpDOB.Value = new DateTime(data.Patient.DOB_year, data.Patient.DOB_month, data.Patient.DOB_day);
                        tbxPhoneNumber.Text = data.Patient.PhoneNumber;

                        // Display addresses
                        tbxAddressCode.Text = data.Address.AddressCode;
                        tbxSectionName.Text = data.Address.SectionName_EN;
                        tbxVillageCode.Text = data.Address.VillageCode;
                        tbxVillageNameEN.Text = data.Address.VillageName_EN;
                        tbxVillageNameMM.Text = data.Address.VillageName_MM;
                        tbxVillageNameKaren.Text = data.Address.VillageName_KAREN;
                        tbxDistrictCode.Text = data.Address.DistrictCode;
                        tbxProvinceCode.Text = data.Address.ProvinceCode;
                        tbxRegionCode.Text = data.Address.RegionCode;
                        tbxCountryCode.Text = data.Address.CountryCode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void tbxSearchIDcard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnSearch_Click(sender, null);
                e.Handled = true;
            }
        }

        //private void btnSaveRecord_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(tbxAddressCode.Text))
        //    {
        //        errorProviderAddressCode.SetError(tbxAddressCode, "This field is required");
        //        MessageBox.Show("Please enter address code.", "Empty address code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    using (UnitOfWork uow = new UnitOfWork())
        //    {
        //        //var patient = uow.Query<Patients>()
        //        //   .FirstOrDefault(p => p.IDCard == idcard.Trim());

        //        //patient.FullName = tbxFullName.Text;
        //        //patient.MotherName = tbxMotherName.Text;
        //        //patient.FatherName = tbxFatherName.Text;
        //        //patient.SpouseName = tbxSpouseName.Text;
        //        //patient.Gender = cbxGender.Text;
        //        //patient.DOB_year = dtpDOB.Value.Year;
        //        //patient.DOB_month = dtpDOB.Value.Month;
        //        //patient.DOB_day = dtpDOB.Value.Day;
        //        //patient.PhoneNumber = tbxPhoneNumber.Text;


        //        // Retrieve the entities from the query
        //        var query = uow.Query<Patients>()
        //                       .Join(uow.Query<Addresses>(),
        //                             patient => patient.AddressCode,
        //                             address => address.AddressCode,
        //                             (patient, address) => new { Patient = patient, Address = address });

        //        // Check if the query result is empty
        //        if (!query.Any())
        //        {
        //            MessageBox.Show("No patient found with the provided ID card number.");
        //            tbxSearchIDcard.Focus();
        //            return;
        //        }

        //        // Iterate over the results and update the patient entity
        //        foreach (var result in query)
        //        {
        //            // Update patient entity with new data
        //            result.Patient.FullName = tbxFullName.Text;
        //            result.Patient.MotherName = tbxMotherName.Text;
        //            result.Patient.FatherName = tbxFatherName.Text;
        //            result.Patient.SpouseName = tbxSpouseName.Text;
        //            result.Patient.Gender = cbxGender.Text;
        //            result.Patient.DOB_year = dtpDOB.Value.Year;
        //            result.Patient.DOB_month = dtpDOB.Value.Month;
        //            result.Patient.DOB_day = dtpDOB.Value.Day;
        //            result.Patient.PhoneNumber = tbxPhoneNumber.Text;

        //            // If needed, update the address entity as well
        //            // result.Address.SomeProperty = someValue;
        //            //result.Address.AddressCode = tbxAddressCode.Text;
        //            result.Address.SectionName_EN = tbxSectionName.Text;
        //            result.Address.VillageCode = tbxVillageCode.Text;
        //            result.Address.VillageName_EN = tbxVillageNameEN.Text;
        //            result.Address.VillageName_MM = tbxVillageNameMM.Text;
        //            result.Address.VillageName_KAREN = tbxVillageNameKaren.Text;
        //            result.Address.DistrictCode = tbxDistrictCode.Text;
        //            result.Address.ProvinceCode = tbxProvinceCode.Text;
        //            result.Address.RegionCode = tbxRegionCode.Text;
        //            result.Address.CountryCode = tbxCountryCode.Text;

        //            try
        //            {
        //                uow.CommitChanges();
        //                tbxFullName.Clear();
        //                tbxMotherName.Clear();
        //                tbxFatherName.Clear();
        //                tbxSpouseName.Clear();
        //                cbxGender.SelectedIndex = -1;
        //                dtpDOB.Value = DateTime.Now;
        //                tbxPhoneNumber.Clear();
        //                MessageBox.Show("Patient record successfully updadted!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                tbxSearchIDcard.Clear();


        //                tbxSectionName.Clear();
        //                tbxVillageCode.Clear();
        //                tbxVillageNameEN.Clear();
        //                tbxVillageNameMM.Clear();
        //                tbxVillageNameEN.Clear();
        //                tbxDistrictCode.Clear();
        //                tbxProvinceCode.Clear();
        //                tbxRegionCode.Clear();
        //                tbxCountryCode.Clear();
        //                tbxSearchIDcard.Focus();
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
        //        }



        //    }
        //}

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Check if the currently selected tab is not the last one
            if (tbcEditPatient.SelectedIndex < tbcEditPatient.TabCount - 1)
            {
                // Move to the next tab
                tbcEditPatient.SelectedIndex++;
            }
            else
            {
                // Optionally, if you want to loop back to the first tab when reaching the last one:
                // tbcPatientInfo.SelectedIndex = 0;

                // Alternatively, if you want to display a message when reaching the last tab:
                MessageBox.Show("You have reached the last tab.", "End of Tabs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var patient = uow.Query<Patients>()
                   .FirstOrDefault(p => p.IDCard == tbxSearchIDcard.Text.Trim());

                var address = uow.Query<Addresses>()
                                   .FirstOrDefault(a => a.AddressCode == tbxAddressCode.Text);

                // Check if any changes were made to the patient
                bool patientChanged = patient.FullName == tbxFullName.Text &&
                                      patient.MotherName == tbxMotherName.Text &&
                                      patient.FatherName == tbxFatherName.Text &&
                                      patient.SpouseName == tbxSpouseName.Text &&
                                      patient.Gender == cbxGender.Text &&
                                      patient.DOB_year == dtpDOB.Value.Year &&
                                      patient.DOB_month == dtpDOB.Value.Month &&
                                      patient.DOB_day == dtpDOB.Value.Day &&
                                      patient.PhoneNumber == tbxPhoneNumber.Text;

                bool addressChanged = address.AddressCode == tbxAddressCode.Text &&
                      address.SectionName_EN == tbxSectionName.Text &&
                      address.VillageCode == tbxVillageCode.Text &&
                      address.VillageName_EN == tbxVillageNameEN.Text &&
                      address.VillageName_MM == tbxVillageNameMM.Text &&
                      address.VillageName_KAREN == tbxVillageNameKaren.Text &&
                      address.DistrictCode == tbxDistrictCode.Text &&
                      address.ProvinceCode == tbxProvinceCode.Text &&
                      address.RegionCode == tbxRegionCode.Text &&
                      address.CountryCode == tbxCountryCode.Text;


                if (patientChanged && addressChanged)
                {
                    MessageBox.Show("No changes were made to the patient record.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                //Save patient 
                patient.FullName = tbxFullName.Text;
                patient.MotherName = tbxMotherName.Text;
                patient.FatherName = tbxFatherName.Text;
                patient.SpouseName = tbxSpouseName.Text;
                patient.Gender = cbxGender.Text;
                patient.DOB_year = dtpDOB.Value.Year;
                patient.DOB_month = dtpDOB.Value.Month;
                patient.DOB_day = dtpDOB.Value.Day;
                patient.PhoneNumber = tbxPhoneNumber.Text;


                //Dave Address

                address.AddressCode = tbxAddressCode.Text;
                address.SectionName_EN = tbxSectionName.Text;
                address.VillageCode = tbxVillageCode.Text;
                address.VillageName_EN = tbxVillageNameEN.Text;
                address.VillageName_MM = tbxVillageNameMM.Text;
                address.VillageName_KAREN = tbxVillageNameKaren.Text;
                address.DistrictCode = tbxDistrictCode.Text;
                address.ProvinceCode = tbxProvinceCode.Text;
                address.RegionCode = tbxRegionCode.Text;
                address.CountryCode = tbxCountryCode.Text;

                try
                {
                    uow.CommitChanges();
                    MessageBox.Show("Patient record successfully updadted!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbcEditPatient.SelectedIndex = 0;
                    tbxSearchIDcard.Focus();
                    tbxFullName.Clear();
                    tbxMotherName.Clear();
                    tbxFatherName.Clear();
                    tbxSpouseName.Clear();
                    cbxGender.SelectedIndex = -1;
                    dtpDOB.Value = DateTime.Now;
                    tbxPhoneNumber.Clear();
                    tbxSearchIDcard.Clear();
                    tbxSearchIDcard.Focus();


                    tbxAddressCode.Clear();
                    tbxSectionName.Clear();
                    tbxVillageCode.Clear();
                    tbxVillageNameEN.Clear();
                    tbxVillageNameMM.Clear();
                    tbxVillageNameKaren.Clear();
                    tbxDistrictCode.Clear();
                    tbxProvinceCode.Clear();
                    tbxRegionCode.Clear();
                    tbxCountryCode.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
