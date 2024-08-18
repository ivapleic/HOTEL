using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.forms;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class Guests_UpdateForm : Form
    {
        public Guest selectedGuest;
        private DBConnection dbConnection;

        public Guests_UpdateForm(Guest guest)
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            this.selectedGuest = guest;
            LoadGuestData(selectedGuest);
            PopulateGenders(selectedGuest); // Popunjavanje combobox-a za spol
            PopulateCountries(selectedGuest); // Popunjavanje combobox-a za države
            PopulateIdentifications(selectedGuest); // Popunjavanje combobox-a za identifikaciju
            PopulateStateOfBirth(selectedGuest); // Popunjavanje combobox-a za državu rođenja
        }

        private void LoadGuestData(Guest guest)
        {
            try
            {
                // Provjera i popunjavanje kontrola podacima gosta

                textBox_first_name.Text = guest.FirstName ?? string.Empty;
                textBox_last_name.Text = guest.LastName ?? string.Empty;
                comboBox_gender.SelectedValue = string.IsNullOrEmpty(guest.Gender) ? null : guest.Gender;
                textBox_oib.Text = guest.OIB ?? string.Empty;
                textBox_address.Text = guest.Address ?? string.Empty;
                textBox_city.Text = guest.City ?? string.Empty;

                // Ako je CountryName null ili prazno, postavi na null ili prazan string
                comboBox_country.SelectedItem = string.IsNullOrEmpty(guest.CountryName) ? null : guest.CountryName;

                textBox_phone.Text = guest.Phone ?? string.Empty;
                textBox_mobile.Text = guest.Mobile ?? string.Empty;

                // Ako je IdentificationID veći od 0, postavi ga, inače postavi na neodabrano
                comboBox_id.SelectedValue = guest.IdentificationID > 0 ? guest.IdentificationID : null;

                textBox_id_text.Text = guest.IdentificationText ?? string.Empty;

                // Ako je BirthDate validan datum, postavi ga, inače postavi na trenutni datum
                dateTimePicker_date_birth.Value = guest.BirthDate != default(DateTime) ? guest.BirthDate : DateTime.Now;

                textBox_birth_place.Text = guest.BirthPlace ?? string.Empty;

                // Ako je BirthStateID veći od 0, postavi ga, inače postavi na neodabranog
                comboBox_state_birth.SelectedValue = guest.BirthStateID > 0 ? (object)guest.BirthStateID : null;

                textBox_nationality.Text = guest.Nationality ?? string.Empty;
                textBox_email.Text = guest.Email ?? string.Empty;
                textBox_description.Text = guest.Description ?? string.Empty;

                // IsActive se pretpostavlja da je bool i nikad ne može biti null
                checkBox_active.Checked = guest.IsActive;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void PopulateGenders(Guest guest)
        {
            comboBox_gender.Items.AddRange(new string[] { "Muško", "Žensko" });
        }

        private void PopulateCountries(Guest guest)
        {
            try
            {
                DataTable countriesTable = dbConnection.ExecuteStoredProcedure("Get_COUNTRIES", new SqlParameter[] { });

                comboBox_country.DisplayMember = "cy_name_en";
                comboBox_country.ValueMember = "cy_id_pk";

                comboBox_country.DataSource = countriesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateIdentifications(Guest guest)
        {
            try
            {
                DataTable identificationsTable = dbConnection.ExecuteStoredProcedure("Get_IDENTIFICATIONS", new SqlParameter[] { });

                comboBox_id.DisplayMember = "id_name";
                comboBox_id.ValueMember = "id_id_pk";

                comboBox_id.DataSource = identificationsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateStateOfBirth(Guest guest)
        {
            try
            {
                DataTable countriesTable = dbConnection.ExecuteStoredProcedure("Get_COUNTRIES", new SqlParameter[] { });

                comboBox_state_birth.DisplayMember = "cy_name_en";
                comboBox_state_birth.ValueMember = "cy_id_pk";

                comboBox_state_birth.DataSource = countriesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                // Prikupljanje podataka iz kontrola
                string firstName = textBox_first_name.Text;
                string lastName = textBox_last_name.Text;
                string gender = comboBox_gender.SelectedItem?.ToString() ?? "";
                string oib = textBox_oib.Text;
                string address = textBox_address.Text;
                string city = textBox_city.Text;
                int countryID = Convert.ToInt32(comboBox_country.SelectedValue);
                string phone = textBox_phone.Text;
                string mobile = textBox_mobile.Text;
                int identificationID = Convert.ToInt32(comboBox_id.SelectedValue);
                string idText = textBox_id_text.Text;
                DateTime birthDate = dateTimePicker_date_birth.Value;
                string birthPlace = textBox_birth_place.Text;
                int birthCountryID = Convert.ToInt32(comboBox_state_birth.SelectedValue);
                string nationality = textBox_nationality.Text;
                string email = textBox_email.Text;
                string description = textBox_description.Text;
                bool isActive = checkBox_active.Checked;

                // Priprema SQL parametara za pohranjenu proceduru
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@gu_id_pk",selectedGuest.ID),
                    new SqlParameter("@gu_co_id_fk", countryID),
                    new SqlParameter("@gu_id_id_fk", identificationID),
                    new SqlParameter("@gu_id_text", idText),
                    new SqlParameter("@gu_gender", gender),
                    new SqlParameter("@gu_first_name", firstName),
                    new SqlParameter("@gu_last_name", lastName),
                    new SqlParameter("@gu_oib", oib),
                    new SqlParameter("@gu_address", address),
                    new SqlParameter("@gu_city", city),
                    new SqlParameter("@gu_phone", phone),
                    new SqlParameter("@gu_mobile", mobile),
                    new SqlParameter("@gu_email", email),
                    new SqlParameter("@gu_birth_date", birthDate),
                    new SqlParameter("@gu_birth_place", birthPlace),
                    new SqlParameter("@gu_birth_state_id_fk", birthCountryID),
                    new SqlParameter("@gu_nationality", nationality),
                    new SqlParameter("@gu_description", description),
                    new SqlParameter("@gu_is_active", isActive)
                };

                dbConnection.ExecuteStoredProcedure("Update_GUEST", parameters);

                MessageBox.Show("Guest updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating guest: " + ex.Message);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guests_UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form_Guests"] is Form_Guests guestsForm)
            {
                guestsForm.RefreshGuestList();
            }
        }
    }
}
