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
    public partial class RoomType_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public RoomType_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int roomTypeID = random.Next(1, 1001);
                string roomTypeName = Convert.ToString(txtRoomtypeName.Text);
                int numberOfPersons = Convert.ToInt32(txtNumberOfPersons.Text);
                int numberOfChildren = Convert.ToInt32(txtNumberOfChildren.Text);

                SqlParameter[] parameters = new SqlParameter[]
                   {
                    new SqlParameter("@rt_name", roomTypeName),
                    new SqlParameter("@rt_nr_persons", numberOfPersons),
                     new SqlParameter("@rt_nr_children",numberOfChildren)
                   };

                object result = dbConnection.ExecuteStoredProcedure("Insert_ROOM_TYPE", parameters);
                MessageBox.Show("Novi tip sobe je uspješno dodan!");

                if (Application.OpenForms["RoomTypesForm"] is RoomTypesForm roomTypesForm)
                {
                    roomTypesForm.RefreshRoomTypesList();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new room type: {ex.Message}");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
