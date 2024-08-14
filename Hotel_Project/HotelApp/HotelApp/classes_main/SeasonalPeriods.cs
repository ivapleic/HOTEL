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
    public class SeasonalPeriods
    {
        private DBConnection dbConnection;
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SeasonalPeriods()
        {
            dbConnection = new DBConnection();
        }

        public SeasonalPeriods(int id, string name, DateTime startDate, DateTime endDate)
        {
            dbConnection = new DBConnection();
            ID = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }

        public DataTable GetSeasonalPeriods()
        {
            DataTable seasonsTable = new DataTable();

            seasonsTable = dbConnection.ExecuteStoredProcedure("GET_SEASONAL_PERIODS", new SqlParameter[0]);

            return seasonsTable;
        }

        public int GetSeasonalPeriodIDByName(string name)
        {
            int id = -1;
            // Provjerite je li name valjan i odgovara li nazivima sezonskih perioda u vašoj bazi podataka
            string query = "SELECT sp_id_pk FROM SEASONAL_PERIODS WHERE sp_name = @sp_name";

            using (var connection = dbConnection.GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    // Ispravite ovdje: koristite 'name' umjesto 'columnName'
                    command.Parameters.Add(new SqlParameter("@sp_name", SqlDbType.NVarChar) { Value = name });

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


        public string GetSeasonalPeriodNameByID(int id)
        {
            string name = null;

            // SQL upit za dohvaćanje imena sezonskog perioda prema ID-u
            string query = "SELECT sp_name FROM SEASONAL_PERIODS WHERE sp_id_pk = @sp_id_pk";

            using (var connection = dbConnection.GetConnection())
            {
                using (var command = new SqlCommand(query, connection))
                {
                    // Ispravite ovdje: koristite 'name' umjesto 'columnName'
                    command.Parameters.Add(new SqlParameter("@sp_id_pk", SqlDbType.Int) { Value = id });

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        name = Convert.ToString(result);
                    }
                }
            }

            return name;
        }






    }
}
