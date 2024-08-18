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
    public partial class Guest_DetailsForm : Form
    {
        public Guest_DetailsForm(Guest guest)
        {
            InitializeComponent();

            // Koristi ?? operator za postavljanje zadane vrijednosti ako je null
            label_first_name.Text = guest.FirstName ?? "N/A";
            label_last_name.Text = guest.LastName ?? "N/A";
            label_gender.Text = guest.Gender ?? "N/A";
            label_oib.Text = guest.OIB ?? "N/A";
            label_address.Text = guest.Address ?? "N/A";
            label_country.Text = guest.CountryName ?? "N/A";
            label_city.Text = guest.City ?? "N/A";
            label_phone.Text = guest.Phone ?? "N/A";
            label_mobile.Text = guest.Mobile ?? "N/A";
            label_description.Text = guest.Description ?? "N/A";
            label_id_name.Text = guest.IdentificationName ?? "N/A";
            label_id_number.Text = guest.IdentificationText ?? "N/A";

            // Ako je BirthDate null, postavi prazno polje ili specifičnu poruku
            label_date_birth.Text = guest.BirthDate != DateTime.MinValue ? guest.BirthDate.ToString("d") : "N/A";

            label_state_birth.Text = guest.BirthStateName ?? "N/A";
            label_place_birth.Text = guest.BirthPlace ?? "N/A";
            label_nationality.Text = guest.Nationality ?? "N/A";
            label_email.Text = guest.Email ?? "N/A";

            // Provjeri je li gost aktivan
            label_active.Text = guest.IsActive ? "Yes" : "No";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
