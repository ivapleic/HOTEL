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
    public partial class RoomTypesForm : Form
    {
        private DBConnection dbConnection;
        public RoomTypesForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void RoomTypesForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            DisplayRoomTypes();
            dataGridView_RoomTypes.ClearSelection();
        }

        private void DisplayRoomTypes()
        {
            try
            {
                DataTable roomTypesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_TYPES", new SqlParameter[0]);

                dataGridView_RoomTypes.Rows.Clear();

                foreach (DataRow row in roomTypesTable.Rows)
                {
                    int id = Convert.ToInt32(row["rt_id_pk"]);
                    string name = Convert.ToString(row["rt_name"]);
                    int num_of_persons = Convert.ToInt32(row["rt_nr_persons"]);
                    int num_of_children = Convert.ToInt32(row["rt_nr_children"]);
                    int rowIndex = dataGridView_RoomTypes.Rows.Add(id, name, num_of_persons, num_of_children);
                }

                label_num_of_room_types.Text = $"{roomTypesTable.Rows.Count}";
                dataGridView_RoomTypes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying room types: {ex.Message}");
            }
        }

        public void RefreshRoomTypesList()
        {
            try
            {
                DisplayRoomTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing room types list: {ex.Message}");
            }
        }


        private void dataGridView_RoomTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_RoomTypes.ClearSelection();
        }

        private void dataGridView_RoomTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView_RoomTypes.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            RoomType_AddNewForm addNewRoomTypeForm = new RoomType_AddNewForm();
            addNewRoomTypeForm.Show();
        }

        private void btn_update_room_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridView_RoomTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite tip sobe koji želite ažurirati.");
                return;
            }

            try
            {
                // Dohvati podatke odabranog reda iz DataGridView
                int roomTypeID = Convert.ToInt32(dataGridView_RoomTypes.SelectedRows[0].Cells["Room_type_ID"].Value);
                string roomTypeName = Convert.ToString(dataGridView_RoomTypes.SelectedRows[0].Cells["Room_type_name"].Value);
                int numberOfPersons = Convert.ToInt32(dataGridView_RoomTypes.SelectedRows[0].Cells["Number_of_persons"].Value);
                int numberOfChildren = Convert.ToInt32(dataGridView_RoomTypes.SelectedRows[0].Cells["Number_of_children"].Value);

                // Stvori objekt Floor s podacima odabranog kata
                RoomTypes selectedRoomType = new RoomTypes
                {
                    ID = roomTypeID,
                    Name = roomTypeName,
                    NumberOfPersons = numberOfPersons,
                    NumberOfChildren = numberOfChildren

                };

                // Stvori novu instancu Floor_UpdateForm i proslijedi objekt Floor
                RoomType_UpdateForm updateForm = new RoomType_UpdateForm(selectedRoomType);

                // Prikaži formu za ažuriranje
                DialogResult result = updateForm.ShowDialog();

                // Provjeri rezultat iz forme za ažuriranje
                if (result == DialogResult.OK)
                {
                    // Dohvati ažurirane podatke iz objekta Floor
                    selectedRoomType = updateForm.SelectedRoomType;

                    // Poziv spremljene procedure za ažuriranje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@rt_id_pk", selectedRoomType.ID),
                        new SqlParameter("@rt_name", selectedRoomType.Name),
                        new SqlParameter("@rt_nr_persons", selectedRoomType.NumberOfPersons),
                        new SqlParameter("@rt_nr_children", selectedRoomType.NumberOfChildren)
                    };

                    object updateResult = dbConnection.ExecuteStoredProcedure("Update_ROOM_TYPE", parameters);

                    // Obavijest korisniku o uspješnom ažuriranju
                    MessageBox.Show("Tip sobe je uspješno ažuriran!");

                    // Osvježavanje prikaza liste katova
                    DisplayRoomTypes(); // Ovo je vaša postojeća metoda za prikaz katova
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranja tipa sobe: {ex.Message}");
            }
        }

        private void btn_delete_room_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridView_RoomTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite tip sobe koji želite izbrisati.");
                return;
            }

            // Dohvati FloorID odabranog kata iz skrivenog stupca
            int roomTypeID = Convert.ToInt32(dataGridView_RoomTypes.SelectedRows[0].Cells["Room_type_ID"].Value);

            // Pitaj korisnika za potvrdu brisanja
            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati odabrani tip sobe?",
                                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Poziv spremljene procedure za brisanje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@rt_id_pk", roomTypeID)
                    };

                    object deleteResult = dbConnection.ExecuteStoredProcedure("Delete_ROOM_TYPE", parameters);

                    // Obavijest korisniku o uspješnom brisanju
                    MessageBox.Show("Tip sobe je uspješno izbrisan!");

                    // Osvježavanje prikaza liste katova
                    DisplayRoomTypes(); // Ovo je vaša postojeća metoda za prikaz katova
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom brisanja tipa sobe: {ex.Message}");
                }
            }
        }
    }
}
