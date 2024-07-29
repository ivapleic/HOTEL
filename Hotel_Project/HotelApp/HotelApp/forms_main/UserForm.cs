using HotelApp.classes;
using HotelApp.classes_main;
using HotelApp.forms;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp.forms_main
{
    public partial class UserForm : Form
    {
        RoomsForm roomsForm;
        Form_Floors floorsForm;
        Form_Dashboard dashboardForm;
        Form_RoomsAccessories roomsAccessoriesForm;
        RoomTypesForm roomTypesForm;
        Employee employee;
        public UserForm()
        {
            InitializeComponent();
        }

        public UserForm(Employee employee) : this()
        {
            employee = employee;
        }

        bool managementExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        private void managementTransition_Tick(object sender, EventArgs e)
        {
            if (!managementExpand)
            {
                pnl_management.Height += 10;
                if (pnl_management.Height >= 323)
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

        private void ShowFormInPanel(Form form)
        {
            // Remove all controls from the panel
            main_panel.Controls.Clear();

            // Set form properties
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add form to the panel
            main_panel.Controls.Add(form);
            main_panel.Tag = form;

            // Show form
            form.Show();
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
            }
            ShowFormInPanel(roomsForm);
        }

        private void RoomsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            roomsForm = null;
        }

        private void btn_floors_Click(object sender, EventArgs e)
        {
            if (floorsForm == null)
            {
                floorsForm = new Form_Floors();
                floorsForm.FormClosed += Form_Floors_FormClosed;
            }
            ShowFormInPanel(floorsForm);
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (dashboardForm == null)
            {
                dashboardForm = new Form_Dashboard();
                dashboardForm.FormClosed += Form_Dashboard_FormClosed;
            }
            ShowFormInPanel(dashboardForm);
        }
        private void Form_Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void btn_room_acc_Click(object sender, EventArgs e)
        {
            if (roomsAccessoriesForm == null)
            {
                roomsAccessoriesForm = new Form_RoomsAccessories();
                roomsAccessoriesForm.FormClosed += Form_RoomAccessories_FormClosed;
            }
            ShowFormInPanel(roomsAccessoriesForm);
        }
        private void Form_RoomAccessories_FormClosed(object? sender, FormClosedEventArgs e)
        {
            roomsAccessoriesForm = null;
        }

        private void btn_room_types_Click(object sender, EventArgs e)
        {
            if (roomTypesForm == null)
            {
                roomTypesForm = new RoomTypesForm();
                roomTypesForm.FormClosed += RoomTypesForm_FormClosed;
            }
            ShowFormInPanel(roomTypesForm);
        }

        private void RoomTypesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            roomTypesForm = null;
        }
    }
}
