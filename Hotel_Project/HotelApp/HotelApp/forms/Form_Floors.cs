using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.user_controls;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.forms
{
    public partial class Form_Floors : Form
    {
        private DBConnection dbConnection;
        public Form_Floors()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        public void RefreshFloorList()
        {
            try
            {
                DisplayFloors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing floor list: {ex.Message}");
            }
        }

        private void Form_Floors_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridViewFloors.ClearSelection();
            DisplayFloors();
        }

        private void DisplayFloors()
        {
            try
            {
                DataTable floorsTable = dbConnection.ExecuteStoredProcedure("Get_FLOORS", new SqlParameter[0]);

                dataGridViewFloors.Rows.Clear();

                foreach (DataRow row in floorsTable.Rows)
                {
                    int id = Convert.ToInt32(row["fl_id_pk"]);
                    int number = Convert.ToInt32(row["fl_number"]);
                    string description = Convert.ToString(row["fl_description"]);

                    // Dodajte red u DataGridView s ID-om kao skrivenim stupcem
                    int rowIndex = dataGridViewFloors.Rows.Add(id, number, description);

                }

                label_num_of_floors.Text = $"{floorsTable.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying floors: {ex.Message}");
            }
        }

        private void btn_add_new_floor_Click(object sender, EventArgs e)
        {
            Floor_AddNewForm addNewFloorForm = new Floor_AddNewForm();
            addNewFloorForm.Show();
        }

        private void btn_delete_floor_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewFloors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite kat koji želite izbrisati.");
                return;
            }

            // Dohvati FloorID odabranog kata iz skrivenog stupca
            int floorId = Convert.ToInt32(dataGridViewFloors.SelectedRows[0].Cells["FloorID"].Value);

            // Pitaj korisnika za potvrdu brisanja
            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati odabrani kat?",
                                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Poziv spremljene procedure za brisanje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@fl_id_pk", floorId)
                    };

                    object deleteResult = dbConnection.ExecuteStoredProcedure("Delete_FLOOR", parameters);

                    // Obavijest korisniku o uspješnom brisanju
                    MessageBox.Show("Kat je uspješno izbrisan!");

                    // Osvježavanje prikaza liste katova
                    DisplayFloors(); // Ovo je vaša postojeća metoda za prikaz katova
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom brisanja kata: {ex.Message}");
                }
            }
        }

        private void btn_update_floor_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewFloors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite kat koji želite ažurirati.");
                return;
            }

            try
            {
                // Dohvati podatke odabranog reda iz DataGridView
                int floorId = Convert.ToInt32(dataGridViewFloors.SelectedRows[0].Cells["FloorID"].Value);
                int floorNumber = Convert.ToInt32(dataGridViewFloors.SelectedRows[0].Cells["FloorNumber"].Value);
                string floorDescription = Convert.ToString(dataGridViewFloors.SelectedRows[0].Cells["FloorDescription"].Value);

                // Stvori objekt Floor s podacima odabranog kata
                Floor selectedFloor = new Floor
                {
                    ID = floorId,
                    Number = floorNumber,
                    Description = floorDescription
                };

                // Stvori novu instancu Floor_UpdateForm i proslijedi objekt Floor
                Floor_UpdateForm updateForm = new Floor_UpdateForm(selectedFloor);

                // Prikaži formu za ažuriranje
                DialogResult result = updateForm.ShowDialog();

                // Provjeri rezultat iz forme za ažuriranje
                if (result == DialogResult.OK)
                {
                    // Dohvati ažurirane podatke iz objekta Floor
                    selectedFloor = updateForm.SelectedFloor;

                    // Poziv spremljene procedure za ažuriranje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                    new SqlParameter("@fl_id_pk", selectedFloor.ID),
                    new SqlParameter("@fl_number", selectedFloor.Number),
                    new SqlParameter("@fl_description", selectedFloor.Description)
                    };

                    object updateResult = dbConnection.ExecuteStoredProcedure("Update_FLOOR", parameters);

                    // Obavijest korisniku o uspješnom ažuriranju
                    MessageBox.Show("Kat je uspješno ažuriran!");

                    // Osvježavanje prikaza liste katova
                    DisplayFloors(); // Ovo je vaša postojeća metoda za prikaz katova
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranja kata: {ex.Message}");
            }
        }





    }
}
