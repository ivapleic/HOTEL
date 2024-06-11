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
        private System.Windows.Forms.Timer timerTime;

        public UserForm()
        {
            InitializeComponent();
            label_UserName.Text = "";
            label_DateTime.Text = "";
            InitializeTimer();

            subpanelMenu.Visible = false;
            subpanelManagement.Visible = false;
            subpanelReservations.Visible = false;
            subpanelInformations.Visible = false;
        }
        public UserForm(Employee employee) : this()
        {
            label_UserName.Text = $"{employee.FirstName} {employee.LastName}";
        }

        #region Timer

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

        #endregion

        #region Panel Visibility

        private void MakePanelVisible(Panel panel)
        {
            panel.Visible = true;
            HideOtherSubmenus(panel);
        }

        private void MakePanelNonVisible(Panel panel)
        {
            panel.Visible = false;
        }

        private void HideOtherSubmenus(Panel visiblePanel)
        {
            if (subpanelMenu != visiblePanel && !MouseIsOverPanelOrButton(subpanelMenu)) subpanelMenu.Visible = false;
            if (subpanelManagement != visiblePanel && !MouseIsOverPanelOrButton(subpanelManagement)) subpanelManagement.Visible = false;
            if (subpanelReservations != visiblePanel && !MouseIsOverPanelOrButton(subpanelReservations)) subpanelReservations.Visible = false;
            if (subpanelInformations != visiblePanel && !MouseIsOverPanelOrButton(subpanelInformations)) subpanelInformations.Visible = false;
        }

        #endregion

        #region Mouse Event Handlers

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelMenu);
        }

        private void subpanelMenu_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelMenu);
        }

        private void subpanelMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverPanelOrButton(subpanelMenu))
            {
                MakePanelNonVisible(subpanelMenu);
            }
        }

        private void btnManagement_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelManagement);
        }

        private void subpanelManagement_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelManagement);
        }

        private void subpanelManagement_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverPanelOrButton(subpanelManagement))
            {
                MakePanelNonVisible(subpanelManagement);
            }
        }

        private void btnReservations_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelReservations);
        }

        private void subpanelReservations_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelReservations);
        }

        private void subpanelReservations_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverPanelOrButton(subpanelReservations))
            {
                MakePanelNonVisible(subpanelReservations);
            }
        }

        private void btnInformations_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelInformations);
        }

        private void subpanelInformations_MouseEnter(object sender, EventArgs e)
        {
            MakePanelVisible(subpanelInformations);
        }

        private void subpanelInformations_MouseLeave(object sender, EventArgs e)
        {
            if (!MouseIsOverPanelOrButton(subpanelInformations))
            {
                MakePanelNonVisible(subpanelInformations);
            }
        }

        #endregion

        #region Helper Method

        private bool MouseIsOverPanelOrButton(Panel panel)
        {
            return panel.ClientRectangle.Contains(panel.PointToClient(Control.MousePosition))
                || panel.ClientRectangle.Contains(panel.PointToClient(panel.Parent.PointToClient(Control.MousePosition)));
        }

        #endregion

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }
    }
}
