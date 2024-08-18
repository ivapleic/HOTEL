namespace HotelApp.user_controls
{
    partial class Reservation_AddNew_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_AddNew_Form));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            panel6 = new Panel();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            panel7 = new Panel();
            dateTimePicker_end_date = new DateTimePicker();
            dateTimePicker_start_date = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label25 = new Label();
            label28 = new Label();
            label29 = new Label();
            label31 = new Label();
            panel3 = new Panel();
            comboBox_status = new ComboBox();
            label_employee_name = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            panel2 = new Panel();
            btn_close_form = new Button();
            btn_add_new = new Button();
            panel9 = new Panel();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btn_add_services = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            btn_details_guest = new Button();
            btn_update_guest = new Button();
            btn_delete_guest = new Button();
            btn_add_guest = new Button();
            dataGridViewGuests = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            panel11 = new Panel();
            label3 = new Label();
            panel12 = new Panel();
            comboBox_rooms = new ComboBox();
            comboBox_roomType = new ComboBox();
            label37 = new Label();
            label39 = new Label();
            label40 = new Label();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(431, 43);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW RESERVATION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 86);
            panel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gainsboro;
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(panel6);
            panel8.Controls.Add(panel7);
            panel8.Controls.Add(panel3);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 86);
            panel8.Name = "panel8";
            panel8.Size = new Size(774, 865);
            panel8.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(12, 616);
            panel5.Name = "panel5";
            panel5.Size = new Size(750, 173);
            panel5.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(716, 70);
            textBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 21);
            label7.Name = "label7";
            label7.Size = new Size(143, 26);
            label7.TabIndex = 3;
            label7.Text = "Description :";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.BackColor = Color.Gainsboro;
            panel6.Controls.Add(dateTimePicker5);
            panel6.Controls.Add(dateTimePicker4);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label19);
            panel6.Location = new Point(12, 426);
            panel6.Name = "panel6";
            panel6.Size = new Size(750, 184);
            panel6.TabIndex = 7;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(201, 118);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(300, 31);
            dateTimePicker5.TabIndex = 10;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(179, 69);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(300, 31);
            dateTimePicker4.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(21, 116);
            label16.Name = "label16";
            label16.Size = new Size(175, 23);
            label16.TabIndex = 8;
            label16.Text = "Date check out :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(16, 67);
            label17.Name = "label17";
            label17.Size = new Size(158, 23);
            label17.TabIndex = 7;
            label17.Text = "Date check in :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(12, 19);
            label19.Name = "label19";
            label19.Size = new Size(163, 26);
            label19.TabIndex = 2;
            label19.Text = "Check in / out";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.BackColor = Color.Gainsboro;
            panel7.Controls.Add(dateTimePicker_end_date);
            panel7.Controls.Add(dateTimePicker_start_date);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(label28);
            panel7.Controls.Add(label29);
            panel7.Controls.Add(label31);
            panel7.Location = new Point(12, 204);
            panel7.Name = "panel7";
            panel7.Size = new Size(750, 216);
            panel7.TabIndex = 6;
            // 
            // dateTimePicker_end_date
            // 
            dateTimePicker_end_date.Location = new Point(141, 164);
            dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            dateTimePicker_end_date.Size = new Size(300, 31);
            dateTimePicker_end_date.TabIndex = 11;
            dateTimePicker_end_date.ValueChanged += dateTimePicker_end_date_ValueChanged;
            // 
            // dateTimePicker_start_date
            // 
            dateTimePicker_start_date.Location = new Point(150, 117);
            dateTimePicker_start_date.Name = "dateTimePicker_start_date";
            dateTimePicker_start_date.Size = new Size(300, 31);
            dateTimePicker_start_date.TabIndex = 10;
            dateTimePicker_start_date.ValueChanged += dateTimePicker_start_date_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(216, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(21, 73);
            label25.Name = "label25";
            label25.Size = new Size(189, 23);
            label25.TabIndex = 6;
            label25.Text = "Reservation date :";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(21, 170);
            label28.Name = "label28";
            label28.Size = new Size(112, 23);
            label28.TabIndex = 4;
            label28.Text = "End date :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(21, 122);
            label29.Name = "label29";
            label29.Size = new Size(119, 23);
            label29.TabIndex = 3;
            label29.Text = "Start date :";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(12, 21);
            label31.Name = "label31";
            label31.Size = new Size(136, 26);
            label31.TabIndex = 1;
            label31.Text = "Reservation";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(comboBox_status);
            panel3.Controls.Add(label_employee_name);
            panel3.Controls.Add(label34);
            panel3.Controls.Add(label35);
            panel3.Controls.Add(label36);
            panel3.Location = new Point(12, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(750, 175);
            panel3.TabIndex = 5;
            // 
            // comboBox_status
            // 
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Location = new Point(101, 67);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(251, 33);
            comboBox_status.TabIndex = 7;
            // 
            // label_employee_name
            // 
            label_employee_name.AutoSize = true;
            label_employee_name.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_employee_name.Location = new Point(142, 118);
            label_employee_name.Name = "label_employee_name";
            label_employee_name.Size = new Size(190, 23);
            label_employee_name.TabIndex = 5;
            label_employee_name.Text = "Logirani zaposlenik";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(16, 118);
            label34.Name = "label34";
            label34.Size = new Size(120, 23);
            label34.TabIndex = 2;
            label34.Text = "Employee :";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.Location = new Point(16, 67);
            label35.Name = "label35";
            label35.Size = new Size(79, 23);
            label35.TabIndex = 1;
            label35.Text = "Status :";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(12, 15);
            label36.Name = "label36";
            label36.Size = new Size(79, 26);
            label36.TabIndex = 0;
            label36.Text = "Basics";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(btn_close_form);
            panel2.Controls.Add(btn_add_new);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel12);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(768, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 865);
            panel2.TabIndex = 6;
            // 
            // btn_close_form
            // 
            btn_close_form.Location = new Point(705, 801);
            btn_close_form.Name = "btn_close_form";
            btn_close_form.Size = new Size(135, 52);
            btn_close_form.TabIndex = 13;
            btn_close_form.Text = "Exit";
            btn_close_form.UseVisualStyleBackColor = true;
            btn_close_form.Click += btn_close_form_Click;
            // 
            // btn_add_new
            // 
            btn_add_new.Location = new Point(549, 801);
            btn_add_new.Name = "btn_add_new";
            btn_add_new.Size = new Size(135, 52);
            btn_add_new.TabIndex = 12;
            btn_add_new.Text = "Add new";
            btn_add_new.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel9.BackColor = Color.Gainsboro;
            panel9.Controls.Add(button8);
            panel9.Controls.Add(button9);
            panel9.Controls.Add(button10);
            panel9.Controls.Add(btn_add_services);
            panel9.Controls.Add(label2);
            panel9.Controls.Add(dataGridView1);
            panel9.Location = new Point(15, 522);
            panel9.Name = "panel9";
            panel9.Size = new Size(827, 267);
            panel9.TabIndex = 10;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Location = new Point(762, 218);
            button8.Name = "button8";
            button8.Size = new Size(65, 52);
            button8.TabIndex = 19;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Location = new Point(762, 160);
            button9.Name = "button9";
            button9.Size = new Size(65, 52);
            button9.TabIndex = 18;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImage = (Image)resources.GetObject("button10.BackgroundImage");
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Location = new Point(762, 102);
            button10.Name = "button10";
            button10.Size = new Size(66, 52);
            button10.TabIndex = 17;
            button10.UseVisualStyleBackColor = true;
            // 
            // btn_add_services
            // 
            btn_add_services.BackgroundImage = (Image)resources.GetObject("btn_add_services.BackgroundImage");
            btn_add_services.BackgroundImageLayout = ImageLayout.Zoom;
            btn_add_services.Location = new Point(762, 50);
            btn_add_services.Name = "btn_add_services";
            btn_add_services.Size = new Size(65, 46);
            btn_add_services.TabIndex = 16;
            btn_add_services.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 3, 0, 3);
            label2.Size = new Size(174, 27);
            label2.TabIndex = 9;
            label2.Text = "Additional services";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 38;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(-3, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(765, 234);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Service Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Amount";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Reservation Date";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Consumation Date";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel10.BackColor = Color.Gainsboro;
            panel10.Controls.Add(btn_details_guest);
            panel10.Controls.Add(btn_update_guest);
            panel10.Controls.Add(btn_delete_guest);
            panel10.Controls.Add(btn_add_guest);
            panel10.Controls.Add(dataGridViewGuests);
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(14, 238);
            panel10.Name = "panel10";
            panel10.Size = new Size(827, 278);
            panel10.TabIndex = 9;
            // 
            // btn_details_guest
            // 
            btn_details_guest.BackgroundImage = (Image)resources.GetObject("btn_details_guest.BackgroundImage");
            btn_details_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_details_guest.Location = new Point(762, 226);
            btn_details_guest.Name = "btn_details_guest";
            btn_details_guest.Size = new Size(65, 52);
            btn_details_guest.TabIndex = 15;
            btn_details_guest.UseVisualStyleBackColor = true;
            // 
            // btn_update_guest
            // 
            btn_update_guest.BackgroundImage = (Image)resources.GetObject("btn_update_guest.BackgroundImage");
            btn_update_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_update_guest.Location = new Point(762, 168);
            btn_update_guest.Name = "btn_update_guest";
            btn_update_guest.Size = new Size(65, 52);
            btn_update_guest.TabIndex = 14;
            btn_update_guest.UseVisualStyleBackColor = true;
            // 
            // btn_delete_guest
            // 
            btn_delete_guest.BackgroundImage = (Image)resources.GetObject("btn_delete_guest.BackgroundImage");
            btn_delete_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_guest.Location = new Point(762, 110);
            btn_delete_guest.Name = "btn_delete_guest";
            btn_delete_guest.Size = new Size(66, 52);
            btn_delete_guest.TabIndex = 13;
            btn_delete_guest.UseVisualStyleBackColor = true;
            // 
            // btn_add_guest
            // 
            btn_add_guest.BackgroundImage = (Image)resources.GetObject("btn_add_guest.BackgroundImage");
            btn_add_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_add_guest.Location = new Point(762, 58);
            btn_add_guest.Name = "btn_add_guest";
            btn_add_guest.Size = new Size(65, 46);
            btn_add_guest.TabIndex = 12;
            btn_add_guest.UseVisualStyleBackColor = true;
            btn_add_guest.Click += btn_add_guest_Click;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGuests.ColumnHeadersHeight = 38;
            dataGridViewGuests.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewCheckBoxColumn1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewGuests.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGuests.Dock = DockStyle.Left;
            dataGridViewGuests.EnableHeadersVisualStyles = false;
            dataGridViewGuests.Location = new Point(0, 38);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewGuests.RowHeadersVisible = false;
            dataGridViewGuests.RowHeadersWidth = 62;
            dataGridViewGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGuests.Size = new Size(763, 240);
            dataGridViewGuests.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Guest ID";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "First Name";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Last Name";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Start Date";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "End Date";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "Add Person";
            dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Silver;
            panel11.Controls.Add(label3);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(827, 38);
            panel11.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(366, 8);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 3, 0, 3);
            label3.Size = new Size(70, 27);
            label3.TabIndex = 8;
            label3.Text = "Guests";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel12.BackColor = Color.Gainsboro;
            panel12.Controls.Add(comboBox_rooms);
            panel12.Controls.Add(comboBox_roomType);
            panel12.Controls.Add(label37);
            panel12.Controls.Add(label39);
            panel12.Controls.Add(label40);
            panel12.Location = new Point(12, 23);
            panel12.Name = "panel12";
            panel12.Size = new Size(827, 197);
            panel12.TabIndex = 8;
            // 
            // comboBox_rooms
            // 
            comboBox_rooms.FormattingEnabled = true;
            comboBox_rooms.Location = new Point(185, 148);
            comboBox_rooms.Name = "comboBox_rooms";
            comboBox_rooms.Size = new Size(236, 33);
            comboBox_rooms.TabIndex = 12;
            // 
            // comboBox_roomType
            // 
            comboBox_roomType.FormattingEnabled = true;
            comboBox_roomType.Location = new Point(185, 73);
            comboBox_roomType.Name = "comboBox_roomType";
            comboBox_roomType.Size = new Size(297, 33);
            comboBox_roomType.TabIndex = 11;
            comboBox_roomType.SelectedIndexChanged += comboBox_roomType_SelectedIndexChanged;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label37.Location = new Point(19, 152);
            label37.Name = "label37";
            label37.Size = new Size(160, 23);
            label37.TabIndex = 9;
            label37.Text = "Room number :";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label39.Location = new Point(50, 77);
            label39.Name = "label39";
            label39.Size = new Size(129, 23);
            label39.TabIndex = 7;
            label39.Text = "Room type :";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label40.Location = new Point(19, 15);
            label40.Name = "label40";
            label40.Size = new Size(74, 26);
            label40.TabIndex = 2;
            label40.Text = "Room";
            // 
            // Reservation_AddNew_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 951);
            Controls.Add(panel2);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Name = "Reservation_AddNew_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation_AddNew_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel8;
        private Panel panel2;
        private Panel panel3;
        private ComboBox comboBox_status;
        private Label label_employee_name;
        private Label label34;
        private Label label35;
        private Label label36;
        private Panel panel7;
        private DateTimePicker dateTimePicker_end_date;
        private DateTimePicker dateTimePicker_start_date;
        private DateTimePicker dateTimePicker1;
        private Label label25;
        private Label label28;
        private Label label29;
        private Label label31;
        private Panel panel6;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker4;
        private Label label16;
        private Label label17;
        private Label label19;
        private Panel panel5;
        private TextBox textBox1;
        private Label label7;
        private Panel panel12;
        private ComboBox comboBox_rooms;
        private ComboBox comboBox_roomType;
        private Label label37;
        private Label label39;
        private Label label40;
        private Panel panel10;
        private Button btn_details_guest;
        private Button btn_update_guest;
        private Button btn_delete_guest;
        private Button btn_add_guest;
        private DataGridView dataGridViewGuests;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Panel panel11;
        private Label label3;
        private Panel panel9;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btn_add_services;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btn_close_form;
        private Button btn_add_new;
    }
}