using HotelApp.classes;
using HotelApp.classes_main;
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
    public partial class RoomsForm : Form
    {
        private Employee employee;

        public RoomsForm()
        {
            InitializeComponent();
            LoadRoomsData();
        }

        private void LoadRoomsData()
        {
            try
            {
                DBConnection dbConnection = new DBConnection();
                DataTable roomsTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS", new SqlParameter[0]);

                if (roomsTable.Rows.Count > 0)
                {
                    // Očistite postojeće redove
                    dataGridViewRooms.Rows.Clear();

                    label_num_of_rooms.Text = $"{roomsTable.Rows.Count}";


                    // Iterirajte kroz redove u DataTable i dodajte ih u DataGridView
                    foreach (DataRow row in roomsTable.Rows)
                    {
                        int rowIndex = dataGridViewRooms.Rows.Add();
                        DataGridViewRow dataGridViewRow = dataGridViewRooms.Rows[rowIndex];

                        dataGridViewRow.Cells["RoomNumber"].Value = row["rm_nr"];
                        dataGridViewRow.Cells["RoomType"].Value = row["rt_name"];
                        dataGridViewRow.Cells["RoomFloor"].Value = row["fl_number"];
                        dataGridViewRow.Cells["RoomAvailable"].Value = (bool)row["rm_active"] ? "Yes" : "No"; // Pretvorba bool u Yes/No
                        dataGridViewRow.Cells["RoomDescription"].Value = row["tm_description"];
                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewRooms.Rows[e.RowIndex];

                /*
                int roomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value); // Prilagodite naziv stupca
                string roomNumber = selectedRow.Cells["RoomNumber"].Value.ToString(); // Prilagodite naziv stupca
                string roomType = selectedRow.Cells["RoomType"].Value.ToString(); // Prilagodite naziv stupca
                int roomFloor = Convert.ToInt32(selectedRow.Cells["RoomFloor"].Value); // Prilagodite naziv stupca
                bool roomAvailable = selectedRow.Cells["RoomAvailable"].Value.ToString() == "Yes"; // Prilagodite naziv stupca
                string roomDescription = selectedRow.Cells["RoomDescription"].Value.ToString(); // Prilagodite naziv stupca

                */
                // Otvaranje forme s detaljima sobe
                RoomDetailsForm roomDetailsForm = new RoomDetailsForm();
                roomDetailsForm.Show();
            }
        }
    }
}
