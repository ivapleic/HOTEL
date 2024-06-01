using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    internal class Room
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int ID_RoomType { get; set; }
        public string RoomTypeName { get; set; }
        public int ID_Floor { get; set; }
        public int Floor_Number { get; set; }
        public bool Is_Active { get; set; }
        public string Description { get; set; }
        public Image Image_1 { get; set; }
        public Image Image_2 { get; set; }
        public Image Image_3 { get; set; }
        public Image Image_4 { get; set; }
        public Image Image_5 { get; set; }
        public int SortKey { get; set; }
        public DataTable RoomAccesories_DTable { get; set; }
        public DataView RoomAccesories_DView { get; set; }

        public Room()
        {
            try
            {
                ID = -1;
                Number = 0;
                ID_RoomType = -1;
                RoomTypeName = "";
                ID_Floor = -1;
                Floor_Number = -1;
                Is_Active = true;
                Description = "";
                Image_1 = null;
                Image_2 = null;
                Image_3 = null;
                Image_4 = null;
                Image_5 = null;
                SortKey = 0;
                RoomAccesories_DTable = CreateRoomAccesories_Empty();
                RoomAccesories_DView = RoomAccesories_DTable.DefaultView;
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }
        public DataTable CreateRoomAccesories_Empty()
        {
            try
            {
                DataTable newTable = new DataTable();
                newTable.TableName = "RoomAccesories";
                newTable.Columns.Add("ar_id_pk", typeof(int));
                newTable.Columns.Add("ar_rm_id_fk", typeof(int));
                newTable.Columns.Add("ar_ac_id_fk", typeof(int));
                newTable.Columns.Add("ac_name", typeof(string));
                return newTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Update_RoomID_To_RoomAccesoriesDView()
        {
            try
            {
                int cntr = RoomAccesories_DView.Count;
                for (int i = 0; i < cntr; i++)
                {
                    RoomAccesories_DView[i]["ar_rm_id_fk"] = ID;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
        }



    }
}
