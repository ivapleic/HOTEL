using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using HotelApp.forms_main;
using HotelApp.classes;
using HotelApp.classes_main;

namespace HotelApp
{
    public partial class LoginForm : Form
    {
        private readonly DBConnection dbConnection = new DBConnection();

        public LoginForm()
        {
            InitializeComponent();
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
                Employee employee = dbConnection.LoginEmployee(username, password);

                if (employee != null)
                {
                    if (employee.IsAdmin)
                    {
                        MessageBox.Show("Uspješna prijava kao admin.");
                        AdminForm adminForm = new AdminForm(employee);
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Uspješna prijava kao zaposlenik.");
                        UserForm userForm = new UserForm(employee);
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Prijava nije uspješna. Provjerite korisničko ime i lozinku.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri prijavi: " + ex.Message);
            }
        }
    }
}
