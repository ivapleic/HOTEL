using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp.modules;

namespace HotelApp.forms_main
{
    public partial class form_login : Form
    {
        // Globalna varijabla za označavanje zatvaranja forme
        public bool Form_Close_OK;

        #region STATIC_STRINGS

        // Statički stringovi
        //******************************************************************************
        public string var_frm_login_caption = "Blue Hotel login";
        //******************************************************************************
        public string var_frm_login_gbox_login = "Sigurnosna provjera";
        //******************************************************************************
        public string var_frm_login_link_help = "Pomoć";
        public string var_frm_login_link_about = "O Programu";
        public string var_frm_login_link_uvjeti_koristenja = "Uvjeti korištenja";
        public string var_frm_login_link_exit = "Izlaz";
        //******************************************************************************
        public string var_frm_login_lbl_description = "Dobrodošli u Blue Hotel, informacijski sustav za hotelijerstvo. Ovaj tekst sadrži osnovni opis programa.";
        public string var_frm_login_lbl_please_wait = "Provjera u tijeku, pričekajte...";
        //******************************************************************************
        public string var_frm_login_lbl_stat_pswd = "Lozinka:";
        public string var_frm_login_lbl_login_description = "Neki tekst o tome kako se prijaviti u sustav.";
        //******************************************************************************
        public string var_frm_login_lbl_vendor = "Plavo d.o.o.";
        public string var_frm_login_lbl_vendor_web = "www.plavo-st.hr";
        //******************************************************************************
        public string var_frm_login_btn_ok = "Prihvati";
        public string var_frm_login_btn_exit = "Izlaz";
        //******************************************************************************
        public string var_frm_login_msgBox_ErrorLogin = "Neuspješno logiranje. Pokušajte ponovno.";
        //******************************************************************************
        public string var_frm_login_msgBox_Exit_Ask = "Izlaz iz Blue Hotel programa?";
        //******************************************************************************

        #endregion

        public form_login()
        {
            InitializeComponent();

            Form_Close_OK = false;
            lbl_time.Text = "";
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbox_login_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void picBox_BlueHotel_Logo_Click(object sender, EventArgs e)
        {

        }

        private void gbox_login_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
