using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using HotelApp.forms_main;
using System.Data;
using HotelApp.classes_main;

namespace HotelApp
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-4TKMESF;Initial Catalog=Hotel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private Employee AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null; // Ovdje staviti neku custom exception da je prazno polje 
            }

            string checkUserQuery = "SELECT * FROM EMPLOYEES WHERE em_username=@Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(checkUserQuery, connection);
                command.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username });

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader["em_password"].ToString();

                        if (storedPassword == password)
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
                                Password = storedPassword,
                                Username= username,
                                IsAdmin = Convert.ToBoolean(reader["em_is_admin"]),
                                IsActive = Convert.ToBoolean(reader["em_is_active"]),
                                Description = reader["em_description"].ToString()
                            };
                        }
                    }
                }
                return null;
            }
        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string password = pswdTextBox.Text;
            string username = usernameTextBox.Text;

            try
            {
                Employee employee = AuthenticateUser(username, password);

                if (employee != null)
                {
                    if (employee.IsAdmin)
                    {
                        MessageBox.Show("Uspjesna prijava kao admin.");
                        AdminForm adminForm = new AdminForm(employee);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uspjesna prijava kao zaposlenik.");
                        UserForm userForm = new UserForm(employee);
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Prijava nije uspješna. Provjerite korisnicko ime i lozinku.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri prijavi: " + ex.Message);
            }
        }

    }
}
