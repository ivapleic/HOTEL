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
    public partial class Form_RoomsAccessories : Form
    {
        private DBConnection dbConnection;
        public Form_RoomsAccessories()
        {
            InitializeComponent();
            dbConnection = new DBConnection();

            // Dodajte DataBindingComplete događaj
            dataGridViewAccessories.DataBindingComplete += dataGridViewAccessories_DataBindingComplete;
            dataGridViewAccessories.CellClick += dataGridViewAccessories_CellClick;
        }

        public void RefreshAccessoryList()
        {
            try
            {
                DisplayAccessories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing accessories list: {ex.Message}");
            }
        }

        private void Form_RoomsAccessories_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridViewAccessories.ClearSelection();
            DisplayAccessories();
        }

        private void DisplayAccessories()
        {
            try
            {
                DataTable accesoriesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_ACCESSORIES", new SqlParameter[0]);

                dataGridViewAccessories.Rows.Clear();

                foreach (DataRow row in accesoriesTable.Rows)
                {
                    int id = Convert.ToInt32(row["ac_id_pk"]);
                    string name = Convert.ToString(row["ac_name"]);

                    int rowIndex = dataGridViewAccessories.Rows.Add(id, name);

                }

                label_num_of_acc.Text = $"{accesoriesTable.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying accessories: {ex.Message}");
            }
        }

        private void dataGridViewAccessories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAccessories.ClearSelection();
        }

        private void dataGridViewAccessories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Provjerite je li kliknuta ćelija unutar reda, a ne header
            {
                dataGridViewAccessories.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_add_new_acc_Click(object sender, EventArgs e)
        {
            Accessories_AddNewForm addNewRoomAccForm = new Accessories_AddNewForm();
            addNewRoomAccForm.Show();
        }

        private void btn_update_floor_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewAccessories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite dodatak koji želite ažurirati.");
                return;
            }

            try
            {
                // Dohvati podatke odabranog reda iz DataGridView
                int accID = Convert.ToInt32(dataGridViewAccessories.SelectedRows[0].Cells["RoomAccID"].Value);
                string accName = Convert.ToString(dataGridViewAccessories.SelectedRows[0].Cells["RoomAccName"].Value);

                // Stvori objekt Floor s podacima odabranog kata
                RoomAccessory selectedAccessory = new RoomAccessory
                {
                    ID = accID,
                    Name = accName
                };

                // Stvori novu instancu Floor_UpdateForm i proslijedi objekt Floor
                RoomAcc_UpdateForm updateForm = new RoomAcc_UpdateForm(selectedAccessory);

                // Prikaži formu za ažuriranje
                DialogResult result = updateForm.ShowDialog();

                // Provjeri rezultat iz forme za ažuriranje
                if (result == DialogResult.OK)
                {
                    // Dohvati ažurirane podatke iz objekta Floor
                    selectedAccessory = updateForm.SelectedAccessory;

                    // Poziv spremljene procedure za ažuriranje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ac_id_pk", selectedAccessory.ID),
                        new SqlParameter("@ac_name", selectedAccessory.Name),
                    };

                    object updateResult = dbConnection.ExecuteStoredProcedure("Update_ROOM_ACCESSORY", parameters);

                    // Obavijest korisniku o uspješnom ažuriranju
                    MessageBox.Show("Dodatak je uspješno ažuriran!");

                    // Osvježavanje prikaza liste katova
                    DisplayAccessories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranja dodataka: {ex.Message}");
            }
        }

        private void btn_delete_floor_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewAccessories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite dodatak koji želite izbrisati.");
                return;
            }

            // Dohvati FloorID odabranog kata iz skrivenog stupca
            int accId = Convert.ToInt32(dataGridViewAccessories.SelectedRows[0].Cells["RoomAccID"].Value);

            // Pitaj korisnika za potvrdu brisanja
            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati odabrani dodatak?",
                                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Poziv spremljene procedure za brisanje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ac_id_pk", accId)
                    };

                    object deleteResult = dbConnection.ExecuteStoredProcedure("Delete_ROOM_ACCESSORY", parameters);

                    // Obavijest korisniku o uspješnom brisanju
                    MessageBox.Show("Dodatak je uspješno izbrisan!");

                    // Osvježavanje prikaza liste katova
                    DisplayAccessories(); // Ovo je vaša postojeća metoda za prikaz katova
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom brisanja dodatka {ex.Message}");
                }
            }
        }
    }
}
