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
    public partial class Form_AddServices : Form
    {
        private DBConnection dbConnection;
        public Form_AddServices()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            DisplayAddServices();
        }

        public void RefreshAddServicesList()
        {
            try
            {
                DisplayAddServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing services list: {ex.Message}");
            }
        }
        private void DisplayAddServices()
        {
            try
            {
                // Poziv pohranjene procedure koja dohvaća dodatne usluge iz baze podataka
                DataTable addServicesTable = dbConnection.ExecuteStoredProcedure("Get_ADD_SERVICES", new SqlParameter[0]);

                // Čišćenje DataGridView-a prije dodavanja novih redaka
                dataGridViewAddServices.Rows.Clear();

                label_num_of_add_services.Text = $"{addServicesTable.Rows.Count}";

                // Popunjavanje DataGridView-a s dohvaćenim podacima
                foreach (DataRow row in addServicesTable.Rows)
                {
                    int id = Convert.ToInt32(row["as_id_pk"]);
                    string name = Convert.ToString(row["as_name"]);
                    decimal price = Convert.ToDecimal(row["as_price"]);
                    string description = Convert.ToString(row["as_description"]);

                    // Dodavanje reda u DataGridView
                    int rowIndex = dataGridViewAddServices.Rows.Add(id, name, price, description);
                }

                // Čišćenje selekcije nakon popunjavanja
                dataGridViewAddServices.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying additional services: {ex.Message}");
            }
        }

        private void btn_add_new_add_service_Click(object sender, EventArgs e)
        {
            AddServices_AddNewForm addNewServiceForm = new AddServices_AddNewForm();
            addNewServiceForm.Show();
        }

        private void btn_delete_add_service_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewAddServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite uslugu koju želite izbrisati.");
                return;
            }

            // Dohvati FloorID odabranog kata iz skrivenog stupca
            int serviceId = Convert.ToInt32(dataGridViewAddServices.SelectedRows[0].Cells["AddService_ID"].Value);

            // Pitaj korisnika za potvrdu brisanja
            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati odabranu uslugu?",
                                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Poziv spremljene procedure za brisanje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@as_id_pk", serviceId)
                    };

                    object deleteResult = dbConnection.ExecuteStoredProcedure("Delete_ADD_SERVICE", parameters);

                    // Obavijest korisniku o uspješnom brisanju
                    MessageBox.Show("Usluga je uspješno izbrisana!");

                    // Osvježavanje prikaza liste katova
                    DisplayAddServices(); // Ovo je vaša postojeća metoda za prikaz katova
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom brisanja usluge: {ex.Message}");
                }
            }
        }

        private void btn_update_add_service_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewAddServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite kat koji želite ažurirati.");
                return;
            }

            try
            {
                // Dohvati podatke odabranog reda iz DataGridView
                int serviceId = Convert.ToInt32(dataGridViewAddServices.SelectedRows[0].Cells["AddService_ID"].Value);
                string serviceName = Convert.ToString(dataGridViewAddServices.SelectedRows[0].Cells["AddService_Name"].Value);
                decimal servicePrice = Convert.ToDecimal(dataGridViewAddServices.SelectedRows[0].Cells["AddService_Price"].Value);
                string serviceDescription = Convert.ToString(dataGridViewAddServices.SelectedRows[0].Cells["AddService_Description"].Value);


                // Stvori objekt Floor s podacima odabranog kata
                AdditionalServices selectedService = new AdditionalServices
                {
                    ID = serviceId,
                    Name = serviceName,
                    Price =servicePrice,
                    Description=serviceDescription
                };

                // Stvori novu instancu Floor_UpdateForm i proslijedi objekt Floor
                AddServices_UpdateForm updateForm = new AddServices_UpdateForm(selectedService);

                // Prikaži formu za ažuriranje
                DialogResult result = updateForm.ShowDialog();

                // Provjeri rezultat iz forme za ažuriranje
                if (result == DialogResult.OK)
                {
                    // Dohvati ažurirane podatke iz objekta Floor
                    selectedService = updateForm.selectedService;

                    // Poziv spremljene procedure za ažuriranje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@as_id_pk", selectedService.ID),
                        new SqlParameter("@as_name", selectedService.Name),
                        new SqlParameter("@as_price", selectedService.Price),
                        new SqlParameter("@as_description", selectedService.Description)
                    };

                    object updateResult = dbConnection.ExecuteStoredProcedure("Update_ADD_SERVICE", parameters);

                  
                    MessageBox.Show("Usluga je uspješno ažurirana!");

                    DisplayAddServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranja usluge: {ex.Message}");
            }
        }
    }
}
