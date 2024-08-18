using System;
using System.Data;
using HotelApp.classes;
using Microsoft.Data.SqlClient;

namespace HotelApp.classes_main
{
    public class Guest
    {
        private DBConnection dbConnection;
        public int ID { get; set; }
        public int CountryID { get; set; }
        public int IdentificationID { get; set; }
        public string IdentificationText { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OIB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public int BirthStateID { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        // Polja za dodatne informacije
        public string CountryName { get; set; }
        public string IdentificationName { get; set; }
        public string BirthStateName { get; set; }

        public Guest(int id, int countryId, int identificationId, string identificationText,string gender, string firstName,
                     string lastName, string oib, string address, string city, string phone,
                     string mobile, string email, DateTime birthDate, string birthPlace,
                     int birthStateId, string nationality, string description, bool isActive,
                     string countryName, string identificationName, string birthStateName)
        {
            dbConnection = new DBConnection();
            ID = id;
            CountryID = countryId;
            IdentificationID = identificationId;
            IdentificationText = identificationText;
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            OIB = oib;
            Address = address;
            City = city;
            Phone = phone;
            Mobile = mobile;
            Email = email;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            BirthStateID = birthStateId;
            Nationality = nationality;
            Description = description;
            IsActive = isActive;
            CountryName = countryName;
            IdentificationName = identificationName;
            BirthStateName = birthStateName;
        }

        public Guest() { }

        public Guest GetGuestById(int guestID)
        {
            try
            {
                dbConnection = new DBConnection();
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@gu_id_pk", guestID)
                };

                DataTable guestData = dbConnection.ExecuteStoredProcedure("Get_GUEST_BY_ID", parameters);

                if (guestData.Rows.Count > 0)
                {
                    DataRow row = guestData.Rows[0];

                    // Pomoćne metode za dohvaćanje dodatnih informacija
                    string GetStringValue(object value) => value == DBNull.Value ? string.Empty : value.ToString();
                    int GetIntValue(object value) => value == DBNull.Value ? 0 : Convert.ToInt32(value);
                    DateTime GetDateTimeValue(object value) => value == DBNull.Value ? default(DateTime) : Convert.ToDateTime(value);
                    bool GetBooleanValue(object value) => value == DBNull.Value ? false : Convert.ToBoolean(value);

                    return new Guest
                    {
                        ID = GetIntValue(row["gu_id_pk"]),
                        CountryID = GetIntValue(row["gu_co_id_fk"]),
                        IdentificationID = GetIntValue(row["gu_id_text"]),
                        Gender = GetStringValue(row["gu_gender"]),
                        FirstName = GetStringValue(row["gu_first_name"]),
                        LastName = GetStringValue(row["gu_last_name"]),
                        OIB = GetStringValue(row["gu_oib"]),
                        Address = GetStringValue(row["gu_address"]),
                        City = GetStringValue(row["gu_city"]),
                        Phone = GetStringValue(row["gu_phone"]),
                        Mobile = GetStringValue(row["gu_mobile"]),
                        Email = GetStringValue(row["gu_email"]),
                        BirthDate = GetDateTimeValue(row["gu_birth_date"]),
                        BirthPlace = GetStringValue(row["gu_birth_place"]),
                        BirthStateID = GetIntValue(row["gu_birth_state_id_fk"]),
                        Nationality = GetStringValue(row["gu_nationality"]),
                        Description = GetStringValue(row["gu_description"]),
                        IsActive = GetBooleanValue(row["gu_is_active"]),
                        CountryName = GetCountryName(GetIntValue(row["gu_co_id_fk"]), dbConnection),
                        IdentificationName = GetIdentificationName(GetIntValue(row["gu_id_id_fk"]), dbConnection),
                        BirthStateName = GetCountryName(GetIntValue(row["gu_birth_state_id_fk"]), dbConnection) 
                    };
                }
                else
                {
                    throw new Exception("Guest not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading guest data: " + ex.Message);
            }
        }


        private static string GetCountryName(int countryId, DBConnection dbConnection)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@cy_id_pk", countryId)
                };

                DataTable data = dbConnection.ExecuteStoredProcedure("Get_COUNTRY_BY_ID", parameters);
                if (data.Rows.Count > 0)
                {
                    return data.Rows[0]["cy_name_en"].ToString();
                }
                else
                {
                    return "Unknown";
                }
            }
            catch
            {
                return "Unknown";
            }
        }

        private static string GetIdentificationName(int id, DBConnection dbConnection)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@id_id_pk", id)
                };

                DataTable data = dbConnection.ExecuteStoredProcedure("Get_IDENTIFICATION_BY_ID", parameters);
                if (data.Rows.Count > 0)
                {
                    return data.Rows[0]["id_name"].ToString();
                }
                else
                {
                    return "Unknown";
                }
            }
            catch
            {
                return "Unknown";
            }
        }

        private static string GetBirthStateName(int stateId, DBConnection dbConnection)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@cy_id_pk", stateId)
                };

                DataTable data = dbConnection.ExecuteStoredProcedure("Get_COUNTRY_BY_ID", parameters);
                if (data.Rows.Count > 0)
                {
                    return data.Rows[0]["cy_name_en"].ToString();
                }
                else
                {
                    return "Unknown";
                }
            }
            catch
            {
                return "Unknown";
            }
        }
    }
}
