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
          
           
        }
        public AdminForm(Employee employee) :base()
        {
           
        }


    }
}
