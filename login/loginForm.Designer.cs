namespace PatientIsImplementation.login
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.chbxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.toolTipUsername = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipShowPassword = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipForgot = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.chbxShowPassword);
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.lblForgotPassword);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Location = new System.Drawing.Point(3, 3);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(400, 436);
            this.gbxLogin.TabIndex = 1;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Please log in first";
            // 
            // chbxShowPassword
            // 
            this.chbxShowPassword.AutoSize = true;
            this.chbxShowPassword.Location = new System.Drawing.Point(67, 205);
            this.chbxShowPassword.Name = "chbxShowPassword";
            this.chbxShowPassword.Size = new System.Drawing.Size(125, 20);
            this.chbxShowPassword.TabIndex = 6;
            this.chbxShowPassword.Text = "Show Password";
            this.toolTipShowPassword.SetToolTip(this.chbxShowPassword, "Click Here to show password");
            this.chbxShowPassword.UseVisualStyleBackColor = true;
            this.chbxShowPassword.CheckedChanged += new System.EventHandler(this.chbxShowPassword_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(64, 297);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(275, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.toolTipLogin.SetToolTip(this.btnLogin, "Click here to login");
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblForgotPassword.Location = new System.Drawing.Point(134, 263);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(139, 18);
            this.lblForgotPassword.TabIndex = 4;
            this.lblForgotPassword.Text = "Forgot password? ";
            this.toolTipForgot.SetToolTip(this.lblForgotPassword, "Click here to reset password");
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(64, 171);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(275, 22);
            this.tbxPassword.TabIndex = 3;
            this.toolTipPassword.SetToolTip(this.tbxPassword, "Please enter password ");
            this.tbxPassword.UseSystemPasswordChar = true;
            this.tbxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(64, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 18);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(64, 113);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(275, 22);
            this.tbxUsername.TabIndex = 1;
            this.toolTipUsername.SetToolTip(this.tbxUsername, "Please enter username ");
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(64, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 18);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginForm";
            this.Size = new System.Drawing.Size(828, 458);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.CheckBox chbxShowPassword;
        private System.Windows.Forms.ToolTip toolTipShowPassword;
        private System.Windows.Forms.ToolTip toolTipLogin;
        private System.Windows.Forms.ToolTip toolTipForgot;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.ToolTip toolTipUsername;
    }
}
