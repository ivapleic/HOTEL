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
    public partial class ReservationServices_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public ReservationServices_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            LoadAdditionalServices();
        }

        private void btn_close_form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAdditionalServices()
        {
            try
            {
                // Poziv pohranjene procedure koja dohvaća dodatne usluge iz baze podataka
                DataTable addServicesTable = dbConnection.ExecuteStoredProcedure("Get_ADD_SERVICES", new SqlParameter[0]);

                // Čišćenje DataGridView-a prije dodavanja novih redaka
                dataGridViewServices.Rows.Clear();

                dataGridViewServices.Text = $"{addServicesTable.Rows.Count}";

                // Popunjavanje DataGridView-a s dohvaćenim podacima
                foreach (DataRow row in addServicesTable.Rows)
                {
                    int id = Convert.ToInt32(row["as_id_pk"]);
                    string name = Convert.ToString(row["as_name"]);
                    decimal price = Convert.ToDecimal(row["as_price"]);
                    string description = Convert.ToString(row["as_description"]);

                    // Dodavanje reda u DataGridView
                    int rowIndex = dataGridViewServices.Rows.Add(id, name, price, description);
                }

                // Čišćenje selekcije nakon popunjavanja
                dataGridViewServices.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying additional services: {ex.Message}");
            }
        }

        private void btn_add_service_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewServices.SelectedRows.Count > 0)
                {
                    int serviceID = Convert.ToInt32(dataGridViewServices.SelectedRows[0].Cells["ServiceID"].Value);
                    AdditionalServices service = new AdditionalServices();
                    AdditionalServices selectedService = service.GetServiceById(serviceID);

                    ReservationServicesDetails_AddNewForm addNewForm = new ReservationServicesDetails_AddNewForm(selectedService);
                    addNewForm.ShowDialog(); // Koristite ShowDialog za modalno prikazivanje forme

                    // Zatvori trenutnu formu (ako je potrebno)
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please select a service to add.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in selectingservuce: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
