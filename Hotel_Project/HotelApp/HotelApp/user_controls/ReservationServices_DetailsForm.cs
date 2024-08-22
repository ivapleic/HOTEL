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
    public partial class ReservationServices_DetailsForm : Form
    {
        public ReservationServices_DetailsForm(Reservation_Service resService)
        {
            InitializeComponent();
            AdditionalServices service = new AdditionalServices();
            AdditionalServices selectedService = service.GetServiceById(resService.ServiceID);
            lbl_service_name.Text = selectedService.Name.ToString();
            label_service_price.Text = selectedService.Price.ToString();
            label_service_amount.Text = resService.Quantity.ToString();
            label_con_date.Text = resService.DateConsumption.ToString();
            label_res_date.Text = resService.DateReservation.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
