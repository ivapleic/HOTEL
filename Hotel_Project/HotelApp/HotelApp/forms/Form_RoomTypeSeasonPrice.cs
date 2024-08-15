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
    public partial class Form_RoomTypeSeasonPrice : Form
    {
        private DBConnection dbConnection;

        public Form_RoomTypeSeasonPrice()
        {
            InitializeComponent();
            dbConnection = new DBConnection();
            LoadSeasonalPeriods();
            LoadRoomTypes();
            LoadRoomPrices();
        }

        public void RefreshPricesTable()
        {
            LoadSeasonalPeriods();
            LoadRoomTypes();
            LoadRoomPrices();
        }

        private void LoadSeasonalPeriods()
        {
            // Dohvati podatke iz pohranjene procedure
            DataTable roomPricesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_TYPE_SEASONAL_PRICES", new SqlParameter[0]);

            // Dohvaćanje unikatnih sezonskih perioda
            var seasonalPeriods = roomPricesTable.AsEnumerable()
                .Select(row => row.Field<string>("SeasonalPeriod"))
                .Distinct()
                .ToList();

            // Brisanje postojećih stupaca
            dataGridViewPrices.Columns.Clear();

            // Dodavanje osnovnih stupaca za tipove sobe
            DataGridViewTextBoxColumn roomTypeIDColumn = new DataGridViewTextBoxColumn
            {
                Name = "RoomTypeID",
                HeaderText = "Room Type ID",
                Visible = false // Postavljanje da stupac bude nevidljiv
            };
            dataGridViewPrices.Columns.Add(roomTypeIDColumn);

            DataGridViewTextBoxColumn roomTypeNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "RoomTypeName",
                HeaderText = "Room Type Name"
            };
            dataGridViewPrices.Columns.Add(roomTypeNameColumn);

            // Dodavanje stupaca za sezonske periode
            foreach (var periodName in seasonalPeriods)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    Name = periodName,
                    HeaderText = periodName,
                    DefaultCellStyle = { Format = "C2", FormatProvider = System.Globalization.CultureInfo.CreateSpecificCulture("en-IE") } // Format za prikaz cijene kao valuta EUR
                };
                dataGridViewPrices.Columns.Add(column);
            }
        }

        private void LoadRoomTypes()
        {
            RoomTypes roomTypes = new RoomTypes();
            DataTable roomTypesTable = roomTypes.GetRoomTypes();

            foreach (DataRow row in roomTypesTable.Rows)
            {
                string roomTypeID = row["rt_id_pk"].ToString();
                string roomTypeName = row["rt_name"].ToString();

                if (dataGridViewPrices.Rows.Cast<DataGridViewRow>().All(r => r.Cells["RoomTypeID"].Value.ToString() != roomTypeID))
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dataGridViewPrices);
                    dgvRow.Cells[dataGridViewPrices.Columns["RoomTypeID"].Index].Value = roomTypeID;
                    dgvRow.Cells[dataGridViewPrices.Columns["RoomTypeName"].Index].Value = roomTypeName;
                    dataGridViewPrices.Rows.Add(dgvRow);
                }
            }
        }

        private void LoadRoomPrices()
        {
            DataTable roomPricesTable = dbConnection.ExecuteStoredProcedure("Get_ROOM_TYPE_SEASONAL_PRICES", new SqlParameter[0]);

            foreach (DataRow row in roomPricesTable.Rows)
            {
                string roomTypeID = row["RoomTypeID"].ToString();
                string seasonalPeriod = row["SeasonalPeriod"].ToString();
                decimal price = Convert.ToDecimal(row["rtsp_price"]);

                // Pronađite redak za RoomTypeID
                DataGridViewRow dgvRow = dataGridViewPrices.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["RoomTypeID"].Value.ToString() == roomTypeID);

                if (dgvRow != null)
                {
                    // Provjerite ako stupac za sezonski period postoji
                    if (dataGridViewPrices.Columns.Contains(seasonalPeriod))
                    {
                        dgvRow.Cells[seasonalPeriod].Value = price;
                    }
                }
            }
        }

        private void btn_add_prices_Click(object sender, EventArgs e)
        {
            RoomTypeSeasonalPrices_AddNewForm addNewRoomTypeSeasonalPriceForm = new RoomTypeSeasonalPrices_AddNewForm();
            addNewRoomTypeSeasonalPriceForm.Show();
        }

        private void btn_update_price_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrices.SelectedCells.Count > 0)
            {
                RoomType_SeasonalPrices roomType_SeasonalPrices = new RoomType_SeasonalPrices();

                DataGridViewCell selectedCell = dataGridViewPrices.SelectedCells[0];
                int rowIndex = selectedCell.RowIndex;
                int columnIndex = selectedCell.ColumnIndex;

                // Dohvati podatke iz odabrane ćelije
                int roomTypeID = Convert.ToInt32(dataGridViewPrices.Rows[rowIndex].Cells["RoomTypeID"].Value);
                string seasonName = dataGridViewPrices.Columns[columnIndex].HeaderText;
                decimal currentPrice = selectedCell.Value != null ? Convert.ToDecimal(selectedCell.Value) : 0;

                // Nađi odgovarajući ID sezonskog perioda
                int seasonalPeriodID = GetSeasonalPeriodIDFromColumnName(seasonName);

                // Dobij ID retka koristeći funkciju GetIDByDetails
                int rowID = roomType_SeasonalPrices.GetIDByDetails(roomTypeID, seasonalPeriodID, currentPrice);

                // Ako ID nije pronađen, prikaži poruku o grešci
                if (rowID == -1)
                {
                    MessageBox.Show("Ne mogu pronaći ID za odabrane detalje.");
                    return;
                }

                // Kreiraj instancu RoomType_SeasonalPrices s dobivenim ID-em
                var roomTypeSeasonalPrice = new RoomType_SeasonalPrices(rowID, roomTypeID, seasonalPeriodID, currentPrice);

                // Otvori formu za ažuriranje
                using (var updateForm = new RoomTypeSeasonalPrices_UpdateForm(roomTypeSeasonalPrice))
                {
                    if (updateForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal updatedPrice = updateForm.selectedRoomTypeSeasonalPrice.Price;
                        // Pozovi metodu za spremanje promjena u bazu podataka
                        UpdateRoomPriceInDatabase(rowID, updatedPrice);

                        // Osvježi sve podatke u DataGridView
                        RefreshPricesTable();
                    }
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite ćeliju iz stupaca za zimu, ljeto ili jesen za ažuriranje cijene.");
            }
        }


        public int GetSeasonalPeriodIDFromColumnName(string seasonName)
        {
            int id = -1;
            dbConnection = new DBConnection();

            using (var connection = dbConnection.GetConnection())
            {
                string query = "SELECT sp_id_pk FROM SEASONAL_PERIODS WHERE sp_name = @sp_name";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@sp_name", SqlDbType.NVarChar) { Value = seasonName });

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }

            return id;
        }


        private void UpdateRoomPriceInDatabase(int rowID, decimal newPrice)
        {
            using (var connection = dbConnection.GetConnection())
            {
                string procedureName = "Update_ROOM_TYPE_SEASONAL_PRICE";

                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Define the parameters for the stored procedure
                    command.Parameters.Add(new SqlParameter("@rtsp_id_pk", SqlDbType.Int) { Value = rowID });
                    command.Parameters.Add(new SqlParameter("@rtsp_price", SqlDbType.Decimal) { Value = newPrice });

                    connection.Open();
                    command.ExecuteNonQuery(); // Execute the stored procedure
                }
            }
        }

        private void btn_delete_price_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrices.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridViewPrices.SelectedCells[0];
                int rowIndex = selectedCell.RowIndex;

                RoomType_SeasonalPrices roomType_SeasonalPrices = new RoomType_SeasonalPrices();

                // Dohvati podatke iz odabrane ćelije
                int roomTypeID = Convert.ToInt32(dataGridViewPrices.Rows[rowIndex].Cells["RoomTypeID"].Value);
                string seasonName = dataGridViewPrices.Columns[selectedCell.ColumnIndex].HeaderText;
                decimal currentPrice = selectedCell.Value != null ? Convert.ToDecimal(selectedCell.Value) : 0;

                // Nađi odgovarajući ID sezonskog perioda
                int seasonalPeriodID = GetSeasonalPeriodIDFromColumnName(seasonName);

                // Dobij ID retka koristeći funkciju GetIDByDetails
                int rowID = roomType_SeasonalPrices.GetIDByDetails(roomTypeID, seasonalPeriodID, currentPrice);

                // Ako ID nije pronađen, prikaži poruku o grešci
                if (rowID == -1)
                {
                    MessageBox.Show("Ne mogu pronaći ID za odabrane detalje.");
                    return;
                }

                // Potvrda brisanja
                var confirmResult = MessageBox.Show("Jeste li sigurni da želite izbrisati ovu cijenu?", "Potvrda brisanja", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Pozovite metodu za brisanje
                    DeleteRoomPriceFromDatabase(rowID);

                    // Osvježite sve podatke u DataGridView
                    RefreshPricesTable();
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite ćeliju iz stupaca za zimu, ljeto ili jesen za brisanje cijene.");
            }
        }
        
        private void DeleteRoomPriceFromDatabase(int rowID)
        {
            using (var connection = dbConnection.GetConnection())
            {
                string procedureName = "Delete_ROOM_TYPE_SEASONAL_PRICE";

                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Definišite parametar za spremljenu proceduru
                    command.Parameters.Add(new SqlParameter("@rtsp_id_pk", SqlDbType.Int) { Value = rowID });

                    connection.Open();
                    command.ExecuteNonQuery(); // Izvrši spremljenu proceduru
                }
            }
        }


    }
}
