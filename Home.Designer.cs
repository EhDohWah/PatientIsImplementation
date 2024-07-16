namespace PatientIsImplementation
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlMenuTitle = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEdit_Title = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblOperatorName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRoleShow = new System.Windows.Forms.Label();
            this.toolTipBtnView = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnEntry = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipbtnAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBtnLogOut = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuTitle
            // 
            this.pnlMenuTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTitle.Name = "pnlMenuTitle";
            this.pnlMenuTitle.Size = new System.Drawing.Size(1033, 100);
            this.pnlMenuTitle.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.lblSelect);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnEdit);
            this.pnlMenu.Controls.Add(this.btnEntry);
            this.pnlMenu.Controls.Add(this.btnView);
            this.pnlMenu.Location = new System.Drawing.Point(12, 189);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1009, 383);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(364, 58);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(311, 27);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Please select an option";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.Location = new System.Drawing.Point(748, 128);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(188, 128);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipbtnAdmin.SetToolTip(this.btnAdmin, "Admin operations");
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.Location = new System.Drawing.Point(524, 128);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(188, 128);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipBtnEdit.SetToolTip(this.btnEdit, "Edit patient record");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnEntry.Image")));
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntry.Location = new System.Drawing.Point(300, 128);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(188, 128);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "Entry";
            this.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipBtnEntry.SetToolTip(this.btnEntry, "Register new patient");
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.Location = new System.Drawing.Point(76, 128);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(188, 128);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipBtnView.SetToolTip(this.btnView, "Identify registered patients");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEdit_Title
            // 
            this.lblEdit_Title.AutoSize = true;
            this.lblEdit_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Title.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblEdit_Title.Location = new System.Drawing.Point(32, 132);
            this.lblEdit_Title.Name = "lblEdit_Title";
            this.lblEdit_Title.Size = new System.Drawing.Size(77, 29);
            this.lblEdit_Title.TabIndex = 4;
            this.lblEdit_Title.Text = "Menu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1033, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 16);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(895, 125);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 49);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipBtnLogOut.SetToolTip(this.btnLogout, "Click to logout");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblOperatorName
            // 
            this.lblOperatorName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOperatorName.AutoSize = true;
            this.lblOperatorName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorName.Location = new System.Drawing.Point(99, 610);
            this.lblOperatorName.Name = "lblOperatorName";
            this.lblOperatorName.Size = new System.Drawing.Size(153, 20);
            this.lblOperatorName.TabIndex = 7;
            this.lblOperatorName.Text = "Operator Name : ";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(406, 610);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(72, 20);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role : ";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUsername.Location = new System.Drawing.Point(262, 611);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(38, 20);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Null";
            // 
            // lblRoleShow
            // 
            this.lblRoleShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRoleShow.AutoSize = true;
            this.lblRoleShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleShow.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRoleShow.Location = new System.Drawing.Point(484, 611);
            this.lblRoleShow.Name = "lblRoleShow";
            this.lblRoleShow.Size = new System.Drawing.Size(38, 20);
            this.lblRoleShow.TabIndex = 9;
            this.lblRoleShow.Text = "Null";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 682);
            this.Controls.Add(this.lblRoleShow);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblOperatorName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblEdit_Title);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMenuTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblEdit_Title;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblOperatorName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRoleShow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.ToolTip toolTipbtnAdmin;
        private System.Windows.Forms.ToolTip toolTipBtnEdit;
        private System.Windows.Forms.ToolTip toolTipBtnEntry;
        private System.Windows.Forms.ToolTip toolTipBtnView;
        private System.Windows.Forms.ToolTip toolTipBtnLogOut;
    }
}