using HotelApp.classes;
using HotelApp.user_controls;
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

namespace HotelApp.forms
{
    public partial class Form_RoomsAccessories : Form
    {
        private DBConnection dbConnection;
        public Form_RoomsAccessories()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        public void RefreshAccessoryList()
        {
            try
            {
                DisplayAccessories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing accessories list: {ex.Message}");
            }
        }

        private void Form_RoomsAccessories_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridViewAccessories.ClearSelection();
            DisplayAccessories();
        }

        private void DisplayAccessories()
        {
            try
            {
                DataTable accesoriesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_ACCESSORIES", new SqlParameter[0]);

                dataGridViewAccessories.Rows.Clear();

                foreach (DataRow row in accesoriesTable.Rows)
                {
                    int id = Convert.ToInt32(row["ac_id_pk"]);
                    string name = Convert.ToString(row["ac_name"]);

                    int rowIndex = dataGridViewAccessories.Rows.Add(id, name);

                }

                label_num_of_acc.Text = $"{accesoriesTable.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying accessories: {ex.Message}");
            }
        }

        private void btn_add_new_floor_Click(object sender, EventArgs e)
        {
            Accessories_AddNewForm addNewAccessoryForm = new Accessories_AddNewForm();
            addNewAccessoryForm.Show();
        }
    }
}
