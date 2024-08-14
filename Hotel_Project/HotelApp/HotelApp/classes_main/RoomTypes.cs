using HotelApp.classes;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace HotelApp.classes_main
{
    public class RoomTypes
    {
        private DBConnection dbConnection;
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfPersons { get; set; }
        public int NumberOfChildren { get; set; }

        // Podrazumijevani konstruktor
        public RoomTypes()
        {
            dbConnection = new DBConnection(); // Inicijalizacija dbConnection
        }

        // Konstruktor s parametrima
        public RoomTypes(int roomTypeID, string roomTypeName, int numOfPersons, int numOfChildren)
        {
            dbConnection = new DBConnection(); // Inicijalizacija dbConnection
            this.ID = roomTypeID;
            this.Name = roomTypeName;
            this.NumberOfPersons = numOfPersons;
            this.NumberOfChildren = numOfChildren;
        }

        // Dohvaćanje svih tipova soba
        public DataTable GetRoomTypes()
        {
            DataTable roomTypesTable = new DataTable();
            SqlParameter[] parameters = new SqlParameter[0];

            roomTypesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_TYPES", parameters);

            return roomTypesTable;
        }

        // Dohvaćanje naziva tipa sobe prema ID-u
        public string GetRoomTypeNameByID(int roomTypeID)
        {
            string roomTypeName = null;
            string query = "SELECT rt_name FROM ROOM_TYPES WHERE rt_id_pk = @rt_id_pk";

            using (var connection = dbConnection.GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@rt_id_pk", SqlDbType.Int) { Value = roomTypeID });

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        roomTypeName = result.ToString();
                    }
                }
            }

            return roomTypeName;
        }
    }
}
