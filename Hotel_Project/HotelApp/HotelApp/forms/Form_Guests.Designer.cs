namespace HotelApp.forms
{
    partial class Form_Guests
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            lbl_number_of_guests = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridViewGuests = new DataGridView();
            GuestID = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            btn_add_new_guest = new Button();
            btn_delete_guest = new Button();
            btn_update_guest = new Button();
            btn_details_guest = new Button();
            btn_add = new Button();
            btn_exit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 31, 33);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1294, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(257, 56);
            label1.TabIndex = 0;
            label1.Text = "GUEST LIST";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(155, 31, 33);
            panel2.Controls.Add(lbl_number_of_guests);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(59, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(1185, 56);
            panel2.TabIndex = 2;
            // 
            // lbl_number_of_guests
            // 
            lbl_number_of_guests.AutoSize = true;
            lbl_number_of_guests.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_number_of_guests.Location = new Point(322, 17);
            lbl_number_of_guests.Name = "lbl_number_of_guests";
            lbl_number_of_guests.Size = new Size(125, 25);
            lbl_number_of_guests.TabIndex = 2;
            lbl_number_of_guests.Text = "broj gostiju";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(309, 25);
            label2.TabIndex = 1;
            label2.Text = "Number of guests in the list :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewGuests);
            panel3.Location = new Point(56, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(1188, 647);
            panel3.TabIndex = 3;
            // 
            // dataGridViewGuests
            // 
            dataGridViewGuests.AllowUserToAddRows = false;
            dataGridViewGuests.AllowUserToDeleteRows = false;
            dataGridViewGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGuests.BackgroundColor = Color.White;
            dataGridViewGuests.BorderStyle = BorderStyle.None;
            dataGridViewGuests.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewGuests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGuests.ColumnHeadersHeight = 38;
            dataGridViewGuests.Columns.AddRange(new DataGridViewColumn[] { GuestID, LastName, FirstName, Gender, Address, City, Country });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewGuests.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewGuests.Dock = DockStyle.Left;
            dataGridViewGuests.EnableHeadersVisualStyles = false;
            dataGridViewGuests.Location = new Point(0, 0);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewGuests.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGuests.RowHeadersVisible = false;
            dataGridViewGuests.RowHeadersWidth = 62;
            dataGridViewGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGuests.Size = new Size(1188, 647);
            dataGridViewGuests.TabIndex = 2;
            // 
            // GuestID
            // 
            GuestID.HeaderText = "Guest ID";
            GuestID.MinimumWidth = 8;
            GuestID.Name = "GuestID";
            GuestID.Visible = false;
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 8;
            Address.Name = "Address";
            // 
            // City
            // 
            City.HeaderText = "City";
            City.MinimumWidth = 8;
            City.Name = "City";
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 8;
            Country.Name = "Country";
            // 
            // btn_add_new_guest
            // 
            btn_add_new_guest.BackColor = Color.FromArgb(155, 31, 33);
            btn_add_new_guest.ForeColor = Color.White;
            btn_add_new_guest.Location = new Point(56, 847);
            btn_add_new_guest.Name = "btn_add_new_guest";
            btn_add_new_guest.Size = new Size(136, 52);
            btn_add_new_guest.TabIndex = 7;
            btn_add_new_guest.Text = "Add New";
            btn_add_new_guest.UseVisualStyleBackColor = false;
            btn_add_new_guest.Click += btn_add_new_guest_Click;
            // 
            // btn_delete_guest
            // 
            btn_delete_guest.BackColor = Color.FromArgb(155, 31, 33);
            btn_delete_guest.ForeColor = Color.White;
            btn_delete_guest.Location = new Point(208, 847);
            btn_delete_guest.Name = "btn_delete_guest";
            btn_delete_guest.Size = new Size(136, 52);
            btn_delete_guest.TabIndex = 8;
            btn_delete_guest.Text = "Delete";
            btn_delete_guest.UseVisualStyleBackColor = false;
            btn_delete_guest.Click += btn_delete_guest_Click;
            // 
            // btn_update_guest
            // 
            btn_update_guest.BackColor = Color.FromArgb(155, 31, 33);
            btn_update_guest.ForeColor = Color.White;
            btn_update_guest.Location = new Point(361, 847);
            btn_update_guest.Name = "btn_update_guest";
            btn_update_guest.Size = new Size(136, 52);
            btn_update_guest.TabIndex = 9;
            btn_update_guest.Text = "Update";
            btn_update_guest.UseVisualStyleBackColor = false;
            btn_update_guest.Click += btn_update_guest_Click;
            // 
            // btn_details_guest
            // 
            btn_details_guest.BackColor = Color.FromArgb(155, 31, 33);
            btn_details_guest.ForeColor = Color.White;
            btn_details_guest.Location = new Point(516, 847);
            btn_details_guest.Name = "btn_details_guest";
            btn_details_guest.Size = new Size(136, 52);
            btn_details_guest.TabIndex = 10;
            btn_details_guest.Text = "Details";
            btn_details_guest.UseVisualStyleBackColor = false;
            btn_details_guest.Click += btn_details_guest_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(155, 31, 33);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(946, 847);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(136, 52);
            btn_add.TabIndex = 11;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(155, 31, 33);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(1106, 847);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(136, 52);
            btn_exit.TabIndex = 12;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form_Guests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1294, 921);
            Controls.Add(btn_exit);
            Controls.Add(btn_add);
            Controls.Add(btn_details_guest);
            Controls.Add(btn_update_guest);
            Controls.Add(btn_delete_guest);
            Controls.Add(btn_add_new_guest);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form_Guests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Guests";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_add_new_guest;
        private Button btn_delete_guest;
        private Button btn_update_guest;
        private Button btn_details_guest;
        private Button btn_add;
        private Button btn_exit;
        private Label lbl_number_of_guests;
        private Label label2;
        private DataGridView dataGridViewGuests;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Country;
    }
}