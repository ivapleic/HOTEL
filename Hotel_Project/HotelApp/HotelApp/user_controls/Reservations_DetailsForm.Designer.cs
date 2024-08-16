namespace HotelApp.user_controls
{
    partial class Reservations_DetailsForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label_res_number = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pnl_description = new Panel();
            label_description = new Label();
            label18 = new Label();
            pnl_check_in_out = new Panel();
            label_check_out_date = new Label();
            label_check_in_date = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            pnl_reservation = new Panel();
            label_end_date = new Label();
            label_start_date = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label_reservation_date = new Label();
            label6 = new Label();
            pnl_basics = new Panel();
            label_status = new Label();
            label_employee_name = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btn_close = new Button();
            btn_exit = new Button();
            pnl_add_services = new Panel();
            label27 = new Label();
            dataGridViewAddServices = new DataGridView();
            ServiceName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ReservationDate = new DataGridViewTextBoxColumn();
            ConsumationDate = new DataGridViewTextBoxColumn();
            pnl_guests = new Panel();
            dataGridViewGuests = new DataGridView();
            GuestID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            AddPerson = new DataGridViewCheckBoxColumn();
            panel4 = new Panel();
            label26 = new Label();
            pnl_room = new Panel();
            btn_room_details = new Button();
            label_room_number = new Label();
            label24 = new Label();
            label_room_type = new Label();
            label22 = new Label();
            label20 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnl_description.SuspendLayout();
            pnl_check_in_out.SuspendLayout();
            pnl_reservation.SuspendLayout();
            pnl_basics.SuspendLayout();
            panel3.SuspendLayout();
            pnl_add_services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddServices).BeginInit();
            pnl_guests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).BeginInit();
            panel4.SuspendLayout();
            pnl_room.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label_res_number);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 86);
            panel1.TabIndex = 0;
            // 
            // label_res_number
            // 
            label_res_number.AutoSize = true;
            label_res_number.Font = new Font("Century Gothic", 12F);
            label_res_number.Location = new Point(309, 31);
            label_res_number.Name = "label_res_number";
            label_res_number.Size = new Size(179, 30);
            label_res_number.TabIndex = 1;
            label_res_number.Text = "some number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(270, 30);
            label1.TabIndex = 0;
            label1.Text = "Reservation Number :";
            // 
            // panel2
            // 
            panel2.Controls.Add(pnl_description);
            panel2.Controls.Add(pnl_check_in_out);
            panel2.Controls.Add(pnl_reservation);
            panel2.Controls.Add(pnl_basics);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 838);
            panel2.TabIndex = 1;
            // 
            // pnl_description
            // 
            pnl_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_description.BackColor = Color.Gainsboro;
            pnl_description.Controls.Add(label_description);
            pnl_description.Controls.Add(label18);
            pnl_description.Location = new Point(12, 630);
            pnl_description.Name = "pnl_description";
            pnl_description.Size = new Size(750, 142);
            pnl_description.TabIndex = 3;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_description.Location = new Point(16, 60);
            label_description.Name = "label_description";
            label_description.Size = new Size(288, 23);
            label_description.TabIndex = 11;
            label_description.Text = "Lorem ipsum neki description";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(12, 21);
            label18.Name = "label18";
            label18.Size = new Size(143, 26);
            label18.TabIndex = 3;
            label18.Text = "Description :";
            // 
            // pnl_check_in_out
            // 
            pnl_check_in_out.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_check_in_out.BackColor = Color.Gainsboro;
            pnl_check_in_out.Controls.Add(label_check_out_date);
            pnl_check_in_out.Controls.Add(label_check_in_date);
            pnl_check_in_out.Controls.Add(label15);
            pnl_check_in_out.Controls.Add(label14);
            pnl_check_in_out.Controls.Add(label13);
            pnl_check_in_out.Location = new Point(12, 440);
            pnl_check_in_out.Name = "pnl_check_in_out";
            pnl_check_in_out.Size = new Size(750, 184);
            pnl_check_in_out.TabIndex = 2;
            // 
            // label_check_out_date
            // 
            label_check_out_date.AutoSize = true;
            label_check_out_date.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_check_out_date.Location = new Point(202, 116);
            label_check_out_date.Name = "label_check_out_date";
            label_check_out_date.Size = new Size(189, 23);
            label_check_out_date.TabIndex = 10;
            label_check_out_date.Text = "datum checkouta";
            // 
            // label_check_in_date
            // 
            label_check_in_date.AutoSize = true;
            label_check_in_date.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_check_in_date.Location = new Point(180, 67);
            label_check_in_date.Name = "label_check_in_date";
            label_check_in_date.Size = new Size(172, 23);
            label_check_in_date.TabIndex = 9;
            label_check_in_date.Text = "datum checkina";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(21, 116);
            label15.Name = "label15";
            label15.Size = new Size(175, 23);
            label15.TabIndex = 8;
            label15.Text = "Date check out :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 67);
            label14.Name = "label14";
            label14.Size = new Size(158, 23);
            label14.TabIndex = 7;
            label14.Text = "Date check in :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 19);
            label13.Name = "label13";
            label13.Size = new Size(163, 26);
            label13.TabIndex = 2;
            label13.Text = "Check in / out";
            // 
            // pnl_reservation
            // 
            pnl_reservation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_reservation.BackColor = Color.Gainsboro;
            pnl_reservation.Controls.Add(label_end_date);
            pnl_reservation.Controls.Add(label_start_date);
            pnl_reservation.Controls.Add(label10);
            pnl_reservation.Controls.Add(label9);
            pnl_reservation.Controls.Add(label8);
            pnl_reservation.Controls.Add(label_reservation_date);
            pnl_reservation.Controls.Add(label6);
            pnl_reservation.Location = new Point(12, 210);
            pnl_reservation.Name = "pnl_reservation";
            pnl_reservation.Size = new Size(750, 216);
            pnl_reservation.TabIndex = 1;
            // 
            // label_end_date
            // 
            label_end_date.AutoSize = true;
            label_end_date.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_end_date.Location = new Point(146, 159);
            label_end_date.Name = "label_end_date";
            label_end_date.Size = new Size(147, 23);
            label_end_date.TabIndex = 8;
            label_end_date.Text = "zavrsni datum";
            // 
            // label_start_date
            // 
            label_start_date.AutoSize = true;
            label_start_date.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_start_date.Location = new Point(146, 114);
            label_start_date.Name = "label_start_date";
            label_start_date.Size = new Size(157, 23);
            label_start_date.TabIndex = 7;
            label_start_date.Text = "pocetni datum";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 73);
            label10.Name = "label10";
            label10.Size = new Size(189, 23);
            label10.TabIndex = 6;
            label10.Text = "Reservation date :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 159);
            label9.Name = "label9";
            label9.Size = new Size(112, 23);
            label9.TabIndex = 4;
            label9.Text = "End date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 114);
            label8.Name = "label8";
            label8.Size = new Size(119, 23);
            label8.TabIndex = 3;
            label8.Text = "Start date :";
            // 
            // label_reservation_date
            // 
            label_reservation_date.AutoSize = true;
            label_reservation_date.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_reservation_date.Location = new Point(216, 73);
            label_reservation_date.Name = "label_reservation_date";
            label_reservation_date.Size = new Size(189, 23);
            label_reservation_date.TabIndex = 2;
            label_reservation_date.Text = "Reservation date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(136, 26);
            label6.TabIndex = 1;
            label6.Text = "Reservation";
            // 
            // pnl_basics
            // 
            pnl_basics.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_basics.BackColor = Color.Gainsboro;
            pnl_basics.Controls.Add(label_status);
            pnl_basics.Controls.Add(label_employee_name);
            pnl_basics.Controls.Add(label4);
            pnl_basics.Controls.Add(label3);
            pnl_basics.Controls.Add(label2);
            pnl_basics.Location = new Point(12, 18);
            pnl_basics.Name = "pnl_basics";
            pnl_basics.Size = new Size(750, 175);
            pnl_basics.TabIndex = 0;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_status.Location = new Point(103, 67);
            label_status.Name = "label_status";
            label_status.Size = new Size(178, 23);
            label_status.TabIndex = 6;
            label_status.Text = "sttaus rezervacije";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 118);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 2;
            label4.Text = "Employee :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 67);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 1;
            label3.Text = "Status :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(79, 26);
            label2.TabIndex = 0;
            label2.Text = "Basics";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_close);
            panel3.Controls.Add(btn_exit);
            panel3.Controls.Add(pnl_add_services);
            panel3.Controls.Add(pnl_guests);
            panel3.Controls.Add(pnl_room);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(768, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(853, 838);
            panel3.TabIndex = 2;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_close.Location = new Point(701, 778);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(137, 48);
            btn_close.TabIndex = 6;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(723, 866);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(143, 50);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Visible = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // pnl_add_services
            // 
            pnl_add_services.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnl_add_services.BackColor = Color.Gainsboro;
            pnl_add_services.Controls.Add(label27);
            pnl_add_services.Controls.Add(dataGridViewAddServices);
            pnl_add_services.Location = new Point(14, 507);
            pnl_add_services.Name = "pnl_add_services";
            pnl_add_services.Size = new Size(827, 265);
            pnl_add_services.TabIndex = 3;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(334, 3);
            label27.Name = "label27";
            label27.Padding = new Padding(0, 3, 0, 3);
            label27.Size = new Size(174, 27);
            label27.TabIndex = 9;
            label27.Text = "Additional services";
            // 
            // dataGridViewAddServices
            // 
            dataGridViewAddServices.AllowUserToAddRows = false;
            dataGridViewAddServices.AllowUserToDeleteRows = false;
            dataGridViewAddServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAddServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAddServices.BackgroundColor = Color.White;
            dataGridViewAddServices.BorderStyle = BorderStyle.None;
            dataGridViewAddServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAddServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAddServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAddServices.ColumnHeadersHeight = 38;
            dataGridViewAddServices.Columns.AddRange(new DataGridViewColumn[] { ServiceName, Amount, ReservationDate, ConsumationDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAddServices.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAddServices.EnableHeadersVisualStyles = false;
            dataGridViewAddServices.Location = new Point(1, 33);
            dataGridViewAddServices.Name = "dataGridViewAddServices";
            dataGridViewAddServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAddServices.RowHeadersVisible = false;
            dataGridViewAddServices.RowHeadersWidth = 62;
            dataGridViewAddServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAddServices.Size = new Size(824, 231);
            dataGridViewAddServices.TabIndex = 2;
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
            // pnl_guests
            // 
            pnl_guests.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnl_guests.BackColor = Color.Gainsboro;
            pnl_guests.Controls.Add(dataGridViewGuests);
            pnl_guests.Controls.Add(panel4);
            pnl_guests.Location = new Point(14, 185);
            pnl_guests.Name = "pnl_guests";
            pnl_guests.Size = new Size(827, 317);
            pnl_guests.TabIndex = 2;
            // 
            // dataGridViewGuests
            // 
            dataGridViewGuests.AllowUserToAddRows = false;
            dataGridViewGuests.AllowUserToDeleteRows = false;
            dataGridViewGuests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewGuests.Columns.AddRange(new DataGridViewColumn[] { GuestID, FirstName, LastName, StartDate, EndDate, AddPerson });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewGuests.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGuests.EnableHeadersVisualStyles = false;
            dataGridViewGuests.Location = new Point(0, 27);
            dataGridViewGuests.Name = "dataGridViewGuests";
            dataGridViewGuests.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewGuests.RowHeadersVisible = false;
            dataGridViewGuests.RowHeadersWidth = 62;
            dataGridViewGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGuests.Size = new Size(824, 287);
            dataGridViewGuests.TabIndex = 1;
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
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label26);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(827, 38);
            panel4.TabIndex = 0;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(371, 0);
            label26.Name = "label26";
            label26.Padding = new Padding(0, 3, 0, 3);
            label26.Size = new Size(70, 27);
            label26.TabIndex = 8;
            label26.Text = "Guests";
            // 
            // pnl_room
            // 
            pnl_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnl_room.BackColor = Color.Gainsboro;
            pnl_room.Controls.Add(btn_room_details);
            pnl_room.Controls.Add(label_room_number);
            pnl_room.Controls.Add(label24);
            pnl_room.Controls.Add(label_room_type);
            pnl_room.Controls.Add(label22);
            pnl_room.Controls.Add(label20);
            pnl_room.Location = new Point(14, 18);
            pnl_room.Name = "pnl_room";
            pnl_room.Size = new Size(827, 161);
            pnl_room.TabIndex = 1;
            // 
            // btn_room_details
            // 
            btn_room_details.Location = new Point(359, 112);
            btn_room_details.Name = "btn_room_details";
            btn_room_details.Size = new Size(149, 34);
            btn_room_details.TabIndex = 0;
            btn_room_details.Text = "Details room";
            btn_room_details.UseVisualStyleBackColor = true;
            btn_room_details.Click += btn_room_details_Click;
            // 
            // label_room_number
            // 
            label_room_number.AutoSize = true;
            label_room_number.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_room_number.Location = new Point(185, 118);
            label_room_number.Name = "label_room_number";
            label_room_number.Size = new Size(74, 23);
            label_room_number.TabIndex = 10;
            label_room_number.Text = "neki br";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(19, 118);
            label24.Name = "label24";
            label24.Size = new Size(160, 23);
            label24.TabIndex = 9;
            label24.Text = "Room number :";
            // 
            // label_room_type
            // 
            label_room_type.AutoSize = true;
            label_room_type.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_room_type.Location = new Point(154, 67);
            label_room_type.Name = "label_room_type";
            label_room_type.Size = new Size(191, 23);
            label_room_type.TabIndex = 8;
            label_room_type.Text = "npr jednokrevetna";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(19, 67);
            label22.Name = "label22";
            label22.Size = new Size(129, 23);
            label22.TabIndex = 7;
            label22.Text = "Room type :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(19, 15);
            label20.Name = "label20";
            label20.Size = new Size(74, 26);
            label20.TabIndex = 2;
            label20.Text = "Room";
            // 
            // Reservations_DetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1621, 924);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Reservations_DetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservations_DetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnl_description.ResumeLayout(false);
            pnl_description.PerformLayout();
            pnl_check_in_out.ResumeLayout(false);
            pnl_check_in_out.PerformLayout();
            pnl_reservation.ResumeLayout(false);
            pnl_reservation.PerformLayout();
            pnl_basics.ResumeLayout(false);
            pnl_basics.PerformLayout();
            panel3.ResumeLayout(false);
            pnl_add_services.ResumeLayout(false);
            pnl_add_services.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddServices).EndInit();
            pnl_guests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuests).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnl_room.ResumeLayout(false);
            pnl_room.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_res_number;
        private Label label1;
        private Panel panel2;
        private Panel pnl_description;
        private Panel pnl_check_in_out;
        private Panel pnl_reservation;
        private Panel pnl_basics;
        private Panel panel3;
        private Panel pnl_add_services;
        private Panel pnl_guests;
        private Panel pnl_room;
        private Button btn_exit;
        private Button btn_close;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label_end_date;
        private Label label_start_date;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label_reservation_date;
        private Label label6;
        private Label label_employee_name;
        private Label label_description;
        private Label label18;
        private Label label_check_out_date;
        private Label label_check_in_date;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label_status;
        private Label label24;
        private Label label_room_type;
        private Label label22;
        private Label label20;
        private Panel panel4;
        private Label label26;
        private Button btn_room_details;
        private Label label_room_number;
        private DataGridView dataGridViewGuests;
        private Label label27;
        private DataGridView dataGridViewAddServices;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ReservationDate;
        private DataGridViewTextBoxColumn ConsumationDate;
        private DataGridViewTextBoxColumn GuestID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewCheckBoxColumn AddPerson;
    }
}