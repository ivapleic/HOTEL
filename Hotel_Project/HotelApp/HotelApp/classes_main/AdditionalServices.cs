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
    public class AdditionalServices
    {
        private DBConnection dbConnection;
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public AdditionalServices GetServiceById(int serviceID)
        {
            try
            {
                dbConnection = new DBConnection();
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@as_id_pk", serviceID)
                };

                DataTable serviceData = dbConnection.ExecuteStoredProcedure("Get_ADD_SERVICES_BY_ID", parameters);

                if (serviceData.Rows.Count > 0)
                {
                    DataRow row = serviceData.Rows[0];
                    string GetStringValue(object value) => value == DBNull.Value ? string.Empty : value.ToString();
                    decimal GetDecimalValue(object value) => value == DBNull.Value ? 0 : Convert.ToDecimal(value);
                    int GetIntValue(object value) => value == DBNull.Value ? 0 : Convert.ToInt32(value);
                    return new AdditionalServices
                    {
                        ID = GetIntValue(row["as_id_pk"]),
                        Name = GetStringValue(row["as_name"]),
                        Price = GetDecimalValue(row["as_price"]),
                        Description = GetStringValue(row["as_description"])
                      
                    };
                }
                else
                {
                    throw new Exception("Service not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading service data: " + ex.Message);
            }
        }

    }
}
