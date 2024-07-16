namespace PatientIsImplementation.Admin
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.pnlHistoryTitle = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckingD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHistoryTitle
            // 
            this.pnlHistoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlHistoryTitle.Name = "pnlHistoryTitle";
            this.pnlHistoryTitle.Size = new System.Drawing.Size(1200, 79);
            this.pnlHistoryTitle.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHistoryTitle.Location = new System.Drawing.Point(37, 95);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(146, 20);
            this.lblHistoryTitle.TabIndex = 4;
            this.lblHistoryTitle.Text = "History Records";
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUserId,
            this.colUsername,
            this.colPatientId,
            this.colCheckingD,
            this.colRemark});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(0, 79);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(1200, 583);
            this.dgvHistory.TabIndex = 5;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colUserId
            // 
            this.colUserId.HeaderText = "User ID";
            this.colUserId.MinimumWidth = 6;
            this.colUserId.Name = "colUserId";
            this.colUserId.ReadOnly = true;
            this.colUserId.Width = 125;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 150;
            // 
            // colPatientId
            // 
            this.colPatientId.HeaderText = "Patient IDCard";
            this.colPatientId.MinimumWidth = 6;
            this.colPatientId.Name = "colPatientId";
            this.colPatientId.ReadOnly = true;
            this.colPatientId.Width = 160;
            // 
            // colCheckingD
            // 
            this.colCheckingD.HeaderText = "Checkin Date";
            this.colCheckingD.MinimumWidth = 6;
            this.colCheckingD.Name = "colCheckingD";
            this.colCheckingD.ReadOnly = true;
            this.colCheckingD.Width = 150;
            // 
            // colRemark
            // 
            this.colRemark.HeaderText = "Remark";
            this.colRemark.MinimumWidth = 6;
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Width = 510;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 662);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.lblHistoryTitle);
            this.Controls.Add(this.pnlHistoryTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHistoryTitle;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckingD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}