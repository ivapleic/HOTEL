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
    public partial class GuestReservation_DetailsForm : Form
    {
        Reservation_Guest reservation_guest;
        public GuestReservation_DetailsForm(Reservation_Guest guest_res)
        {
            InitializeComponent();
            this.reservation_guest = guest_res;
            Guest guest = new Guest();
            label_date_start.Text = guest_res.DateStart.ToString();
            label_date_end.Text = guest_res.DateEnd.ToString();
            Guest selectedGuest = guest.GetGuestById(guest_res.GuestID);
            labelFirstName.Text = selectedGuest.FirstName.ToString();
            labelLastName.Text = selectedGuest.LastName.ToString();
            label_add_person.Text = guest_res.IsAdditionalPerson ? "Yes" : "No";
        }

        private void btn_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guest_details_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            Guest selectedGuest = guest.GetGuestById(reservation_guest.GuestID);
            Guest_DetailsForm guestDetailForm = new Guest_DetailsForm(selectedGuest);
            guestDetailForm.Show();
        }
    }
}
