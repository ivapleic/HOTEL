using Azure.Core;
using HotelApp.classes_main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.user_controls
{
    public partial class ReservationService_UpdateForm : Form
    {
        public Reservation_Service selectedResService { get; set; }
        public ReservationService_UpdateForm(Reservation_Service resService)
        {
            InitializeComponent();
            AdditionalServices service = new AdditionalServices();
            AdditionalServices selectedService = service.GetServiceById(resService.ServiceID);
            this.selectedResService = resService;
            lbl_service_name.Text = selectedService.Name.ToString();
            label_service_price.Text = selectedService.Price.ToString();
            textBox_amount.Text = resService.Quantity.ToString();
            dateTimePicker_res_date.Value = resService.DateReservation;
            dateTimePicker_con_date.Value = resService.DateConsumption;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_services_Click(object sender, EventArgs e)
        {
            selectedResService.DateConsumption = dateTimePicker_con_date.Value;
            selectedResService.DateReservation = dateTimePicker_res_date.Value;
            selectedResService.Quantity = Convert.ToInt32(textBox_amount.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
