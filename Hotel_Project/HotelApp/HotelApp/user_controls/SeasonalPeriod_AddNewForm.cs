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
    public partial class SeasonalPeriod_AddNewForm : Form
    {
        private DBConnection dbConnection;
        public SeasonalPeriod_AddNewForm()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string seasonName = Convert.ToString(txtSeasonName.Text);
                DateTime startDate = dateTimePicker_startDate.Value;
                DateTime endDate = dateTimePicker_endDate.Value;

                SqlParameter[] parameters = new SqlParameter[]
                   {
                    new SqlParameter("@sp_name", seasonName),
                    new SqlParameter("@sp_start_date ", startDate),
                     new SqlParameter("@sp_end_date ", endDate)
                   };

                object result = dbConnection.ExecuteStoredProcedure("Insert_SEASONAL_PERIOD", parameters);
                MessageBox.Show("Nova sezona je uspješno dodana!");

                if (Application.OpenForms["Form_SeasonalPeriods"] is Form_SeasonalPeriods seasonsForm)
                {
                    seasonsForm.RefreshSeasonalPeriodsList();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new season: {ex.Message}");
            }
        }
    }
}
