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
    public partial class RoomTypesForm : Form
    {
        private DBConnection dbConnection;
        public RoomTypesForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void RoomTypesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DisplayRoomTypes();
            dataGridView_RoomTypes.ClearSelection();
        }

        private void DisplayRoomTypes()
        {
            try
            {
                DataTable roomTypesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_TYPES", new SqlParameter[0]);

                dataGridView_RoomTypes.Rows.Clear();

                foreach (DataRow row in roomTypesTable.Rows)
                {
                    int id = Convert.ToInt32(row["rt_id_pk"]);
                    string name = Convert.ToString(row["rt_name"]);
                    int num_of_persons = Convert.ToInt32(row["rt_nr_persons"]);
                    int num_of_children = Convert.ToInt32(row["rt_nr_children"]);
                    int rowIndex = dataGridView_RoomTypes.Rows.Add(id, name, num_of_persons, num_of_children);
                }

                label_num_of_room_types.Text = $"{roomTypesTable.Rows.Count}";
                dataGridView_RoomTypes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying room types: {ex.Message}");
            }
        }

        private void dataGridView_RoomTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_RoomTypes.ClearSelection();
        }

        private void dataGridView_RoomTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView_RoomTypes.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            RoomType_AddNewForm addNewRoomTypeForm = new RoomType_AddNewForm();
            addNewRoomTypeForm.Show();
        }
    }
}
