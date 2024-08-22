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
    public partial class GuestReservation_UpdateForm : Form
    {
        public Reservation_Guest SelectedRes_Guest { get; private set; }
        public GuestReservation_UpdateForm(Reservation_Guest resGuest)
        {
            InitializeComponent();
            Guest guest = new Guest();
            Guest selectedGuest = guest.GetGuestById(resGuest.GuestID);
            this.SelectedRes_Guest = resGuest;
            labelFirstName.Text = selectedGuest.FirstName.ToString();
            labelLastName.Text = selectedGuest.LastName.ToString();
            dateTimePicker_start.Value = resGuest.DateStart;
            dateTimePicker_end.Value = resGuest.DateEnd;
            checkBox_add_person.Checked = resGuest.IsAdditionalPerson ? true : false;

        }

        private void btn_update_res_guest_Click(object sender, EventArgs e)
        {
            SelectedRes_Guest.DateStart = dateTimePicker_start.Value;
            SelectedRes_Guest.DateEnd = dateTimePicker_end.Value;
            SelectedRes_Guest.IsAdditionalPerson=checkBox_add_person.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
