using DevExpress.Xpo;
using PatientIsImplementation.Models;
using PatientIsImplementation.UiComponents;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PatientIsImplementation.Admin
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            TitleMain adminmainTitle = new TitleMain();
            adminmainTitle.Dock = DockStyle.Fill;
            pnlHistoryTitle.Controls.Add(adminmainTitle);

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            using (var session = new Session())
            {
                // Query data
                XPCollection<History> entities = new XPCollection<History>(session);
                // You can apply additional criteria if needed, like:
                // entities.Criteria = CriteriaOperator.Parse("PropertyName = ?", value);

                // Load the data
                entities.Load();



                // Iterate through the data and populate DataGridView
                foreach (History entity in entities)
                {
                    // Add a new row
                    int rowIndex = dgvHistory.Rows.Add();
                    DataGridViewRow row = dgvHistory.Rows[rowIndex];

                    // Populate the cells in the row with data from the entity
                    row.Cells["colId"].Value = entity.Hist_Id;
                    row.Cells["colUserId"].Value = entity.User_Id;

                    // Query for username from User table using User_Id from History table
                    var userQuery = session.Query<Users>().FirstOrDefault(u => u.Id == entity.User_Id);
                    if (userQuery != null)
                    {
                        row.Cells["colUsername"].Value = userQuery.Username;
                    }

                    row.Cells["colPatientId"].Value = entity.Patient_IDCard;
                    row.Cells["colCheckingD"].Value = entity.Checkin_Date;
                    row.Cells["colRemark"].Value = entity.Remark;

                    // Populate more columns as needed
                }
            }

            //dgvHistory.DataSource = new XPCollection<History>();
        }
    }
}
