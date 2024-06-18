using HotelApp.classes_main;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HotelApp.classes
{
    internal class DBConnection
    {
        private readonly string connectionString = "Data Source=DESKTOP-4TKMESF;Initial Catalog=Hotel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);

                    return resultTable;
                }
            }
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);

                    return resultTable;
                }
            }
        }

        public Employee LoginEmployee(string username, string password)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM EMPLOYEES WHERE em_username = @Username AND em_password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username });
                    command.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password });

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Employee
                            {
                                ID = Convert.ToInt32(reader["em_id_pk"]),
                                Gender = reader["em_gender"].ToString(),
                                FirstName = reader["em_first_name"].ToString(),
                                LastName = reader["em_last_name"].ToString(),
                                OIB = reader["em_oib"].ToString(),
                                PhoneNumber = reader["em_phone"].ToString(),
                                Email = reader["em_email"].ToString(),
                                DateOfBirth = reader["em_date_of_birth"] != DBNull.Value ? Convert.ToDateTime(reader["em_date_of_birth"]) : (DateTime?)null,
                                Address = reader["em_address"].ToString(),
                                City = reader["em_city"].ToString(),
                                CountryID = Convert.ToInt32(reader["em_country_id_fk"]),
                                Work_Start = reader["em_work_start"] != DBNull.Value ? Convert.ToDateTime(reader["em_work_start"]) : (DateTime?)null,
                                Work_End = reader["em_work_end"] != DBNull.Value ? Convert.ToDateTime(reader["em_work_end"]) : (DateTime?)null,
                                Password = reader["em_password"].ToString(),
                                Username = reader["em_username"].ToString(),
                                IsAdmin = Convert.ToBoolean(reader["em_is_admin"]),
                                IsActive = Convert.ToBoolean(reader["em_is_active"]),
                                Description = reader["em_description"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
