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
            navbar = new Panel();
            btnHam = new Button();
            sideBar = new Panel();
            MngmtPanel = new Panel();
            button6 = new Button();
            button7 = new Button();
            btn_management = new Button();
            SettingsPanel = new Panel();
            btnSettings = new Button();
            AboutPanel = new Panel();
            btnAbout = new Button();
            LogoutPanel = new Panel();
            btnLogout = new Button();
            dashboardPanel = new Panel();
            btnDashboard = new Button();
            managementTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            navbar.SuspendLayout();
            sideBar.SuspendLayout();
            MngmtPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            AboutPanel.SuspendLayout();
            LogoutPanel.SuspendLayout();
            dashboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(28, 78, 128);
            navbar.Controls.Add(btnHam);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(1580, 64);
            navbar.TabIndex = 0;
            // 
            // btnHam
            // 
            btnHam.BackgroundImage = (Image)resources.GetObject("btnHam.BackgroundImage");
            btnHam.FlatAppearance.BorderSize = 0;
            btnHam.FlatStyle = FlatStyle.Flat;
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(12, 12);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(47, 42);
            btnHam.TabIndex = 0;
            btnHam.UseVisualStyleBackColor = true;
            btnHam.Click += btnHam_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(28, 78, 128);
            sideBar.Controls.Add(MngmtPanel);
            sideBar.Controls.Add(SettingsPanel);
            sideBar.Controls.Add(AboutPanel);
            sideBar.Controls.Add(LogoutPanel);
            sideBar.Controls.Add(dashboardPanel);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 64);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(265, 606);
            sideBar.TabIndex = 1;
            // 
            // MngmtPanel
            // 
            MngmtPanel.BackColor = Color.FromArgb(28, 78, 128);
            MngmtPanel.Controls.Add(button6);
            MngmtPanel.Controls.Add(button7);
            MngmtPanel.Controls.Add(btn_management);
            MngmtPanel.Location = new Point(0, 96);
            MngmtPanel.Name = "MngmtPanel";
            MngmtPanel.Size = new Size(268, 41);
            MngmtPanel.TabIndex = 3;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 90);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(265, 41);
            button6.TabIndex = 1;
            button6.Text = "Sub Menu 2";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 43);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(265, 41);
            button7.TabIndex = 2;
            button7.Text = "Sub Menu 1";
            button7.UseVisualStyleBackColor = true;
            // 
            // btn_management
            // 
            btn_management.FlatAppearance.BorderSize = 0;
            btn_management.FlatStyle = FlatStyle.Flat;
            btn_management.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_management.ForeColor = Color.White;
            btn_management.Image = (Image)resources.GetObject("btn_management.Image");
            btn_management.ImageAlign = ContentAlignment.MiddleLeft;
            btn_management.Location = new Point(0, 0);
            btn_management.Name = "btn_management";
            btn_management.Padding = new Padding(10, 0, 0, 0);
            btn_management.Size = new Size(265, 41);
            btn_management.TabIndex = 0;
            btn_management.Text = "Management";
            btn_management.UseVisualStyleBackColor = true;
            btn_management.Click += btn_management_Click;
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.FromArgb(28, 78, 128);
            SettingsPanel.Controls.Add(btnSettings);
            SettingsPanel.Location = new Point(0, 218);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(265, 56);
            SettingsPanel.TabIndex = 3;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(28, 78, 128);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(265, 41);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // AboutPanel
            // 
            AboutPanel.BackColor = Color.FromArgb(28, 78, 128);
            AboutPanel.Controls.Add(btnAbout);
            AboutPanel.Location = new Point(3, 156);
            AboutPanel.Name = "AboutPanel";
            AboutPanel.Size = new Size(265, 56);
            AboutPanel.TabIndex = 2;
            // 
            // btnAbout
            // 
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.White;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(10, 0, 0, 0);
            btnAbout.Size = new Size(265, 41);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // LogoutPanel
            // 
            LogoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LogoutPanel.Controls.Add(btnLogout);
            LogoutPanel.Location = new Point(0, 547);
            LogoutPanel.Name = "LogoutPanel";
            LogoutPanel.Size = new Size(265, 56);
            LogoutPanel.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(265, 41);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Controls.Add(btnDashboard);
            dashboardPanel.Location = new Point(0, 23);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(265, 56);
            dashboardPanel.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(265, 41);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
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
            // UserForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1580, 670);
            Controls.Add(sideBar);
            Controls.Add(navbar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            navbar.ResumeLayout(false);
            sideBar.ResumeLayout(false);
            MngmtPanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
            AboutPanel.ResumeLayout(false);
            LogoutPanel.ResumeLayout(false);
            dashboardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Panel sideBar;
        private Panel dashboardPanel;
        private Button btnDashboard;
        private Button btn_management;
        private Panel LogoutPanel;
        private Button btnLogout;
        private Panel AboutPanel;
        private Button btnAbout;
        private Panel SettingsPanel;
        private Button btnSettings;
        private Button button7;
        private Button button6;
        private System.Windows.Forms.Timer managementTransition;
        private Button btnHam;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel MngmtPanel;
    }
}