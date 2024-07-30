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
    public partial class RoomAcc_UpdateForm : Form
    {
        public RoomAcc_UpdateForm(RoomAccessory selectedAccessory)
        {
            InitializeComponent();
            this.SelectedAccessory = selectedAccessory;
            txtBox_accName.Text = selectedAccessory.Name;
        }

        public RoomAccessory SelectedAccessory { get; private set; }

        private void btn_save_Click(object sender, EventArgs e)
        {

            SelectedAccessory.Name = txtBox_accName.Text;

            // Zatvori formu s rezultatom OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
