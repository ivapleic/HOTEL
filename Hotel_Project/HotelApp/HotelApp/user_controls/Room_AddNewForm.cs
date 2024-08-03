using HotelApp.classes;
using HotelApp.forms;
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
    public partial class Room_AddNewForm : Form
    {
        private class ListBoxItem
        {
            public string Text { get; set; }
            public int Tag { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private DBConnection dbConnection;

        public Room_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();

            PopulateFloors();
            PopulateRoomTypes();
            PopulateAccessories();

            // Dodavanje event handlera za dodavanje slika
            btn_add_img1.Click += (s, e) => AddImage(room_image1);
            btn_add_img2.Click += (s, e) => AddImage(room_image2);
            btn_add_img3.Click += (s, e) => AddImage(room_image3);
            btn_add_img4.Click += (s, e) => AddImage(room_image4);
            btn_add_img5.Click += (s, e) => AddImage(room_image5);

            // Dodavanje event handlera za brisanje slika
            btn_remove_img1.Click += (s, e) => RemoveImage(room_image1);
            btn_remove_img2.Click += (s, e) => RemoveImage(room_image2);
            btn_remove_img3.Click += (s, e) => RemoveImage(room_image3);
            btn_remove_img4.Click += (s, e) => RemoveImage(room_image4);
            btn_remove_img5.Click += (s, e) => RemoveImage(room_image5);
        }

        private void AddImage(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Postavi sliku u PictureBox
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
                    // Spremi putanju slike u Tag svojstvo
                    pictureBox.Tag = openFileDialog.FileName;
                }
            }
        }

        private void RemoveImage(PictureBox pictureBox)
        {
            // Ukloni sliku iz PictureBox
            pictureBox.Image = null;
            // Ukloni putanju slike iz Tag svojstva
            pictureBox.Tag = null;
        }

        private void PopulateFloors()
        {
            try
            {
                DataTable dt_floors = dbConnection.ExecuteStoredProcedure("GET_FLOORS", new SqlParameter[] { });

                // Postavi DisplayMember i ValueMember
                floor_choose.DisplayMember = "fl_number";
                floor_choose.ValueMember = "fl_id_pk";

                // Postavi DataSource
                floor_choose.DataSource = dt_floors;
                floor_choose.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateRoomTypes()
        {
            try
            {
                DataTable dt_roomTypes = dbConnection.ExecuteStoredProcedure("GET_ROOM_TYPES", new SqlParameter[] { });

                // Postavi DisplayMember i ValueMember
                room_type_choose.DisplayMember = "rt_name";
                room_type_choose.ValueMember = "rt_id_pk";

                // Postavi DataSource
                room_type_choose.DataSource = dt_roomTypes;
                room_type_choose.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateAccessories()
        {
            try
            {
                // Izvrši pohranu podataka za pristupne točke
                DataTable dt_accessories = dbConnection.ExecuteStoredProcedure("GET_ROOM_ACCESSORIES", new SqlParameter[] { });

                // Postavi DisplayMember i ValueMember
                acessories_choose.DisplayMember = "ac_name";
                acessories_choose.ValueMember = "ac_id_pk";

                // Postavi DataSource
                acessories_choose.DataSource = dt_accessories;
                acessories_choose.SelectedIndex = -1;
                accessories_listBox.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void acessories_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (acessories_choose.SelectedItem != null)
            {
                // Dohvati odabrani redak iz DataTable
                DataRowView selectedRow = (DataRowView)acessories_choose.SelectedItem;
                string accessoryName = selectedRow["ac_name"].ToString();
                int accessoryID = Convert.ToInt32(selectedRow["ac_id_pk"]);

                // Formatiraj stavku kao samo naziv dodatka
                string itemText = accessoryName;

                // Provjeri je li dodatak već u ListBoxu
                if (!IsAccessoryAlreadyInList(accessoryID))
                {
                    // Dodaj dodatak u ListBox
                    ListBoxItem item = new ListBoxItem
                    {
                        Text = itemText,
                        Tag = accessoryID
                    };
                    accessories_listBox.Items.Add(item);
                }
            }
        }


        private bool IsAccessoryAlreadyInList(int accessoryID)
        {
            foreach (object item in accessories_listBox.Items)
            {
                // Provjeri ID u Tag svojstvu
                if (item is ListBoxItem listBoxItem)
                {
                    if ((int)listBoxItem.Tag == accessoryID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private void remove_acc_btn_Click(object sender, EventArgs e)
        {
            if (accessories_listBox.SelectedItem != null)
            {
                // Ukloni stavku iz ListBoxa
                accessories_listBox.Items.Remove(accessories_listBox.SelectedItem);
            }
        }


        private int AddRoom()
        {
            try
            {
                // Prikupi podatke sa forme
                int roomNumber = Convert.ToInt32(room_number_input.Text);
                int roomTypeID = Convert.ToInt32(room_type_choose.SelectedValue);
                int floorID = Convert.ToInt32(floor_choose.SelectedValue);
                bool isActive = checkBox_available.Checked;
                string description = room_description_input.Text;

                // Postavi slike; ako slika nije dodana, postavi kao DBNull.Value
                string image1 = room_image1.Tag != null ? room_image1.Tag.ToString() : null;
                string image2 = room_image2.Tag != null ? room_image2.Tag.ToString() : null;
                string image3 = room_image3.Tag != null ? room_image3.Tag.ToString() : null;
                string image4 = room_image4.Tag != null ? room_image4.Tag.ToString() : null;
                string image5 = room_image5.Tag != null ? room_image5.Tag.ToString() : null;

                SqlParameter[] parameters = {
            new SqlParameter("@rm_nr", roomNumber),
            new SqlParameter("@rm_rt_id_fk", roomTypeID),
            new SqlParameter("@rm_fl_id_fk", floorID),
            new SqlParameter("@rm_active", isActive),
            new SqlParameter("@rm_description", description),
            new SqlParameter("@rm_image_1", (object)image1 ?? DBNull.Value),
            new SqlParameter("@rm_image_2", (object)image2 ?? DBNull.Value),
            new SqlParameter("@rm_image_3", (object)image3 ?? DBNull.Value),
            new SqlParameter("@rm_image_4", (object)image4 ?? DBNull.Value),
            new SqlParameter("@rm_image_5", (object)image5 ?? DBNull.Value)
        };

                // Ako pohranjena procedura vraća DataTable, obradite ga kao DataTable
                DataTable resultTable = dbConnection.ExecuteStoredProcedure("Insert_ROOM", parameters);

                // Pretpostavljamo da je ID sobe u prvom retku i prvom stupcu DataTablea
                if (resultTable.Rows.Count > 0)
                {
                    int roomId = Convert.ToInt32(resultTable.Rows[0][0]);
                    MessageBox.Show($"Room added successfully with ID: {roomId}");
                    return roomId;
                }
                else
                {
                    MessageBox.Show("Failed to retrieve room ID.");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding room: " + ex.Message);
                return -1;
            }
        }



        private void AddRoomAccessories(int roomId)
        {
            try
            {
                foreach (ListBoxItem item in accessories_listBox.Items) // Koristite ListBoxItem
                {
                    int accessoryID = item.Tag; // Prikupite ID iz Tag svojstva

                    // Pozovi pohranjenu proceduru za dodavanje dodatka
                    SqlParameter[] parameters = {
                new SqlParameter("@ar_rm_id_fk", roomId),
                new SqlParameter("@ar_ac_id_fk", accessoryID)
            };

                    dbConnection.ExecuteStoredProcedure("Insert_ROOMS_ROOM_ACCESSORY", parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding accessories: " + ex.Message);
            }
        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
            int roomId = AddRoom();
            if (roomId != -1) // Provjerite je li soba uspješno dodana
            {
                AddRoomAccessories(roomId);

                // Ako želite osvježiti prikaz soba nakon dodavanja, pozovite LoadRoomsData
                if (Application.OpenForms["RoomsForm"] is RoomsForm roomsForm)
                {
                    roomsForm.LoadRoomsData();
                }

                // Zatvorite formu nakon uspješnog dodavanja
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
