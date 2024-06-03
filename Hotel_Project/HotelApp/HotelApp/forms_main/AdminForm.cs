using System;
using System.Windows.Forms;
using HotelApp.classes_main; // Pretpostavljam da je ovo namespace u kojem se nalazi klasa Employee

namespace HotelApp.forms_main
{
    public partial class AdminForm : Form
    {
        private System.Windows.Forms.Timer timerTime;

        public AdminForm()
        {
            InitializeComponent();
            label_UserName.Text = "";
            label_DateTime.Text = "";
            InitializeTimer();
        }

        public AdminForm(Employee employee) : this()
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
    }
}
