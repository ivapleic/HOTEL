namespace HotelApp.forms
{
    partial class Form_Reservations
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label_num_of_reservations = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridViewReservations = new DataGridView();
            ReservationID = new DataGridViewTextBoxColumn();
            ReservationNumber = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            EmployeName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            CheckInDate = new DataGridViewTextBoxColumn();
            CheckOutDate = new DataGridViewTextBoxColumn();
            ReservationStatus = new DataGridViewTextBoxColumn();
            btn_details_reservations = new Button();
            btn_add_new_reservation = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 3, 3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 105);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(600, 32);
            label1.Name = "label1";
            label1.Size = new Size(441, 56);
            label1.TabIndex = 0;
            label1.Text = "List of reservations";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 86, 182);
            panel2.Controls.Add(label_num_of_reservations);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(1296, 60);
            panel2.TabIndex = 3;
            // 
            // label_num_of_reservations
            // 
            label_num_of_reservations.AutoSize = true;
            label_num_of_reservations.Font = new Font("Century Gothic", 11F);
            label_num_of_reservations.ForeColor = Color.White;
            label_num_of_reservations.Location = new Point(294, 17);
            label_num_of_reservations.Name = "label_num_of_reservations";
            label_num_of_reservations.Size = new Size(161, 25);
            label_num_of_reservations.TabIndex = 1;
            label_num_of_reservations.Text = "some number";
            label_num_of_reservations.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(271, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of reservations :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(dataGridViewReservations);
            panel3.Location = new Point(12, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(1296, 393);
            panel3.TabIndex = 4;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.AllowUserToAddRows = false;
            dataGridViewReservations.AllowUserToDeleteRows = false;
            dataGridViewReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservations.BackgroundColor = Color.White;
            dataGridViewReservations.BorderStyle = BorderStyle.None;
            dataGridViewReservations.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewReservations.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewReservations.ColumnHeadersHeight = 55;
            dataGridViewReservations.Columns.AddRange(new DataGridViewColumn[] { ReservationID, ReservationNumber, RoomType, RoomNumber, EmployeName, StartDate, EndDate, CheckInDate, CheckOutDate, ReservationStatus });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewReservations.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewReservations.EnableHeadersVisualStyles = false;
            dataGridViewReservations.GridColor = Color.White;
            dataGridViewReservations.Location = new Point(0, 0);
            dataGridViewReservations.MultiSelect = false;
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.ReadOnly = true;
            dataGridViewReservations.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewReservations.RowHeadersVisible = false;
            dataGridViewReservations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewReservations.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewReservations.RowTemplate.Height = 30;
            dataGridViewReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservations.Size = new Size(1296, 393);
            dataGridViewReservations.TabIndex = 1;
            // 
            // ReservationID
            // 
            ReservationID.HeaderText = "Reservation ID";
            ReservationID.MinimumWidth = 8;
            ReservationID.Name = "ReservationID";
            ReservationID.ReadOnly = true;
            ReservationID.Visible = false;
            // 
            // ReservationNumber
            // 
            ReservationNumber.HeaderText = "Reservation Number";
            ReservationNumber.MinimumWidth = 8;
            ReservationNumber.Name = "ReservationNumber";
            ReservationNumber.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.HeaderText = "Room Type";
            RoomType.MinimumWidth = 8;
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 8;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // EmployeName
            // 
            EmployeName.HeaderText = "Employee";
            EmployeName.MinimumWidth = 8;
            EmployeName.Name = "EmployeName";
            EmployeName.ReadOnly = true;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Start Date";
            StartDate.MinimumWidth = 8;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "End Date";
            EndDate.MinimumWidth = 8;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            // 
            // CheckInDate
            // 
            CheckInDate.HeaderText = "Check In Date";
            CheckInDate.MinimumWidth = 8;
            CheckInDate.Name = "CheckInDate";
            CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            CheckOutDate.HeaderText = "Check-Out Date";
            CheckOutDate.MinimumWidth = 8;
            CheckOutDate.Name = "CheckOutDate";
            CheckOutDate.ReadOnly = true;
            // 
            // ReservationStatus
            // 
            ReservationStatus.HeaderText = "Reservation Status";
            ReservationStatus.MinimumWidth = 8;
            ReservationStatus.Name = "ReservationStatus";
            ReservationStatus.ReadOnly = true;
            // 
            // btn_details_reservations
            // 
            btn_details_reservations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_details_reservations.Location = new Point(918, 630);
            btn_details_reservations.Name = "btn_details_reservations";
            btn_details_reservations.Size = new Size(133, 48);
            btn_details_reservations.TabIndex = 5;
            btn_details_reservations.Text = "Details";
            btn_details_reservations.UseVisualStyleBackColor = true;
            btn_details_reservations.Click += btn_details_reservations_Click;
            // 
            // btn_add_new_reservation
            // 
            btn_add_new_reservation.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_new_reservation.Location = new Point(761, 630);
            btn_add_new_reservation.Name = "btn_add_new_reservation";
            btn_add_new_reservation.Size = new Size(133, 48);
            btn_add_new_reservation.TabIndex = 6;
            btn_add_new_reservation.Text = "Add new";
            btn_add_new_reservation.UseVisualStyleBackColor = true;
            btn_add_new_reservation.Click += btn_add_new_reservation_Click;
            // 
            // Form_Reservations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 699);
            Controls.Add(btn_add_new_reservation);
            Controls.Add(btn_details_reservations);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "Form_Reservations";
            Text = "Form_Reservations";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label_num_of_reservations;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridViewReservations;
        private DataGridViewTextBoxColumn ReservationID;
        private DataGridViewTextBoxColumn ReservationNumber;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn EmployeName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn CheckInDate;
        private DataGridViewTextBoxColumn CheckOutDate;
        private DataGridViewTextBoxColumn ReservationStatus;
        private Button btn_details_reservations;
        private Button btn_add_new_reservation;
    }
}