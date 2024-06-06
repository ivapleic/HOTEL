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
            btnSettings = new Button();
            btn_Informations = new Button();
            btnManagement = new Button();
            btn_Menu = new Button();
            panelFooter = new Panel();
            label_DateTime = new Label();
            label1 = new Label();
            label_UserName = new Label();
            panel_Toolbar.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Toolbar
            // 
            panel_Toolbar.BackColor = Color.FromArgb(28, 78, 128);
            panel_Toolbar.Controls.Add(btnSettings);
            panel_Toolbar.Controls.Add(btn_Informations);
            panel_Toolbar.Controls.Add(btnManagement);
            panel_Toolbar.Controls.Add(btn_Menu);
            panel_Toolbar.Dock = DockStyle.Top;
            panel_Toolbar.Location = new Point(0, 0);
            panel_Toolbar.Name = "panel_Toolbar";
            panel_Toolbar.Size = new Size(1235, 78);
            panel_Toolbar.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(528, 30);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(160, 40);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btn_Informations
            // 
            btn_Informations.Cursor = Cursors.Hand;
            btn_Informations.FlatAppearance.BorderSize = 0;
            btn_Informations.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Informations.FlatStyle = FlatStyle.Flat;
            btn_Informations.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btn_Informations.ForeColor = Color.White;
            btn_Informations.Location = new Point(361, 30);
            btn_Informations.Name = "btn_Informations";
            btn_Informations.Size = new Size(160, 40);
            btn_Informations.TabIndex = 2;
            btn_Informations.Text = "Informations";
            btn_Informations.UseVisualStyleBackColor = true;
            // 
            // btnManagement
            // 
            btnManagement.Cursor = Cursors.Hand;
            btnManagement.FlatAppearance.BorderSize = 0;
            btnManagement.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnManagement.FlatStyle = FlatStyle.Flat;
            btnManagement.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnManagement.ForeColor = Color.White;
            btnManagement.Location = new Point(197, 30);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(160, 40);
            btnManagement.TabIndex = 1;
            btnManagement.Text = "Management";
            btnManagement.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            btn_Menu.Cursor = Cursors.Hand;
            btn_Menu.FlatAppearance.BorderSize = 0;
            btn_Menu.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Menu.FlatStyle = FlatStyle.Flat;
            btn_Menu.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btn_Menu.ForeColor = Color.White;
            btn_Menu.Location = new Point(33, 30);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(160, 40);
            btn_Menu.TabIndex = 0;
            btn_Menu.Text = "Menu";
            btn_Menu.UseVisualStyleBackColor = true;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(label_DateTime);
            panelFooter.Controls.Add(label1);
            panelFooter.Controls.Add(label_UserName);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 565);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1235, 78);
            panelFooter.TabIndex = 1;
            // 
            // label_DateTime
            // 
            label_DateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_DateTime.AutoSize = true;
            label_DateTime.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DateTime.Location = new Point(942, 22);
            label_DateTime.Name = "label_DateTime";
            label_DateTime.Size = new Size(279, 34);
            label_DateTime.TabIndex = 5;
            label_DateTime.Text = "10.02.2024 12:43:33";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 34);
            label1.TabIndex = 3;
            label1.Text = "User: ";
            // 
            // label_UserName
            // 
            label_UserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_UserName.AutoSize = true;
            label_UserName.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_UserName.Location = new Point(94, 23);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(182, 34);
            label_UserName.TabIndex = 4;
            label_UserName.Text = "Ime Prezime";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1235, 643);
            Controls.Add(panelFooter);
            Controls.Add(panel_Toolbar);
            DoubleBuffered = true;
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            panel_Toolbar.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Toolbar;
        private Panel panelFooter;
        private Label label_DateTime;
        private Label label1;
        private Label label_UserName;
        private Button btnSettings;
        private Button btn_Informations;
        private Button btnManagement;
        private Button btn_Menu;
    }
}