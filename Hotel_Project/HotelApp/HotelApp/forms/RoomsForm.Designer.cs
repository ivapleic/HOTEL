namespace HotelApp.forms
{
    partial class RoomsForm
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label_num_of_rooms = new Label();
            label2 = new Label();
            btn_add_room = new Button();
            btn_delete_room = new Button();
            btn_update_room = new Button();
            btn_room_details = new Button();
            dataGridViewRooms = new DataGridView();
            RoomNumber = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            RoomFloor = new DataGridViewTextBoxColumn();
            RoomAvailable = new DataGridViewTextBoxColumn();
            RoomDescription = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(600, 30);
            label1.Name = "label1";
            label1.Size = new Size(305, 56);
            label1.TabIndex = 0;
            label1.Text = "List of rooms";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 105);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 86, 182);
            panel2.Controls.Add(label_num_of_rooms);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(34, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 60);
            panel2.TabIndex = 2;
            // 
            // label_num_of_rooms
            // 
            label_num_of_rooms.AutoSize = true;
            label_num_of_rooms.Font = new Font("Century Gothic", 11F);
            label_num_of_rooms.ForeColor = Color.White;
            label_num_of_rooms.Location = new Point(227, 17);
            label_num_of_rooms.Name = "label_num_of_rooms";
            label_num_of_rooms.Size = new Size(161, 25);
            label_num_of_rooms.TabIndex = 1;
            label_num_of_rooms.Text = "some number";
            label_num_of_rooms.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of rooms:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_add_room
            // 
            btn_add_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_room.Location = new Point(1093, 257);
            btn_add_room.Name = "btn_add_room";
            btn_add_room.Size = new Size(164, 58);
            btn_add_room.TabIndex = 4;
            btn_add_room.Text = "Add New";
            btn_add_room.UseVisualStyleBackColor = true;
            btn_add_room.Click += btn_add_room_Click;
            // 
            // btn_delete_room
            // 
            btn_delete_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_room.Location = new Point(1094, 352);
            btn_delete_room.Name = "btn_delete_room";
            btn_delete_room.Size = new Size(163, 62);
            btn_delete_room.TabIndex = 5;
            btn_delete_room.Text = "Delete";
            btn_delete_room.UseVisualStyleBackColor = true;
            // 
            // btn_update_room
            // 
            btn_update_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_room.Location = new Point(1094, 454);
            btn_update_room.Name = "btn_update_room";
            btn_update_room.Size = new Size(163, 60);
            btn_update_room.TabIndex = 6;
            btn_update_room.Text = "Update";
            btn_update_room.UseVisualStyleBackColor = true;
            // 
            // btn_room_details
            // 
            btn_room_details.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_room_details.Location = new Point(1094, 551);
            btn_room_details.Name = "btn_room_details";
            btn_room_details.Size = new Size(163, 61);
            btn_room_details.TabIndex = 7;
            btn_room_details.Text = "Details";
            btn_room_details.UseVisualStyleBackColor = true;
            btn_room_details.Click += btn_room_details_Click;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.AllowUserToAddRows = false;
            dataGridViewRooms.AllowUserToDeleteRows = false;
            dataGridViewRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRooms.BackgroundColor = Color.White;
            dataGridViewRooms.BorderStyle = BorderStyle.None;
            dataGridViewRooms.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewRooms.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewRooms.ColumnHeadersHeight = 38;
            dataGridViewRooms.Columns.AddRange(new DataGridViewColumn[] { RoomNumber, RoomType, RoomFloor, RoomAvailable, RoomDescription });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewRooms.EnableHeadersVisualStyles = false;
            dataGridViewRooms.GridColor = Color.White;
            dataGridViewRooms.Location = new Point(0, -4);
            dataGridViewRooms.MultiSelect = false;
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.ReadOnly = true;
            dataGridViewRooms.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewRooms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewRooms.RowHeadersVisible = false;
            dataGridViewRooms.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewRooms.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewRooms.RowTemplate.Height = 30;
            dataGridViewRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRooms.Size = new Size(1018, 532);
            dataGridViewRooms.TabIndex = 0;
            dataGridViewRooms.CellMouseDoubleClick += dataGridViewRooms_CellMouseDoubleClick;
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomNumber.FillWeight = 150F;
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.MinimumWidth = 8;
            RoomNumber.Name = "RoomNumber";
            RoomNumber.ReadOnly = true;
            // 
            // RoomType
            // 
            RoomType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomType.FillWeight = 150F;
            RoomType.HeaderText = "Room Type";
            RoomType.MinimumWidth = 8;
            RoomType.Name = "RoomType";
            RoomType.ReadOnly = true;
            // 
            // RoomFloor
            // 
            RoomFloor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomFloor.FillWeight = 150F;
            RoomFloor.HeaderText = "Floor";
            RoomFloor.MinimumWidth = 8;
            RoomFloor.Name = "RoomFloor";
            RoomFloor.ReadOnly = true;
            // 
            // RoomAvailable
            // 
            RoomAvailable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomAvailable.FillWeight = 150F;
            RoomAvailable.HeaderText = "Available";
            RoomAvailable.MinimumWidth = 8;
            RoomAvailable.Name = "RoomAvailable";
            RoomAvailable.ReadOnly = true;
            // 
            // RoomDescription
            // 
            RoomDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoomDescription.FillWeight = 150F;
            RoomDescription.HeaderText = "Room Description";
            RoomDescription.MinimumWidth = 8;
            RoomDescription.Name = "RoomDescription";
            RoomDescription.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(28, 78, 128);
            panel3.Controls.Add(dataGridViewRooms);
            panel3.Location = new Point(34, 192);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 521);
            panel3.TabIndex = 3;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 715);
            Controls.Add(btn_room_details);
            Controls.Add(btn_update_room);
            Controls.Add(btn_delete_room);
            Controls.Add(btn_add_room);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "RoomsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label_num_of_rooms;
        private Label label2;
        private Button btn_add_room;
        private Button btn_delete_room;
        private Button btn_update_room;
        private Button btn_room_details;
        private DataGridView dataGridViewRooms;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn RoomFloor;
        private DataGridViewTextBoxColumn RoomAvailable;
        private DataGridViewTextBoxColumn RoomDescription;
        private Panel panel3;
    }
}