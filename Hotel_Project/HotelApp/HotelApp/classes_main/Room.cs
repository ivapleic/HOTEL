using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace HotelApp.classes_main
{
    public class Room
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public int FloorID { get; set; }
        public bool Is_Active { get; set; }
        public string Description { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public string ImagePath3 { get; set; }
        public string ImagePath4 { get; set; }
        public string ImagePath5 { get; set; }
        public List<RoomAccessory> RoomAccessories { get; set; }

        public Room()
        {
            ID = -1;
            Number = 0;
            RoomTypeID = -1;
            RoomTypeName = "";
            FloorID = -1;
            Is_Active = true;
            Description = "";
            ImagePath1 = "";
            ImagePath2 = "";
            ImagePath3 ="";
            ImagePath4 = "";
            ImagePath5 = "";
            RoomAccessories = new List<RoomAccessory>();
        }
    }
}
