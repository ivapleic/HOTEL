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
    public partial class Accessories_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public Accessories_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string accName = txtAccName.Text;

                SqlParameter[] parameters = new SqlParameter[]
                   {
                    new SqlParameter("@ac_name", accName)
                   };

                object result = dbConnection.ExecuteStoredProcedure("Insert_ROOM_ACCESSORY", parameters);
                MessageBox.Show("Novi dodatak je uspješno dodan!");

                if (Application.OpenForms["Form_RoomsAccessories"] is Form_RoomsAccessories form_RoomsAccessories)
                {
                    form_RoomsAccessories.RefreshAccessoryList();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new accessory: {ex.Message}");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
