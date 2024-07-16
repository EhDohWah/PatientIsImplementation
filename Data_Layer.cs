using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace PatientIsImplementation
{
    internal class Data_Layer
    {
        public static void Connect()
        {
            try
            {
                //Create a connection string 
                string connectionString = $@"XpoProvider=MSSqlServer;Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Turtle\Documents\PatientIsImplementation\PatientIS.mdf;Integrated Security=True;Connect Timeout=30";

                // XPOdefault layer
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);

                //MessageBox.Show("Database Connection Successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}
