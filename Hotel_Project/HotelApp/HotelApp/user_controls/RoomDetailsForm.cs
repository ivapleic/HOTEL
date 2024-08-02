// HotelApp.user_controls.RoomDetailsForm
using HotelApp.classes;
using HotelApp.classes_main;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class RoomDetailsForm : Form
    {
        private Room room;
        private List<RoomAccessory> accessories;
        private DBConnection dbConnection = new DBConnection(); // Instanca DBConnection

        public RoomDetailsForm()
        {
            InitializeComponent();
        }

        public RoomDetailsForm(Room room) : this()
        {
            this.room = room;
            LoadRoomDetails();
        }

        private void LoadRoomDetails()
        {
            room_number_label.Text = room.Number.ToString();
            room_type_label.Text = room.RoomTypeName;
            floor_number_label.Text = room.FloorID.ToString();
            room_available_label.Text = room.Is_Active ? "Yes" : "No";
            room_description_label.Text = room.Description;

            DisplayImage(room.ImagePath1, room_image1);
            DisplayImage(room.ImagePath2, room_image2);
            DisplayImage(room.ImagePath3, room_image3);
            DisplayImage(room.ImagePath4, room_image4);
            DisplayImage(room.ImagePath5, room_image5);

            LoadRoomAccessories();
        }

        private void LoadRoomAccessories()
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ar_rm_id_fk", room.ID)
                };

                DataTable accessoriesTable = dbConnection.ExecuteStoredProcedure("Get_ROOMS_ROOM_ACCESSORIES_BY_ROOM_ID", parameters);
                accessories = new List<RoomAccessory>();

                foreach (DataRow accessoryRow in accessoriesTable.Rows)
                {
                    RoomAccessory accessory = new RoomAccessory
                    {
                        ID = (int)accessoryRow["ar_ac_id_fk"],
                        Name = accessoryRow["ac_name"].ToString()
                    };
                    accessories.Add(accessory);
                    accessories_listBox.Items.Add(accessory.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja dodatne opreme: " + ex.Message);
            }
        }

        // Metoda za prikaz slike u PictureBox-u
        private void DisplayImage(string imagePath, PictureBox pictureBox)
        {
            if (!string.IsNullOrWhiteSpace(imagePath))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    pictureBox.Image = null;
                    MessageBox.Show($"Greška prilikom učitavanja slike: {ex.Message}");
                }
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        private void room_image4_Click(object sender, EventArgs e)
        {

        }
    }
}
