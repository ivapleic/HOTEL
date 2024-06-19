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

                // Dohvat soba iz baze podataka
                DataTable roomsTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS", new SqlParameter[0]);

                if (roomsTable.Rows.Count > 0)
                {
                    dataGridViewRooms.Rows.Clear();
                    label_num_of_rooms.Text = $"{roomsTable.Rows.Count}";

                    List<Room> rooms = new List<Room>();

                    foreach (DataRow roomRow in roomsTable.Rows)
                    {
                        int roomId = (int)roomRow["rm_id_pk"];

                        // Stvaranje objekta sobe
                        Room room = new Room
                        {
                            ID = roomId,
                            Number = (int)roomRow["rm_nr"],
                            ID_RoomType = (int)roomRow["rm_roomtype_id"],
                            RoomTypeName = roomRow["rt_name"].ToString(),
                            Floor = new Floor
                            {
                                ID = (int)roomRow["rm_fl_id_fk"],
                                Number = 0, // Ovdje postavite broj kata ako je dostupan
                                Description = "" // Ovdje postavite opis kata ako je dostupan
                            },
                            Is_Active = (bool)roomRow["rm_active"],
                            Description = roomRow["rm_description"].ToString(),
                            SortKey = (int)roomRow["rm_sort_key"]
                        };

                        // Dohvat povezanih dodatnih stvari (accessories) preko RoomAccessoryAssignment
                        DataTable accessoriesTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS_ROOM_ACCESSORIES_BY_ROOM_ID",
                            new SqlParameter[] { new SqlParameter("@ar_rm_id_fk", roomId) });

                        foreach (DataRow accessoryRow in accessoriesTable.Rows)
                        {
                            RoomAccessory accessory = new RoomAccessory
                            {
                                ID = (int)accessoryRow["ra_id"],
                                Name = accessoryRow["ac_name"].ToString()
                            };
                            room.RoomAccessories.Add(accessory);
                        }

                        rooms.Add(room);
                    }

                    // Dodavanje soba u DataGridView
                    foreach (var room in rooms)
                    {
                        int rowIndex = dataGridViewRooms.Rows.Add();
                        DataGridViewRow dataGridViewRow = dataGridViewRooms.Rows[rowIndex];
                        dataGridViewRow.Cells["RoomNumber"].Value = room.Number;
                        dataGridViewRow.Cells["RoomType"].Value = room.RoomTypeName;
                        dataGridViewRow.Cells["RoomFloor"].Value = room.Floor != null ? room.Floor.Number.ToString() : "N/A";
                        dataGridViewRow.Cells["RoomAvailable"].Value = room.Is_Active ? "Yes" : "No";
                        dataGridViewRow.Cells["RoomDescription"].Value = room.Description;
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
                int roomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value); // Prilagodite naziv stupca

                // Prikazivanje detalja sobe
                ShowRoomDetails(roomId);
            }
        }

        private void ShowRoomDetails(int roomId)
        {
            try
            {
                DBConnection dbConnection = new DBConnection();
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ar_rm_id_fk", roomId)
                };

                // Dohvat podataka o sobi i dodatnim stvarima za tu sobu
                DataTable roomDetailsTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS_ROOM_ACCESSORIES_BY_ROOM_ID", parameters);

                if (roomDetailsTable.Rows.Count > 0)
                {
                    Room room = null;
                    List<RoomAccessory> accessories = new List<RoomAccessory>();

                    // Kreiranje objekta sobe iz prvog retka rezultata
                    foreach (DataRow row in roomDetailsTable.Rows)
                    {
                        if (room == null)
                        {
                            room = new Room
                            {
                                ID = (int)row["rm_id"],
                                Number = (int)row["rm_nr"],
                                ID_RoomType = (int)row["rm_roomtype_id"],
                                RoomTypeName = row["rt_name"].ToString(),
                                Floor = new Floor
                                {
                                    ID = (int)row["rm_fl_id"],
                                    Number = 0, // Ovdje postavite broj kata ako je dostupan
                                    Description = "" // Ovdje postavite opis kata ako je dostupan
                                },
                                Is_Active = (bool)row["rm_active"],
                                Description = row["rm_description"].ToString(),
                                SortKey = (int)row["rm_sortkey"]
                            };
                        }

                        // Dodavanje dodatnih stvari u listu accessories
                        RoomAccessory accessory = new RoomAccessory
                        {
                            ID = (int)row["ar_id_pk"],
                            Name = row["ac_name"].ToString()
                        };
                        accessories.Add(accessory);
                    }

                    // Otvaranje forme s detaljima sobe i proslijeđivanje podataka
                    RoomDetailsForm roomDetailsForm = new RoomDetailsForm(room, accessories);
                    roomDetailsForm.Show();
                }
                else
                {
                    MessageBox.Show("No details found for selected room.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
