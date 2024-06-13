using HotelApp.classes_main;
using HotelApp.forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp.forms_main
{
    public partial class UserForm : Form
    {
        RoomsForm roomsForm;
        Form_Floors floorsForm;
        Employee employee;
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(Employee employee) : this()
        {
            //SetGUI.InitializeFormGUI(this, employee);
            employee = employee;
        }

        bool managementExpand = false;

        private void managementTransition_Tick(object sender, EventArgs e)
        {
            if (!managementExpand)
            {
                pnl_management.Height += 10;
                if (pnl_management.Height >= 188)
                {
                    managementTransition.Stop();
                    managementExpand = true;
                }
            }
            else
            {
                pnl_management.Height -= 10;
                if (pnl_management.Height <= 56)
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
                pnl_sidebar.Width -= 10;
                if (pnl_sidebar.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnl_dashboard.Width = pnl_sidebar.Width;
                    pnl_management.Width = pnl_sidebar.Width;
                    pnl_about.Width = pnl_sidebar.Width;
                    pnl_settings.Width = pnl_sidebar.Width;
                    pnl_logout.Width = pnl_sidebar.Width;
                }
            }
            else
            {
                pnl_sidebar.Width += 10;
                if (pnl_sidebar.Width >= 265)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnl_dashboard.Width = pnl_sidebar.Width;
                    pnl_management.Width = pnl_sidebar.Width;
                    pnl_about.Width = pnl_sidebar.Width;
                    pnl_settings.Width = pnl_sidebar.Width;
                    pnl_logout.Width = pnl_sidebar.Width;
                }

            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_rooms_Click(object sender, EventArgs e)
        {
            if (roomsForm == null)
            {
                roomsForm = new RoomsForm();
                roomsForm.FormClosed += RoomsForm_FormClosed;
                roomsForm.MdiParent = this;
                roomsForm.Dock = DockStyle.Fill;
                roomsForm.Show();
            }
            else
            {
                roomsForm.Activate();
            }
        }

        private void RoomsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            roomsForm = null;
        }

        private void btn_floors_Click(object sender, EventArgs e)
        {
            if (roomsForm == null)
            {
                floorsForm = new Form_Floors();
                floorsForm.FormClosed += Form_Floors_FormClosed;
                floorsForm.MdiParent = this;
                floorsForm.Dock = DockStyle.Fill;
                floorsForm.Show();
            }
            else
            {
                floorsForm.Activate();
            }
        }
        private void Form_Floors_FormClosed(object? sender, FormClosedEventArgs e)
        {
            floorsForm = null;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
