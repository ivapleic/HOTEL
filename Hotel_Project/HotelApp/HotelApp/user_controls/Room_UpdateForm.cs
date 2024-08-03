using HotelApp.classes;
using HotelApp.classes_main;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class Room_UpdateForm : Form
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
        private Room room;
        private DataTable floorsTable;
        private DataTable accessoriesTable;

        public Room_UpdateForm(Room room, DataTable floors)
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            this.room = room;
            this.floorsTable = floors;

            PopulateFloors();
            PopulateRoomTypes();
            PopulateAccessories();
            LoadRoomData();

            // Add event handlers for adding and removing images
            btn_add_img1.Click += (s, e) => AddImage(room_image1);
            btn_add_img2.Click += (s, e) => AddImage(room_image2);
            btn_add_img3.Click += (s, e) => AddImage(room_image3);
            btn_add_img4.Click += (s, e) => AddImage(room_image4);
            btn_add_img5.Click += (s, e) => AddImage(room_image5);

            btn_remove_img1.Click += (s, e) => RemoveImage(room_image1);
            btn_remove_img2.Click += (s, e) => RemoveImage(room_image2);
            btn_remove_img3.Click += (s, e) => RemoveImage(room_image3);
            btn_remove_img4.Click += (s, e) => RemoveImage(room_image4);
            btn_remove_img5.Click += (s, e) => RemoveImage(room_image5);

            // Add event handlers for updating room
            btn_update_room.Click += btn_update_room_Click;
        }

        private void LoadRoomData()
        {
            room_number_input.Text = room.Number.ToString();
            room_type_choose.SelectedValue = room.RoomTypeID;
            floor_choose.SelectedValue = room.FloorID;
            checkBox_available.Checked = room.Is_Active;
            room_description_input.Text = room.Description;

            room_image1.Tag = room.ImagePath1;
            room_image1.Image = LoadImageFromPath(room.ImagePath1);
            room_image2.Tag = room.ImagePath2;
            room_image2.Image = LoadImageFromPath(room.ImagePath2);
            room_image3.Tag = room.ImagePath3;
            room_image3.Image = LoadImageFromPath(room.ImagePath3);
            room_image4.Tag = room.ImagePath4;
            room_image4.Image = LoadImageFromPath(room.ImagePath4);
            room_image5.Tag = room.ImagePath5;
            room_image5.Image = LoadImageFromPath(room.ImagePath5);

            // Populate accessories list box with existing accessories
            foreach (var accessory in room.RoomAccessories)
            {
                ListBoxItem item = new ListBoxItem
                {
                    Text = accessory.Name,
                    Tag = accessory.ID
                };
                accessories_listBox.Items.Add(item);
            }
        }

        private Image LoadImageFromPath(string path)
        {
            return string.IsNullOrEmpty(path) ? null : Image.FromFile(path);
        }

        private void AddImage(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Picture";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
                    pictureBox.Tag = openFileDialog.FileName;
                }
            }
        }

        private void RemoveImage(PictureBox pictureBox)
        {
            pictureBox.Image = null;
            pictureBox.Tag = null;
        }

        private void PopulateFloors()
        {
            floor_choose.DisplayMember = "fl_number";
            floor_choose.ValueMember = "fl_id_pk";
            floor_choose.DataSource = floorsTable;
        }

        private void PopulateRoomTypes()
        {
            try
            {
                DataTable dt_roomTypes = dbConnection.ExecuteStoredProcedure("GET_ROOM_TYPES", new SqlParameter[] { });

                room_type_choose.DisplayMember = "rt_name";
                room_type_choose.ValueMember = "rt_id_pk";
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
                accessoriesTable = dbConnection.ExecuteStoredProcedure("GET_ROOM_ACCESSORIES", new SqlParameter[] { });

                acessories_choose.DisplayMember = "ac_name";
                acessories_choose.ValueMember = "ac_id_pk";
                acessories_choose.DataSource = accessoriesTable;
                acessories_choose.SelectedIndex = -1;
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
                DataRowView selectedRow = (DataRowView)acessories_choose.SelectedItem;
                string accessoryName = selectedRow["ac_name"].ToString();
                int accessoryID = Convert.ToInt32(selectedRow["ac_id_pk"]);

                if (!IsAccessoryAlreadyInList(accessoryID))
                {
                    ListBoxItem item = new ListBoxItem
                    {
                        Text = accessoryName,
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
                accessories_listBox.Items.Remove(accessories_listBox.SelectedItem);
            }
        }

        private void UpdateRoom()
        {
            try
            {
                int roomNumber = Convert.ToInt32(room_number_input.Text);
                int roomTypeID = Convert.ToInt32(room_type_choose.SelectedValue);
                int floorID = Convert.ToInt32(floor_choose.SelectedValue);
                bool isActive = checkBox_available.Checked;
                string description = room_description_input.Text;

                string image1 = room_image1.Tag != null ? room_image1.Tag.ToString() : null;
                string image2 = room_image2.Tag != null ? room_image2.Tag.ToString() : null;
                string image3 = room_image3.Tag != null ? room_image3.Tag.ToString() : null;
                string image4 = room_image4.Tag != null ? room_image4.Tag.ToString() : null;
                string image5 = room_image5.Tag != null ? room_image5.Tag.ToString() : null;

                SqlParameter[] parameters = {
                    new SqlParameter("@rm_id_pk", room.ID),
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

                dbConnection.ExecuteStoredProcedure("UPDATE_ROOM", parameters);

                // Update room accessories
                dbConnection.ExecuteStoredProcedure("DELETE_ROOM_ACCESSORIES_BY_ROOM_ID", new SqlParameter[] {
                    new SqlParameter("@ar_rm_id_fk", room.ID)
                });

                foreach (ListBoxItem item in accessories_listBox.Items)
                {
                    SqlParameter[] accessoryParameters = {
                        new SqlParameter("@ar_rm_id_fk", room.ID),
                        new SqlParameter("@ar_ac_id_fk", item.Tag)
                    };
                    dbConnection.ExecuteStoredProcedure("INSERT_ROOM_ACCESSORY", accessoryParameters);
                }

                MessageBox.Show("Room updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_update_room_Click(object sender, EventArgs e)
        {
            UpdateRoom();

        }
    }
}
