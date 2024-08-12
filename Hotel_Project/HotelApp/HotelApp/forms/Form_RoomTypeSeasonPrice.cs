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

        }
    }
}
