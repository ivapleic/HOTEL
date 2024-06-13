using HotelApp.classes_main;
using HotelApp.forms;
using HotelApp.forms_main;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HotelApp.classes
{
    internal class SetGUI
    {
        private static Employee employee; 
        public static void InitializeFormGUI(Form form, Employee employee)
        {
            SetGUI.employee = employee;
            InitializeNavBar(form);
            InitializeFooter(form, employee);
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

            SetStyleButtons(new Button[] { btnMenu, btnManagement, btnReservations, btnInformations });


            //Creating subpanels
            Panel subpanelMenu = CreateSubpanel(form, panel_Navbar,btnMenu);
            Panel subpanelManagement = CreateSubpanel(form, panel_Navbar,btnManagement);
            Panel subpanelReservations = CreateSubpanel(form, panel_Navbar,btnReservations);
            Panel subpanelInformations = CreateSubpanel(form, panel_Navbar,btnInformations);

            //Connecting the buttons with subpanels
            ConnectMouseEvents(btnMenu, subpanelMenu);
            ConnectMouseEvents(btnManagement, subpanelManagement);
            ConnectMouseEvents(btnReservations, subpanelReservations);
            ConnectMouseEvents(btnInformations, subpanelInformations);

            //Buttons in Menu form
            Button btnDashboard = CreateButton("Dashboard");
            Button btnLogOff = CreateButton("Log Off");
            Button btnExit = CreateButton("Exit");
            subpanelMenu.Controls.AddRange(new Control[] { btnDashboard,btnLogOff, btnExit });

            //Buttons in Management form
            Button btnRooms = CreateButton("Rooms");
            Button btnFloors = CreateButton("Floors");
            subpanelManagement.Controls.AddRange(new Control[] { btnRooms, btnFloors });

            //Buttons in Reservations form
            Button btnSeeAllReservations = CreateButton("See All Reservations");
            Button btnMakeReservation = CreateButton("Make a Reservation");
            subpanelReservations.Controls.AddRange(new Control[] { btnSeeAllReservations, btnMakeReservation });

            //Buttons in Informations form
            Button btnAboutUs = CreateButton("About Us");
            Button btnHelp = CreateButton("Help");
            subpanelInformations.Controls.AddRange(new Control[] { btnAboutUs, btnHelp });

            // Connect button click events for subpanel buttons
            btnDashboard.Click += (sender, e) => ReturnToDashboard(form);
            btnLogOff.Click += (sender, e) => LogOff(form);
            btnExit.Click += (sender, e) => Application.Exit();

            btnRooms.Click += (sender, e) => OpenRoomsForm(form);
            //btnFloors.Click += (sender, e) => OpenFloorsForm();

            //btnSeeAllReservations.Click += (sender, e) => OpenSeeAllReservationsForm();
            //btnMakeReservation.Click += (sender, e) => OpenMakeReservationForm();

            //btnAboutUs.Click += (sender, e) => OpenAboutUsForm();
            //btnHelp.Click += (sender, e) => OpenHelpForm();

        }

        public static void InitializeFooter(Form form, Employee employee)
        {
            Panel panel_Footer = new Panel
            {
                BackColor = Color.FromArgb(28, 78, 128),
                Dock = DockStyle.Bottom,
                Height = 70
            };

            Label label_UserName = new Label
            {
                Text = "User: " + $"{employee.FirstName} {employee.LastName}",
                Font = new Font("Century Gothic", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true,
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
                Margin = new Padding(5, 0, 0, 0)
            };
            label_UserName.Location = new Point(10, panel_Footer.Height / 2 - label_UserName.Height / 2);

            Label label_DateTime = new Label
            {
                Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"),
                Font = new Font("Century Gothic", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleRight,
                AutoSize = true,
                Anchor = AnchorStyles.Right| AnchorStyles.Bottom,
                Margin = new Padding(0, 0, 5, 0)
            };

            label_DateTime.Location = new Point(panel_Footer.Width - label_DateTime.Width - 110, panel_Footer.Height / 2 - label_DateTime.Height / 2);


            InitializeTimer(label_DateTime);

            panel_Footer.Controls.AddRange(new Control[] { label_UserName, label_DateTime });

            form.Controls.Add(panel_Footer);
        }

        private static void InitializeTimer(Label label_DateTime)
        {
            System.Windows.Forms.Timer timerTime = new System.Windows.Forms.Timer();
            timerTime.Interval = 1000;
            timerTime.Tick += (sender, e) => label_DateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            timerTime.Start();
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
                Size = new Size(160,65),
                Cursor = Cursors.Hand
            };

            return button;
        }

        private static void SetStyleButtons(Button[] buttons)
        {
            int buttonWidth = 160; 
            int spacing = 10; 
            int startX = 10;

            for (int i = 0; i < buttons.Length; i++)
            {
                Button button = buttons[i];
                button.Location = new Point(startX + i * (buttonWidth + spacing), 10);
                button.Size = new Size(buttonWidth, 40);
                button.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Cursor = Cursors.Hand;
            }
        }

        private static Panel CreateSubpanel(Form form, Control parent, Button button)
        {
            int panelX = button.Location.X;
            int panelY = button.Bottom;
            Panel subpanel = new Panel
            {
                BackColor = Color.FromArgb(28, 78, 128),
                Size = new Size(160, 300),
                Location = new Point(panelX, panelY),
                Visible = false
            };

            form.Controls.Add(subpanel);
            subpanel.BringToFront(); 
            return subpanel;
        }

        private static void ConnectMouseEvents(Button button, Panel subpanel)
        {
            button.MouseClick += (s, e) =>
            {
                if (subpanel.Visible)
                {
                    MakePanelNonVisible(subpanel);
                }
                else
                {
                    MakePanelVisible(subpanel);
                }
            };
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
                if (control is Panel otherPanel && otherPanel != visiblePanel)
                {
                    if (otherPanel.Tag?.ToString() == "SubPanel" && otherPanel.Visible)
                    {
                        otherPanel.Visible = false;
                    }
                }
            }
        }

        private static bool MouseIsOverPanelOrButton(Panel panel)
        {
            return panel.ClientRectangle.Contains(panel.PointToClient(Control.MousePosition))
                || panel.Parent.Controls.OfType<Button>().Any(button =>
                    button.ClientRectangle.Contains(button.PointToClient(Control.MousePosition)));
        }

        private static void SetStyleSecondaryButtons(Button[] buttons, Panel subpanel)
        {
            int buttonWidth = 160;
            int spacing = 10;
            int startY = 50;

            for (int i = 0; i < buttons.Length; i++)
            {
                Button button = buttons[i];
                button.Location = new Point(10, startY + i * (button.Height + spacing));
                button.Size = new Size(buttonWidth, 40);
                button.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Cursor = Cursors.Hand;

                subpanel.Controls.Add(button);
            }
        }
        private static void ReturnToDashboard(Form form)
        {
            Form userForm = new UserForm(employee);
            userForm.Show();
            form.Close();
            
        }
        private static void LogOff(Form form)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            form.Close(); 
        }

        private static void OpenRoomsForm(Form form)
        {
            RoomsForm roomForm = new RoomsForm();
            roomForm.Show();
            form.Close();
        }

    }
}
