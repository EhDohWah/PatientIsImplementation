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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MenuTitle = new System.Windows.Forms.Label();
            this.statusStripHome = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbxOperator = new System.Windows.Forms.PictureBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblOperatorUsername = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblHomeRole = new System.Windows.Forms.Label();
            this.lblHomeRoleValue = new System.Windows.Forms.Label();
            this.lblMenuExplanation = new System.Windows.Forms.Label();
            this.toolTipViewButton = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenu.SuspendLayout();
            this.statusStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOperator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.Location = new System.Drawing.Point(438, 61);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(311, 27);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Please select an option";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnEdit);
            this.pnlMenu.Controls.Add(this.btnEntry);
            this.pnlMenu.Controls.Add(this.btnView);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Location = new System.Drawing.Point(18, 164);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1164, 378);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.Location = new System.Drawing.Point(843, 156);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(181, 119);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.Location = new System.Drawing.Point(612, 156);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(181, 119);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnEntry.Image")));
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntry.Location = new System.Drawing.Point(381, 156);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(181, 119);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "Entry";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnView
            // 
            this.btnView.AccessibleDescription = "";
            this.btnView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.Location = new System.Drawing.Point(150, 156);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(181, 118);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTipViewButton.SetToolTip(this.btnView, "Identify Registered Patient");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1200, 79);
            this.pnlTitle.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.MenuTitle.Location = new System.Drawing.Point(24, 110);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(77, 29);
            this.MenuTitle.TabIndex = 5;
            this.MenuTitle.Text = "Menu";
            // 
            // statusStripHome
            // 
            this.statusStripHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStripHome.Location = new System.Drawing.Point(0, 640);
            this.statusStripHome.Name = "statusStripHome";
            this.statusStripHome.Size = new System.Drawing.Size(1200, 22);
            this.statusStripHome.TabIndex = 6;
            this.statusStripHome.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 16);
            // 
            // pbxOperator
            // 
            this.pbxOperator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbxOperator.Image = ((System.Drawing.Image)(resources.GetObject("pbxOperator.Image")));
            this.pbxOperator.Location = new System.Drawing.Point(47, 567);
            this.pbxOperator.Name = "pbxOperator";
            this.pbxOperator.Size = new System.Drawing.Size(43, 40);
            this.pbxOperator.TabIndex = 7;
            this.pbxOperator.TabStop = false;
            // 
            // lblOperator
            // 
            this.lblOperator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(96, 582);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(134, 20);
            this.lblOperator.TabIndex = 8;
            this.lblOperator.Text = "Operator Name: ";
            // 
            // lblOperatorUsername
            // 
            this.lblOperatorUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOperatorUsername.AutoSize = true;
            this.lblOperatorUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperatorUsername.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblOperatorUsername.Location = new System.Drawing.Point(236, 582);
            this.lblOperatorUsername.Name = "lblOperatorUsername";
            this.lblOperatorUsername.Size = new System.Drawing.Size(42, 20);
            this.lblOperatorUsername.TabIndex = 9;
            this.lblOperatorUsername.Text = "Null";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(1049, 103);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(133, 39);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblHomeRole
            // 
            this.lblHomeRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHomeRole.AutoSize = true;
            this.lblHomeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeRole.Location = new System.Drawing.Point(375, 582);
            this.lblHomeRole.Name = "lblHomeRole";
            this.lblHomeRole.Size = new System.Drawing.Size(53, 20);
            this.lblHomeRole.TabIndex = 8;
            this.lblHomeRole.Text = "Role: ";
            // 
            // lblHomeRoleValue
            // 
            this.lblHomeRoleValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHomeRoleValue.AutoSize = true;
            this.lblHomeRoleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeRoleValue.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHomeRoleValue.Location = new System.Drawing.Point(426, 582);
            this.lblHomeRoleValue.Name = "lblHomeRoleValue";
            this.lblHomeRoleValue.Size = new System.Drawing.Size(42, 20);
            this.lblHomeRoleValue.TabIndex = 9;
            this.lblHomeRoleValue.Text = "Null";
            // 
            // lblMenuExplanation
            // 
            this.lblMenuExplanation.AutoSize = true;
            this.lblMenuExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuExplanation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenuExplanation.Location = new System.Drawing.Point(107, 115);
            this.lblMenuExplanation.Name = "lblMenuExplanation";
            this.lblMenuExplanation.Size = new System.Drawing.Size(527, 22);
            this.lblMenuExplanation.TabIndex = 11;
            this.lblMenuExplanation.Text = " Identify, register, and edit patients\' data. Administrative functions";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 662);
            this.Controls.Add(this.lblMenuExplanation);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblHomeRoleValue);
            this.Controls.Add(this.lblOperatorUsername);
            this.Controls.Add(this.lblHomeRole);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.pbxOperator);
            this.Controls.Add(this.statusStripHome);
            this.Controls.Add(this.MenuTitle);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.statusStripHome.ResumeLayout(false);
            this.statusStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label MenuTitle;
        public System.Windows.Forms.StatusStrip statusStripHome;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.PictureBox pbxOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblOperatorUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblHomeRole;
        private System.Windows.Forms.Label lblHomeRoleValue;
        private System.Windows.Forms.Label lblMenuExplanation;
        private System.Windows.Forms.ToolTip toolTipViewButton;
    }
}