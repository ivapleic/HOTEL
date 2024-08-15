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
    public partial class Reservations_DetailsForm : Form
    {
        Reservation selectedReservation;
        public Reservations_DetailsForm(Reservation SelectedReservation)
        {
            InitializeComponent();
            this.selectedReservation = SelectedReservation;
            label_res_number.Text = SelectedReservation.Number.ToString();
            label_reservation_date.Text = SelectedReservation.ReservationDate.ToString();
            label_employee_name.Text=SelectedReservation.EmployeeName.ToString();
            label_start_date.Text = SelectedReservation.StartDate.ToString();
            label_end_date.Text = SelectedReservation.EndDate.ToString();
            label_check_in_date.Text = SelectedReservation.CheckInDate.ToString();
            label_check_out_date.Text=SelectedReservation.CheckOutDate.ToString();
            label_description.Text=SelectedReservation.Description.ToString();
            label_room_type.Text=SelectedReservation.RoomTypeName.ToString();
            label_room_number.Text = SelectedReservation.RoomNumber.ToString();
            label_status.Text=SelectedReservation.ReservationStatusName.ToString();


        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
