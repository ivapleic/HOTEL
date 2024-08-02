using Bunifu.UI.WinForms;
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
    public partial class RoomType_UpdateForm : Form
    {
        public RoomTypes SelectedRoomType { get; private set; }
        public RoomType_UpdateForm(RoomTypes selectedRoomType)
        {
            InitializeComponent();
            this.SelectedRoomType = selectedRoomType;
            // Postavi trenutne podatke u TextBox kontrole
            txtRoomtypeName.Text = selectedRoomType.Name.ToString();
            txtNumberOfPersons.Text = selectedRoomType.NumberOfPersons.ToString();
            txtNumberOfChildren.Text = selectedRoomType.NumberOfChildren.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            SelectedRoomType.Name = txtRoomtypeName.Text;
            SelectedRoomType.NumberOfPersons = Convert.ToInt32(txtNumberOfPersons.Text);
            SelectedRoomType.NumberOfChildren = Convert.ToInt32(txtNumberOfChildren.Text);

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
