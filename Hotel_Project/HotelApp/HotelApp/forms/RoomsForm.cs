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

                DataTable roomsTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS", new SqlParameter[0]);

                if (roomsTable.Rows.Count > 0)
                {
                    dataGridViewRooms.Rows.Clear();
                    label_num_of_rooms.Text = $"{roomsTable.Rows.Count}";

                    foreach (DataRow roomRow in roomsTable.Rows)
                    {
                        int roomId = (int)roomRow["rm_id_pk"];
                        Room room = new Room
                        {
                            ID = roomId,
                            Number = (int)roomRow["rm_nr"],
                            RoomTypeName = roomRow["rt_name"].ToString(),
                            Floor = new Floor
                            {
                                ID = (int)roomRow["rm_fl_id_fk"],
                                Number = 0,
                                Description = ""
                            },
                            Is_Active = (bool)roomRow["rm_active"],
                            Description = roomRow["rm_description"].ToString(),
                            SortKey = (int)roomRow["rm_sort_key"]
                        };

                        int rowIndex = dataGridViewRooms.Rows.Add(
                            room.ID,
                            room.Number,
                            room.RoomTypeName,
                            room.Floor != null ? room.Floor.Number.ToString() : "N/A",
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



    }
}
