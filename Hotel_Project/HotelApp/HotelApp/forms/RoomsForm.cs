using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.user_controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

                // Učitavanje podataka o sobama
                DataTable roomsTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS", new SqlParameter[0]);

                // Učitavanje podataka o katovima
                DataTable floorsTable = dbConnection.ExecuteStoredProcedure("Get_FLOORS", new SqlParameter[0]);

                // Kreiranje mape ID-eva katova na brojeve katova
                Dictionary<int, int> floorNumberMap = new Dictionary<int, int>();
                foreach (DataRow floorRow in floorsTable.Rows)
                {
                    int floorId = (int)floorRow["fl_id_pk"];
                    int floorNumber = (int)floorRow["fl_number"];
                    floorNumberMap[floorId] = floorNumber;
                }

                if (roomsTable.Rows.Count > 0)
                {
                    dataGridViewRooms.Rows.Clear();
                    label_num_of_rooms.Text = $"{roomsTable.Rows.Count}";

                    foreach (DataRow roomRow in roomsTable.Rows)
                    {
                        int roomId = (int)roomRow["rm_id_pk"];
                        int floorId = (int)roomRow["rm_fl_id_fk"];
                        Room room = new Room
                        {
                            ID = roomId,
                            Number = (int)roomRow["rm_nr"],
                            RoomTypeID = (int)roomRow["rm_rt_id_fk"],
                            RoomTypeName = roomRow["rt_name"].ToString(),
                            FloorID = floorId,
                            Is_Active = (bool)roomRow["rm_active"],
                            Description = roomRow["rm_description"].ToString(),
                            ImagePath1 = roomRow["rm_image_1"].ToString(),
                            ImagePath2 = roomRow["rm_image_2"].ToString(),
                            ImagePath3 = roomRow["rm_image_3"].ToString(),
                            ImagePath4 = roomRow["rm_image_4"].ToString(),
                            ImagePath5 = roomRow["rm_image_5"].ToString(),
                            RoomAccessories = GetRoomAccessories(roomId)
                        };

                        int rowIndex = dataGridViewRooms.Rows.Add(
                            room.Number,
                            room.RoomTypeName,
                            floorNumberMap.ContainsKey(floorId) ? floorNumberMap[floorId].ToString() : "N/A",
                            room.Is_Active ? "Yes" : "No",
                            room.Description
                        );

                        // Store the room object in the row's Tag property for later use
                        dataGridViewRooms.Rows[rowIndex].Tag = room;
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

        private List<RoomAccessory> GetRoomAccessories(int roomId)
        {
            try
            {
                DBConnection dbConnection = new DBConnection();

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ar_rm_id_fk", roomId)
                };

                DataTable accessoriesTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS_ROOM_ACCESSORIES_BY_ROOM_ID", parameters);
                List<RoomAccessory> accessories = new List<RoomAccessory>();

                foreach (DataRow accessoryRow in accessoriesTable.Rows)
                {
                    RoomAccessory accessory = new RoomAccessory
                    {
                        ID = (int)accessoryRow["ar_ac_id_fk"],
                        Name = accessoryRow["ac_name"].ToString()
                    };

                    accessories.Add(accessory);
                }

                return accessories;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return new List<RoomAccessory>();
            }
        }

        private void dataGridViewRooms_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewRooms.Rows[e.RowIndex];
                Room room = (Room)selectedRow.Tag;

                if (room != null)
                {
                    RoomDetailsForm roomDetailsForm = new RoomDetailsForm(room);
                    roomDetailsForm.ShowDialog();
                }
            }
        }

        private void btn_room_details_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite sobu koju zelite detaljnije vidjeti.");
                return;
            }

            try
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewRooms.SelectedRows[0];

                // Get the Room object from the selected row's Tag property
                Room selectedRoom = (Room)selectedRow.Tag;

                // Check if the selectedRoom is not null
                if (selectedRoom != null)
                {
                    // Create an instance of RoomDetailsForm and pass the selectedRoom to it
                    RoomDetailsForm roomDetailsForm = new RoomDetailsForm(selectedRoom);

                    // Show the RoomDetailsForm as a dialog
                    roomDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odabrana soba nije validna.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            Room_AddNewForm addNewForm = new Room_AddNewForm();
            addNewForm.ShowDialog();
        }
    }
}
