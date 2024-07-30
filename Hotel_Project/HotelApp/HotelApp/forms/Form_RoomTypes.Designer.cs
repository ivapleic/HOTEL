namespace HotelApp.forms
{
    partial class RoomTypesForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label_num_of_room_types = new Label();
            label2 = new Label();
            dataGridView_RoomTypes = new DataGridView();
            Room_type_ID = new DataGridViewTextBoxColumn();
            Room_type_name = new DataGridViewTextBoxColumn();
            Number_of_persons = new DataGridViewTextBoxColumn();
            Number_of_children = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btn_update_room = new Button();
            btn_delete_room = new Button();
            btn_add_room = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_RoomTypes).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1345, 105);
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
            label1.Size = new Size(423, 56);
            label1.TabIndex = 0;
            label1.Text = "List of room types";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 86, 182);
            panel2.Controls.Add(label_num_of_room_types);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(34, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 60);
            panel2.TabIndex = 3;
            // 
            // label_num_of_room_types
            // 
            label_num_of_room_types.AutoSize = true;
            label_num_of_room_types.Font = new Font("Century Gothic", 11F);
            label_num_of_room_types.ForeColor = Color.White;
            label_num_of_room_types.Location = new Point(294, 17);
            label_num_of_room_types.Name = "label_num_of_room_types";
            label_num_of_room_types.Size = new Size(161, 25);
            label_num_of_room_types.TabIndex = 1;
            label_num_of_room_types.Text = "some number";
            label_num_of_room_types.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 17);
            label2.Name = "label2";
            label2.Size = new Size(266, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of room types :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView_RoomTypes
            // 
            dataGridView_RoomTypes.AllowUserToAddRows = false;
            dataGridView_RoomTypes.AllowUserToDeleteRows = false;
            dataGridView_RoomTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_RoomTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_RoomTypes.BackgroundColor = Color.White;
            dataGridView_RoomTypes.BorderStyle = BorderStyle.None;
            dataGridView_RoomTypes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_RoomTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_RoomTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_RoomTypes.ColumnHeadersHeight = 38;
            dataGridView_RoomTypes.Columns.AddRange(new DataGridViewColumn[] { Room_type_ID, Room_type_name, Number_of_persons, Number_of_children });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_RoomTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_RoomTypes.EnableHeadersVisualStyles = false;
            dataGridView_RoomTypes.Location = new Point(0, 0);
            dataGridView_RoomTypes.Name = "dataGridView_RoomTypes";
            dataGridView_RoomTypes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_RoomTypes.RowHeadersVisible = false;
            dataGridView_RoomTypes.RowHeadersWidth = 62;
            dataGridView_RoomTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_RoomTypes.Size = new Size(1067, 459);
            dataGridView_RoomTypes.TabIndex = 4;
            dataGridView_RoomTypes.CellClick += dataGridView_RoomTypes_CellClick;
            dataGridView_RoomTypes.DataBindingComplete += dataGridView_RoomTypes_DataBindingComplete;
            // 
            // Room_type_ID
            // 
            Room_type_ID.HeaderText = "Room type ID";
            Room_type_ID.MinimumWidth = 8;
            Room_type_ID.Name = "Room_type_ID";
            // 
            // Room_type_name
            // 
            Room_type_name.HeaderText = "Room Type Name";
            Room_type_name.MinimumWidth = 8;
            Room_type_name.Name = "Room_type_name";
            // 
            // Number_of_persons
            // 
            Number_of_persons.HeaderText = "Number of people";
            Number_of_persons.MinimumWidth = 8;
            Number_of_persons.Name = "Number_of_persons";
            // 
            // Number_of_children
            // 
            Number_of_children.HeaderText = "Number of children";
            Number_of_children.MinimumWidth = 8;
            Number_of_children.Name = "Number_of_children";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(dataGridView_RoomTypes);
            panel3.Location = new Point(34, 205);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1067, 449);
            panel3.TabIndex = 5;
            // 
            // btn_update_room
            // 
            btn_update_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_room.Location = new Point(1127, 474);
            btn_update_room.Name = "btn_update_room";
            btn_update_room.Size = new Size(163, 60);
            btn_update_room.TabIndex = 10;
            btn_update_room.Text = "Update";
            btn_update_room.UseVisualStyleBackColor = true;
            // 
            // btn_delete_room
            // 
            btn_delete_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_room.Location = new Point(1127, 372);
            btn_delete_room.Name = "btn_delete_room";
            btn_delete_room.Size = new Size(163, 62);
            btn_delete_room.TabIndex = 9;
            btn_delete_room.Text = "Delete";
            btn_delete_room.UseVisualStyleBackColor = true;
            // 
            // btn_add_room
            // 
            btn_add_room.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_room.Location = new Point(1126, 277);
            btn_add_room.Name = "btn_add_room";
            btn_add_room.Size = new Size(164, 58);
            btn_add_room.TabIndex = 8;
            btn_add_room.Text = "Add New";
            btn_add_room.UseVisualStyleBackColor = true;
            btn_add_room.Click += btn_add_room_Click;
            // 
            // RoomTypesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1345, 736);
            Controls.Add(btn_update_room);
            Controls.Add(btn_delete_room);
            Controls.Add(btn_add_room);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "RoomTypesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomTypes";
            WindowState = FormWindowState.Maximized;
            Load += RoomTypesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_RoomTypes).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label_num_of_room_types;
        private Label label2;
        private DataGridView dataGridView_RoomTypes;
        private DataGridViewTextBoxColumn Room_type_ID;
        private DataGridViewTextBoxColumn Room_type_name;
        private DataGridViewTextBoxColumn Number_of_persons;
        private DataGridViewTextBoxColumn Number_of_children;
        private Panel panel3;
        private Button btn_update_room;
        private Button btn_delete_room;
        private Button btn_add_room;
    }
}