namespace PatientIsImplementation.Admin
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.adminTitle = new System.Windows.Forms.Label();
            this.lblAdminExplanation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnAdminPasswordChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1200, 79);
            this.pnlTitle.TabIndex = 0;
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.adminTitle.Location = new System.Drawing.Point(38, 104);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(86, 29);
            this.adminTitle.TabIndex = 1;
            this.adminTitle.Text = "Admin";
            // 
            // lblAdminExplanation
            // 
            this.lblAdminExplanation.AutoSize = true;
            this.lblAdminExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminExplanation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAdminExplanation.Location = new System.Drawing.Point(130, 111);
            this.lblAdminExplanation.Name = "lblAdminExplanation";
            this.lblAdminExplanation.Size = new System.Drawing.Size(270, 20);
            this.lblAdminExplanation.TabIndex = 2;
            this.lblAdminExplanation.Text = "User management and Data export";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAdminPasswordChange);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnAddUsers);
            this.panel1.Location = new System.Drawing.Point(42, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 358);
            this.panel1.TabIndex = 3;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(475, 66);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(139, 89);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.Location = new System.Drawing.Point(280, 66);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(139, 89);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsers.Image")));
            this.btnAddUsers.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUsers.Location = new System.Drawing.Point(85, 66);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(139, 89);
            this.btnAddUsers.TabIndex = 0;
            this.btnAddUsers.Text = "AddUser";
            this.btnAddUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnAdminPasswordChange
            // 
            this.btnAdminPasswordChange.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPasswordChange.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPasswordChange.Image")));
            this.btnAdminPasswordChange.Location = new System.Drawing.Point(670, 66);
            this.btnAdminPasswordChange.Name = "btnAdminPasswordChange";
            this.btnAdminPasswordChange.Size = new System.Drawing.Size(139, 89);
            this.btnAdminPasswordChange.TabIndex = 2;
            this.btnAdminPasswordChange.Text = "Admin Change Password";
            this.btnAdminPasswordChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminPasswordChange.UseVisualStyleBackColor = true;
            this.btnAdminPasswordChange.Click += new System.EventHandler(this.btnAdminPasswordChange_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdminExplanation);
            this.Controls.Add(this.adminTitle);
            this.Controls.Add(this.pnlTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - user management and administrative functions";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.Label lblAdminExplanation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnAdminPasswordChange;
    }
}