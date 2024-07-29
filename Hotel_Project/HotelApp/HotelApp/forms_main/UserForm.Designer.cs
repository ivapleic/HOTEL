﻿namespace HotelApp.forms_main
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
            label1 = new Label();
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
            btn_room_acc = new Button();
            btn_room_types = new Button();
            pnl_exit = new Panel();
            btn_exit = new Button();
            main_panel = new Panel();
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
            pnl_navbar.BackColor = Color.FromArgb(40, 86, 182);
            pnl_navbar.Controls.Add(label1);
            pnl_navbar.Controls.Add(btn_ham);
            pnl_navbar.Dock = DockStyle.Top;
            pnl_navbar.Location = new Point(0, 0);
            pnl_navbar.Name = "pnl_navbar";
            pnl_navbar.Size = new Size(1121, 61);
            pnl_navbar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(74, 22);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // btn_ham
            // 
            btn_ham.BackgroundImage = (Image)resources.GetObject("btn_ham.BackgroundImage");
            btn_ham.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ham.FlatAppearance.BorderSize = 0;
            btn_ham.FlatStyle = FlatStyle.Flat;
            btn_ham.Location = new Point(6, 12);
            btn_ham.Name = "btn_ham";
            btn_ham.Size = new Size(62, 43);
            btn_ham.TabIndex = 0;
            btn_ham.UseVisualStyleBackColor = true;
            btn_ham.Click += btnHam_Click;
            // 
            // btn_rooms
            // 
            btn_rooms.FlatAppearance.BorderSize = 0;
            btn_rooms.FlatStyle = FlatStyle.Flat;
            btn_rooms.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_rooms.ForeColor = Color.Gray;
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
            btn_floors.BackColor = Color.FromArgb(235, 239, 241);
            btn_floors.FlatAppearance.BorderSize = 0;
            btn_floors.FlatStyle = FlatStyle.Flat;
            btn_floors.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_floors.ForeColor = Color.Gray;
            btn_floors.ImageAlign = ContentAlignment.MiddleLeft;
            btn_floors.Location = new Point(3, 65);
            btn_floors.Name = "btn_floors";
            btn_floors.Padding = new Padding(10, 0, 0, 0);
            btn_floors.Size = new Size(265, 56);
            btn_floors.TabIndex = 2;
            btn_floors.Text = "Floors";
            btn_floors.UseVisualStyleBackColor = false;
            btn_floors.Click += btn_floors_Click;
            // 
            // btn_management
            // 
            btn_management.FlatAppearance.BorderSize = 0;
            btn_management.FlatStyle = FlatStyle.Flat;
            btn_management.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_management.ForeColor = Color.Gray;
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
            pnl_settings.BackColor = Color.FromArgb(235, 239, 241);
            pnl_settings.Controls.Add(btn_settings);
            pnl_settings.ForeColor = Color.Gray;
            pnl_settings.Location = new Point(3, 134);
            pnl_settings.Name = "pnl_settings";
            pnl_settings.Size = new Size(265, 56);
            pnl_settings.TabIndex = 3;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.FromArgb(235, 239, 241);
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_settings.ForeColor = Color.Gray;
            btn_settings.Image = (Image)resources.GetObject("btn_settings.Image");
            btn_settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_settings.Location = new Point(0, 3);
            btn_settings.Name = "btn_settings";
            btn_settings.Padding = new Padding(10, 0, 0, 0);
            btn_settings.Size = new Size(265, 56);
            btn_settings.TabIndex = 0;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = false;
            // 
            // pnl_about
            // 
            pnl_about.BackColor = Color.FromArgb(235, 239, 241);
            pnl_about.Controls.Add(btn_about);
            pnl_about.ForeColor = Color.Gray;
            pnl_about.Location = new Point(3, 196);
            pnl_about.Name = "pnl_about";
            pnl_about.Size = new Size(265, 56);
            pnl_about.TabIndex = 2;
            // 
            // btn_about
            // 
            btn_about.BackColor = Color.FromArgb(235, 239, 241);
            btn_about.FlatAppearance.BorderSize = 0;
            btn_about.FlatStyle = FlatStyle.Flat;
            btn_about.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_about.ForeColor = Color.Gray;
            btn_about.Image = (Image)resources.GetObject("btn_about.Image");
            btn_about.ImageAlign = ContentAlignment.MiddleLeft;
            btn_about.Location = new Point(0, 3);
            btn_about.Name = "btn_about";
            btn_about.Padding = new Padding(10, 0, 0, 0);
            btn_about.Size = new Size(265, 56);
            btn_about.TabIndex = 0;
            btn_about.Text = "About";
            btn_about.UseVisualStyleBackColor = false;
            // 
            // pnl_logout
            // 
            pnl_logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_logout.BackColor = Color.FromArgb(235, 239, 241);
            pnl_logout.Controls.Add(btn_logout);
            pnl_logout.ForeColor = Color.Gray;
            pnl_logout.Location = new Point(3, 258);
            pnl_logout.Name = "pnl_logout";
            pnl_logout.Size = new Size(265, 56);
            pnl_logout.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Gray;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(0, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(10, 0, 0, 0);
            btn_logout.Size = new Size(265, 56);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // pnl_dashboard
            // 
            pnl_dashboard.BackColor = Color.FromArgb(235, 239, 241);
            pnl_dashboard.Controls.Add(btn_dashboard);
            pnl_dashboard.ForeColor = Color.Gray;
            pnl_dashboard.Location = new Point(3, 3);
            pnl_dashboard.Name = "pnl_dashboard";
            pnl_dashboard.Size = new Size(265, 56);
            pnl_dashboard.TabIndex = 0;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.FromArgb(235, 239, 241);
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.Gray;
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 3);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard.Size = new Size(265, 56);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
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
            pnl_sidebar.BackColor = Color.FromArgb(235, 239, 241);
            pnl_sidebar.Controls.Add(pnl_dashboard);
            pnl_sidebar.Controls.Add(pnl_management);
            pnl_sidebar.Controls.Add(pnl_settings);
            pnl_sidebar.Controls.Add(pnl_about);
            pnl_sidebar.Controls.Add(pnl_logout);
            pnl_sidebar.Controls.Add(pnl_exit);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 61);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(265, 520);
            pnl_sidebar.TabIndex = 2;
            // 
            // pnl_management
            // 
            pnl_management.BackColor = Color.FromArgb(235, 239, 241);
            pnl_management.Controls.Add(btn_management);
            pnl_management.Controls.Add(btn_floors);
            pnl_management.Controls.Add(btn_rooms);
            pnl_management.Controls.Add(btn_room_acc);
            pnl_management.Controls.Add(btn_room_types);
            pnl_management.ForeColor = Color.Gray;
            pnl_management.Location = new Point(3, 65);
            pnl_management.Name = "pnl_management";
            pnl_management.Size = new Size(265, 63);
            pnl_management.TabIndex = 4;
            // 
            // btn_room_acc
            // 
            btn_room_acc.FlatAppearance.BorderSize = 0;
            btn_room_acc.FlatStyle = FlatStyle.Flat;
            btn_room_acc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_room_acc.ForeColor = Color.Gray;
            btn_room_acc.ImageAlign = ContentAlignment.MiddleLeft;
            btn_room_acc.Location = new Point(3, 189);
            btn_room_acc.Name = "btn_room_acc";
            btn_room_acc.Padding = new Padding(10, 0, 0, 0);
            btn_room_acc.Size = new Size(265, 56);
            btn_room_acc.TabIndex = 3;
            btn_room_acc.Text = "Room Accessories";
            btn_room_acc.UseVisualStyleBackColor = true;
            btn_room_acc.Click += btn_room_acc_Click;
            // 
            // btn_room_types
            // 
            btn_room_types.FlatAppearance.BorderSize = 0;
            btn_room_types.FlatStyle = FlatStyle.Flat;
            btn_room_types.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_room_types.ForeColor = Color.Gray;
            btn_room_types.ImageAlign = ContentAlignment.MiddleLeft;
            btn_room_types.Location = new Point(3, 251);
            btn_room_types.Name = "btn_room_types";
            btn_room_types.Padding = new Padding(10, 0, 0, 0);
            btn_room_types.Size = new Size(265, 56);
            btn_room_types.TabIndex = 4;
            btn_room_types.Text = "Room Types";
            btn_room_types.UseVisualStyleBackColor = true;
            btn_room_types.Click += btn_room_types_Click;
            // 
            // pnl_exit
            // 
            pnl_exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_exit.BackColor = Color.FromArgb(235, 239, 241);
            pnl_exit.Controls.Add(btn_exit);
            pnl_exit.ForeColor = Color.Gray;
            pnl_exit.Location = new Point(3, 320);
            pnl_exit.Name = "pnl_exit";
            pnl_exit.Size = new Size(265, 56);
            pnl_exit.TabIndex = 5;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(235, 239, 241);
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Gray;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(0, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Padding = new Padding(10, 0, 0, 0);
            btn_exit.Size = new Size(265, 56);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // main_panel
            // 
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(265, 61);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(856, 520);
            main_panel.TabIndex = 4;
            // 
            // UserForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1121, 581);
            Controls.Add(main_panel);
            Controls.Add(pnl_sidebar);
            Controls.Add(pnl_navbar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            pnl_navbar.ResumeLayout(false);
            pnl_navbar.PerformLayout();
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
        private Button btn_room_acc;
        private Button btn_room_types;
        private Label label1;
        private Panel main_panel;
    }
}