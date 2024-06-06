using HotelApp.classes_main;
using HotelApp.forms_items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp.forms_main
{
    public partial class UserForm : Form
    {
        private System.Windows.Forms.Timer timerTime;
        public UserForm()
        {
            InitializeComponent();
            InitializeDropDownMenus();
            label_UserName.Text = "";
            label_DateTime.Text = "";
            InitializeTimer();
            InitializeDropDownMenus();
        }

        public UserForm(Employee employee) : this()
        {
            label_UserName.Text = $"{employee.FirstName} {employee.LastName}";
        }

        private void InitializeTimer()
        {
            timerTime = new System.Windows.Forms.Timer();
            timerTime.Interval = 1000;
            timerTime.Tick += TimerTime_Tick;
            timerTime.Start();
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            label_DateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void InitializeDropDownMenus()
        {
            // Kreirajte DropDownMenu instance
            DropDownMenu managementMenu = new DropDownMenu(btnManagement, new List<string> { "Rooms", "Floors", "Tariff Types" });
            DropDownMenu settingsMenu = new DropDownMenu(btnSettings, new List<string> { "Preferences", "User Settings" });

            // Dodajte panele na formu
            this.Controls.Add(managementMenu.GetMenuPanel());
            this.Controls.Add(settingsMenu.GetMenuPanel());
        }


    }
}
