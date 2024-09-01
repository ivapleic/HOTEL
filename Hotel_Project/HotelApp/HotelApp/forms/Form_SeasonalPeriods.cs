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
    public partial class Form_SeasonalPeriods : Form
    {
        private DBConnection dbConnection;
        public Form_SeasonalPeriods()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            DisplaySeasonalPeriods();
            dataGridViewSeasons.ClearSelection();
        }

        public void RefreshSeasonalPeriodsList()
        {
            try
            {
                DisplaySeasonalPeriods();
                MessageBox.Show("uslo je ode");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing seasons list: {ex.Message}");
            }
        }
        private void DisplaySeasonalPeriods()
        {
            try
            {
                DataTable seasonsTable = dbConnection.ExecuteStoredProcedure("GET_SEASONAL_PERIODS", new SqlParameter[0]);

                dataGridViewSeasons.Rows.Clear();

                foreach (DataRow row in seasonsTable.Rows)
                {
                    int seasonId = Convert.ToInt32(row["sp_id_pk"]);
                    string seasonName = Convert.ToString(row["sp_name"]);
                    DateTime startDate = Convert.ToDateTime(row["sp_start_date"]).Date;
                    DateTime endDate = Convert.ToDateTime(row["sp_end_date"]).Date;

                    int rowIndex = dataGridViewSeasons.Rows.Add(seasonId, seasonName, startDate, endDate);
                }

                dataGridViewSeasons.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying seasons: {ex.Message}");
            }
        }


        private void btn_add_season_Click(object sender, EventArgs e)
        {
            SeasonalPeriod_AddNewForm addNewSeasonForm = new SeasonalPeriod_AddNewForm();
            addNewSeasonForm.Show();
        }

        private void btn_update_season_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewSeasons.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite sezonu koju želite ažurirati.");
                return;
            }

            try
            {
                // Dohvati podatke odabranog reda iz DataGridView
                int seasonId = Convert.ToInt32(dataGridViewSeasons.SelectedRows[0].Cells["SeasonID"].Value);
                string seasonName = Convert.ToString(dataGridViewSeasons.SelectedRows[0].Cells["SeasonName"].Value);
                DateTime startDate = Convert.ToDateTime(dataGridViewSeasons.SelectedRows[0].Cells["StartDate"].Value);
                DateTime endDate = Convert.ToDateTime(dataGridViewSeasons.SelectedRows[0].Cells["EndDate"].Value);

                SeasonalPeriods selectedSeason = new SeasonalPeriods(seasonId, seasonName, startDate, endDate);

                SeasonalPeriod_UpdateForm updateForm = new SeasonalPeriod_UpdateForm(selectedSeason);

                DialogResult result = updateForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedSeason = updateForm.selectedSeason;

                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@sp_id_pk", selectedSeason.ID),
                        new SqlParameter("@sp_name", selectedSeason.Name),
                        new SqlParameter("@sp_start_date", selectedSeason.StartDate),
                        new SqlParameter("@sp_end_date", selectedSeason.EndDate),
                    };

                    object updateResult = dbConnection.ExecuteStoredProcedure("Update_SEASONAL_PERIOD", parameters);

                    MessageBox.Show("Sezona je uspješno ažurirana!");

                    DisplaySeasonalPeriods();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom ažuriranje sezone: {ex.Message}");
            }
        }

        private void btn_delete_season_Click(object sender, EventArgs e)
        {
            // Provjeri je li odabran redak
            if (dataGridViewSeasons.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite sezonu koji želite izbrisati.");
                return;
            }

            // Dohvati FloorID odabranog kata iz skrivenog stupca
            int seasonId = Convert.ToInt32(dataGridViewSeasons.SelectedRows[0].Cells["SeasonID"].Value);

            // Pitaj korisnika za potvrdu brisanja
            DialogResult result = MessageBox.Show($"Jeste li sigurni da želite izbrisati odabranu sezonu?",
                                                  "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Poziv spremljene procedure za brisanje kroz DBConnection
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@sp_id_pk", seasonId)
                    };

                    object deleteResult = dbConnection.ExecuteStoredProcedure("Delete_SEASONAL_PERIOD", parameters);

                    MessageBox.Show("Sezona je uspješno izbrisana!");

                   
                    DisplaySeasonalPeriods(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška prilikom brisanja sezone: {ex.Message}");
                }
            }
        }
    }
}
