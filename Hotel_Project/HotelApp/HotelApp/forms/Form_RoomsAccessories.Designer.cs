namespace HotelApp.forms
{
    partial class Form_RoomsAccessories
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
            label_num_of_acc = new Label();
            label2 = new Label();
            btn_delete_floor = new Button();
            btn_update_floor = new Button();
            btn_add_new_floor = new Button();
            dataGridViewAccessories = new DataGridView();
            RoomAccID = new DataGridViewTextBoxColumn();
            RoomAccName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccessories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 78, 128);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(380, 18);
            label1.Name = "label1";
            label1.Size = new Size(538, 51);
            label1.TabIndex = 0;
            label1.Text = "List of Room Accessories";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(28, 78, 128);
            panel2.Controls.Add(label_num_of_acc);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(138, 115);
            panel2.Margin = new Padding(3, 3, 3, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 53);
            panel2.TabIndex = 2;
            // 
            // label_num_of_acc
            // 
            label_num_of_acc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_num_of_acc.AutoSize = true;
            label_num_of_acc.ForeColor = Color.White;
            label_num_of_acc.Location = new Point(623, 14);
            label_num_of_acc.Name = "label_num_of_acc";
            label_num_of_acc.Size = new Size(54, 25);
            label_num_of_acc.TabIndex = 1;
            label_num_of_acc.Text = "npr 7";
            label_num_of_acc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(398, 14);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of accessories: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_delete_floor
            // 
            btn_delete_floor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_floor.Location = new Point(1196, 656);
            btn_delete_floor.Name = "btn_delete_floor";
            btn_delete_floor.Size = new Size(112, 34);
            btn_delete_floor.TabIndex = 9;
            btn_delete_floor.Text = "Delete";
            btn_delete_floor.UseVisualStyleBackColor = true;
            // 
            // btn_update_floor
            // 
            btn_update_floor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_floor.Location = new Point(1073, 656);
            btn_update_floor.Name = "btn_update_floor";
            btn_update_floor.Size = new Size(112, 34);
            btn_update_floor.TabIndex = 8;
            btn_update_floor.Text = "Update";
            btn_update_floor.UseVisualStyleBackColor = true;
            // 
            // btn_add_new_floor
            // 
            btn_add_new_floor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_new_floor.Location = new Point(955, 656);
            btn_add_new_floor.Name = "btn_add_new_floor";
            btn_add_new_floor.Size = new Size(112, 34);
            btn_add_new_floor.TabIndex = 7;
            btn_add_new_floor.Text = "Add New";
            btn_add_new_floor.UseVisualStyleBackColor = true;
            btn_add_new_floor.Click += btn_add_new_floor_Click;
            // 
            // dataGridViewAccessories
            // 
            dataGridViewAccessories.AllowUserToAddRows = false;
            dataGridViewAccessories.AllowUserToDeleteRows = false;
            dataGridViewAccessories.AllowUserToResizeColumns = false;
            dataGridViewAccessories.AllowUserToResizeRows = false;
            dataGridViewAccessories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAccessories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccessories.BackgroundColor = Color.White;
            dataGridViewAccessories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAccessories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAccessories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccessories.Columns.AddRange(new DataGridViewColumn[] { RoomAccID, RoomAccName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAccessories.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAccessories.EnableHeadersVisualStyles = false;
            dataGridViewAccessories.Location = new Point(448, 267);
            dataGridViewAccessories.Name = "dataGridViewAccessories";
            dataGridViewAccessories.ReadOnly = true;
            dataGridViewAccessories.RowHeadersWidth = 62;
            dataGridViewAccessories.Size = new Size(494, 323);
            dataGridViewAccessories.TabIndex = 0;
            // 
            // RoomAccID
            // 
            RoomAccID.HeaderText = "Room Acc ID";
            RoomAccID.MinimumWidth = 8;
            RoomAccID.Name = "RoomAccID";
            RoomAccID.ReadOnly = true;
            RoomAccID.Visible = false;
            // 
            // RoomAccName
            // 
            RoomAccName.HeaderText = "Accessory Name";
            RoomAccName.MinimumWidth = 8;
            RoomAccName.Name = "RoomAccName";
            RoomAccName.ReadOnly = true;
            // 
            // Form_RoomsAccessories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 715);
            Controls.Add(dataGridViewAccessories);
            Controls.Add(btn_delete_floor);
            Controls.Add(btn_update_floor);
            Controls.Add(btn_add_new_floor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "Form_RoomsAccessories";
            Text = "Form_RoomsAccessories";
            Load += Form_RoomsAccessories_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccessories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label_num_of_acc;
        private Label label2;
        private Button btn_delete_floor;
        private Button btn_update_floor;
        private Button btn_add_new_floor;
        private DataGridView dataGridViewAccessories;
        private DataGridViewTextBoxColumn RoomAccID;
        private DataGridViewTextBoxColumn RoomAccName;
    }
}