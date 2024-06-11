using HotelApp.classes_main;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp.classes
{
    internal class SetGUI
    {
        public static void InitializeForm(Form form, Employee employee)
        {
            InitializeNavBar(form);
            //InitializeFooter(form, employee);
        }

        public static void InitializeNavBar(Form form)
        {
            //Creating the main panel for the NavBar
            Panel panel_Navbar = new Panel
            {
                BackColor = Color.FromArgb(28, 78, 128),
                Dock = DockStyle.Top,
                Size = new Size(1279, 65)
            };

            //Creating the main buttons in NavBar
            Button btnMenu = CreateButton("Menu");
            Button btnManagement = CreateButton("Management");
            Button btnReservations = CreateButton("Reservations");
            Button btnInformations = CreateButton("Informations");

            //Connecting buttons with the panel
            panel_Navbar.Controls.AddRange(new Control[] { btnMenu, btnManagement, btnReservations, btnInformations });

            //connecting the panel with the form
            form.Controls.Add(panel_Navbar);

            //Creating subpanels
            Panel subpanelMenu = CreateSubpanel(form, panel_Navbar);
            Panel subpanelManagement = CreateSubpanel(form, panel_Navbar);
            Panel subpanelReservations = CreateSubpanel(form, panel_Navbar);
            Panel subpanelInformations = CreateSubpanel(form, panel_Navbar);

            //Connecting the buttons with subpanels
            ConnectMouseEvents(btnMenu, subpanelMenu);
            ConnectMouseEvents(btnManagement, subpanelManagement);
            ConnectMouseEvents(btnReservations, subpanelReservations);
            ConnectMouseEvents(btnInformations, subpanelInformations);

        }

        private static Button CreateButton(string text)
        {

            Button button = new Button
            {
                Text = text,
                Font = new Font("Century Gothic", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(160, 40),
                Cursor = Cursors.Hand
            };

            return button;
        }

        private static Panel CreateSubpanel(Form form, Control parent)
        {
            Panel subpanel = new Panel
            {
                BackColor = Color.FromArgb(28, 78, 128),
                Size = new Size(160, 180),
                Visible = false
            };

            form.Controls.Add(subpanel);
            subpanel.BringToFront(); //so other elements don't cover it
            return subpanel;
        }

        private static void ConnectMouseEvents(Button button, Panel subpanel)
        {
            button.MouseEnter += (s, e) => MakePanelVisible(subpanel);
            subpanel.MouseEnter += (s, e) => MakePanelVisible(subpanel);
            subpanel.MouseLeave += (s, e) =>
            {
                if (!MouseIsOverPanelOrButton(subpanel))
                {
                    MakePanelNonVisible(subpanel);
                }
            };
        }

        private static void MakePanelVisible(Panel panel)
        {
            panel.Visible = true;
            HideOtherSubmenus(panel);
        }

        private static void MakePanelNonVisible(Panel panel)
        {
            panel.Visible = false;
        }

        private static void HideOtherSubmenus(Panel visiblePanel)
        {
            foreach (Control control in visiblePanel.Parent.Controls)
            {
                if (control is Panel panel && panel.Tag?.ToString() == "SubPanel" && panel != visiblePanel)
                {
                    panel.Visible = false;
                }
            }
        }

        private static bool MouseIsOverPanelOrButton(Panel panel)
        {
            return panel.ClientRectangle.Contains(panel.PointToClient(Control.MousePosition))
                || panel.Parent.Controls.OfType<Button>().Any(button =>
                    button.ClientRectangle.Contains(button.PointToClient(Control.MousePosition)));
        }

    }
}
