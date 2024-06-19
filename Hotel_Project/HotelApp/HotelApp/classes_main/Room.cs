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
        public int ID_RoomType { get; set; }
        public string RoomTypeName { get; set; }
        public Floor Floor { get; set; }
        public bool Is_Active { get; set; }
        public string Description { get; set; }
        public Image Image_1 { get; set; }
        public Image Image_2 { get; set; }
        public Image Image_3 { get; set; }
        public Image Image_4 { get; set; }
        public Image Image_5 { get; set; }
        public int SortKey { get; set; }
        public List<RoomAccessory> RoomAccessories { get; set; }

        public Room()
        {
            ID = -1;
            Number = 0;
            ID_RoomType = -1;
            RoomTypeName = "";
            Floor = new Floor();
            Is_Active = true;
            Description = "";
            Image_1 = null;
            Image_2 = null;
            Image_3 = null;
            Image_4 = null;
            Image_5 = null;
            SortKey = 0;
            RoomAccessories = new List<RoomAccessory>();
        }
    }
}
