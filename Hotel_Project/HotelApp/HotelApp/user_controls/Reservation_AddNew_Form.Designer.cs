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
            textBox_description = new TextBox();
            label7 = new Label();
            panel6 = new Panel();
            dateTimePicker_check_out = new DateTimePicker();
            dateTimePicker_check_in = new DateTimePicker();
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
            btn_details_service = new Button();
            btn_update_service = new Button();
            btn_delete_service = new Button();
            btn_add_services = new Button();
            label2 = new Label();
            dataGridView_AddServices = new DataGridView();
            ReservationServiceID = new DataGridViewTextBoxColumn();
            ServiceID = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ReservationDate = new DataGridViewTextBoxColumn();
            ConsumationDate = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            btn_details_guest = new Button();
            btn_update_guest = new Button();
            btn_delete_guest = new Button();
            btn_add_guest = new Button();
            dataGridViewGuests = new DataGridView();
            GuestResID = new DataGridViewTextBoxColumn();
            GuestID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            AddPerson = new DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_AddServices).BeginInit();
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
            panel1.BackColor = Color.FromArgb(155, 31, 33);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 86);
            panel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
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
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBox_description);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(12, 606);
            panel5.Name = "panel5";
            panel5.Size = new Size(750, 189);
            panel5.TabIndex = 8;
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(16, 61);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(716, 117);
            textBox_description.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(155, 31, 33);
            label7.Location = new Point(12, 21);
            label7.Name = "label7";
            label7.Size = new Size(143, 26);
            label7.TabIndex = 3;
            label7.Text = "Description :";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dateTimePicker_check_out);
            panel6.Controls.Add(dateTimePicker_check_in);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label19);
            panel6.Location = new Point(12, 426);
            panel6.Name = "panel6";
            panel6.Size = new Size(750, 184);
            panel6.TabIndex = 7;
            // 
            // dateTimePicker_check_out
            // 
            dateTimePicker_check_out.Location = new Point(194, 125);
            dateTimePicker_check_out.Name = "dateTimePicker_check_out";
            dateTimePicker_check_out.Size = new Size(300, 31);
            dateTimePicker_check_out.TabIndex = 10;
            // 
            // dateTimePicker_check_in
            // 
            dateTimePicker_check_in.Location = new Point(194, 67);
            dateTimePicker_check_in.Name = "dateTimePicker_check_in";
            dateTimePicker_check_in.Size = new Size(300, 31);
            dateTimePicker_check_in.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(14, 123);
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
            label19.ForeColor = Color.FromArgb(155, 31, 33);
            label19.Location = new Point(12, 19);
            label19.Name = "label19";
            label19.Size = new Size(163, 26);
            label19.TabIndex = 2;
            label19.Text = "Check in / out";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dateTimePicker_end_date);
            panel7.Controls.Add(dateTimePicker_start_date);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(label25);
            panel7.Controls.Add(label28);
            panel7.Controls.Add(label29);
            panel7.Controls.Add(label31);
            panel7.Location = new Point(12, 196);
            panel7.Name = "panel7";
            panel7.Size = new Size(750, 224);
            panel7.TabIndex = 6;
            // 
            // dateTimePicker_end_date
            // 
            dateTimePicker_end_date.Location = new Point(136, 157);
            dateTimePicker_end_date.Name = "dateTimePicker_end_date";
            dateTimePicker_end_date.Size = new Size(300, 31);
            dateTimePicker_end_date.TabIndex = 11;
            dateTimePicker_end_date.ValueChanged += dateTimePicker_end_date_ValueChanged;
            // 
            // dateTimePicker_start_date
            // 
            dateTimePicker_start_date.Location = new Point(145, 110);
            dateTimePicker_start_date.Name = "dateTimePicker_start_date";
            dateTimePicker_start_date.Size = new Size(300, 31);
            dateTimePicker_start_date.TabIndex = 10;
            dateTimePicker_start_date.ValueChanged += dateTimePicker_start_date_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(211, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(16, 66);
            label25.Name = "label25";
            label25.Size = new Size(189, 23);
            label25.TabIndex = 6;
            label25.Text = "Reservation date :";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(16, 163);
            label28.Name = "label28";
            label28.Size = new Size(112, 23);
            label28.TabIndex = 4;
            label28.Text = "End date :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(16, 115);
            label29.Name = "label29";
            label29.Size = new Size(119, 23);
            label29.TabIndex = 3;
            label29.Text = "Start date :";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.FromArgb(155, 31, 33);
            label31.Location = new Point(12, 21);
            label31.Name = "label31";
            label31.Size = new Size(136, 26);
            label31.TabIndex = 1;
            label31.Text = "Reservation";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.White;
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
            label36.ForeColor = Color.FromArgb(155, 31, 33);
            label36.Location = new Point(12, 15);
            label36.Name = "label36";
            label36.Size = new Size(79, 26);
            label36.TabIndex = 0;
            label36.Text = "Basics";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
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
            btn_close_form.BackColor = Color.FromArgb(155, 31, 33);
            btn_close_form.ForeColor = Color.White;
            btn_close_form.Location = new Point(706, 801);
            btn_close_form.Name = "btn_close_form";
            btn_close_form.Size = new Size(135, 52);
            btn_close_form.TabIndex = 13;
            btn_close_form.Text = "Exit";
            btn_close_form.UseVisualStyleBackColor = false;
            btn_close_form.Click += btn_close_form_Click;
            // 
            // btn_add_new
            // 
            btn_add_new.BackColor = Color.FromArgb(155, 31, 33);
            btn_add_new.ForeColor = Color.White;
            btn_add_new.Location = new Point(550, 801);
            btn_add_new.Name = "btn_add_new";
            btn_add_new.Size = new Size(135, 52);
            btn_add_new.TabIndex = 12;
            btn_add_new.Text = "Add new";
            btn_add_new.UseVisualStyleBackColor = false;
            btn_add_new.Click += btn_add_new_Click;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel9.BackColor = Color.White;
            panel9.Controls.Add(btn_details_service);
            panel9.Controls.Add(btn_update_service);
            panel9.Controls.Add(btn_delete_service);
            panel9.Controls.Add(btn_add_services);
            panel9.Controls.Add(label2);
            panel9.Controls.Add(dataGridView_AddServices);
            panel9.Location = new Point(15, 522);
            panel9.Name = "panel9";
            panel9.Size = new Size(827, 263);
            panel9.TabIndex = 10;
            // 
            // btn_details_service
            // 
            btn_details_service.BackColor = Color.White;
            btn_details_service.BackgroundImage = (Image)resources.GetObject("btn_details_service.BackgroundImage");
            btn_details_service.BackgroundImageLayout = ImageLayout.Zoom;
            btn_details_service.Location = new Point(761, 209);
            btn_details_service.Name = "btn_details_service";
            btn_details_service.Size = new Size(65, 52);
            btn_details_service.TabIndex = 19;
            btn_details_service.UseVisualStyleBackColor = false;
            btn_details_service.Click += btn_details_service_Click;
            // 
            // btn_update_service
            // 
            btn_update_service.BackColor = Color.White;
            btn_update_service.BackgroundImage = (Image)resources.GetObject("btn_update_service.BackgroundImage");
            btn_update_service.BackgroundImageLayout = ImageLayout.Zoom;
            btn_update_service.Location = new Point(761, 152);
            btn_update_service.Name = "btn_update_service";
            btn_update_service.Size = new Size(65, 52);
            btn_update_service.TabIndex = 18;
            btn_update_service.UseVisualStyleBackColor = false;
            btn_update_service.Click += btn_update_service_Click;
            // 
            // btn_delete_service
            // 
            btn_delete_service.BackColor = Color.White;
            btn_delete_service.BackgroundImage = (Image)resources.GetObject("btn_delete_service.BackgroundImage");
            btn_delete_service.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_service.Location = new Point(760, 94);
            btn_delete_service.Name = "btn_delete_service";
            btn_delete_service.Size = new Size(66, 52);
            btn_delete_service.TabIndex = 17;
            btn_delete_service.UseVisualStyleBackColor = false;
            btn_delete_service.Click += btn_delete_service_Click;
            // 
            // btn_add_services
            // 
            btn_add_services.BackColor = Color.White;
            btn_add_services.BackgroundImage = (Image)resources.GetObject("btn_add_services.BackgroundImage");
            btn_add_services.BackgroundImageLayout = ImageLayout.Zoom;
            btn_add_services.Location = new Point(761, 42);
            btn_add_services.Name = "btn_add_services";
            btn_add_services.Size = new Size(65, 46);
            btn_add_services.TabIndex = 16;
            btn_add_services.UseVisualStyleBackColor = false;
            btn_add_services.Click += btn_add_services_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(155, 31, 33);
            label2.Location = new Point(334, 3);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 3, 0, 3);
            label2.Size = new Size(176, 28);
            label2.TabIndex = 9;
            label2.Text = "Additional services";
            // 
            // dataGridView_AddServices
            // 
            dataGridView_AddServices.AllowUserToAddRows = false;
            dataGridView_AddServices.AllowUserToDeleteRows = false;
            dataGridView_AddServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_AddServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_AddServices.BackgroundColor = Color.White;
            dataGridView_AddServices.BorderStyle = BorderStyle.None;
            dataGridView_AddServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_AddServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_AddServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_AddServices.ColumnHeadersHeight = 38;
            dataGridView_AddServices.Columns.AddRange(new DataGridViewColumn[] { ReservationServiceID, ServiceID, ServiceName, Amount, ReservationDate, ConsumationDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_AddServices.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_AddServices.EnableHeadersVisualStyles = false;
            dataGridView_AddServices.Location = new Point(-3, 33);
            dataGridView_AddServices.Name = "dataGridView_AddServices";
            dataGridView_AddServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_AddServices.RowHeadersVisible = false;
            dataGridView_AddServices.RowHeadersWidth = 62;
            dataGridView_AddServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AddServices.Size = new Size(765, 230);
            dataGridView_AddServices.TabIndex = 2;
            // 
            // ReservationServiceID
            // 
            ReservationServiceID.HeaderText = "ReservationServiceID";
            ReservationServiceID.MinimumWidth = 8;
            ReservationServiceID.Name = "ReservationServiceID";
            ReservationServiceID.Visible = false;
            // 
            // ServiceID
            // 
            ServiceID.HeaderText = "Service ID";
            ServiceID.MinimumWidth = 8;
            ServiceID.Name = "ServiceID";
            ServiceID.Visible = false;
            // 
            // ServiceName
            // 
            ServiceName.HeaderText = "Service Name";
            ServiceName.MinimumWidth = 8;
            ServiceName.Name = "ServiceName";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            // 
            // ReservationDate
            // 
            ReservationDate.HeaderText = "Reservation Date";
            ReservationDate.MinimumWidth = 8;
            ReservationDate.Name = "ReservationDate";
            // 
            // ConsumationDate
            // 
            ConsumationDate.HeaderText = "Consumation Date";
            ConsumationDate.MinimumWidth = 8;
            ConsumationDate.Name = "ConsumationDate";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel10.BackColor = Color.White;
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
            btn_details_guest.BackColor = Color.White;
            btn_details_guest.BackgroundImage = (Image)resources.GetObject("btn_details_guest.BackgroundImage");
            btn_details_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_details_guest.Location = new Point(762, 226);
            btn_details_guest.Name = "btn_details_guest";
            btn_details_guest.Size = new Size(65, 52);
            btn_details_guest.TabIndex = 15;
            btn_details_guest.UseVisualStyleBackColor = false;
            btn_details_guest.Click += btn_details_guest_Click;
            // 
            // btn_update_guest
            // 
            btn_update_guest.BackColor = Color.White;
            btn_update_guest.BackgroundImage = (Image)resources.GetObject("btn_update_guest.BackgroundImage");
            btn_update_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_update_guest.Location = new Point(762, 168);
            btn_update_guest.Name = "btn_update_guest";
            btn_update_guest.Size = new Size(65, 52);
            btn_update_guest.TabIndex = 14;
            btn_update_guest.UseVisualStyleBackColor = false;
            btn_update_guest.Click += btn_update_guest_Click;
            // 
            // btn_delete_guest
            // 
            btn_delete_guest.BackColor = Color.White;
            btn_delete_guest.BackgroundImage = (Image)resources.GetObject("btn_delete_guest.BackgroundImage");
            btn_delete_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_delete_guest.Location = new Point(762, 110);
            btn_delete_guest.Name = "btn_delete_guest";
            btn_delete_guest.Size = new Size(66, 52);
            btn_delete_guest.TabIndex = 13;
            btn_delete_guest.UseVisualStyleBackColor = false;
            btn_delete_guest.Click += btn_delete_guest_Click;
            // 
            // btn_add_guest
            // 
            btn_add_guest.BackColor = Color.White;
            btn_add_guest.BackgroundImage = (Image)resources.GetObject("btn_add_guest.BackgroundImage");
            btn_add_guest.BackgroundImageLayout = ImageLayout.Zoom;
            btn_add_guest.Location = new Point(762, 58);
            btn_add_guest.Name = "btn_add_guest";
            btn_add_guest.Size = new Size(65, 46);
            btn_add_guest.TabIndex = 12;
            btn_add_guest.UseVisualStyleBackColor = false;
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
            dataGridViewGuests.Columns.AddRange(new DataGridViewColumn[] { GuestResID, GuestID, FirstName, LastName, StartDate, EndDate, AddPerson });
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
            // GuestResID
            // 
            GuestResID.HeaderText = "Guest Reservation ID";
            GuestResID.MinimumWidth = 8;
            GuestResID.Name = "GuestResID";
            GuestResID.Visible = false;
            // 
            // GuestID
            // 
            GuestID.HeaderText = "Guest ID";
            GuestID.MinimumWidth = 8;
            GuestID.Name = "GuestID";
            GuestID.Visible = false;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 8;
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 8;
            LastName.Name = "LastName";
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Start Date";
            StartDate.MinimumWidth = 8;
            StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            EndDate.HeaderText = "End Date";
            EndDate.MinimumWidth = 8;
            EndDate.Name = "EndDate";
            // 
            // AddPerson
            // 
            AddPerson.HeaderText = "Add Person";
            AddPerson.MinimumWidth = 8;
            AddPerson.Name = "AddPerson";
            AddPerson.Resizable = DataGridViewTriState.True;
            AddPerson.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(label3);
            panel11.Dock = DockStyle.Top;
            panel11.ForeColor = Color.White;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(827, 38);
            panel11.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(155, 31, 33);
            label3.Location = new Point(366, 8);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 3, 0, 3);
            label3.Size = new Size(69, 28);
            label3.TabIndex = 8;
            label3.Text = "Guests";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel12.BackColor = Color.White;
            panel12.Controls.Add(comboBox_rooms);
            panel12.Controls.Add(comboBox_roomType);
            panel12.Controls.Add(label37);
            panel12.Controls.Add(label39);
            panel12.Controls.Add(label40);
            panel12.Location = new Point(14, 23);
            panel12.Name = "panel12";
            panel12.Size = new Size(828, 209);
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
            label40.ForeColor = Color.FromArgb(155, 31, 33);
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
            FormClosed += Reservation_AddNew_Form_FormClosed;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_AddServices).EndInit();
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
        private DateTimePicker dateTimePicker_check_out;
        private DateTimePicker dateTimePicker_check_in;
        private Label label16;
        private Label label17;
        private Label label19;
        private Panel panel5;
        private TextBox textBox_description;
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
        private Panel panel11;
        private Label label3;
        private Panel panel9;
        private Button btn_details_service;
        private Button btn_update_service;
        private Button btn_delete_service;
        private Button btn_add_services;
        private Label label2;
        private DataGridView dataGridView_AddServices;
        private Button btn_close_form;
        private Button btn_add_new;
        private DataGridViewTextBoxColumn GuestResID;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewCheckBoxColumn AddPerson;
        private DataGridViewTextBoxColumn ReservationServiceID;
        private DataGridViewTextBoxColumn ServiceID;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ReservationDate;
        private DataGridViewTextBoxColumn ConsumationDate;
    }
}