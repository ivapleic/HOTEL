using HotelApp.classes_main;
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
    public partial class ReservationServicesDetails_AddNewForm : Form
    {
        AdditionalServices selectedService;
        public ReservationServicesDetails_AddNewForm(AdditionalServices service)
        {
            InitializeComponent();
            this.selectedService=service;
            label_service_name.Text=service.Name.ToString();
            label_service_price.Text = service.Price.ToString();

        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            try
            {
                int serviceID = selectedService.ID;
                DateTime resDate = dateTimePicker_res_date.Value;
                DateTime conDate = dateTimePicker_con_date.Value;
                int amount = Convert.ToInt32(textBox_amount.Text);

             

                // Kreiraj objekt Reservation_Guest s prikupljenim podacima
                Reservation_Service newReservationService = new Reservation_Service
                {
                    ReservationID = 0, // Ovdje možete postaviti ID rezervacije ako ga imate, ili ga kasnije postaviti kada se kreira rezervacija
                    ServiceID = selectedService.ID,
                    DateReservation= resDate,
                    DateConsumption = conDate,
                    Quantity=amount
                };

                // Proslijedi objekt Reservation_Guest u već otvorenu formu za dodavanje rezervacija
                Reservation_AddNew_Form reservationForm = (Reservation_AddNew_Form)Application.OpenForms["Reservation_AddNew_Form"];
                if (reservationForm != null)
                {
                    reservationForm.reservationService = newReservationService;  // Kopiraj objekt u polje reservationGuest
                    reservationForm.AddServiceToReservation(newReservationService); // Osvježi DataTable u reservationForm
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
