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

        public RoomDetailsForm(Room room) : this()
        {
            this.room = room;
        }

    }
}
