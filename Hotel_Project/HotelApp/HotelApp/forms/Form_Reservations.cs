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
    public partial class Form_Reservations : Form
    {
        private DBConnection dbConnection;
        public Form_Reservations()
        {
            InitializeComponent();

        }
        public Form_Reservations(Employee employee) : this()
        {
            dbConnection = new DBConnection();

            DisplayReservations();
        }
        public void DisplayReservations()
        {
            try
            {
                DataTable reservationsTable = dbConnection.ExecuteStoredProcedure("Get_RESERVATIONS", new SqlParameter[0]);
                dataGridViewReservations.Rows.Clear();

                foreach (DataRow row in reservationsTable.Rows)
                {
                    // Dohvaćanje podataka iz redaka koristeći nove nazive stupaca
                    int reservationID = Convert.ToInt32(row["ReservationID"]);
                    int employeeID = Convert.ToInt32(row["EmployeeID"]);
                    int roomID = Convert.ToInt32(row["RoomID"]);
                    int reservationStatusID = Convert.ToInt32(row["ReservationStatusID"]);
                    int reservationNumber = Convert.ToInt32(row["ReservationNumber"]);
                    DateTime startDate = Convert.IsDBNull(row["StartDate"]) ? DateTime.MinValue : Convert.ToDateTime(row["StartDate"]);
                    DateTime endDate = Convert.IsDBNull(row["EndDate"]) ? DateTime.MinValue : Convert.ToDateTime(row["EndDate"]);
                    DateTime? checkInDate = Convert.IsDBNull(row["CheckInDate"]) ? (DateTime?)null : Convert.ToDateTime(row["CheckInDate"]);
                    DateTime? checkOutDate = Convert.IsDBNull(row["CheckOutDate"]) ? (DateTime?)null : Convert.ToDateTime(row["CheckOutDate"]);
                    string reservationDescription = Convert.ToString(row["ReservationDescription"]);
                    string roomNumber = Convert.ToString(row["RoomNumber"]);
                    string roomTypeName = Convert.ToString(row["RoomTypeName"]);
                    string employeeFullName = Convert.ToString(row["EmployeeFullName"]);
                    string reservationStatusName = Convert.ToString(row["ReservationStatusName"]);

                    Reservation reservation = new Reservation
                    {
                        ID = reservationID,
                        Number = reservationNumber,
                        EmployeeID = employeeID,
                        EmployeeName = employeeFullName,
                        RoomID = roomID,
                        RoomNumber = roomNumber,
                        RoomTypeName = roomTypeName,
                        ReservationStatusID = reservationStatusID,
                        StartDate = startDate,
                        EndDate = endDate,
                        CheckInDate = checkInDate,
                        CheckOutDate = checkOutDate,
                        Description = reservationDescription,
                        ReservationStatusName = reservationStatusName
                    };

                    int rowIndex = dataGridViewReservations.Rows.Add(
                        reservationID,
                        reservationNumber,
                        roomTypeName,
                        roomNumber,
                        employeeFullName,
                        startDate,
                        endDate,
                        checkInDate,
                        checkOutDate,
                        reservationStatusName
                    );
                    dataGridViewReservations.Rows[rowIndex].Tag = reservation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying reservations: {ex.Message}");
            }
        }

        private void btn_details_reservations_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite rezervaciju koju zelite detaljnije vidjeti.");
                return;
            }

            try
            {
                DataGridViewRow selectedRow = dataGridViewReservations.SelectedRows[0];

                Reservation selectedReservation = (Reservation)selectedRow.Tag;

                if (selectedReservation != null)
                {
                    Reservations_DetailsForm reservationsDetailsForm = new Reservations_DetailsForm(selectedReservation);

                    reservationsDetailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Odabrana rezervacija nije validna.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_add_new_reservation_Click(object sender, EventArgs e)
        {
            Reservations_AddNewForm addNewForm = new Reservations_AddNewForm();
            addNewForm.ShowDialog();
        }
    }
}
