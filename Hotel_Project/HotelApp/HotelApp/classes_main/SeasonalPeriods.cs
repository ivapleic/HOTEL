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
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SeasonalPeriods()
        {

        }

        public SeasonalPeriods(int id, string name, DateTime startDate, DateTime endDate)
        {
            ID = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
        }
        private DBConnection dbConnection;

        public DataTable GetSeasonalPeriods()
        {
            DataTable seasonsTable = new DataTable();

            dbConnection = new DBConnection();

            seasonsTable = dbConnection.ExecuteStoredProcedure("GET_SEASONAL_PERIODS", new SqlParameter[0]);

            return seasonsTable;
        }


    }
}
