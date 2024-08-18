using HotelApp.classes_main;
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
    public partial class GuestReservation_AddNewForm : Form
    {
        private Guest SelectedGuest;
        public GuestReservation_AddNewForm(Guest guest)
        {
            InitializeComponent();
            SelectedGuest = guest;
            LoadGuestDetails();
        }

        private void LoadGuestDetails()
        {
            if (SelectedGuest != null)
            {
                labelFirstName.Text = SelectedGuest.FirstName ?? string.Empty;
                labelLastName.Text = SelectedGuest.LastName ?? string.Empty;
            }
        }

        private void btn_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_res_guest_Click(object sender, EventArgs e)
        {
            try
            {
                // Prikupi podatke iz forme
                int guestID = SelectedGuest.ID; // Ovo bi trebalo biti ID gosta koji je proslijeđen u konstruktoru forme
                DateTime startDate = dateTimePicker_start.Value;
                DateTime endDate = dateTimePicker_end.Value;
                bool isAdditionalPerson = checkBox_add_person.Checked;

                // Provjera validnosti podataka
                if (startDate >= endDate)
                {
                    MessageBox.Show("End date must be later than start date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kreiraj objekt Reservation_Guest s prikupljenim podacima
                Reservation_Guest newReservationGuest = new Reservation_Guest
                {
                    ReservationID = 0, // Ovdje možete postaviti ID rezervacije ako ga imate, ili ga kasnije postaviti kada se kreira rezervacija
                    GuestID = guestID,
                    DateStart = startDate,
                    DateEnd = endDate,
                    IsAdditionalPerson = isAdditionalPerson
                };

                // Proslijedi objekt Reservation_Guest u već otvorenu formu za dodavanje rezervacija
                Reservation_AddNew_Form reservationForm = (Reservation_AddNew_Form)Application.OpenForms["Reservation_AddNew_Form"];
                if (reservationForm != null)
                {
                    reservationForm.reservationGuest = newReservationGuest;  // Kopiraj objekt u polje reservationGuest
                    reservationForm.AddGuestToReservation(newReservationGuest); // Osvježi DataTable u reservationForm
                    reservationForm.BringToFront(); // Fokusira postojeću formu
                }

                // Zatvori trenutnu formu
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in adding reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
