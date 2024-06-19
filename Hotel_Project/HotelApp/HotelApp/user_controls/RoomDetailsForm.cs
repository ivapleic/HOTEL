using HotelApp.classes_main;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class RoomDetailsForm : Form
    {
        private Room room;
        private List<RoomAccessory> accessories;

        public RoomDetailsForm()
        {
            InitializeComponent();
        }

        public RoomDetailsForm(Room room, List<RoomAccessory> accessories) : this()
        {
            this.room = room;
            this.accessories = accessories;
            DisplayRoomDetails();
            DisplayAccessories();
        }

        private void DisplayRoomDetails()
        {
            room_number_label.Text = room.Number.ToString();
            room_type_label.Text = room.RoomTypeName;
            floor_number_label.Text = room.Floor != null ? room.Floor.Number.ToString() : "N/A";
            room_available_label.Text = room.Is_Active ? "Yes" : "No";
            room_description_label.Text = room.Description;
        }

        private void DisplayAccessories()
        {
            accessories_listBox.Items.Clear();

            foreach (var accessory in accessories)
            {
                accessories_listBox.Items.Add(accessory.Name);
            }
        }
    }
}
