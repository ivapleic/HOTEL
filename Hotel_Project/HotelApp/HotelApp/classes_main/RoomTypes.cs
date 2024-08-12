using HotelApp.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.classes_main
{
    public class RoomTypes
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfPersons { get; set; }
        public int NumberOfChildren { get; set; }

        public RoomTypes()
        {
            
        }

        public RoomTypes(int roomTypeID, string roomTypeName, int numOfPersons, int numOfChildren)
        {
            this.ID = roomTypeID;
            this.Name = roomTypeName;
            this.NumberOfPersons = numOfPersons;
            this.NumberOfChildren= numOfChildren;

        }
        private DBConnection dbConnection;


        public DataTable GetRoomTypes()
        {
            DataTable roomTypesTable = new DataTable();

            dbConnection = new DBConnection();

            SqlParameter[] parameters = new SqlParameter[0];

            roomTypesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_TYPES", parameters);

            return roomTypesTable;
        }

    }
}
