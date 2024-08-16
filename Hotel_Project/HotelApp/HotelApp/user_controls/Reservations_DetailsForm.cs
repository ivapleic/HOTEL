using HotelApp.classes;
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
    public partial class Reservations_DetailsForm : Form
    {
        Reservation selectedReservation;
        private DBConnection dbConnection;
        public Reservations_DetailsForm(Reservation SelectedReservation)
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            this.selectedReservation = SelectedReservation;
            label_res_number.Text = SelectedReservation.Number.ToString();
            label_reservation_date.Text = SelectedReservation.ReservationDate.ToString();
            label_employee_name.Text = SelectedReservation.EmployeeName.ToString();
            label_start_date.Text = SelectedReservation.StartDate.ToString();
            label_end_date.Text = SelectedReservation.EndDate.ToString();
            label_check_in_date.Text = SelectedReservation.CheckInDate.ToString();
            label_check_out_date.Text = SelectedReservation.CheckOutDate.ToString();
            label_description.Text = SelectedReservation.Description.ToString();
            label_room_type.Text = SelectedReservation.RoomTypeName.ToString();
            label_room_number.Text = SelectedReservation.RoomNumber.ToString();
            label_status.Text = SelectedReservation.ReservationStatusName.ToString();

            DisplayGuests();
            DisplayAdditionalServices();

        }

        private void DisplayGuests()
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                      new SqlParameter("@rg_rz_id_fk", selectedReservation.ID)
                };


                DataTable guestsTable = dbConnection.ExecuteStoredProcedure("Get_RESERV_GUESTS_BY_RESERVATION_ID", parameters);

                dataGridViewGuests.Rows.Clear();

                foreach (DataRow row in guestsTable.Rows)
                {
                    int rg_id_pk = Convert.ToInt32(row["rg_id_pk"]);
                    int ReservationID = Convert.ToInt32(row["rg_rz_id_fk"]);
                    int GuestID = Convert.ToInt32(row["rg_gu_id_fk"]);
                    DateTime StartDate = Convert.ToDateTime(row["rg_date_start"]);
                    DateTime EndDate = Convert.ToDateTime(row["rg_date_end"]);
                    bool AddPerson = Convert.ToBoolean(row["rg_add_person"]);
                    string GuestFirstName = Convert.ToString(row["gu_first_name"]);
                    string GuestLastName = Convert.ToString(row["gu_last_name"]);

                    int rowIndex = dataGridViewGuests.Rows.Add(GuestID, GuestFirstName, GuestLastName, StartDate, EndDate, AddPerson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying guests: {ex.Message}");
            }
        }

        private void DisplayAdditionalServices()
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                      new SqlParameter("@ra_rz_id_fk", selectedReservation.ID)
                };

                DataTable servicesTable = dbConnection.ExecuteStoredProcedure("Get_RESERV_ADD_SERVICES_BY_RESERVATION_ID", parameters);

                dataGridViewAddServices.Rows.Clear();

                foreach (DataRow row in servicesTable.Rows)
                {
                    int ra_id_pk = Convert.ToInt32(row["ra_id_pk"]);
                    int ReservationID = Convert.ToInt32(row["ra_rz_id_fk"]);
                    int ServiceID = Convert.ToInt32(row["ra_as_id_fk"]);
                    string ServiceName = Convert.ToString(row["as_name"]);
                    int ServiceQuantity = Convert.ToInt32(row["ra_kolicina"]);
                    DateTime ReservationDate = Convert.ToDateTime(row["ra_date_reservation"]);
                    DateTime ConsumptionDate = Convert.ToDateTime(row["ra_date_consumption"]);


                    int rowIndex = dataGridViewAddServices.Rows.Add(ServiceID, ServiceName, ServiceQuantity, ReservationDate, ConsumptionDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying services: {ex.Message}");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Room GetRoomById(int roomId)
        {
            Room room = null;

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@rm_id_pk", roomId)
                };

                DataTable roomTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_BY_ID", parameters);

                if (roomTable.Rows.Count > 0)
                {
                    DataRow row = roomTable.Rows[0];

                    room = new Room
                    {
                        ID = Convert.ToInt32(row["rm_id_pk"]),
                        Number = Convert.ToInt32(row["rm_nr"]),
                        RoomTypeName = Convert.ToString(row["rt_name"]),
                        FloorID = Convert.ToInt32(row["rm_fl_id_fk"]),
                        FloorNumber = Convert.ToInt32(row["fl_number"]),
                        Is_Active = Convert.ToBoolean(row["rm_active"]),
                        Description = Convert.ToString(row["rm_description"]),
                        ImagePath1 = Convert.ToString(row["rm_image_1"]),
                        ImagePath2 = Convert.ToString(row["rm_image_2"]),
                        ImagePath3 = Convert.ToString(row["rm_image_3"]),
                        ImagePath4 = Convert.ToString(row["rm_image_4"]),
                        ImagePath5 = Convert.ToString(row["rm_image_5"])
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading room details: {ex.Message}");
            }

            return room;
        }

        private void btn_room_details_Click(object sender, EventArgs e)
        {
            int roomId = selectedReservation.RoomID;

            Room room = GetRoomById(roomId);

            if (room != null)
            {

                RoomDetailsForm roomDetailsForm = new RoomDetailsForm(room);
                roomDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Detalji sobe nisu pronađeni.");
            }
        }
     
    }
}
