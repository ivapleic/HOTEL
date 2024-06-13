namespace HotelApp.forms_main
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            pnl_navbar = new Panel();
            btn_ham = new Button();
            btn_rooms = new Button();
            btn_floors = new Button();
            btn_management = new Button();
            pnl_settings = new Panel();
            btn_settings = new Button();
            pnl_about = new Panel();
            btn_about = new Button();
            pnl_logout = new Panel();
            btn_logout = new Button();
            pnl_dashboard = new Panel();
            btn_dashboard = new Button();
            managementTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            pnl_sidebar = new FlowLayoutPanel();
            pnl_management = new FlowLayoutPanel();
            pnl_exit = new Panel();
            btn_exit = new Button();
            pnl_navbar.SuspendLayout();
            pnl_settings.SuspendLayout();
            pnl_about.SuspendLayout();
            pnl_logout.SuspendLayout();
            pnl_dashboard.SuspendLayout();
            pnl_sidebar.SuspendLayout();
            pnl_management.SuspendLayout();
            pnl_exit.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_navbar
            // 
            pnl_navbar.BackColor = Color.FromArgb(28, 78, 128);
            pnl_navbar.Controls.Add(btn_ham);
            pnl_navbar.Dock = DockStyle.Top;
            pnl_navbar.Location = new Point(0, 0);
            pnl_navbar.Name = "pnl_navbar";
            pnl_navbar.Size = new Size(1121, 64);
            pnl_navbar.TabIndex = 0;
            // 
            // btn_ham
            // 
            btn_ham.BackgroundImage = (Image)resources.GetObject("btn_ham.BackgroundImage");
            btn_ham.FlatAppearance.BorderSize = 0;
            btn_ham.FlatStyle = FlatStyle.Flat;
            btn_ham.Image = (Image)resources.GetObject("btn_ham.Image");
            btn_ham.Location = new Point(12, 12);
            btn_ham.Name = "btn_ham";
            btn_ham.Size = new Size(47, 42);
            btn_ham.TabIndex = 0;
            btn_ham.UseVisualStyleBackColor = true;
            btn_ham.Click += btnHam_Click;
            // 
            // btn_rooms
            // 
            btn_rooms.FlatAppearance.BorderSize = 0;
            btn_rooms.FlatStyle = FlatStyle.Flat;
            btn_rooms.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_rooms.ForeColor = Color.White;
            btn_rooms.Image = (Image)resources.GetObject("btn_rooms.Image");
            btn_rooms.ImageAlign = ContentAlignment.MiddleLeft;
            btn_rooms.Location = new Point(3, 127);
            btn_rooms.Name = "btn_rooms";
            btn_rooms.Padding = new Padding(10, 0, 0, 0);
            btn_rooms.Size = new Size(265, 56);
            btn_rooms.TabIndex = 1;
            btn_rooms.Text = "Rooms";
            btn_rooms.UseVisualStyleBackColor = true;
            btn_rooms.Click += btn_rooms_Click;
            // 
            // btn_floors
            // 
            btn_floors.FlatAppearance.BorderSize = 0;
            btn_floors.FlatStyle = FlatStyle.Flat;
            btn_floors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_floors.ForeColor = Color.White;
            btn_floors.Image = (Image)resources.GetObject("btn_floors.Image");
            btn_floors.ImageAlign = ContentAlignment.MiddleLeft;
            btn_floors.Location = new Point(3, 65);
            btn_floors.Name = "btn_floors";
            btn_floors.Padding = new Padding(10, 0, 0, 0);
            btn_floors.Size = new Size(265, 56);
            btn_floors.TabIndex = 2;
            btn_floors.Text = "Floors";
            btn_floors.UseVisualStyleBackColor = true;
            btn_floors.Click += btn_floors_Click;
            // 
            // btn_management
            // 
            btn_management.FlatAppearance.BorderSize = 0;
            btn_management.FlatStyle = FlatStyle.Flat;
            btn_management.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_management.ForeColor = Color.White;
            btn_management.Image = (Image)resources.GetObject("btn_management.Image");
            btn_management.ImageAlign = ContentAlignment.MiddleLeft;
            btn_management.Location = new Point(3, 3);
            btn_management.Name = "btn_management";
            btn_management.Padding = new Padding(10, 0, 0, 0);
            btn_management.Size = new Size(265, 56);
            btn_management.TabIndex = 0;
            btn_management.Text = "Management";
            btn_management.UseVisualStyleBackColor = true;
            btn_management.Click += btn_management_Click;
            // 
            // pnl_settings
            // 
            pnl_settings.BackColor = Color.FromArgb(28, 78, 128);
            pnl_settings.Controls.Add(btn_settings);
            pnl_settings.Location = new Point(3, 127);
            pnl_settings.Name = "pnl_settings";
            pnl_settings.Size = new Size(265, 56);
            pnl_settings.TabIndex = 3;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.FromArgb(28, 78, 128);
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_settings.ForeColor = Color.White;
            btn_settings.Image = (Image)resources.GetObject("btn_settings.Image");
            btn_settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_settings.Location = new Point(0, 3);
            btn_settings.Name = "btn_settings";
            btn_settings.Padding = new Padding(10, 0, 0, 0);
            btn_settings.Size = new Size(265, 41);
            btn_settings.TabIndex = 0;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = false;
            // 
            // pnl_about
            // 
            pnl_about.BackColor = Color.FromArgb(28, 78, 128);
            pnl_about.Controls.Add(btn_about);
            pnl_about.Location = new Point(3, 189);
            pnl_about.Name = "pnl_about";
            pnl_about.Size = new Size(265, 56);
            pnl_about.TabIndex = 2;
            // 
            // btn_about
            // 
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_about.ForeColor = Color.White;
            btn_about.Image = (Image)resources.GetObject("btn_about.Image");
            btn_about.ImageAlign = ContentAlignment.MiddleLeft;
            btn_about.Location = new Point(0, 3);
            btn_about.Name = "btn_about";
            btn_about.Padding = new Padding(10, 0, 0, 0);
            btn_about.Size = new Size(265, 41);
            btn_about.TabIndex = 0;
            btn_about.Text = "About";
            btn_about.UseVisualStyleBackColor = true;
            // 
            // pnl_logout
            // 
            pnl_logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_logout.BackColor = Color.FromArgb(28, 78, 128);
            pnl_logout.Controls.Add(btn_logout);
            pnl_logout.Location = new Point(3, 251);
            pnl_logout.Name = "pnl_logout";
            pnl_logout.Size = new Size(265, 56);
            pnl_logout.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(0, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(10, 0, 0, 0);
            btn_logout.Size = new Size(265, 41);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // pnl_dashboard
            // 
            pnl_dashboard.BackColor = Color.FromArgb(28, 78, 128);
            pnl_dashboard.Controls.Add(btn_dashboard);
            pnl_dashboard.Location = new Point(3, 3);
            pnl_dashboard.Name = "pnl_dashboard";
            pnl_dashboard.Size = new Size(265, 56);
            pnl_dashboard.TabIndex = 0;
            // 
            // btn_dashboard
            // 
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 12);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard.Size = new Size(265, 41);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // managementTransition
            // 
            managementTransition.Interval = 10;
            managementTransition.Tick += managementTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.BackColor = Color.FromArgb(28, 78, 128);
            pnl_sidebar.Controls.Add(pnl_dashboard);
            pnl_sidebar.Controls.Add(pnl_management);
            pnl_sidebar.Controls.Add(pnl_settings);
            pnl_sidebar.Controls.Add(pnl_about);
            pnl_sidebar.Controls.Add(pnl_logout);
            pnl_sidebar.Controls.Add(pnl_exit);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 64);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(265, 517);
            pnl_sidebar.TabIndex = 2;
            // 
            // pnl_management
            // 
            pnl_management.BackColor = Color.FromArgb(28, 78, 128);
            pnl_management.Controls.Add(btn_management);
            pnl_management.Controls.Add(btn_floors);
            pnl_management.Controls.Add(btn_rooms);
            pnl_management.Location = new Point(3, 65);
            pnl_management.Name = "pnl_management";
            pnl_management.Size = new Size(265, 56);
            pnl_management.TabIndex = 4;
            // 
            // pnl_exit
            // 
            pnl_exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_exit.BackColor = Color.FromArgb(28, 78, 128);
            pnl_exit.Controls.Add(btn_exit);
            pnl_exit.Location = new Point(3, 313);
            pnl_exit.Name = "pnl_exit";
            pnl_exit.Size = new Size(265, 56);
            pnl_exit.TabIndex = 5;
            // 
            // btn_exit
            // 
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(0, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Padding = new Padding(10, 0, 0, 0);
            btn_exit.Size = new Size(265, 41);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // UserForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1121, 581);
            Controls.Add(pnl_sidebar);
            Controls.Add(pnl_navbar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            pnl_navbar.ResumeLayout(false);
            pnl_settings.ResumeLayout(false);
            pnl_about.ResumeLayout(false);
            pnl_logout.ResumeLayout(false);
            pnl_dashboard.ResumeLayout(false);
            pnl_sidebar.ResumeLayout(false);
            pnl_management.ResumeLayout(false);
            pnl_exit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_navbar;
        private Panel pnl_dashboard;
        private Button btn_dashboard;
        private Button btn_management;
        private Panel pnl_logout;
        private Button btn_logout;
        private Panel pnl_about;
        private Button btn_about;
        private Panel pnl_settings;
        private Button btn_settings;
        private Button btn_floors;
        private Button btn_rooms;
        private System.Windows.Forms.Timer managementTransition;
        private Button btn_ham;
        private System.Windows.Forms.Timer sidebarTransition;
        private FlowLayoutPanel pnl_sidebar;
        private FlowLayoutPanel pnl_management;
        private Panel pnl_exit;
        private Button btn_exit;
    }
}