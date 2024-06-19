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
    public partial class Floor_UpdateForm : Form
    {
        public Floor SelectedFloor { get; private set; }

        public Floor_UpdateForm(Floor floor)
        {
            InitializeComponent();
            this.SelectedFloor = floor;
            // Postavi trenutne podatke u TextBox kontrole
            txtBox_floorNumber.Text = floor.Number.ToString();
            txtBox_floorDescription.Text = floor.Description;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validacija unosa
            if (!int.TryParse(txtBox_floorNumber.Text, out int newFloorNumber))
            {
                MessageBox.Show("Neispravan unos za broj kata.");
                return;
            }

            SelectedFloor.Number = newFloorNumber;
            SelectedFloor.Description = txtBox_floorDescription.Text;

            // Zatvori formu s rezultatom OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
