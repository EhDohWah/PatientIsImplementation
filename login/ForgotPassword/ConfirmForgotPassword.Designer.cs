namespace PatientIsImplementation.login.ForgotPassword
{
    partial class ConfirmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForgotPassword));
            this.btnForgotCancel = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.errorProviderNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.chBxNewPassword = new System.Windows.Forms.CheckBox();
            this.chBxConfirmPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForgotCancel
            // 
            this.btnForgotCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnForgotCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnForgotCancel.Location = new System.Drawing.Point(60, 436);
            this.btnForgotCancel.Name = "btnForgotCancel";
            this.btnForgotCancel.Size = new System.Drawing.Size(275, 40);
            this.btnForgotCancel.TabIndex = 3;
            this.btnForgotCancel.Text = "Cancel";
            this.btnForgotCancel.UseVisualStyleBackColor = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangePassword.Location = new System.Drawing.Point(60, 384);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(275, 40);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(60, 192);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(275, 22);
            this.tbxNewPassword.TabIndex = 0;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(60, 263);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(137, 18);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(60, 153);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(112, 18);
            this.lblNewPassword.TabIndex = 12;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(60, 302);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(275, 22);
            this.tbxConfirmPassword.TabIndex = 1;
            this.tbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // errorProviderNewPassword
            // 
            this.errorProviderNewPassword.ContainerControl = this;
            // 
            // chBxNewPassword
            // 
            this.chBxNewPassword.AutoSize = true;
            this.chBxNewPassword.Location = new System.Drawing.Point(60, 220);
            this.chBxNewPassword.Name = "chBxNewPassword";
            this.chBxNewPassword.Size = new System.Drawing.Size(125, 20);
            this.chBxNewPassword.TabIndex = 14;
            this.chBxNewPassword.Text = "Show Password";
            this.chBxNewPassword.UseVisualStyleBackColor = true;
            this.chBxNewPassword.CheckedChanged += new System.EventHandler(this.chBxNewPassword_CheckedChanged);
            // 
            // chBxConfirmPassword
            // 
            this.chBxConfirmPassword.AutoSize = true;
            this.chBxConfirmPassword.Location = new System.Drawing.Point(60, 330);
            this.chBxConfirmPassword.Name = "chBxConfirmPassword";
            this.chBxConfirmPassword.Size = new System.Drawing.Size(125, 20);
            this.chBxConfirmPassword.TabIndex = 15;
            this.chBxConfirmPassword.Text = "Show Password";
            this.chBxConfirmPassword.UseVisualStyleBackColor = true;
            this.chBxConfirmPassword.CheckedChanged += new System.EventHandler(this.chBxConfirmPassword_CheckedChanged);
            // 
            // ConfirmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 656);
            this.Controls.Add(this.chBxConfirmPassword);
            this.Controls.Add(this.chBxNewPassword);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.btnForgotCancel);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForgotCancel;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProviderNewPassword;
        private System.Windows.Forms.CheckBox chBxConfirmPassword;
        private System.Windows.Forms.CheckBox chBxNewPassword;
    }
}