using PatientIsImplementation.login;
using System;
using System.Windows.Forms;

namespace PatientIsImplementation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Home menu = new Home();
        //    menu.ShowDialog();
        //    this.Close();
        //}

        private void Main_Load(object sender, EventArgs e)
        {
            //loginForm mainTitle = new TitleMai();
            //mainTitle.Dock = DockStyle.Fill;
            //pnlRgTitle.Controls.Add(mainTitle);

            // Load UserControl form
            loginForm loginform = new loginForm(this);
            loginform.Dock = DockStyle.Fill;
            pnlLoginControl.Controls.Add(loginform);
        }

    }
}
