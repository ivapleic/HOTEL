using HotelApp.classes_main;
using System;
using System.Drawing;
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
            //SetGUI.InitializeFormGUI(this, employee);
        }

        bool managementExpand = false;

        private void managementTransition_Tick(object sender, EventArgs e)
        {
            if (!managementExpand)
            {
                MngmtPanel.Height += 10;
                if (MngmtPanel.Height >= 165)
                {
                    managementTransition.Stop();
                    managementExpand = true;
                }
            }
            else
            {
                MngmtPanel.Height -= 10;
                if (MngmtPanel.Height <= 53)
                {
                    managementTransition.Stop();
                    managementExpand = false;
                }
            }
        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            managementTransition.Start();
        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 265)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
