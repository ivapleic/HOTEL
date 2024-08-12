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
    public partial class SeasonalPeriod_UpdateForm : Form
    {

        public SeasonalPeriods selectedSeason;
        public SeasonalPeriod_UpdateForm(SeasonalPeriods selectedSeasonalPeriod)
        {
            InitializeComponent();
            this.selectedSeason = selectedSeasonalPeriod;
            txtSeasonName.Text = selectedSeasonalPeriod.Name;
            dateTimePicker_startDate.Value = selectedSeasonalPeriod.StartDate;
            dateTimePicker_endDate.Value = selectedSeasonalPeriod.EndDate;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            selectedSeason.Name = txtSeasonName.Text;
            selectedSeason.StartDate = dateTimePicker_startDate.Value;
            selectedSeason.EndDate = dateTimePicker_endDate.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
