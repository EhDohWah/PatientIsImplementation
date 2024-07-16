namespace PatientIsImplementation.Menu
{
    partial class EditPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatientForm));
            this.pnlEditTitle = new System.Windows.Forms.Panel();
            this.lblEdit_Title = new System.Windows.Forms.Label();
            this.tbcEditPatient = new System.Windows.Forms.TabControl();
            this.tbgPatient = new System.Windows.Forms.TabPage();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSpouseName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblMotherName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxSpouseName = new System.Windows.Forms.TextBox();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.tbxMotherName = new System.Windows.Forms.TextBox();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.lblPatientInfoTitle = new System.Windows.Forms.Label();
            this.tbgAddress = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchIDcard = new System.Windows.Forms.TextBox();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblVillageNEn = new System.Windows.Forms.Label();
            this.lblVillageCode = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.lblAddressCode = new System.Windows.Forms.Label();
            this.tbxVillageNameEN = new System.Windows.Forms.TextBox();
            this.tbxVillageCode = new System.Windows.Forms.TextBox();
            this.tbxSectionName = new System.Windows.Forms.TextBox();
            this.tbxAddressCode = new System.Windows.Forms.TextBox();
            this.tbxVillageNameMM = new System.Windows.Forms.TextBox();
            this.tbxVillageNameKaren = new System.Windows.Forms.TextBox();
            this.tbxDistrictCode = new System.Windows.Forms.TextBox();
            this.tbxProvinceCode = new System.Windows.Forms.TextBox();
            this.lblVillageNMM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDistrictCode = new System.Windows.Forms.Label();
            this.lblProvinceCode = new System.Windows.Forms.Label();
            this.tbxRegionCode = new System.Windows.Forms.TextBox();
            this.tbxCountryCode = new System.Windows.Forms.TextBox();
            this.lblRegionCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.toolTipAddressCode = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderAddressCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcEditPatient.SuspendLayout();
            this.tbgPatient.SuspendLayout();
            this.tbgAddress.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddressCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditTitle
            // 
            this.pnlEditTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlEditTitle.Name = "pnlEditTitle";
            this.pnlEditTitle.Size = new System.Drawing.Size(1033, 79);
            this.pnlEditTitle.TabIndex = 0;
            // 
            // lblEdit_Title
            // 
            this.lblEdit_Title.AutoSize = true;
            this.lblEdit_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Title.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEdit_Title.Location = new System.Drawing.Point(47, 129);
            this.lblEdit_Title.Name = "lblEdit_Title";
            this.lblEdit_Title.Size = new System.Drawing.Size(173, 20);
            this.lblEdit_Title.TabIndex = 3;
            this.lblEdit_Title.Text = "Edit Patient Record";
            // 
            // tbcEditPatient
            // 
            this.tbcEditPatient.Controls.Add(this.tbgPatient);
            this.tbcEditPatient.Controls.Add(this.tbgAddress);
            this.tbcEditPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcEditPatient.Location = new System.Drawing.Point(358, 163);
            this.tbcEditPatient.Name = "tbcEditPatient";
            this.tbcEditPatient.SelectedIndex = 0;
            this.tbcEditPatient.Size = new System.Drawing.Size(647, 487);
            this.tbcEditPatient.TabIndex = 4;
            // 
            // tbgPatient
            // 
            this.tbgPatient.BackColor = System.Drawing.Color.Gainsboro;
            this.tbgPatient.Controls.Add(this.btnNext);
            this.tbgPatient.Controls.Add(this.dtpDOB);
            this.tbgPatient.Controls.Add(this.cbxGender);
            this.tbgPatient.Controls.Add(this.lblPhoneNumber);
            this.tbgPatient.Controls.Add(this.lblDOB);
            this.tbgPatient.Controls.Add(this.lblGender);
            this.tbgPatient.Controls.Add(this.lblSpouseName);
            this.tbgPatient.Controls.Add(this.lblFatherName);
            this.tbgPatient.Controls.Add(this.lblMotherName);
            this.tbgPatient.Controls.Add(this.lblFullName);
            this.tbgPatient.Controls.Add(this.tbxPhoneNumber);
            this.tbgPatient.Controls.Add(this.tbxSpouseName);
            this.tbgPatient.Controls.Add(this.tbxFatherName);
            this.tbgPatient.Controls.Add(this.tbxMotherName);
            this.tbgPatient.Controls.Add(this.tbxFullName);
            this.tbgPatient.Controls.Add(this.lblPatientInfoTitle);
            this.tbgPatient.Location = new System.Drawing.Point(4, 27);
            this.tbgPatient.Name = "tbgPatient";
            this.tbgPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tbgPatient.Size = new System.Drawing.Size(639, 456);
            this.tbgPatient.TabIndex = 0;
            this.tbgPatient.Text = "Patient Personal Information";
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(167, 217);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 26);
            this.cbxGender.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(48, 287);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 18);
            this.lblPhoneNumber.TabIndex = 65;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(66, 257);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(90, 18);
            this.lblDOB.TabIndex = 65;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(99, 220);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 18);
            this.lblGender.TabIndex = 65;
            this.lblGender.Text = "Gender";
            // 
            // lblSpouseName
            // 
            this.lblSpouseName.AutoSize = true;
            this.lblSpouseName.Location = new System.Drawing.Point(53, 183);
            this.lblSpouseName.Name = "lblSpouseName";
            this.lblSpouseName.Size = new System.Drawing.Size(103, 18);
            this.lblSpouseName.TabIndex = 65;
            this.lblSpouseName.Text = "Spouse Name";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(62, 146);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(94, 18);
            this.lblFatherName.TabIndex = 65;
            this.lblFatherName.Text = "Father Name";
            // 
            // lblMotherName
            // 
            this.lblMotherName.AutoSize = true;
            this.lblMotherName.Location = new System.Drawing.Point(57, 109);
            this.lblMotherName.Name = "lblMotherName";
            this.lblMotherName.Size = new System.Drawing.Size(99, 18);
            this.lblMotherName.TabIndex = 65;
            this.lblMotherName.Text = "Mother Name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(81, 72);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 18);
            this.lblFullName.TabIndex = 65;
            this.lblFullName.Text = "Full Name";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(167, 284);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(370, 24);
            this.tbxPhoneNumber.TabIndex = 8;
            // 
            // tbxSpouseName
            // 
            this.tbxSpouseName.Location = new System.Drawing.Point(167, 180);
            this.tbxSpouseName.Name = "tbxSpouseName";
            this.tbxSpouseName.Size = new System.Drawing.Size(370, 24);
            this.tbxSpouseName.TabIndex = 3;
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(167, 143);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(370, 24);
            this.tbxFatherName.TabIndex = 2;
            // 
            // tbxMotherName
            // 
            this.tbxMotherName.Location = new System.Drawing.Point(167, 106);
            this.tbxMotherName.Name = "tbxMotherName";
            this.tbxMotherName.Size = new System.Drawing.Size(370, 24);
            this.tbxMotherName.TabIndex = 1;
            // 
            // tbxFullName
            // 
            this.tbxFullName.Location = new System.Drawing.Point(167, 69);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(370, 24);
            this.tbxFullName.TabIndex = 0;
            // 
            // lblPatientInfoTitle
            // 
            this.lblPatientInfoTitle.AutoSize = true;
            this.lblPatientInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientInfoTitle.Location = new System.Drawing.Point(41, 22);
            this.lblPatientInfoTitle.Name = "lblPatientInfoTitle";
            this.lblPatientInfoTitle.Size = new System.Drawing.Size(108, 20);
            this.lblPatientInfoTitle.TabIndex = 1;
            this.lblPatientInfoTitle.Text = "Edit Record";
            // 
            // tbgAddress
            // 
            this.tbgAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.tbgAddress.Controls.Add(this.btnSaveAll);
            this.tbgAddress.Controls.Add(this.lblCountry);
            this.tbgAddress.Controls.Add(this.lblProvinceCode);
            this.tbgAddress.Controls.Add(this.lblVillageNEn);
            this.tbgAddress.Controls.Add(this.lblRegionCode);
            this.tbgAddress.Controls.Add(this.lblDistrictCode);
            this.tbgAddress.Controls.Add(this.lblVillageCode);
            this.tbgAddress.Controls.Add(this.label6);
            this.tbgAddress.Controls.Add(this.lblSectionName);
            this.tbgAddress.Controls.Add(this.lblVillageNMM);
            this.tbgAddress.Controls.Add(this.lblAddressCode);
            this.tbgAddress.Controls.Add(this.tbxCountryCode);
            this.tbgAddress.Controls.Add(this.tbxRegionCode);
            this.tbgAddress.Controls.Add(this.tbxProvinceCode);
            this.tbgAddress.Controls.Add(this.tbxDistrictCode);
            this.tbgAddress.Controls.Add(this.tbxVillageNameEN);
            this.tbgAddress.Controls.Add(this.tbxVillageNameKaren);
            this.tbgAddress.Controls.Add(this.tbxVillageCode);
            this.tbgAddress.Controls.Add(this.tbxVillageNameMM);
            this.tbgAddress.Controls.Add(this.tbxSectionName);
            this.tbgAddress.Controls.Add(this.tbxAddressCode);
            this.tbgAddress.Location = new System.Drawing.Point(4, 27);
            this.tbgAddress.Name = "tbgAddress";
            this.tbgAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tbgAddress.Size = new System.Drawing.Size(639, 456);
            this.tbgAddress.TabIndex = 1;
            this.tbgAddress.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbxSearchIDcard);
            this.panel1.Controls.Add(this.lblIDCard);
            this.panel1.Location = new System.Drawing.Point(36, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 256);
            this.panel1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(109, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearchIDcard
            // 
            this.tbxSearchIDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearchIDcard.Location = new System.Drawing.Point(26, 96);
            this.tbxSearchIDcard.Multiline = true;
            this.tbxSearchIDcard.Name = "tbxSearchIDcard";
            this.tbxSearchIDcard.Size = new System.Drawing.Size(253, 30);
            this.tbxSearchIDcard.TabIndex = 0;
            this.tbxSearchIDcard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchIDcard_KeyDown);
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Location = new System.Drawing.Point(126, 68);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(52, 16);
            this.lblIDCard.TabIndex = 0;
            this.lblIDCard.Text = "ID Card";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(167, 252);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 24);
            this.dtpDOB.TabIndex = 66;
            this.dtpDOB.Value = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(444, 339);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 33);
            this.btnNext.TabIndex = 67;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblVillageNEn
            // 
            this.lblVillageNEn.AutoSize = true;
            this.lblVillageNEn.Location = new System.Drawing.Point(49, 151);
            this.lblVillageNEn.Name = "lblVillageNEn";
            this.lblVillageNEn.Size = new System.Drawing.Size(119, 18);
            this.lblVillageNEn.TabIndex = 70;
            this.lblVillageNEn.Text = "Village Name EN";
            // 
            // lblVillageCode
            // 
            this.lblVillageCode.AutoSize = true;
            this.lblVillageCode.Location = new System.Drawing.Point(78, 115);
            this.lblVillageCode.Name = "lblVillageCode";
            this.lblVillageCode.Size = new System.Drawing.Size(90, 18);
            this.lblVillageCode.TabIndex = 71;
            this.lblVillageCode.Text = "Village Code";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Location = new System.Drawing.Point(66, 79);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(102, 18);
            this.lblSectionName.TabIndex = 72;
            this.lblSectionName.Text = "Section Name";
            // 
            // lblAddressCode
            // 
            this.lblAddressCode.AutoSize = true;
            this.lblAddressCode.Location = new System.Drawing.Point(66, 43);
            this.lblAddressCode.Name = "lblAddressCode";
            this.lblAddressCode.Size = new System.Drawing.Size(102, 18);
            this.lblAddressCode.TabIndex = 73;
            this.lblAddressCode.Text = "Address Code";
            // 
            // tbxVillageNameEN
            // 
            this.tbxVillageNameEN.Location = new System.Drawing.Point(192, 148);
            this.tbxVillageNameEN.Name = "tbxVillageNameEN";
            this.tbxVillageNameEN.Size = new System.Drawing.Size(370, 24);
            this.tbxVillageNameEN.TabIndex = 69;
            // 
            // tbxVillageCode
            // 
            this.tbxVillageCode.Location = new System.Drawing.Point(192, 111);
            this.tbxVillageCode.Name = "tbxVillageCode";
            this.tbxVillageCode.Size = new System.Drawing.Size(370, 24);
            this.tbxVillageCode.TabIndex = 68;
            // 
            // tbxSectionName
            // 
            this.tbxSectionName.Location = new System.Drawing.Point(192, 74);
            this.tbxSectionName.Name = "tbxSectionName";
            this.tbxSectionName.Size = new System.Drawing.Size(370, 24);
            this.tbxSectionName.TabIndex = 67;
            // 
            // tbxAddressCode
            // 
            this.tbxAddressCode.Location = new System.Drawing.Point(192, 37);
            this.tbxAddressCode.Name = "tbxAddressCode";
            this.tbxAddressCode.ReadOnly = true;
            this.tbxAddressCode.Size = new System.Drawing.Size(370, 24);
            this.tbxAddressCode.TabIndex = 66;
            this.toolTipAddressCode.SetToolTip(this.tbxAddressCode, "Please enter the address code");
            // 
            // tbxVillageNameMM
            // 
            this.tbxVillageNameMM.Location = new System.Drawing.Point(192, 185);
            this.tbxVillageNameMM.Name = "tbxVillageNameMM";
            this.tbxVillageNameMM.Size = new System.Drawing.Size(370, 24);
            this.tbxVillageNameMM.TabIndex = 66;
            // 
            // tbxVillageNameKaren
            // 
            this.tbxVillageNameKaren.Location = new System.Drawing.Point(192, 222);
            this.tbxVillageNameKaren.Name = "tbxVillageNameKaren";
            this.tbxVillageNameKaren.Size = new System.Drawing.Size(370, 24);
            this.tbxVillageNameKaren.TabIndex = 67;
            // 
            // tbxDistrictCode
            // 
            this.tbxDistrictCode.Location = new System.Drawing.Point(192, 259);
            this.tbxDistrictCode.Name = "tbxDistrictCode";
            this.tbxDistrictCode.Size = new System.Drawing.Size(218, 24);
            this.tbxDistrictCode.TabIndex = 68;
            // 
            // tbxProvinceCode
            // 
            this.tbxProvinceCode.Location = new System.Drawing.Point(192, 296);
            this.tbxProvinceCode.Name = "tbxProvinceCode";
            this.tbxProvinceCode.Size = new System.Drawing.Size(218, 24);
            this.tbxProvinceCode.TabIndex = 69;
            // 
            // lblVillageNMM
            // 
            this.lblVillageNMM.AutoSize = true;
            this.lblVillageNMM.Location = new System.Drawing.Point(44, 187);
            this.lblVillageNMM.Name = "lblVillageNMM";
            this.lblVillageNMM.Size = new System.Drawing.Size(124, 18);
            this.lblVillageNMM.TabIndex = 73;
            this.lblVillageNMM.Text = "Village Name MM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "Village Name Karen";
            // 
            // lblDistrictCode
            // 
            this.lblDistrictCode.AutoSize = true;
            this.lblDistrictCode.Location = new System.Drawing.Point(74, 259);
            this.lblDistrictCode.Name = "lblDistrictCode";
            this.lblDistrictCode.Size = new System.Drawing.Size(94, 18);
            this.lblDistrictCode.TabIndex = 71;
            this.lblDistrictCode.Text = "District Code";
            // 
            // lblProvinceCode
            // 
            this.lblProvinceCode.AutoSize = true;
            this.lblProvinceCode.Location = new System.Drawing.Point(62, 295);
            this.lblProvinceCode.Name = "lblProvinceCode";
            this.lblProvinceCode.Size = new System.Drawing.Size(106, 18);
            this.lblProvinceCode.TabIndex = 70;
            this.lblProvinceCode.Text = "Province Code";
            // 
            // tbxRegionCode
            // 
            this.tbxRegionCode.Location = new System.Drawing.Point(192, 333);
            this.tbxRegionCode.Name = "tbxRegionCode";
            this.tbxRegionCode.Size = new System.Drawing.Size(218, 24);
            this.tbxRegionCode.TabIndex = 68;
            // 
            // tbxCountryCode
            // 
            this.tbxCountryCode.Location = new System.Drawing.Point(192, 370);
            this.tbxCountryCode.Name = "tbxCountryCode";
            this.tbxCountryCode.Size = new System.Drawing.Size(218, 24);
            this.tbxCountryCode.TabIndex = 69;
            // 
            // lblRegionCode
            // 
            this.lblRegionCode.AutoSize = true;
            this.lblRegionCode.Location = new System.Drawing.Point(73, 331);
            this.lblRegionCode.Name = "lblRegionCode";
            this.lblRegionCode.Size = new System.Drawing.Size(95, 18);
            this.lblRegionCode.TabIndex = 71;
            this.lblRegionCode.Text = "Region Code";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(68, 367);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 18);
            this.lblCountry.TabIndex = 70;
            this.lblCountry.Text = "Country Code";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnSaveAll.Location = new System.Drawing.Point(468, 408);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(94, 33);
            this.btnSaveAll.TabIndex = 74;
            this.btnSaveAll.Text = "Save";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // errorProviderAddressCode
            // 
            this.errorProviderAddressCode.ContainerControl = this;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcEditPatient);
            this.Controls.Add(this.lblEdit_Title);
            this.Controls.Add(this.pnlEditTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit - Patient";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.tbcEditPatient.ResumeLayout(false);
            this.tbgPatient.ResumeLayout(false);
            this.tbgPatient.PerformLayout();
            this.tbgAddress.ResumeLayout(false);
            this.tbgAddress.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddressCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEditTitle;
        private System.Windows.Forms.Label lblEdit_Title;
        private System.Windows.Forms.TabControl tbcEditPatient;
        private System.Windows.Forms.TabPage tbgPatient;
        private System.Windows.Forms.TabPage tbgAddress;
        private System.Windows.Forms.Label lblPatientInfoTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSearchIDcard;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxSpouseName;
        private System.Windows.Forms.TextBox tbxFatherName;
        private System.Windows.Forms.TextBox tbxMotherName;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.Label lblSpouseName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblVillageNEn;
        private System.Windows.Forms.Label lblVillageCode;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.Label lblAddressCode;
        private System.Windows.Forms.TextBox tbxVillageNameEN;
        private System.Windows.Forms.TextBox tbxVillageCode;
        private System.Windows.Forms.TextBox tbxSectionName;
        private System.Windows.Forms.TextBox tbxAddressCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblProvinceCode;
        private System.Windows.Forms.Label lblRegionCode;
        private System.Windows.Forms.Label lblDistrictCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVillageNMM;
        private System.Windows.Forms.TextBox tbxCountryCode;
        private System.Windows.Forms.TextBox tbxRegionCode;
        private System.Windows.Forms.TextBox tbxProvinceCode;
        private System.Windows.Forms.TextBox tbxDistrictCode;
        private System.Windows.Forms.TextBox tbxVillageNameKaren;
        private System.Windows.Forms.TextBox tbxVillageNameMM;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.ToolTip toolTipAddressCode;
        private System.Windows.Forms.ErrorProvider errorProviderAddressCode;
    }
}