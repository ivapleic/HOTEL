using HotelApp.classes;
using HotelApp.forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class Guests_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public Guests_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            PopulateGenders();
            PopulateCountries();
            PopulateIdentifications();
            PopulateStateOfBirth();
        }
        private void PopulateGenders()
        {
            comboBox_gender.Items.AddRange(new string[] { "Muško", "Žensko" });
            comboBox_gender.SelectedIndex = -1;
        }

        private void PopulateCountries()
        {
            try
            {
                DataTable countriesTable = dbConnection.ExecuteStoredProcedure("Get_COUNTRIES", new SqlParameter[] { });

                comboBox_country.DisplayMember = "cy_name_en";
                comboBox_country.ValueMember = "cy_id_pk";

                comboBox_country.DataSource = countriesTable;
                comboBox_country.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateIdentifications()
        {
            try
            {
                DataTable identificationsTable = dbConnection.ExecuteStoredProcedure("Get_IDENTIFICATIONS", new SqlParameter[] { });

                comboBox_id.DisplayMember = "id_name";  // Naziv koji će biti prikazan korisniku
                comboBox_id.ValueMember = "id_id_pk";   // Stvarna vrijednost koju ćemo koristiti

                comboBox_id.DataSource = identificationsTable;
                comboBox_id.SelectedIndex = -1;  // Postavlja neodabrano stanje
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateStateOfBirth()
        {
            try
            {
                DataTable countriesTable = dbConnection.ExecuteStoredProcedure("Get_COUNTRIES", new SqlParameter[] { });

                comboBox_state_birth.DisplayMember = "cy_name_en";  // Naziv koji će biti prikazan korisniku
                comboBox_state_birth.ValueMember = "cy_id_pk";      // Stvarna vrijednost koju ćemo koristiti

                comboBox_state_birth.DataSource = countriesTable;
                comboBox_state_birth.SelectedIndex = -1;  // Postavlja neodabrano stanje
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = textBox_first_name.Text;
                string lastName = textBox_last_name.Text;
                string gender = comboBox_gender.SelectedItem != null ? comboBox_gender.SelectedItem.ToString() : "";
                string oib = textBox_oib.Text;
                string address = textBox_address.Text;
                string city = textBox_city.Text;

                // Sigurno dobivanje i konverzija Country ID
                int countryID;
                if (!int.TryParse(comboBox_country.SelectedValue?.ToString(), out countryID))
                {
                    MessageBox.Show($"Invalid Country ID value: {comboBox_country.SelectedValue}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    countryID = 0;  // Postavite zadanu vrijednost ako konverzija ne uspije
                }

                string phone = textBox_phone.Text;
                string mobile = textBox_mobile.Text;

                // Sigurno dobivanje i konverzija Identification ID
                int identificationID;
                if (!int.TryParse(comboBox_id.SelectedValue?.ToString(), out identificationID))
                {
                    MessageBox.Show($"Invalid Identification ID value: {comboBox_id.SelectedValue}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    identificationID = 0;  // Postavite zadanu vrijednost ako konverzija ne uspije
                }

                string idText = textBox_id_text.Text;
                DateTime birthDate = dateTimePicker_date_birth.Value;

                // Sigurno dobivanje i konverzija Birth Country ID
                int birthCountryID;
                if (!int.TryParse(comboBox_state_birth.SelectedValue?.ToString(), out birthCountryID))
                {
                    MessageBox.Show($"Invalid Birth Country ID value: {comboBox_state_birth.SelectedValue}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    birthCountryID = 0;  // Postavite zadanu vrijednost ako konverzija ne uspije
                }

                string birthPlace = textBox_birth_place.Text;
                string nationality = textBox_nationality.Text;
                string email = textBox_email.Text;
                string description = textBox_description.Text;
                bool isActive = checkBox_active.Checked;

                // Provjera obaveznih polja
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || countryID == 0)
                {
                    MessageBox.Show("Please fill in the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Priprema SQL parametara
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@gu_co_id_fk", countryID),
            new SqlParameter("@gu_id_id_fk", identificationID > 0 ? (object)identificationID : DBNull.Value),
            new SqlParameter("@gu_id_text", string.IsNullOrEmpty(idText) ? (object)DBNull.Value : idText),
            new SqlParameter("@gu_gender", string.IsNullOrEmpty(gender) ? (object)DBNull.Value : gender),
            new SqlParameter("@gu_first_name", firstName),
            new SqlParameter("@gu_last_name", lastName),
            new SqlParameter("@gu_oib", string.IsNullOrEmpty(oib) ? (object)DBNull.Value : oib),
            new SqlParameter("@gu_address", string.IsNullOrEmpty(address) ? (object)DBNull.Value : address),
            new SqlParameter("@gu_city", string.IsNullOrEmpty(city) ? (object)DBNull.Value : city),
            new SqlParameter("@gu_phone", string.IsNullOrEmpty(phone) ? (object)DBNull.Value : phone),
            new SqlParameter("@gu_mobile", string.IsNullOrEmpty(mobile) ? (object)DBNull.Value : mobile),
            new SqlParameter("@gu_email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email),
            new SqlParameter("@gu_birth_date", birthDate),
            new SqlParameter("@gu_birth_place", string.IsNullOrEmpty(birthPlace) ? (object)DBNull.Value : birthPlace),
            new SqlParameter("@gu_birth_state_id_fk", birthCountryID > 0 ? (object)birthCountryID : DBNull.Value),
            new SqlParameter("@gu_nationality", string.IsNullOrEmpty(nationality) ? (object)DBNull.Value : nationality),
            new SqlParameter("@gu_description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description),
            new SqlParameter("@gu_is_active", isActive)

                };

                // Pozivanje pohranjene procedure
                object result = dbConnection.ExecuteStoredProcedure("Insert_GUEST", parameters);

           
                this.Close();
            }
            catch (Exception ex)
            {
                // Prikaz dodatnih informacija o grešci
                MessageBox.Show($"Error in inserting new guest:\nMessage: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guests_AddNewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form_Guests"] is Form_Guests guestsForm)
            {
                guestsForm.RefreshGuestList();
            }
        }
    }
}
