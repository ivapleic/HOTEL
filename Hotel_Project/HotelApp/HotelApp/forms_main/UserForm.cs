using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.forms;
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

        public UserForm()
        {
            InitializeComponent();

        }
        public UserForm(Employee employee) : this()
        {
            SetGUI.InitializeFormGUI(this, employee);
        }

    }
}
