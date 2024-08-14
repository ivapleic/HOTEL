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
    public class RoomType_SeasonalPrices
    {
        private DBConnection dbConnection;
        public int ID { get; set; }
        public int RoomTypeID { get; set; }
        public int SeasonalPeriodID { get; set; }
        public decimal Price { get; set; }

        public RoomType_SeasonalPrices()
        {
            dbConnection = new DBConnection();
        }
        public RoomType_SeasonalPrices(int id, int roomTypeID, int seasonalPeriodID, decimal price)
        {
            dbConnection = new DBConnection();
            ID = id;
            RoomTypeID = roomTypeID;
            SeasonalPeriodID = seasonalPeriodID;
            Price = price;
        }
        // Metoda za dohvaćanje ID-a prema tipovima sobe, sezonskom periodu i cijeni
        public int GetIDByDetails(int roomTypeID, int seasonalPeriodID, decimal price)
        {
            int id = -1;
            string query = "SELECT rtsp_id_pk FROM ROOM_TYPE_SEASONAL_PRICES WHERE rtsp_rt_id_fk = @rtsp_rt_id_fk AND rtsp_sp_id_fk = @rtsp_sp_id_fk AND rtsp_price = @rtsp_price";

            using (var connection = dbConnection.GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@rtsp_rt_id_fk", SqlDbType.Int) { Value = roomTypeID });
                    command.Parameters.Add(new SqlParameter("@rtsp_sp_id_fk", SqlDbType.Int) { Value = seasonalPeriodID });
                    command.Parameters.Add(new SqlParameter("@rtsp_price", SqlDbType.Decimal) { Value = price });

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }

            return id;
        }

    }
}
