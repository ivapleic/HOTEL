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
        public Reservation_Service reservationService;
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

            dataGridViewGuests.Rows.Add(newReservationGuest.ID, selectedGuest.ID, selectedGuest.FirstName, selectedGuest.LastName, reservationGuest.DateStart, reservationGuest.DateEnd);
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
                    int rg_id_pk = Convert.ToInt32(selectedRow.Cells["GuestResID"].Value);
                    int rg_gu_id_fk = Convert.ToInt32(selectedRow.Cells["GuestID"].Value);
                    DateTime rg_date_start = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                    DateTime rg_date_end = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
                    bool rg_add_person = Convert.ToBoolean(selectedRow.Cells["AddPerson"].Value);

                    // Kreiraj objekt Reservation_Guest s podacima iz odabranog retka
                    Reservation_Guest selectedReservationGuest = new Reservation_Guest
                    {
                        ID = rg_id_pk,
                        GuestID = rg_gu_id_fk,
                        DateStart = rg_date_start,
                        DateEnd = rg_date_end,
                        IsAdditionalPerson = rg_add_person
                    };

                    // Kreiraj i prikaži novu formu za ažuriranje
                    GuestReservation_UpdateForm updateForm = new GuestReservation_UpdateForm(selectedReservationGuest);
                    updateForm.ShowDialog(); // Koristi ShowDialog za modalni prikaz forme

                    // Nakon što je forma zatvorena, provjeri je li došlo do promjene u objektu
                    if (updateForm.DialogResult == DialogResult.OK)
                    {
                        // Osvježi odabrani redak u DataGridView s novim podacima
                        selectedRow.Cells["StartDate"].Value = updateForm.SelectedRes_Guest.DateStart;
                        selectedRow.Cells["EndDate"].Value = updateForm.SelectedRes_Guest.DateEnd;
                        selectedRow.Cells["AddPerson"].Value = updateForm.SelectedRes_Guest.IsAdditionalPerson;

                        // Ako je potrebno, ažurirajte i ostale podatke u retku
                    }
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

        private void btn_details_guest_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjeri je li neki redak odabran
                if (dataGridViewGuests.SelectedRows.Count > 0)
                {
                    // Dohvati odabrani redak
                    DataGridViewRow selectedRow = dataGridViewGuests.SelectedRows[0];

                    // Prikupi podatke iz odabranog retka
                    int rg_id_pk = Convert.ToInt32(selectedRow.Cells["GuestResID"].Value);
                    int rg_gu_id_fk = Convert.ToInt32(selectedRow.Cells["GuestID"].Value);
                    DateTime rg_date_start = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                    DateTime rg_date_end = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
                    bool rg_add_person = Convert.ToBoolean(selectedRow.Cells["AddPerson"].Value);

                    // Kreiraj objekt Reservation_Guest s podacima iz odabranog retka
                    Reservation_Guest selectedReservationGuest = new Reservation_Guest
                    {
                        ID = rg_id_pk,
                        GuestID = rg_gu_id_fk,
                        DateStart = rg_date_start,
                        DateEnd = rg_date_end,
                        IsAdditionalPerson = rg_add_person
                    };

                    // Kreiraj i prikaži novu formu za ažuriranje
                    GuestReservation_DetailsForm updateForm = new GuestReservation_DetailsForm(selectedReservationGuest);
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

        private void btn_add_services_Click(object sender, EventArgs e)
        {
            ReservationServices_AddNewForm servicesForm = new ReservationServices_AddNewForm();
            servicesForm.Show();
        }

        public void AddServiceToReservation(Reservation_Service newReservationService)
        {
            AdditionalServices service = new AdditionalServices();
            AdditionalServices selectedService = service.GetServiceById(newReservationService.ServiceID);

            dataGridView_AddServices.Rows.Add(newReservationService.ID, selectedService.ID, selectedService.Name, newReservationService.Quantity, newReservationService.DateReservation, newReservationService.DateConsumption);

        }

        private void btn_delete_service_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjeri je li neki redak odabran
                if (dataGridView_AddServices.SelectedRows.Count > 0)
                {
                    // Potvrdi s korisnikom
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this service?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Ukloni odabrani redak iz DataGridView
                        foreach (DataGridViewRow row in dataGridView_AddServices.SelectedRows)
                        {
                            dataGridView_AddServices.Rows.Remove(row);
                        }

                        MessageBox.Show("Service deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a service to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in deleting service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_service_Click(object sender, EventArgs e)
        {
            try
            {
                // Provjeri je li neki redak odabran
                if (dataGridView_AddServices.SelectedRows.Count > 0)
                {
                    // Dohvati odabrani redak
                    DataGridViewRow selectedRow = dataGridView_AddServices.SelectedRows[0];

                    // Prikupi podatke iz odabranog retka
                    int ra_id_pk = Convert.ToInt32(selectedRow.Cells["ReservationServiceID"].Value);
                    int ServiceID = Convert.ToInt32(selectedRow.Cells["ServiceID"].Value);
                    string ServiceName = Convert.ToString(selectedRow.Cells["ServiceName"].Value);
                    int amount = Convert.ToInt32(selectedRow.Cells["Amount"].Value);
                    DateTime rg_date_consumation = Convert.ToDateTime(selectedRow.Cells["ConsumationDate"].Value);
                    DateTime rg_date_reservation = Convert.ToDateTime(selectedRow.Cells["ReservationDate"].Value);


                    // Kreiraj objekt Reservation_Guest s podacima iz odabranog retka
                    Reservation_Service selectedReservationSevice = new Reservation_Service
                    {
                        ID = ra_id_pk,
                        ServiceID = ServiceID,
                        Quantity = amount,
                        DateReservation = rg_date_reservation,
                        DateConsumption = rg_date_consumation
                    };

                    // Kreiraj i prikaži novu formu za ažuriranje
                    ReservationService_UpdateForm updateForm = new ReservationService_UpdateForm(selectedReservationSevice);
                    updateForm.ShowDialog(); // Koristi ShowDialog za modalni prikaz forme

                    // Nakon što je forma zatvorena, provjeri je li došlo do promjene u objektu
                    if (updateForm.DialogResult == DialogResult.OK)
                    {
                        // Osvježi odabrani redak u DataGridView s novim podacima
                        selectedRow.Cells["ReservationDate"].Value = updateForm.selectedResService.DateReservation;
                        selectedRow.Cells["ConsumationDate"].Value = updateForm.selectedResService.DateConsumption;
                        selectedRow.Cells["Amount"].Value = updateForm.selectedResService.Quantity;

                        // Ako je potrebno, ažurirajte i ostale podatke u retku
                    }
                }
                else
                {
                    MessageBox.Show("Please select a service to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_details_service_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_AddServices.SelectedRows.Count > 0)
                {
                    // Dohvati odabrani redak
                    DataGridViewRow selectedRow = dataGridView_AddServices.SelectedRows[0];

                    // Prikupi podatke iz odabranog retka
                    int ra_id_pk = Convert.ToInt32(selectedRow.Cells["ReservationServiceID"].Value);
                    int ServiceID = Convert.ToInt32(selectedRow.Cells["ServiceID"].Value);
                    string ServiceName = Convert.ToString(selectedRow.Cells["ServiceName"].Value);
                    int amount = Convert.ToInt32(selectedRow.Cells["Amount"].Value);
                    DateTime rg_date_consumation = Convert.ToDateTime(selectedRow.Cells["ConsumationDate"].Value);
                    DateTime rg_date_reservation = Convert.ToDateTime(selectedRow.Cells["ReservationDate"].Value);


                    // Kreiraj objekt Reservation_Guest s podacima iz odabranog retka
                    Reservation_Service selectedReservationSevice = new Reservation_Service
                    {
                        ID = ra_id_pk,
                        ServiceID = ServiceID,
                        Quantity = amount,
                        DateReservation = rg_date_reservation,
                        DateConsumption = rg_date_consumation
                    };


                    // Kreiraj i prikaži novu formu za ažuriranje
                    ReservationServices_DetailsForm updateForm = new ReservationServices_DetailsForm(selectedReservationSevice);
                    updateForm.ShowDialog();

                    // Osvježi DataGridView ako je potrebno nakon ažuriranja
                    // Ovdje možeš dodati kod za osvježavanje prikaza ako je potrebno
                }
                else
                {
                    MessageBox.Show("Please select a service to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in updating service: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_new_Click(object sender, EventArgs e)
        {
            try
            {
                // Prvo, validiraj sve unose
                if (!ValidateInputs())
                {
                    MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Dobij vrednosti iz forme
                int reservationStatusId = (int)comboBox_status.SelectedValue;
                int employeeId = employee.ID;
                int roomId = (int)comboBox_rooms.SelectedValue;
                DateTime reservationDate = DateTime.Now;
                DateTime startDate = dateTimePicker_start_date.Value;
                DateTime endDate = dateTimePicker_end_date.Value;
                DateTime? checkInDate = null;
                DateTime? checkOutDate = null;

                // Ako korisnik unese vrijednost za check-in datum, postavi je
                if (dateTimePicker_check_in.Enabled && dateTimePicker_check_in.Value != DateTime.MinValue)
                {
                    checkInDate = dateTimePicker_check_in.Value;
                }

                // Ako korisnik unese vrijednost za check-out datum, postavi je
                if (dateTimePicker_check_out.Enabled && dateTimePicker_check_out.Value != DateTime.MinValue)
                {
                    checkOutDate = dateTimePicker_check_out.Value;
                }

                string description = textBox_description.Text;

                // Poziv stored procedure za dodavanje rezervacije
                SqlParameter[] reservationParameters = {
            new SqlParameter("@RetVal_ResID", SqlDbType.Int) { Direction = ParameterDirection.Output },
            new SqlParameter("@RetVal_ResNr", SqlDbType.Int) { Direction = ParameterDirection.Output },
            new SqlParameter("@rz_em_id_fk", employeeId),
            new SqlParameter("@rz_rm_id_fk", roomId),
            new SqlParameter("@rz_rs_id_fk", reservationStatusId),
            new SqlParameter("@rz_date_reservation", reservationDate),
            new SqlParameter("@rz_date_start", startDate),
            new SqlParameter("@rz_date_end", endDate),
            new SqlParameter("@rz_date_check_in", checkInDate ?? (object)DBNull.Value),
            new SqlParameter("@rz_date_check_out", checkOutDate ?? (object)DBNull.Value),
            new SqlParameter("@rz_description", description)
        };

                dbConnection.ExecuteStoredProcedure("Insert_RESERVATION", reservationParameters);

                int reservationId = (int)reservationParameters[0].Value;

                // Sada dodaj goste povezane s ovom rezervacijom
                foreach (DataGridViewRow row in dataGridViewGuests.Rows)
                {
                    if (row.Cells["GuestID"].Value != null)
                    {
                        int guestId = Convert.ToInt32(row.Cells["GuestID"].Value);
                        DateTime guestStartDate = Convert.ToDateTime(row.Cells["StartDate"].Value);
                        DateTime guestEndDate = Convert.ToDateTime(row.Cells["EndDate"].Value);
                        bool isAdditionalPerson = Convert.ToBoolean(row.Cells["AddPerson"].Value);

                        SqlParameter[] guestParameters = {
                    new SqlParameter("@rg_rz_id_fk", reservationId),
                    new SqlParameter("@rg_gu_id_fk", guestId),
                    new SqlParameter("@rg_date_start", guestStartDate),
                    new SqlParameter("@rg_date_end", guestEndDate),
                    new SqlParameter("@rg_add_person", isAdditionalPerson)
                };

                        dbConnection.ExecuteStoredProcedure("Insert_RESERVATIONS_GUESTS", guestParameters);
                    }
                }

                // Sada dodaj dodatne usluge povezane s ovom rezervacijom
                foreach (DataGridViewRow row in dataGridView_AddServices.Rows)
                {
                    if (row.Cells["ServiceID"].Value != null)
                    {
                        int serviceId = Convert.ToInt32(row.Cells["ServiceID"].Value);
                        decimal quantity = Convert.ToDecimal(row.Cells["Amount"].Value);
                        DateTime serviceReservationDate = Convert.ToDateTime(row.Cells["ReservationDate"].Value);
                        DateTime serviceConsumptionDate = Convert.ToDateTime(row.Cells["ConsumationDate"].Value);

                        SqlParameter[] serviceParameters = {
                    new SqlParameter("@ra_rz_id_fk", reservationId),
                    new SqlParameter("@ra_as_id_fk", serviceId),
                    new SqlParameter("@ra_kolicina", quantity),
                    new SqlParameter("@ra_date_reservation", serviceReservationDate),
                    new SqlParameter("@ra_date_consumption", serviceConsumptionDate)
                };

                        dbConnection.ExecuteStoredProcedure("Insert_RESERVATION_ADD_SERVICE", serviceParameters);
                    }
                }

                MessageBox.Show("Reservation successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resetuj formu ili zatvori
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInputs()
        {
            // Implementiraj validaciju za obavezna polja
            if (comboBox_status.SelectedValue == null ||
                comboBox_rooms.SelectedValue == null ||
                dateTimePicker_start_date.Value == null ||
                dateTimePicker_end_date.Value == null ||
                string.IsNullOrWhiteSpace(textBox_description.Text))
            {
                return false;
            }

            return true;
        }

        private void Reservation_AddNew_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form_Reservation"] is Form_Reservations reservationForm)
            {
                reservationForm.RefreshReservationsList();
            }
        }
    }
}
