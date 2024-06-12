using HotelApp.classes;
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

namespace HotelApp.forms
{
    public partial class RoomsForm : Form
    {
        private Employee employee;

        public RoomsForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee; 
            SetGUI.InitializeFormGUI(this, employee);
        }
    }
}
