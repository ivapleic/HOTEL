using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.user_controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp.forms
{
    public partial class RoomsForm : Form
    {
        private Employee employee;
        Dictionary<int, int> floorNumberMap;
        DBConnection dbConnection;

        public RoomsForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            LoadRoomsData();
        }

        public void LoadRoomsData()
        {
            try
            {
                DBConnection dbConnection = new DBConnection();

                // Učitavanje podataka o sobama
                DataTable roomsTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS", new SqlParameter[0]);

                // Učitavanje podataka o katovima
                DataTable floorsTable = dbConnection.ExecuteStoredProcedure("Get_FLOORS", new SqlParameter[0]);

                // Kreiranje mape ID-eva katova na brojeve katova
                floorNumberMap = new Dictionary<int, int>();
                foreach (DataRow floorRow in floorsTable.Rows)
                {
                    int floorId = (int)floorRow["fl_id_pk"];
                    int floorNumber = (int)floorRow["fl_number"];
                    floorNumberMap[floorId] = floorNumber;
                }

                // Osvježavanje podataka u DataGridView
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
                        room.ID,
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private List<RoomAccessory> GetRoomAccessories(int roomId)
        {
            try
            {
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
                    RoomDetailsForm roomDetailsForm = new RoomDetailsForm(room, floorNumberMap);
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
                    RoomDetailsForm roomDetailsForm = new RoomDetailsForm(selectedRoom, floorNumberMap);

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

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRooms.SelectedRows.Count > 0)
                {
                    var selectedRow = dataGridViewRooms.SelectedRows[0];
                    int roomId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Brisanje dodataka povezano sa sobom
                    SqlParameter[] accessoryParameters = {
                new SqlParameter("@ar_rm_id_fk", roomId)
            };
                    dbConnection.ExecuteStoredProcedure("Delete_ROOMS_ROOM_ACCESSORY_BY_ROOM_ID", accessoryParameters);

                    // Brisanje sobe
                    SqlParameter[] roomParameters = {
                new SqlParameter("@rm_id_pk", roomId)
            };
                    dbConnection.ExecuteStoredProcedure("Delete_ROOM", roomParameters);

                    MessageBox.Show("Room and its accessories deleted successfully.");

                    // Osvježite prikaz soba nakon brisanja
                    LoadRoomsData(); // Poziv metode za učitavanje podataka o sobama
                }
                else
                {
                    MessageBox.Show("No room selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting room: " + ex.Message);
            }
        }

        private void btn_update_room_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewRooms.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridViewRooms.SelectedRows[0];

                    // Retrieve the room ID from the first cell (assuming ID is in the first column)
                    int roomId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Fetch room details from database
                    SqlParameter[] roomParameters = { new SqlParameter("@rm_id_pk", roomId) };
                    DataTable roomTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_BY_ID", roomParameters);

                    // Fetch floor details from database
                    DataTable floorsTable = dbConnection.ExecuteStoredProcedure("GET_FLOORS", new SqlParameter[] { });

                    if (roomTable.Rows.Count > 0)
                    {
                        // Create a Room object from the data
                        DataRow row = roomTable.Rows[0];
                        Room room = new Room
                        {
                            ID = Convert.ToInt32(row["rm_id_pk"]),
                            Number = Convert.ToInt32(row["rm_nr"]),
                            RoomTypeID = Convert.ToInt32(row["rm_rt_id_fk"]),
                            FloorID = Convert.ToInt32(row["rm_fl_id_fk"]),
                            Is_Active = Convert.ToBoolean(row["rm_active"]),
                            Description = row["rm_description"].ToString(),
                            ImagePath1 = row["rm_image_1"].ToString(),
                            ImagePath2 = row["rm_image_2"].ToString(),
                            ImagePath3 = row["rm_image_3"].ToString(),
                            ImagePath4 = row["rm_image_4"].ToString(),
                            ImagePath5 = row["rm_image_5"].ToString()
                        };

                        // Show the Room_UpdateForm
                        Room_UpdateForm updateForm = new Room_UpdateForm(room, floorsTable);
                        updateForm.ShowDialog(); // Use Show() if you want to open it as a non-modal form
                    }
                    else
                    {
                        MessageBox.Show("Room details not found.");
                    }
                }
                else
                {
                    MessageBox.Show("No room selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
        }
    }
}
