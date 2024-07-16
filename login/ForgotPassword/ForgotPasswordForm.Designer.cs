namespace PatientIsImplementation.login.ForgotPassword
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.btnForgotNext = new System.Windows.Forms.Button();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnForgotCancel = new System.Windows.Forms.Button();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOBForgotPassword = new System.Windows.Forms.DateTimePicker();
            this.errorProviderForgot = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForgot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForgotNext
            // 
            this.btnForgotNext.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnForgotNext.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotNext.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForgotNext.Location = new System.Drawing.Point(61, 376);
            this.btnForgotNext.Name = "btnForgotNext";
            this.btnForgotNext.Size = new System.Drawing.Size(275, 40);
            this.btnForgotNext.TabIndex = 2;
            this.btnForgotNext.Text = "Next";
            this.btnForgotNext.UseVisualStyleBackColor = false;
            this.btnForgotNext.Click += new System.EventHandler(this.btnForgotNext_Click);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(61, 226);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(275, 22);
            this.tbxPhoneNumber.TabIndex = 0;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(61, 191);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(117, 18);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // btnForgotCancel
            // 
            this.btnForgotCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnForgotCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForgotCancel.Location = new System.Drawing.Point(61, 428);
            this.btnForgotCancel.Name = "btnForgotCancel";
            this.btnForgotCancel.Size = new System.Drawing.Size(275, 40);
            this.btnForgotCancel.TabIndex = 3;
            this.btnForgotCancel.Text = "Cancel";
            this.btnForgotCancel.UseVisualStyleBackColor = false;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(61, 265);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 18);
            this.lblDOB.TabIndex = 6;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOBForgotPassword
            // 
            this.dtpDOBForgotPassword.Location = new System.Drawing.Point(61, 300);
            this.dtpDOBForgotPassword.Name = "dtpDOBForgotPassword";
            this.dtpDOBForgotPassword.Size = new System.Drawing.Size(272, 22);
            this.dtpDOBForgotPassword.TabIndex = 1;
            // 
            // errorProviderForgot
            // 
            this.errorProviderForgot.ContainerControl = this;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 656);
            this.Controls.Add(this.dtpDOBForgotPassword);
            this.Controls.Add(this.btnForgotCancel);
            this.Controls.Add(this.btnForgotNext);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblPhoneNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderForgot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForgotNext;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnForgotCancel;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOBForgotPassword;
        private System.Windows.Forms.ErrorProvider errorProviderForgot;
    }
}