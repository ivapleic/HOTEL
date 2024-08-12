using HotelApp.classes;
using HotelApp.classes_main;
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
    public partial class RoomTypeSeasonalPrices_AddNewForm : Form
    {
        DBConnection dbConnection;
        public RoomTypeSeasonalPrices_AddNewForm()
        {
            dbConnection = new DBConnection();
            InitializeComponent();
            LoadRoomTypes();
            LoadSeasons();
        }

        private void LoadRoomTypes()
        {
            try
            {
                RoomTypes roomTypes = new RoomTypes();
                DataTable roomTypesTable = roomTypes.GetRoomTypes();
                comboBox_roomTypes.DisplayMember = "rt_name";
                comboBox_roomTypes.ValueMember = "rt_id_pk";
                comboBox_roomTypes.DataSource = roomTypesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading room types: {ex.Message}");
            }
        }

        private void LoadSeasons()
        {
            try
            {
                SeasonalPeriods seasons = new SeasonalPeriods();
                DataTable seasonsTable = seasons.GetSeasonalPeriods();
                comboBox_seasons.DisplayMember = "sp_name";
                comboBox_seasons.ValueMember = "sp_id_pk";
                comboBox_seasons.DataSource = seasonsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading seasons: {ex.Message}");
            }
        }

        private void btn_add_price_Click(object sender, EventArgs e)
        {
            int roomTypeId = (int)comboBox_roomTypes.SelectedValue;
            int seasonId = (int)comboBox_seasons.SelectedValue;
            decimal price;

            if (decimal.TryParse(txtPrice.Text, out price))
            {
                try
                {
                    // Postavite parametre za pohranjenu proceduru
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@rtsp_rt_id_pk", roomTypeId),
                        new SqlParameter("@rtsp_sp_id_pk",  seasonId),
                        new SqlParameter("@rtsp_price",  price)
                    };

                    // Pozovite pohranjenu proceduru
                    object result = dbConnection.ExecuteStoredProcedure("Insert_ROOM_TYPE_SEASONAL_PRICE", parameters);
                    MessageBox.Show("Nova cijena je uspješno dodan!");

                    if (Application.OpenForms["Form_RoomTypeSeasonPrice"] is Form_RoomTypeSeasonPrice roomTypeSeasonPriceForm)
                    {
                        roomTypeSeasonPriceForm.RefreshPricesTable();
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding price: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }
    }
}
