namespace PatientIsImplementation.Admin
{
    partial class AdminChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangePassword));
            this.chBoxConfirmPasswordShow = new System.Windows.Forms.CheckBox();
            this.chBoxNewPasswordShow = new System.Windows.Forms.CheckBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblURConfirmPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.tbxOldPassword = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.chbOldPassword = new System.Windows.Forms.CheckBox();
            this.errorProviderOldPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // chBoxConfirmPasswordShow
            // 
            this.chBoxConfirmPasswordShow.AutoSize = true;
            this.chBoxConfirmPasswordShow.Location = new System.Drawing.Point(90, 413);
            this.chBoxConfirmPasswordShow.Name = "chBoxConfirmPasswordShow";
            this.chBoxConfirmPasswordShow.Size = new System.Drawing.Size(125, 20);
            this.chBoxConfirmPasswordShow.TabIndex = 19;
            this.chBoxConfirmPasswordShow.Text = "Show Password";
            this.chBoxConfirmPasswordShow.UseVisualStyleBackColor = true;
            this.chBoxConfirmPasswordShow.CheckedChanged += new System.EventHandler(this.chBoxConfirmPasswordShow_CheckedChanged);
            // 
            // chBoxNewPasswordShow
            // 
            this.chBoxNewPasswordShow.AutoSize = true;
            this.chBoxNewPasswordShow.Location = new System.Drawing.Point(90, 328);
            this.chBoxNewPasswordShow.Name = "chBoxNewPasswordShow";
            this.chBoxNewPasswordShow.Size = new System.Drawing.Size(125, 20);
            this.chBoxNewPasswordShow.TabIndex = 18;
            this.chBoxNewPasswordShow.Text = "Show Password";
            this.chBoxNewPasswordShow.UseVisualStyleBackColor = true;
            this.chBoxNewPasswordShow.CheckedChanged += new System.EventHandler(this.chBoxNewPasswordShow_CheckedChanged_1);
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(90, 299);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(233, 22);
            this.tbxNewPassword.TabIndex = 14;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(90, 385);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(233, 22);
            this.tbxConfirmPassword.TabIndex = 15;
            this.tbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(90, 275);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(114, 18);
            this.lblNewPassword.TabIndex = 16;
            this.lblNewPassword.Text = "New password";
            // 
            // lblURConfirmPassword
            // 
            this.lblURConfirmPassword.AutoSize = true;
            this.lblURConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURConfirmPassword.Location = new System.Drawing.Point(90, 361);
            this.lblURConfirmPassword.Name = "lblURConfirmPassword";
            this.lblURConfirmPassword.Size = new System.Drawing.Size(137, 18);
            this.lblURConfirmPassword.TabIndex = 17;
            this.lblURConfirmPassword.Text = "Confirm Password";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(89, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(234, 40);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(90, 186);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(106, 18);
            this.lblOldPassword.TabIndex = 16;
            this.lblOldPassword.Text = "Old Password";
            // 
            // tbxOldPassword
            // 
            this.tbxOldPassword.Location = new System.Drawing.Point(89, 212);
            this.tbxOldPassword.Name = "tbxOldPassword";
            this.tbxOldPassword.Size = new System.Drawing.Size(233, 22);
            this.tbxOldPassword.TabIndex = 14;
            this.tbxOldPassword.UseSystemPasswordChar = true;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(104, 92);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(198, 20);
            this.lblChangePassword.TabIndex = 21;
            this.lblChangePassword.Text = "Change Admin Password";
            // 
            // chbOldPassword
            // 
            this.chbOldPassword.AutoSize = true;
            this.chbOldPassword.Location = new System.Drawing.Point(89, 239);
            this.chbOldPassword.Name = "chbOldPassword";
            this.chbOldPassword.Size = new System.Drawing.Size(125, 20);
            this.chbOldPassword.TabIndex = 18;
            this.chbOldPassword.Text = "Show Password";
            this.chbOldPassword.UseVisualStyleBackColor = true;
            this.chbOldPassword.CheckedChanged += new System.EventHandler(this.chbOldPassword_CheckedChanged);
            // 
            // errorProviderOldPassword
            // 
            this.errorProviderOldPassword.ContainerControl = this;
            // 
            // errorProviderNewPassword
            // 
            this.errorProviderNewPassword.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name : ";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdminName.Location = new System.Drawing.Point(92, 140);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(40, 18);
            this.lblAdminName.TabIndex = 23;
            this.lblAdminName.Text = "Null";
            // 
            // AdminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 703);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chBoxConfirmPasswordShow);
            this.Controls.Add(this.chbOldPassword);
            this.Controls.Add(this.chBoxNewPasswordShow);
            this.Controls.Add(this.tbxOldPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblURConfirmPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBoxConfirmPasswordShow;
        private System.Windows.Forms.CheckBox chBoxNewPasswordShow;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblURConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox tbxOldPassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.CheckBox chbOldPassword;
        private System.Windows.Forms.ErrorProvider errorProviderOldPassword;
        private System.Windows.Forms.ErrorProvider errorProviderNewPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblName;
    }
}