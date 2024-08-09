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
    public partial class AddServices_UpdateForm : Form
    {
        public AdditionalServices selectedService { get; set; }
        public AddServices_UpdateForm(AdditionalServices selectedService)
        {
            InitializeComponent();
            this.selectedService = selectedService;
            txtServiceName.Text = selectedService.Name;
            txtServicePrice.Text = selectedService.Price.ToString();
            txtServiceDescription.Text = selectedService.Description;


        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            selectedService.Name = txtServiceName.Text;
            selectedService.Price = Convert.ToDecimal(txtServicePrice.Text);
            selectedService.Description = txtServiceDescription.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
