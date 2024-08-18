using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class Reservation_AddNew_Form : Form
    {
        private DBConnection dbConnection;
        ReservationStatus reservationStatus;
        public Reservation_Guest reservationGuest;
        public Employee employee;

        public Reservation_AddNew_Form()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        public Reservation_AddNew_Form(Employee employee) : this()
        {
            this.employee = employee;
            label_employee_name.Text = $"{employee.FirstName} {employee.LastName}";
            PopulateReservationStatuses();
            PopulateRoomTypes();
        }

        public void PopulateReservationStatuses()
        {
            try
            {
                DataTable dt_statuses = dbConnection.ExecuteStoredProcedure("Get_RESERVATION_STATUSES", new SqlParameter[] { });

                comboBox_status.DisplayMember = "rs_name";
                comboBox_status.ValueMember = "rs_id_pk";

                // Postavi DataSource
                comboBox_status.DataSource = dt_statuses;
                comboBox_status.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void PopulateRoomTypes()
        {
            try
            {
                DataTable dt_roomTypes = dbConnection.ExecuteStoredProcedure("GET_ROOM_TYPES", new SqlParameter[] { });

                comboBox_roomType.DisplayMember = "rt_name";
                comboBox_roomType.ValueMember = "rt_id_pk";

                comboBox_roomType.DataSource = dt_roomTypes;
                comboBox_roomType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateAvailableRooms(int roomTypeId, DateTime startDate, DateTime endDate)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@RoomTypeID", roomTypeId),
                    new SqlParameter("@StartDate", startDate),
                    new SqlParameter("@EndDate", endDate)
                };

                DataTable dt_rooms = dbConnection.ExecuteStoredProcedure("Get_AVAILABLE_ROOMS", parameters);

                // Postavi DisplayMember i ValueMember
                comboBox_rooms.DisplayMember = "RoomNumber";
                comboBox_rooms.ValueMember = "RoomID";

                // Postavi DataSource
                comboBox_rooms.DataSource = dt_rooms;
                comboBox_rooms.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateAvailableRooms()
        {
            if (comboBox_roomType.SelectedValue != null && dateTimePicker_start_date.Value != null && dateTimePicker_end_date.Value != null)
            {
                int roomTypeId = (int)comboBox_roomType.SelectedValue;
                DateTime startDate = dateTimePicker_start_date.Value;
                DateTime endDate = dateTimePicker_end_date.Value;

                PopulateAvailableRooms(roomTypeId, startDate, endDate);
            }
        }

        private void dateTimePicker_start_date_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvailableRooms();
        }

        private void dateTimePicker_end_date_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvailableRooms();
        }

        private void comboBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAvailableRooms();
        }

        public void AddGuestToReservation(Reservation_Guest newReservationGuest)
        {
            Guest guest = new Guest();
            Guest selectedGuest = guest.GetGuestById(newReservationGuest.GuestID);

            dataGridViewGuests.Rows.Add(selectedGuest.ID,selectedGuest.FirstName,selectedGuest.LastName,reservationGuest.DateStart,reservationGuest.DateEnd);
        }
        private void btn_add_guest_Click(object sender, EventArgs e)
        {
            Form_Guests guestsForm = new Form_Guests();
            guestsForm.Show();
          
            
        }
    }
}
