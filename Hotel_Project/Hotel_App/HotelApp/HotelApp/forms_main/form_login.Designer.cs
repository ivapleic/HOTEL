namespace HotelApp.forms_main
{
    partial class form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            picBox_BlueHotel_Logo = new PictureBox();
            gbox_login = new GroupBox();
            txt_pswd = new MaskedTextBox();
            lbl_stat_pswd = new Label();
            btn_EXIT = new Button();
            btn_OK = new Button();
            lbl_time = new Label();
            link_help = new LinkLabel();
            link_about = new LinkLabel();
            link_uvjeti_koristenja = new LinkLabel();
            link_exit = new LinkLabel();
            panel_login = new Panel();
            ((System.ComponentModel.ISupportInitialize)picBox_BlueHotel_Logo).BeginInit();
            gbox_login.SuspendLayout();
            panel_login.SuspendLayout();
            SuspendLayout();
            // 
            // picBox_BlueHotel_Logo
            // 
            picBox_BlueHotel_Logo.BackColor = Color.FromArgb(0, 192, 0);
            picBox_BlueHotel_Logo.Image = (Image)resources.GetObject("picBox_BlueHotel_Logo.Image");
            picBox_BlueHotel_Logo.Location = new Point(23, 31);
            picBox_BlueHotel_Logo.Name = "picBox_BlueHotel_Logo";
            picBox_BlueHotel_Logo.Size = new Size(396, 97);
            picBox_BlueHotel_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox_BlueHotel_Logo.TabIndex = 0;
            picBox_BlueHotel_Logo.TabStop = false;
            picBox_BlueHotel_Logo.Click += picBox_BlueHotel_Logo_Click;
            // 
            // gbox_login
            // 
            gbox_login.BackColor = Color.FromArgb(252, 252, 252);
            gbox_login.Controls.Add(txt_pswd);
            gbox_login.Controls.Add(lbl_stat_pswd);
            gbox_login.Controls.Add(btn_EXIT);
            gbox_login.Controls.Add(btn_OK);
            gbox_login.Location = new Point(286, 29);
            gbox_login.Margin = new Padding(4, 3, 4, 3);
            gbox_login.Name = "gbox_login";
            gbox_login.Size = new Size(599, 324);
            gbox_login.TabIndex = 3;
            gbox_login.TabStop = false;
            gbox_login.Text = "Log in";
            gbox_login.Enter += gbox_login_Enter_1;
            // 
            // txt_pswd
            // 
            txt_pswd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_pswd.Location = new Point(195, 50);
            txt_pswd.Name = "txt_pswd";
            txt_pswd.Size = new Size(341, 31);
            txt_pswd.TabIndex = 0;
            txt_pswd.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // lbl_stat_pswd
            // 
            lbl_stat_pswd.AutoSize = true;
            lbl_stat_pswd.ForeColor = Color.Black;
            lbl_stat_pswd.Location = new Point(77, 53);
            lbl_stat_pswd.Name = "lbl_stat_pswd";
            lbl_stat_pswd.Size = new Size(91, 25);
            lbl_stat_pswd.TabIndex = 1;
            lbl_stat_pswd.Text = "Password:";
            lbl_stat_pswd.TextAlign = ContentAlignment.MiddleRight;
            lbl_stat_pswd.Click += label1_Click;
            // 
            // btn_EXIT
            // 
            btn_EXIT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_EXIT.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_EXIT.Location = new Point(440, 251);
            btn_EXIT.Name = "btn_EXIT";
            btn_EXIT.Size = new Size(112, 34);
            btn_EXIT.TabIndex = 5;
            btn_EXIT.Text = "EXIT";
            btn_EXIT.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            btn_OK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_OK.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_OK.Location = new Point(97, 251);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(112, 34);
            btn_OK.TabIndex = 4;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += button1_Click;
            // 
            // lbl_time
            // 
            lbl_time.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_time.BackColor = Color.Gray;
            lbl_time.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_time.ForeColor = Color.FromArgb(0, 192, 192);
            lbl_time.Location = new Point(30, 557);
            lbl_time.Margin = new Padding(4, 3, 4, 3);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(304, 39);
            lbl_time.TabIndex = 6;
            lbl_time.Text = "23.12.2012 13:45:56";
            // 
            // link_help
            // 
            link_help.AutoSize = true;
            link_help.Location = new Point(645, 95);
            link_help.Name = "link_help";
            link_help.Size = new Size(49, 25);
            link_help.TabIndex = 5;
            link_help.TabStop = true;
            link_help.Text = "Help";
            link_help.LinkClicked += linkLabel1_LinkClicked;
            // 
            // link_about
            // 
            link_about.AutoSize = true;
            link_about.Location = new Point(789, 95);
            link_about.Name = "link_about";
            link_about.Size = new Size(62, 25);
            link_about.TabIndex = 6;
            link_about.TabStop = true;
            link_about.Text = "About";
            // 
            // link_uvjeti_koristenja
            // 
            link_uvjeti_koristenja.AutoSize = true;
            link_uvjeti_koristenja.Location = new Point(930, 95);
            link_uvjeti_koristenja.Name = "link_uvjeti_koristenja";
            link_uvjeti_koristenja.Size = new Size(138, 25);
            link_uvjeti_koristenja.TabIndex = 7;
            link_uvjeti_koristenja.TabStop = true;
            link_uvjeti_koristenja.Text = "Uvjeti Koristenja";
            // 
            // link_exit
            // 
            link_exit.AutoSize = true;
            link_exit.Location = new Point(1114, 95);
            link_exit.Name = "link_exit";
            link_exit.Size = new Size(46, 25);
            link_exit.TabIndex = 8;
            link_exit.TabStop = true;
            link_exit.Text = "EXIT";
            // 
            // panel_login
            // 
            panel_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_login.BackColor = Color.FromArgb(192, 64, 0);
            panel_login.Controls.Add(gbox_login);
            panel_login.Location = new Point(30, 150);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(1226, 401);
            panel_login.TabIndex = 9;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 81, 113);
            ClientSize = new Size(1309, 608);
            Controls.Add(panel_login);
            Controls.Add(link_exit);
            Controls.Add(link_uvjeti_koristenja);
            Controls.Add(link_about);
            Controls.Add(link_help);
            Controls.Add(lbl_time);
            Controls.Add(picBox_BlueHotel_Logo);
            Location = new Point(30, 86);
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += form_login_Load;
            ((System.ComponentModel.ISupportInitialize)picBox_BlueHotel_Logo).EndInit();
            gbox_login.ResumeLayout(false);
            gbox_login.PerformLayout();
            panel_login.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBox_BlueHotel_Logo;
        private GroupBox gbox_login;
        private Label lbl_stat_pswd;
        private MaskedTextBox txt_pswd;
        private Button btn_EXIT;
        private Button btn_OK;
        private Label lbl_time;
        private LinkLabel link_help;
        private LinkLabel link_about;
        private LinkLabel link_uvjeti_koristenja;
        private LinkLabel link_exit;
        private Panel panel_login;
    }
}