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

            dataGridViewGuests.Rows.Add(selectedGuest.ID, selectedGuest.FirstName, selectedGuest.LastName, reservationGuest.DateStart, reservationGuest.DateEnd);
        }

        private void btn_add_guest_Click(object sender, EventArgs e)
        {
            Form_Guests guestsForm = new Form_Guests();
            guestsForm.Show();


        }

        private void btn_delete_guest_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjeri je li neki redak odabran
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    // Potvrdi s korisnikom
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Ukloni odabrani redak iz DataGridView
                        foreach (DataGridViewRow row in dataGridViewGuests.SelectedRows)
                        {
                            dataGridViewGuests.Rows.Remove(row);
                        }

                        MessageBox.Show("Guest deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a guest to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in deleting guest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_guest_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjeri je li neki redak odabran
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    // Dohvati odabrani redak
                    DataGridViewRow selectedRow = dataGridViewGuests.SelectedRows[0];

                    // Prikupi podatke iz odabranog retka
                    int rg_id_pk = Convert.ToInt32(selectedRow.Cells["rg_id_pk"].Value);
                    int rg_rz_id_fk = Convert.ToInt32(selectedRow.Cells["rg_rz_id_fk"].Value);
                    int rg_gu_id_fk = Convert.ToInt32(selectedRow.Cells["rg_gu_id_fk"].Value);
                    DateTime rg_date_start = Convert.ToDateTime(selectedRow.Cells["rg_date_start"].Value);
                    DateTime rg_date_end = Convert.ToDateTime(selectedRow.Cells["rg_date_end"].Value);
                    bool rg_add_person = Convert.ToBoolean(selectedRow.Cells["rg_add_person"].Value);

                    // Kreiraj objekt Reservation_Guest s podacima iz odabranog retka
                    Reservation_Guest selectedReservationGuest = new Reservation_Guest
                    {
                        ID = rg_id_pk,
                        ReservationID = rg_rz_id_fk,
                        GuestID = rg_gu_id_fk,
                        DateStart = rg_date_start,
                        DateEnd= rg_date_end,
                        IsAdditionalPerson = rg_add_person
                    };

                    // Kreiraj i prikaži novu formu za ažuriranje
                    GuestReservation_UpdateForm updateForm = new GuestReservation_UpdateForm(selectedReservationGuest);
                    updateForm.ShowDialog(); // Koristi ShowDialog za modalni prikaz forme

                    // Osvježi DataGridView ako je potrebno nakon ažuriranja
                    // Ovdje možeš dodati kod za osvježavanje prikaza ako je potrebno
                }
                else
                {
                    MessageBox.Show("Please select a guest to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating guest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
