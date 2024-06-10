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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            panel_Toolbar = new Panel();
            btnReservations = new Button();
            btnInformations = new Button();
            btnManagement = new Button();
            btnMenu = new Button();
            label_UserName = new Label();
            label1 = new Label();
            panelFooter = new Panel();
            label_DateTime = new Label();
            subpanelMenu = new Panel();
            btnExit = new Button();
            btnLogout = new Button();
            subpanelInformations = new Panel();
            btnHelp = new Button();
            btnAbout = new Button();
            subpanelReservations = new Panel();
            button5 = new Button();
            subpanelManagement = new Panel();
            btnRooms = new Button();
            btnFloors = new Button();
            panel_Toolbar.SuspendLayout();
            panelFooter.SuspendLayout();
            subpanelMenu.SuspendLayout();
            subpanelInformations.SuspendLayout();
            subpanelReservations.SuspendLayout();
            subpanelManagement.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Toolbar
            // 
            panel_Toolbar.BackColor = Color.FromArgb(28, 78, 128);
            panel_Toolbar.Controls.Add(btnReservations);
            panel_Toolbar.Controls.Add(btnInformations);
            panel_Toolbar.Controls.Add(btnManagement);
            panel_Toolbar.Controls.Add(btnMenu);
            panel_Toolbar.Dock = DockStyle.Top;
            panel_Toolbar.Location = new Point(0, 0);
            panel_Toolbar.Name = "panel_Toolbar";
            panel_Toolbar.Size = new Size(1279, 65);
            panel_Toolbar.TabIndex = 0;
            // 
            // btnReservations
            // 
            btnReservations.Cursor = Cursors.Hand;
            btnReservations.FlatAppearance.BorderSize = 0;
            btnReservations.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReservations.FlatStyle = FlatStyle.Flat;
            btnReservations.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnReservations.ForeColor = Color.White;
            btnReservations.Location = new Point(389, 12);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(160, 40);
            btnReservations.TabIndex = 3;
            btnReservations.Text = "Reservations";
            btnReservations.UseVisualStyleBackColor = true;
            btnReservations.MouseEnter += btnReservations_MouseEnter;
            // 
            // btnInformations
            // 
            btnInformations.Cursor = Cursors.Hand;
            btnInformations.FlatAppearance.BorderSize = 0;
            btnInformations.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInformations.FlatStyle = FlatStyle.Flat;
            btnInformations.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnInformations.ForeColor = Color.White;
            btnInformations.Location = new Point(565, 12);
            btnInformations.Name = "btnInformations";
            btnInformations.Size = new Size(160, 40);
            btnInformations.TabIndex = 2;
            btnInformations.Text = "Informations";
            btnInformations.UseVisualStyleBackColor = true;
            btnInformations.MouseEnter += btnInformations_MouseEnter;
            // 
            // btnManagement
            // 
            btnManagement.Cursor = Cursors.Hand;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnManagement.ForeColor = Color.White;
            btnManagement.Location = new Point(210, 12);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(160, 40);
            btnManagement.TabIndex = 1;
            btnManagement.Text = "Management";
            btnManagement.UseVisualStyleBackColor = true;
            btnManagement.MouseEnter += btnManagement_MouseEnter;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(28, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(160, 40);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.MouseEnter += btnMenu_MouseEnter;
            // 
            // label_UserName
            // 
            label_UserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_UserName.AutoSize = true;
            label_UserName.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_UserName.Location = new Point(102, 23);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(182, 34);
            label_UserName.TabIndex = 4;
            label_UserName.Text = "Ime Prezime";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 34);
            label1.TabIndex = 3;
            label1.Text = "User: ";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(label_DateTime);
            panelFooter.Controls.Add(label_UserName);
            panelFooter.Controls.Add(label1);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 574);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1279, 78);
            panelFooter.TabIndex = 1;
            // 
            // label_DateTime
            // 
            label_DateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_DateTime.AutoSize = true;
            label_DateTime.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DateTime.Location = new Point(986, 22);
            label_DateTime.Name = "label_DateTime";
            label_DateTime.Size = new Size(279, 34);
            label_DateTime.TabIndex = 5;
            label_DateTime.Text = "10.02.2024 12:43:33";
            // 
            // subpanelMenu
            // 
            subpanelMenu.BackColor = Color.FromArgb(28, 78, 128);
            subpanelMenu.Controls.Add(btnExit);
            subpanelMenu.Controls.Add(btnLogout);
            subpanelMenu.Font = new Font("Segoe UI", 8F);
            subpanelMenu.Location = new Point(28, 65);
            subpanelMenu.Name = "subpanelMenu";
            subpanelMenu.Size = new Size(160, 180);
            subpanelMenu.TabIndex = 2;
            subpanelMenu.MouseEnter += subpanelMenu_MouseEnter;
            subpanelMenu.MouseLeave += subpanelMenu_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(0, 46);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // subpanelInformations
            // 
            subpanelInformations.BackColor = Color.FromArgb(28, 78, 128);
            subpanelInformations.Controls.Add(btnHelp);
            subpanelInformations.Controls.Add(btnAbout);
            subpanelInformations.Font = new Font("Segoe UI", 8F);
            subpanelInformations.Location = new Point(565, 65);
            subpanelInformations.Name = "subpanelInformations";
            subpanelInformations.Size = new Size(160, 180);
            subpanelInformations.TabIndex = 3;
            subpanelInformations.MouseEnter += subpanelInformations_MouseEnter;
            subpanelInformations.MouseLeave += subpanelInformations_MouseLeave;
            // 
            // btnHelp
            // 
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(0, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(160, 40);
            btnHelp.TabIndex = 2;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(0, 49);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(160, 40);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // subpanelReservations
            // 
            subpanelReservations.BackColor = Color.FromArgb(28, 78, 128);
            subpanelReservations.Controls.Add(button5);
            subpanelReservations.Font = new Font("Segoe UI", 8F);
            subpanelReservations.Location = new Point(389, 65);
            subpanelReservations.Name = "subpanelReservations";
            subpanelReservations.Size = new Size(160, 180);
            subpanelReservations.TabIndex = 3;
            subpanelReservations.MouseEnter += subpanelReservations_MouseEnter;
            subpanelReservations.MouseLeave += subpanelReservations_MouseLeave;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(160, 60);
            button5.TabIndex = 1;
            button5.Text = "Make reservation";
            button5.UseVisualStyleBackColor = true;
            // 
            // subpanelManagement
            // 
            subpanelManagement.BackColor = Color.FromArgb(28, 78, 128);
            subpanelManagement.Controls.Add(btnRooms);
            subpanelManagement.Controls.Add(btnFloors);
            subpanelManagement.Font = new Font("Segoe UI", 8F);
            subpanelManagement.Location = new Point(210, 65);
            subpanelManagement.Name = "subpanelManagement";
            subpanelManagement.Size = new Size(160, 180);
            subpanelManagement.TabIndex = 3;
            subpanelManagement.MouseEnter += subpanelManagement_MouseEnter;
            subpanelManagement.MouseLeave += subpanelManagement_MouseLeave;
            // 
            // btnRooms
            // 
            btnRooms.Cursor = Cursors.Hand;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(0, 0);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(160, 40);
            btnRooms.TabIndex = 2;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnFloors
            // 
            btnFloors.Cursor = Cursors.Hand;
            btnFloors.FlatAppearance.BorderSize = 0;
            btnFloors.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFloors.FlatStyle = FlatStyle.Flat;
            btnFloors.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnFloors.ForeColor = Color.White;
            btnFloors.Location = new Point(0, 46);
            btnFloors.Name = "btnFloors";
            btnFloors.Size = new Size(160, 40);
            btnFloors.TabIndex = 1;
            btnFloors.Text = "Floors";
            btnFloors.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1279, 652);
            Controls.Add(subpanelInformations);
            Controls.Add(subpanelManagement);
            Controls.Add(subpanelReservations);
            Controls.Add(subpanelMenu);
            Controls.Add(panelFooter);
            Controls.Add(panel_Toolbar);
            DoubleBuffered = true;
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            panel_Toolbar.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            subpanelMenu.ResumeLayout(false);
            subpanelInformations.ResumeLayout(false);
            subpanelReservations.ResumeLayout(false);
            subpanelManagement.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Toolbar;
        private Panel panelFooter;
        private Label label_DateTime;
        private Label label1;
        private Label label_UserName;
        private Button btnReservations;
        private Button btnInformations;
        private Button btnManagement;
        private Button btnMenu;
        private Panel subpanelReservations;
        private Panel subpanelMenu;
        private Panel subpanelInformations;
        private Panel subpanelManagement;
        private Button btnExit;
        private Button btnLogout;
        private Button btnRooms;
        private Button btnFloors;
        private Button btnHelp;
        private Button btnAbout;
        private Button button5;
    }
}