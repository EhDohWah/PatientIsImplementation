using PatientIsImplementation.UiComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientIsImplementation.login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            //Data_Layer.Connect();

            UserRegisterForm userRegisterForm = new UserRegisterForm();
            pnlRegister.Dock = DockStyle.Fill;
            pnlRegister.Controls.Add(userRegisterForm);


        }
    }
}
