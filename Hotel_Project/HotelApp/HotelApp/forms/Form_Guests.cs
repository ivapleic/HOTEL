using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.user_controls;
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

namespace HotelApp.forms
{
    public partial class Form_Guests : Form
    {
        private DBConnection dbConnection;
        public Guest selectedGuest;
        public Form_Guests()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            selectedGuest = new Guest();
            DisplayGuests();
            dataGridViewGuests.ClearSelection();
        }

        public void RefreshGuestList()
        {
            try
            {
                DisplayGuests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing guest list: {ex.Message}");
            }
        }
        private void DisplayGuests()
        {
            try
            {
                DataTable guestsTable = dbConnection.ExecuteStoredProcedure("Get_GUESTS", new SqlParameter[0]);

                dataGridViewGuests.Rows.Clear();

                foreach (DataRow row in guestsTable.Rows)
                {
                    int id = Convert.ToInt32(row["gu_id_pk"]);
                    string idText = row["gu_id_text"] != DBNull.Value ? Convert.ToString(row["gu_id_text"]) : "";
                    string firstName = row["gu_first_name"] != DBNull.Value ? Convert.ToString(row["gu_first_name"]) : "";
                    string lastName = row["gu_last_name"] != DBNull.Value ? Convert.ToString(row["gu_last_name"]) : "";
                    string oib = row["gu_oib"] != DBNull.Value ? Convert.ToString(row["gu_oib"]) : "";
                    string gender = row["gu_gender"] != DBNull.Value ? Convert.ToString(row["gu_gender"]) : "";
                    string address = row["gu_address"] != DBNull.Value ? Convert.ToString(row["gu_address"]) : "";
                    string city = row["gu_city"] != DBNull.Value ? Convert.ToString(row["gu_city"]) : "";

                    // Koristimo engleski naziv zemlje
                    string country = row["cy_name_en_residence"] != DBNull.Value ? Convert.ToString(row["cy_name_en_residence"]) : "";

                    string phone = row["gu_phone"] != DBNull.Value ? Convert.ToString(row["gu_phone"]) : "";
                    string mobile = row["gu_mobile"] != DBNull.Value ? Convert.ToString(row["gu_mobile"]) : "";
                    string email = row["gu_email"] != DBNull.Value ? Convert.ToString(row["gu_email"]) : "";
                    DateTime birthDate = row["gu_birth_date"] != DBNull.Value ? Convert.ToDateTime(row["gu_birth_date"]) : DateTime.MinValue;
                    string birthPlace = row["gu_birth_place"] != DBNull.Value ? Convert.ToString(row["gu_birth_place"]) : "";

                    // Koristimo engleski naziv države rođenja
                    string birthState = row["cy_name_en_birth"] != DBNull.Value ? Convert.ToString(row["cy_name_en_birth"]) : "";

                    string nationality = row["gu_nationality"] != DBNull.Value ? Convert.ToString(row["gu_nationality"]) : "";
                    string description = row["gu_description"] != DBNull.Value ? Convert.ToString(row["gu_description"]) : "";
                    string idName = row["id_name"] != DBNull.Value ? Convert.ToString(row["id_name"]) : "";
                    bool isActive = row["gu_is_active"] != DBNull.Value && Convert.ToBoolean(row["gu_is_active"]);

                    if (isActive)
                    {
                        int rowIndex = dataGridViewGuests.Rows.Add(id, lastName, firstName, gender, address, city, country);
                    }
                }


                lbl_number_of_guests.Text = $"{dataGridViewGuests.Rows.Count}";
                dataGridViewGuests.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying guests: {ex.Message}");
            }
        }

        private void btn_delete_guest_Click(object sender, EventArgs e)
        {

            try
            {
                // Provjera je li neki redak odabran
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    // Dohvat ID-a odabranog gosta
                    int guestID = Convert.ToInt32(dataGridViewGuests.SelectedRows[0].Cells["GuestID"].Value);

                    // Priprema SQL upita za ažuriranje is_active na false
                    string query = "UPDATE GUESTS SET gu_is_active = 0 WHERE gu_id_pk = @GuestID";

                    // Priprema SQL parametara
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                            new SqlParameter("@GuestID", guestID)
                    };

                    // Izvršavanje SQL upita
                    dbConnection.ExecuteQuery(query, parameters);

                    // Osvježavanje popisa gostiju
                    RefreshGuestList();

                    MessageBox.Show("Guest marked as inactive successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a guest to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in deleting guest: " + ex.Message);
            }


        }

        private void btn_add_new_guest_Click(object sender, EventArgs e)
        {
            Guests_AddNewForm addNewFloorForm = new Guests_AddNewForm();
            addNewFloorForm.Show();
        }

        private void btn_update_guest_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjera je li neki redak odabran
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    // Dohvat ID-a odabranog gosta
                    int GuestID = Convert.ToInt32(dataGridViewGuests.SelectedRows[0].Cells["GuestID"].Value);

                    Guest guest = new Guest();
                    Guest selectedGuest = guest.GetGuestById(GuestID);

                    // Otvori formu za ažuriranje i proslijedi ID gosta
                    Guests_UpdateForm updateForm = new Guests_UpdateForm(selectedGuest);
                    updateForm.ShowDialog();

                    // Osvježi popis gostiju nakon ažuriranja
                    RefreshGuestList();
                }
                else
                {
                    MessageBox.Show("Please select a guest to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    int guestID = Convert.ToInt32(dataGridViewGuests.SelectedRows[0].Cells["GuestID"].Value);
                    Guest selectedGuest = new Guest().GetGuestById(guestID);

                    GuestReservation_AddNewForm addNewForm = new GuestReservation_AddNewForm(selectedGuest);
                    addNewForm.ShowDialog(); // Koristite ShowDialog za modalno prikazivanje forme

                    // Zatvori trenutnu formu (ako je potrebno)
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select a guest to add.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in selecting guest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_details_guest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    int GuestID = Convert.ToInt32(dataGridViewGuests.SelectedRows[0].Cells["GuestID"].Value);

                    Guest guest = new Guest();
                    Guest selectedGuest = guest.GetGuestById(GuestID);

                    Guest_DetailsForm updateForm = new Guest_DetailsForm(selectedGuest);
                    updateForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Please select a guest to viwe details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in guest details: " + ex.Message);
            }
        }
    }
}
