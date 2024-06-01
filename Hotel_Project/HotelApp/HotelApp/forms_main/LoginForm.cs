using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using HotelApp.forms_main;
using System.Data;

namespace HotelApp
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-4TKMESF;Initial Catalog=Hotel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool AuthenticateUser(string username, string password, out bool isAdmin)
        {
            isAdmin = false;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false; // ovdje stavit neku custom exception da je prazno polje 
            }

            string checkUserQuery = "SELECT em_password, em_is_admin FROM EMPLOYEES WHERE em_username=@Username";

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
                        isAdmin = Convert.ToBoolean(reader["em_is_admin"]);

                        if (storedPassword == password)
                        {
                            return true;
                        }
                    }
                }
                return false;
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
                bool isAdmin;  // prenosi se kao referenca u funkciju isAuthenticated
                bool isAuthenticated = AuthenticateUser(username, password, out isAdmin);

                if (isAuthenticated)
                {
                    if (isAdmin)
                    {
                        MessageBox.Show("Uspjesna prijava kao admin.");
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uspjesna prijava kao zaposlenik.");
                        UserForm userForm = new UserForm();
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
