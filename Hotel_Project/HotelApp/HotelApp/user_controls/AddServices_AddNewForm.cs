using HotelApp.classes;
using HotelApp.forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class AddServices_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public AddServices_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string sericeName = Convert.ToString(txtServiceName.Text);
                decimal servicePrice = Convert.ToDecimal(txtServicePrice.Text);
                string serviceDescription = Convert.ToString(txtServiceDescription.Text);

                SqlParameter[] parameters = new SqlParameter[]
                   {
                    new SqlParameter("@as_name", sericeName),
                    new SqlParameter("@as_price", servicePrice),
                     new SqlParameter("@as_description",serviceDescription)
                   };

                object result = dbConnection.ExecuteStoredProcedure("Insert_ADD_SERVICE", parameters);
                MessageBox.Show("Novi tip usluge je uspješno dodan!");

                if (Application.OpenForms["Form_AddServices"] is Form_AddServices addServicesForm)
                {
                    addServicesForm.RefreshAddServicesList();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new additional service: {ex.Message}");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
