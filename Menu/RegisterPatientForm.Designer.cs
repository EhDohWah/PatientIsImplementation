namespace PatientIsImplementation.Menu
{
    partial class RegisterPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPatientForm));
            this.pnlRgTitle = new System.Windows.Forms.Panel();
            this.tbcPatientInfo = new System.Windows.Forms.TabControl();
            this.pgAddress = new System.Windows.Forms.TabPage();
            this.tbxAddressCode = new System.Windows.Forms.TextBox();
            this.lblAddressCode = new System.Windows.Forms.Label();
            this.btnSaveAddress = new System.Windows.Forms.Button();
            this.tbxContryCode = new System.Windows.Forms.TextBox();
            this.tbxRegionCode = new System.Windows.Forms.TextBox();
            this.tbxProvinceCode = new System.Windows.Forms.TextBox();
            this.tbxDistrictCode = new System.Windows.Forms.TextBox();
            this.tbxVillageNKaren = new System.Windows.Forms.TextBox();
            this.tbxVillageNMM = new System.Windows.Forms.TextBox();
            this.tbxVillageNEn = new System.Windows.Forms.TextBox();
            this.tbxVillageCode = new System.Windows.Forms.TextBox();
            this.tbxSectionName = new System.Windows.Forms.TextBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblRegionCode = new System.Windows.Forms.Label();
            this.lblProviceCode = new System.Windows.Forms.Label();
            this.lblDisctrictCode = new System.Windows.Forms.Label();
            this.lblVillageNKaren = new System.Windows.Forms.Label();
            this.lblVillageNMM = new System.Windows.Forms.Label();
            this.lblVillageNEn = new System.Windows.Forms.Label();
            this.lblVillageCode = new System.Windows.Forms.Label();
            this.lblSectionName = new System.Windows.Forms.Label();
            this.lblAddressInfo = new System.Windows.Forms.Label();
            this.lblPatientAddress = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblEntryTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPatientInfoTitle = new System.Windows.Forms.Label();
            this.lblPInfo = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbxFullName = new System.Windows.Forms.TextBox();
            this.lblMomName = new System.Windows.Forms.Label();
            this.tbxMotherName = new System.Windows.Forms.TextBox();
            this.lblFingerId = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.tbxFatherName = new System.Windows.Forms.TextBox();
            this.picFPImg = new System.Windows.Forms.PictureBox();
            this.lblFingerPrintCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbxFPid = new System.Windows.Forms.TextBox();
            this.lblSpouseName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.tbxSpouseName = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblIDcard = new System.Windows.Forms.Label();
            this.tbxIDcard = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateIDcard = new System.Windows.Forms.Button();
            this.pgPatient = new System.Windows.Forms.TabPage();
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcPatientInfo.SuspendLayout();
            this.pgAddress.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).BeginInit();
            this.pgPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRgTitle
            // 
            this.pnlRgTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRgTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlRgTitle.Name = "pnlRgTitle";
            this.pnlRgTitle.Size = new System.Drawing.Size(800, 79);
            this.pnlRgTitle.TabIndex = 0;
            // 
            // tbcPatientInfo
            // 
            this.tbcPatientInfo.Controls.Add(this.pgPatient);
            this.tbcPatientInfo.Controls.Add(this.pgAddress);
            this.tbcPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPatientInfo.Location = new System.Drawing.Point(12, 135);
            this.tbcPatientInfo.Name = "tbcPatientInfo";
            this.tbcPatientInfo.SelectedIndex = 0;
            this.tbcPatientInfo.Size = new System.Drawing.Size(776, 569);
            this.tbcPatientInfo.TabIndex = 1;
            // 
            // pgAddress
            // 
            this.pgAddress.Controls.Add(this.tbxAddressCode);
            this.pgAddress.Controls.Add(this.lblAddressCode);
            this.pgAddress.Controls.Add(this.btnSaveAddress);
            this.pgAddress.Controls.Add(this.tbxContryCode);
            this.pgAddress.Controls.Add(this.tbxRegionCode);
            this.pgAddress.Controls.Add(this.tbxProvinceCode);
            this.pgAddress.Controls.Add(this.tbxDistrictCode);
            this.pgAddress.Controls.Add(this.tbxVillageNKaren);
            this.pgAddress.Controls.Add(this.tbxVillageNMM);
            this.pgAddress.Controls.Add(this.tbxVillageNEn);
            this.pgAddress.Controls.Add(this.tbxVillageCode);
            this.pgAddress.Controls.Add(this.tbxSectionName);
            this.pgAddress.Controls.Add(this.lblCountryCode);
            this.pgAddress.Controls.Add(this.lblRegionCode);
            this.pgAddress.Controls.Add(this.lblProviceCode);
            this.pgAddress.Controls.Add(this.lblDisctrictCode);
            this.pgAddress.Controls.Add(this.lblVillageNKaren);
            this.pgAddress.Controls.Add(this.lblVillageNMM);
            this.pgAddress.Controls.Add(this.lblVillageNEn);
            this.pgAddress.Controls.Add(this.lblVillageCode);
            this.pgAddress.Controls.Add(this.lblSectionName);
            this.pgAddress.Controls.Add(this.lblAddressInfo);
            this.pgAddress.Controls.Add(this.lblPatientAddress);
            this.pgAddress.Location = new System.Drawing.Point(4, 29);
            this.pgAddress.Name = "pgAddress";
            this.pgAddress.Padding = new System.Windows.Forms.Padding(3);
            this.pgAddress.Size = new System.Drawing.Size(768, 536);
            this.pgAddress.TabIndex = 1;
            this.pgAddress.Text = "Address";
            this.pgAddress.UseVisualStyleBackColor = true;
            // 
            // tbxAddressCode
            // 
            this.tbxAddressCode.Location = new System.Drawing.Point(188, 118);
            this.tbxAddressCode.Name = "tbxAddressCode";
            this.tbxAddressCode.Size = new System.Drawing.Size(265, 27);
            this.tbxAddressCode.TabIndex = 0;
            // 
            // lblAddressCode
            // 
            this.lblAddressCode.AutoSize = true;
            this.lblAddressCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCode.Location = new System.Drawing.Point(59, 122);
            this.lblAddressCode.Name = "lblAddressCode";
            this.lblAddressCode.Size = new System.Drawing.Size(98, 18);
            this.lblAddressCode.TabIndex = 22;
            this.lblAddressCode.Text = "AddressCode";
            // 
            // btnSaveAddress
            // 
            this.btnSaveAddress.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAddress.Location = new System.Drawing.Point(353, 460);
            this.btnSaveAddress.Name = "btnSaveAddress";
            this.btnSaveAddress.Size = new System.Drawing.Size(100, 32);
            this.btnSaveAddress.TabIndex = 10;
            this.btnSaveAddress.Text = "Save";
            this.btnSaveAddress.UseVisualStyleBackColor = true;
            this.btnSaveAddress.Click += new System.EventHandler(this.btnSaveAddress_Click);
            // 
            // tbxContryCode
            // 
            this.tbxContryCode.Location = new System.Drawing.Point(189, 415);
            this.tbxContryCode.Name = "tbxContryCode";
            this.tbxContryCode.Size = new System.Drawing.Size(265, 27);
            this.tbxContryCode.TabIndex = 9;
            // 
            // tbxRegionCode
            // 
            this.tbxRegionCode.Location = new System.Drawing.Point(188, 382);
            this.tbxRegionCode.Name = "tbxRegionCode";
            this.tbxRegionCode.Size = new System.Drawing.Size(265, 27);
            this.tbxRegionCode.TabIndex = 8;
            // 
            // tbxProvinceCode
            // 
            this.tbxProvinceCode.Location = new System.Drawing.Point(188, 349);
            this.tbxProvinceCode.Name = "tbxProvinceCode";
            this.tbxProvinceCode.Size = new System.Drawing.Size(265, 27);
            this.tbxProvinceCode.TabIndex = 7;
            // 
            // tbxDistrictCode
            // 
            this.tbxDistrictCode.Location = new System.Drawing.Point(189, 316);
            this.tbxDistrictCode.Name = "tbxDistrictCode";
            this.tbxDistrictCode.Size = new System.Drawing.Size(265, 27);
            this.tbxDistrictCode.TabIndex = 6;
            // 
            // tbxVillageNKaren
            // 
            this.tbxVillageNKaren.Location = new System.Drawing.Point(188, 283);
            this.tbxVillageNKaren.Name = "tbxVillageNKaren";
            this.tbxVillageNKaren.Size = new System.Drawing.Size(265, 27);
            this.tbxVillageNKaren.TabIndex = 5;
            // 
            // tbxVillageNMM
            // 
            this.tbxVillageNMM.Location = new System.Drawing.Point(188, 250);
            this.tbxVillageNMM.Name = "tbxVillageNMM";
            this.tbxVillageNMM.Size = new System.Drawing.Size(265, 27);
            this.tbxVillageNMM.TabIndex = 4;
            // 
            // tbxVillageNEn
            // 
            this.tbxVillageNEn.Location = new System.Drawing.Point(188, 217);
            this.tbxVillageNEn.Name = "tbxVillageNEn";
            this.tbxVillageNEn.Size = new System.Drawing.Size(265, 27);
            this.tbxVillageNEn.TabIndex = 3;
            // 
            // tbxVillageCode
            // 
            this.tbxVillageCode.Location = new System.Drawing.Point(188, 184);
            this.tbxVillageCode.Name = "tbxVillageCode";
            this.tbxVillageCode.Size = new System.Drawing.Size(265, 27);
            this.tbxVillageCode.TabIndex = 2;
            // 
            // tbxSectionName
            // 
            this.tbxSectionName.Location = new System.Drawing.Point(188, 151);
            this.tbxSectionName.Name = "tbxSectionName";
            this.tbxSectionName.Size = new System.Drawing.Size(265, 27);
            this.tbxSectionName.TabIndex = 1;
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryCode.Location = new System.Drawing.Point(57, 419);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(100, 18);
            this.lblCountryCode.TabIndex = 11;
            this.lblCountryCode.Text = "Country Code";
            // 
            // lblRegionCode
            // 
            this.lblRegionCode.AutoSize = true;
            this.lblRegionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegionCode.Location = new System.Drawing.Point(62, 386);
            this.lblRegionCode.Name = "lblRegionCode";
            this.lblRegionCode.Size = new System.Drawing.Size(95, 18);
            this.lblRegionCode.TabIndex = 10;
            this.lblRegionCode.Text = "Region Code";
            // 
            // lblProviceCode
            // 
            this.lblProviceCode.AutoSize = true;
            this.lblProviceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProviceCode.Location = new System.Drawing.Point(51, 353);
            this.lblProviceCode.Name = "lblProviceCode";
            this.lblProviceCode.Size = new System.Drawing.Size(106, 18);
            this.lblProviceCode.TabIndex = 9;
            this.lblProviceCode.Text = "Province Code";
            // 
            // lblDisctrictCode
            // 
            this.lblDisctrictCode.AutoSize = true;
            this.lblDisctrictCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisctrictCode.Location = new System.Drawing.Point(55, 320);
            this.lblDisctrictCode.Name = "lblDisctrictCode";
            this.lblDisctrictCode.Size = new System.Drawing.Size(94, 18);
            this.lblDisctrictCode.TabIndex = 8;
            this.lblDisctrictCode.Text = "District Code";
            // 
            // lblVillageNKaren
            // 
            this.lblVillageNKaren.AutoSize = true;
            this.lblVillageNKaren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageNKaren.Location = new System.Drawing.Point(20, 287);
            this.lblVillageNKaren.Name = "lblVillageNKaren";
            this.lblVillageNKaren.Size = new System.Drawing.Size(137, 18);
            this.lblVillageNKaren.TabIndex = 7;
            this.lblVillageNKaren.Text = "Village Name Karen";
            // 
            // lblVillageNMM
            // 
            this.lblVillageNMM.AutoSize = true;
            this.lblVillageNMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageNMM.Location = new System.Drawing.Point(37, 254);
            this.lblVillageNMM.Name = "lblVillageNMM";
            this.lblVillageNMM.Size = new System.Drawing.Size(120, 18);
            this.lblVillageNMM.TabIndex = 6;
            this.lblVillageNMM.Text = "VillageName MM";
            // 
            // lblVillageNEn
            // 
            this.lblVillageNEn.AutoSize = true;
            this.lblVillageNEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageNEn.Location = new System.Drawing.Point(41, 221);
            this.lblVillageNEn.Name = "lblVillageNEn";
            this.lblVillageNEn.Size = new System.Drawing.Size(116, 18);
            this.lblVillageNEn.TabIndex = 5;
            this.lblVillageNEn.Text = "Village Name En";
            // 
            // lblVillageCode
            // 
            this.lblVillageCode.AutoSize = true;
            this.lblVillageCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageCode.Location = new System.Drawing.Point(71, 188);
            this.lblVillageCode.Name = "lblVillageCode";
            this.lblVillageCode.Size = new System.Drawing.Size(86, 18);
            this.lblVillageCode.TabIndex = 4;
            this.lblVillageCode.Text = "VillageCode";
            // 
            // lblSectionName
            // 
            this.lblSectionName.AutoSize = true;
            this.lblSectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionName.Location = new System.Drawing.Point(55, 155);
            this.lblSectionName.Name = "lblSectionName";
            this.lblSectionName.Size = new System.Drawing.Size(102, 18);
            this.lblSectionName.TabIndex = 3;
            this.lblSectionName.Text = "Section Name";
            // 
            // lblAddressInfo
            // 
            this.lblAddressInfo.AutoSize = true;
            this.lblAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInfo.Location = new System.Drawing.Point(85, 64);
            this.lblAddressInfo.Name = "lblAddressInfo";
            this.lblAddressInfo.Size = new System.Drawing.Size(85, 16);
            this.lblAddressInfo.TabIndex = 2;
            this.lblAddressInfo.Text = "Address Info.";
            // 
            // lblPatientAddress
            // 
            this.lblPatientAddress.AutoSize = true;
            this.lblPatientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAddress.Location = new System.Drawing.Point(38, 21);
            this.lblPatientAddress.Name = "lblPatientAddress";
            this.lblPatientAddress.Size = new System.Drawing.Size(218, 20);
            this.lblPatientAddress.TabIndex = 1;
            this.lblPatientAddress.Text = "New Patient Registration";
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 735);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblEntryTitle
            // 
            this.lblEntryTitle.AutoSize = true;
            this.lblEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEntryTitle.Location = new System.Drawing.Point(21, 100);
            this.lblEntryTitle.Name = "lblEntryTitle";
            this.lblEntryTitle.Size = new System.Drawing.Size(187, 20);
            this.lblEntryTitle.TabIndex = 2;
            this.lblEntryTitle.Text = "Register New Patient";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblPatientInfoTitle
            // 
            this.lblPatientInfoTitle.AutoSize = true;
            this.lblPatientInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientInfoTitle.Location = new System.Drawing.Point(38, 21);
            this.lblPatientInfoTitle.Name = "lblPatientInfoTitle";
            this.lblPatientInfoTitle.Size = new System.Drawing.Size(218, 20);
            this.lblPatientInfoTitle.TabIndex = 0;
            this.lblPatientInfoTitle.Text = "New Patient Registration";
            // 
            // lblPInfo
            // 
            this.lblPInfo.AutoSize = true;
            this.lblPInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPInfo.Location = new System.Drawing.Point(85, 64);
            this.lblPInfo.Name = "lblPInfo";
            this.lblPInfo.Size = new System.Drawing.Size(88, 16);
            this.lblPInfo.TabIndex = 1;
            this.lblPInfo.Text = "Personal Info.";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(59, 179);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 18);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // tbxFullName
            // 
            this.tbxFullName.Location = new System.Drawing.Point(149, 176);
            this.tbxFullName.Name = "tbxFullName";
            this.tbxFullName.Size = new System.Drawing.Size(269, 27);
            this.tbxFullName.TabIndex = 2;
            // 
            // lblMomName
            // 
            this.lblMomName.AutoSize = true;
            this.lblMomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMomName.Location = new System.Drawing.Point(39, 212);
            this.lblMomName.Name = "lblMomName";
            this.lblMomName.Size = new System.Drawing.Size(95, 18);
            this.lblMomName.TabIndex = 4;
            this.lblMomName.Text = "MotherName";
            // 
            // tbxMotherName
            // 
            this.tbxMotherName.Location = new System.Drawing.Point(149, 209);
            this.tbxMotherName.Name = "tbxMotherName";
            this.tbxMotherName.Size = new System.Drawing.Size(269, 27);
            this.tbxMotherName.TabIndex = 3;
            // 
            // lblFingerId
            // 
            this.lblFingerId.AutoSize = true;
            this.lblFingerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFingerId.Location = new System.Drawing.Point(44, 146);
            this.lblFingerId.Name = "lblFingerId";
            this.lblFingerId.Size = new System.Drawing.Size(90, 18);
            this.lblFingerId.TabIndex = 6;
            this.lblFingerId.Text = "FingerPrintId";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.Location = new System.Drawing.Point(44, 245);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(90, 18);
            this.lblFatherName.TabIndex = 7;
            this.lblFatherName.Text = "FatherName";
            // 
            // tbxFatherName
            // 
            this.tbxFatherName.Location = new System.Drawing.Point(149, 242);
            this.tbxFatherName.Name = "tbxFatherName";
            this.tbxFatherName.Size = new System.Drawing.Size(269, 27);
            this.tbxFatherName.TabIndex = 4;
            // 
            // picFPImg
            // 
            this.picFPImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFPImg.Location = new System.Drawing.Point(469, 150);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Size = new System.Drawing.Size(156, 161);
            this.picFPImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFPImg.TabIndex = 9;
            this.picFPImg.TabStop = false;
            // 
            // lblFingerPrintCount
            // 
            this.lblFingerPrintCount.AutoSize = true;
            this.lblFingerPrintCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFingerPrintCount.Location = new System.Drawing.Point(667, 216);
            this.lblFingerPrintCount.Name = "lblFingerPrintCount";
            this.lblFingerPrintCount.Size = new System.Drawing.Size(49, 54);
            this.lblFingerPrintCount.TabIndex = 11;
            this.lblFingerPrintCount.Text = "3";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(325, 424);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 36);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbxFPid
            // 
            this.tbxFPid.Location = new System.Drawing.Point(149, 143);
            this.tbxFPid.Name = "tbxFPid";
            this.tbxFPid.ReadOnly = true;
            this.tbxFPid.Size = new System.Drawing.Size(269, 27);
            this.tbxFPid.TabIndex = 1;
            this.tbxFPid.TextChanged += new System.EventHandler(this.tbxFPid_TextChanged);
            // 
            // lblSpouseName
            // 
            this.lblSpouseName.AutoSize = true;
            this.lblSpouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpouseName.Location = new System.Drawing.Point(35, 278);
            this.lblSpouseName.Name = "lblSpouseName";
            this.lblSpouseName.Size = new System.Drawing.Size(99, 18);
            this.lblSpouseName.TabIndex = 13;
            this.lblSpouseName.Text = "SpouseName";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(77, 311);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 18);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(44, 342);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(90, 18);
            this.lblDOB.TabIndex = 15;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(30, 379);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(104, 18);
            this.lblPhoneNum.TabIndex = 18;
            this.lblPhoneNum.Text = "PhoneNumber";
            // 
            // tbxSpouseName
            // 
            this.tbxSpouseName.Location = new System.Drawing.Point(149, 275);
            this.tbxSpouseName.Name = "tbxSpouseName";
            this.tbxSpouseName.Size = new System.Drawing.Size(269, 27);
            this.tbxSpouseName.TabIndex = 5;
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(149, 308);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(122, 28);
            this.cbxGender.TabIndex = 6;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(149, 375);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(150, 27);
            this.tbxPhone.TabIndex = 8;
            // 
            // lblIDcard
            // 
            this.lblIDcard.AutoSize = true;
            this.lblIDcard.Location = new System.Drawing.Point(72, 115);
            this.lblIDcard.Name = "lblIDcard";
            this.lblIDcard.Size = new System.Drawing.Size(62, 20);
            this.lblIDcard.TabIndex = 19;
            this.lblIDcard.Text = "IDCard";
            // 
            // tbxIDcard
            // 
            this.tbxIDcard.Location = new System.Drawing.Point(149, 110);
            this.tbxIDcard.Name = "tbxIDcard";
            this.tbxIDcard.ReadOnly = true;
            this.tbxIDcard.Size = new System.Drawing.Size(269, 27);
            this.tbxIDcard.TabIndex = 0;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(149, 342);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 27);
            this.dtpDOB.TabIndex = 7;
            // 
            // btnGenerateIDcard
            // 
            this.btnGenerateIDcard.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateIDcard.Location = new System.Drawing.Point(461, 103);
            this.btnGenerateIDcard.Name = "btnGenerateIDcard";
            this.btnGenerateIDcard.Size = new System.Drawing.Size(173, 41);
            this.btnGenerateIDcard.TabIndex = 10;
            this.btnGenerateIDcard.Text = "Generate IDCard";
            this.btnGenerateIDcard.UseVisualStyleBackColor = true;
            this.btnGenerateIDcard.Click += new System.EventHandler(this.btnGenerateIDcard_Click);
            // 
            // pgPatient
            // 
            this.pgPatient.Controls.Add(this.btnGenerateIDcard);
            this.pgPatient.Controls.Add(this.dtpDOB);
            this.pgPatient.Controls.Add(this.tbxIDcard);
            this.pgPatient.Controls.Add(this.lblIDcard);
            this.pgPatient.Controls.Add(this.tbxPhone);
            this.pgPatient.Controls.Add(this.cbxGender);
            this.pgPatient.Controls.Add(this.tbxSpouseName);
            this.pgPatient.Controls.Add(this.lblPhoneNum);
            this.pgPatient.Controls.Add(this.lblDOB);
            this.pgPatient.Controls.Add(this.lblGender);
            this.pgPatient.Controls.Add(this.lblSpouseName);
            this.pgPatient.Controls.Add(this.tbxFPid);
            this.pgPatient.Controls.Add(this.btnNext);
            this.pgPatient.Controls.Add(this.lblFingerPrintCount);
            this.pgPatient.Controls.Add(this.picFPImg);
            this.pgPatient.Controls.Add(this.tbxFatherName);
            this.pgPatient.Controls.Add(this.lblFatherName);
            this.pgPatient.Controls.Add(this.lblFingerId);
            this.pgPatient.Controls.Add(this.tbxMotherName);
            this.pgPatient.Controls.Add(this.lblMomName);
            this.pgPatient.Controls.Add(this.tbxFullName);
            this.pgPatient.Controls.Add(this.lblFullName);
            this.pgPatient.Controls.Add(this.lblPInfo);
            this.pgPatient.Controls.Add(this.lblPatientInfoTitle);
            this.pgPatient.Location = new System.Drawing.Point(4, 29);
            this.pgPatient.Name = "pgPatient";
            this.pgPatient.Padding = new System.Windows.Forms.Padding(3);
            this.pgPatient.Size = new System.Drawing.Size(768, 536);
            this.pgPatient.TabIndex = 0;
            this.pgPatient.Text = "Patient Information";
            this.pgPatient.UseVisualStyleBackColor = true;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderFullName
            // 
            this.errorProviderFullName.ContainerControl = this;
            // 
            // RegisterPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.lblEntryTitle);
            this.Controls.Add(this.tbcPatientInfo);
            this.Controls.Add(this.pnlRgTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register - New Patient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.tbcPatientInfo.ResumeLayout(false);
            this.pgAddress.ResumeLayout(false);
            this.pgAddress.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg)).EndInit();
            this.pgPatient.ResumeLayout(false);
            this.pgPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRgTitle;
        private System.Windows.Forms.TabControl tbcPatientInfo;
        private System.Windows.Forms.TabPage pgAddress;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblPatientAddress;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.Label lblVillageNKaren;
        private System.Windows.Forms.Label lblVillageNMM;
        private System.Windows.Forms.Label lblVillageNEn;
        private System.Windows.Forms.Label lblVillageCode;
        private System.Windows.Forms.Label lblSectionName;
        private System.Windows.Forms.TextBox tbxContryCode;
        private System.Windows.Forms.TextBox tbxRegionCode;
        private System.Windows.Forms.TextBox tbxProvinceCode;
        private System.Windows.Forms.TextBox tbxDistrictCode;
        private System.Windows.Forms.TextBox tbxVillageNKaren;
        private System.Windows.Forms.TextBox tbxVillageNMM;
        private System.Windows.Forms.TextBox tbxVillageNEn;
        private System.Windows.Forms.TextBox tbxVillageCode;
        private System.Windows.Forms.TextBox tbxSectionName;
        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblRegionCode;
        private System.Windows.Forms.Label lblProviceCode;
        private System.Windows.Forms.Label lblDisctrictCode;
        private System.Windows.Forms.Button btnSaveAddress;
        private System.Windows.Forms.Label lblEntryTitle;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox tbxAddressCode;
        private System.Windows.Forms.Label lblAddressCode;
        private System.Windows.Forms.TabPage pgPatient;
        private System.Windows.Forms.Button btnGenerateIDcard;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbxIDcard;
        private System.Windows.Forms.Label lblIDcard;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.TextBox tbxSpouseName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSpouseName;
        private System.Windows.Forms.TextBox tbxFPid;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblFingerPrintCount;
        private System.Windows.Forms.PictureBox picFPImg;
        private System.Windows.Forms.TextBox tbxFatherName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblFingerId;
        private System.Windows.Forms.TextBox tbxMotherName;
        private System.Windows.Forms.Label lblMomName;
        private System.Windows.Forms.TextBox tbxFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPInfo;
        private System.Windows.Forms.Label lblPatientInfoTitle;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.ErrorProvider errorProviderFullName;
    }
}