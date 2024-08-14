using HotelApp.classes_main;
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
    public partial class RoomTypeSeasonalPrices_UpdateForm : Form
    {
        public RoomType_SeasonalPrices selectedRoomTypeSeasonalPrice;
        string roomTypeName;
        string seasonName;
        RoomTypes roomType = new RoomTypes();
        SeasonalPeriods season = new SeasonalPeriods();
        public decimal UpdatedPrice { get; private set; }
        public RoomTypeSeasonalPrices_UpdateForm(RoomType_SeasonalPrices SelectedRoomTypeSeasonalPrice)
        {
            InitializeComponent();
            this.selectedRoomTypeSeasonalPrice = SelectedRoomTypeSeasonalPrice;

            roomTypeName = roomType.GetRoomTypeNameByID(SelectedRoomTypeSeasonalPrice.RoomTypeID);
            comboBox_roomTypes.Text = roomTypeName;
            comboBox_roomTypes.Enabled = false;

            MessageBox.Show("sezonaaa" + selectedRoomTypeSeasonalPrice.SeasonalPeriodID);

            seasonName = season.GetSeasonalPeriodNameByID(SelectedRoomTypeSeasonalPrice.SeasonalPeriodID);
            comboBox_seasons.Text = seasonName;
            comboBox_seasons.Enabled = false;

            txtPrice.Text = SelectedRoomTypeSeasonalPrice.Price.ToString();
        }

        private void btn_update_price_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal updatedPrice))
            {
                selectedRoomTypeSeasonalPrice.Price = updatedPrice;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
            }
        }
    }
}
