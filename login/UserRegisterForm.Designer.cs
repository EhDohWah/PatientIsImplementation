namespace PatientIsImplementation.login
{
    partial class UserRegisterForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnURRegister = new System.Windows.Forms.Button();
            this.tbxURPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblURPhoneNumber = new System.Windows.Forms.Label();
            this.tbxURUsername = new System.Windows.Forms.TextBox();
            this.lblURUsername = new System.Windows.Forms.Label();
            this.lblURConfirmPassword = new System.Windows.Forms.Label();
            this.tbxURConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblURDOB = new System.Windows.Forms.Label();
            this.dtpURDOB = new System.Windows.Forms.DateTimePicker();
            this.lblURPassword = new System.Windows.Forms.Label();
            this.tbxURPassword = new System.Windows.Forms.TextBox();
            this.errorProviderUR = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblURUserRole = new System.Windows.Forms.Label();
            this.cbxUserRole = new System.Windows.Forms.ComboBox();
            this.chBoxPasswordShow = new System.Windows.Forms.CheckBox();
            this.chBoxConfirmPasswordShow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnURRegister
            // 
            this.btnURRegister.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnURRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnURRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnURRegister.Location = new System.Drawing.Point(76, 597);
            this.btnURRegister.Name = "btnURRegister";
            this.btnURRegister.Size = new System.Drawing.Size(234, 40);
            this.btnURRegister.TabIndex = 6;
            this.btnURRegister.Text = "Register";
            this.btnURRegister.UseVisualStyleBackColor = false;
            this.btnURRegister.Click += new System.EventHandler(this.btnURRegister_Click);
            // 
            // tbxURPhoneNumber
            // 
            this.tbxURPhoneNumber.Location = new System.Drawing.Point(76, 212);
            this.tbxURPhoneNumber.Name = "tbxURPhoneNumber";
            this.tbxURPhoneNumber.Size = new System.Drawing.Size(233, 22);
            this.tbxURPhoneNumber.TabIndex = 1;
            // 
            // lblURPhoneNumber
            // 
            this.lblURPhoneNumber.AutoSize = true;
            this.lblURPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURPhoneNumber.Location = new System.Drawing.Point(76, 188);
            this.lblURPhoneNumber.Name = "lblURPhoneNumber";
            this.lblURPhoneNumber.Size = new System.Drawing.Size(113, 18);
            this.lblURPhoneNumber.TabIndex = 3;
            this.lblURPhoneNumber.Text = "PhoneNumber";
            // 
            // tbxURUsername
            // 
            this.tbxURUsername.Location = new System.Drawing.Point(76, 140);
            this.tbxURUsername.Name = "tbxURUsername";
            this.tbxURUsername.Size = new System.Drawing.Size(234, 22);
            this.tbxURUsername.TabIndex = 0;
            // 
            // lblURUsername
            // 
            this.lblURUsername.AutoSize = true;
            this.lblURUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURUsername.Location = new System.Drawing.Point(76, 116);
            this.lblURUsername.Name = "lblURUsername";
            this.lblURUsername.Size = new System.Drawing.Size(82, 18);
            this.lblURUsername.TabIndex = 0;
            this.lblURUsername.Text = "Username";
            // 
            // lblURConfirmPassword
            // 
            this.lblURConfirmPassword.AutoSize = true;
            this.lblURConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURConfirmPassword.Location = new System.Drawing.Point(76, 498);
            this.lblURConfirmPassword.Name = "lblURConfirmPassword";
            this.lblURConfirmPassword.Size = new System.Drawing.Size(137, 18);
            this.lblURConfirmPassword.TabIndex = 11;
            this.lblURConfirmPassword.Text = "Confirm Password";
            // 
            // tbxURConfirmPassword
            // 
            this.tbxURConfirmPassword.Location = new System.Drawing.Point(76, 522);
            this.tbxURConfirmPassword.Name = "tbxURConfirmPassword";
            this.tbxURConfirmPassword.Size = new System.Drawing.Size(233, 22);
            this.tbxURConfirmPassword.TabIndex = 5;
            this.tbxURConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblURDOB
            // 
            this.lblURDOB.AutoSize = true;
            this.lblURDOB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURDOB.Location = new System.Drawing.Point(76, 260);
            this.lblURDOB.Name = "lblURDOB";
            this.lblURDOB.Size = new System.Drawing.Size(96, 18);
            this.lblURDOB.TabIndex = 5;
            this.lblURDOB.Text = "Date of Birth";
            // 
            // dtpURDOB
            // 
            this.dtpURDOB.Location = new System.Drawing.Point(76, 284);
            this.dtpURDOB.Name = "dtpURDOB";
            this.dtpURDOB.Size = new System.Drawing.Size(230, 22);
            this.dtpURDOB.TabIndex = 2;
            this.dtpURDOB.Value = new System.DateTime(2024, 4, 26, 18, 13, 41, 0);
            // 
            // lblURPassword
            // 
            this.lblURPassword.AutoSize = true;
            this.lblURPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURPassword.Location = new System.Drawing.Point(76, 406);
            this.lblURPassword.Name = "lblURPassword";
            this.lblURPassword.Size = new System.Drawing.Size(75, 18);
            this.lblURPassword.TabIndex = 9;
            this.lblURPassword.Text = "Password";
            // 
            // tbxURPassword
            // 
            this.tbxURPassword.Location = new System.Drawing.Point(76, 430);
            this.tbxURPassword.Name = "tbxURPassword";
            this.tbxURPassword.Size = new System.Drawing.Size(233, 22);
            this.tbxURPassword.TabIndex = 4;
            this.tbxURPassword.UseSystemPasswordChar = true;
            // 
            // errorProviderUR
            // 
            this.errorProviderUR.ContainerControl = this;
            // 
            // lblURUserRole
            // 
            this.lblURUserRole.AutoSize = true;
            this.lblURUserRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURUserRole.Location = new System.Drawing.Point(73, 332);
            this.lblURUserRole.Name = "lblURUserRole";
            this.lblURUserRole.Size = new System.Drawing.Size(41, 18);
            this.lblURUserRole.TabIndex = 7;
            this.lblURUserRole.Text = "Role";
            // 
            // cbxUserRole
            // 
            this.cbxUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserRole.FormattingEnabled = true;
            this.cbxUserRole.Items.AddRange(new object[] {
            "Admin",
            "HQ-Data-Staff",
            "Local Staff"});
            this.cbxUserRole.Location = new System.Drawing.Point(76, 356);
            this.cbxUserRole.Name = "cbxUserRole";
            this.cbxUserRole.Size = new System.Drawing.Size(121, 24);
            this.cbxUserRole.TabIndex = 3;
            // 
            // chBoxPasswordShow
            // 
            this.chBoxPasswordShow.AutoSize = true;
            this.chBoxPasswordShow.Location = new System.Drawing.Point(76, 459);
            this.chBoxPasswordShow.Name = "chBoxPasswordShow";
            this.chBoxPasswordShow.Size = new System.Drawing.Size(125, 20);
            this.chBoxPasswordShow.TabIndex = 12;
            this.chBoxPasswordShow.Text = "Show Password";
            this.chBoxPasswordShow.UseVisualStyleBackColor = true;
            this.chBoxPasswordShow.CheckedChanged += new System.EventHandler(this.chBoxPasswordShow_CheckedChanged);
            // 
            // chBoxConfirmPasswordShow
            // 
            this.chBoxConfirmPasswordShow.AutoSize = true;
            this.chBoxConfirmPasswordShow.Location = new System.Drawing.Point(76, 550);
            this.chBoxConfirmPasswordShow.Name = "chBoxConfirmPasswordShow";
            this.chBoxConfirmPasswordShow.Size = new System.Drawing.Size(125, 20);
            this.chBoxConfirmPasswordShow.TabIndex = 13;
            this.chBoxConfirmPasswordShow.Text = "Show Password";
            this.chBoxConfirmPasswordShow.UseVisualStyleBackColor = true;
            this.chBoxConfirmPasswordShow.CheckedChanged += new System.EventHandler(this.chBoxConfirmPasswordShow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Register New User";
            // 
            // UserRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chBoxConfirmPasswordShow);
            this.Controls.Add(this.chBoxPasswordShow);
            this.Controls.Add(this.cbxUserRole);
            this.Controls.Add(this.dtpURDOB);
            this.Controls.Add(this.btnURRegister);
            this.Controls.Add(this.tbxURPassword);
            this.Controls.Add(this.tbxURConfirmPassword);
            this.Controls.Add(this.tbxURPhoneNumber);
            this.Controls.Add(this.lblURUserRole);
            this.Controls.Add(this.lblURDOB);
            this.Controls.Add(this.lblURPassword);
            this.Controls.Add(this.lblURConfirmPassword);
            this.Controls.Add(this.lblURPhoneNumber);
            this.Controls.Add(this.tbxURUsername);
            this.Controls.Add(this.lblURUsername);
            this.Name = "UserRegisterForm";
            this.Size = new System.Drawing.Size(386, 685);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnURRegister;
        private System.Windows.Forms.TextBox tbxURPhoneNumber;
        private System.Windows.Forms.Label lblURPhoneNumber;
        private System.Windows.Forms.TextBox tbxURUsername;
        private System.Windows.Forms.Label lblURUsername;
        private System.Windows.Forms.Label lblURConfirmPassword;
        private System.Windows.Forms.TextBox tbxURConfirmPassword;
        private System.Windows.Forms.Label lblURDOB;
        private System.Windows.Forms.DateTimePicker dtpURDOB;
        private System.Windows.Forms.Label lblURPassword;
        private System.Windows.Forms.TextBox tbxURPassword;
        private System.Windows.Forms.ErrorProvider errorProviderUR;
        private System.Windows.Forms.Label lblURUserRole;
        private System.Windows.Forms.ComboBox cbxUserRole;
        private System.Windows.Forms.CheckBox chBoxConfirmPasswordShow;
        private System.Windows.Forms.CheckBox chBoxPasswordShow;
        private System.Windows.Forms.Label label1;
    }
}
