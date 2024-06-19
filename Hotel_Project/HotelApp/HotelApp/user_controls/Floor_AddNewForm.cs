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
    public partial class Floor_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public Floor_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int floorId = random.Next(1, 1001);
                int floorNumber = Convert.ToInt32(txtFloorNumber.Text);
                string floorDescription = txtFloorDescription.Text;

                SqlParameter[] parameters = new SqlParameter[]
                   {
                    new SqlParameter("@fl_number", floorNumber),
                    new SqlParameter("@fl_description", floorDescription)
                   };

                object result = dbConnection.ExecuteStoredProcedure("Insert_FLOOR", parameters);
                MessageBox.Show("Novi kat je uspješno dodan!");

                if (Application.OpenForms["Form_Floors"] is Form_Floors floorForm)
                {
                    floorForm.RefreshFloorList();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new floor: {ex.Message}");
            }
        }

        private void AddNewFloorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form_Floors"] is Form_Floors floorForm)
            {
                floorForm.RefreshFloorList();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
