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
            label_num_of_floors = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridViewFloors = new DataGridView();
            btn_delete_floor = new Button();
            btn_update_floor = new Button();
            btn_add_new_floor = new Button();
            RoomAccName = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFloors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 78, 128);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 110);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(380, 30);
            label1.Name = "label1";
            label1.Size = new Size(538, 51);
            label1.TabIndex = 0;
            label1.Text = "List of Room Accessories";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(28, 78, 128);
            panel2.Controls.Add(label_num_of_floors);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(30, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(1278, 53);
            panel2.TabIndex = 2;
            // 
            // label_num_of_floors
            // 
            label_num_of_floors.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_num_of_floors.AutoSize = true;
            label_num_of_floors.ForeColor = Color.White;
            label_num_of_floors.Location = new Point(623, 14);
            label_num_of_floors.Name = "label_num_of_floors";
            label_num_of_floors.Size = new Size(54, 25);
            label_num_of_floors.TabIndex = 1;
            label_num_of_floors.Text = "npr 7";
            label_num_of_floors.TextAlign = ContentAlignment.MiddleCenter;
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(28, 78, 128);
            panel3.Controls.Add(dataGridViewFloors);
            panel3.Location = new Point(30, 211);
            panel3.Name = "panel3";
            panel3.Size = new Size(1275, 422);
            panel3.TabIndex = 3;
            // 
            // dataGridViewFloors
            // 
            dataGridViewFloors.AllowUserToAddRows = false;
            dataGridViewFloors.AllowUserToDeleteRows = false;
            dataGridViewFloors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewFloors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFloors.BackgroundColor = Color.White;
            dataGridViewFloors.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFloors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFloors.ColumnHeadersHeight = 38;
            dataGridViewFloors.Columns.AddRange(new DataGridViewColumn[] { RoomAccName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewFloors.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewFloors.EnableHeadersVisualStyles = false;
            dataGridViewFloors.Location = new Point(414, 4);
            dataGridViewFloors.Name = "dataGridViewFloors";
            dataGridViewFloors.RowHeadersWidth = 62;
            dataGridViewFloors.Size = new Size(474, 418);
            dataGridViewFloors.TabIndex = 0;
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
            // 
            // RoomAccName
            // 
            RoomAccName.HeaderText = "Accessory Name";
            RoomAccName.MinimumWidth = 8;
            RoomAccName.Name = "RoomAccName";
            // 
            // Form_RoomsAccessories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 715);
            Controls.Add(btn_delete_floor);
            Controls.Add(btn_update_floor);
            Controls.Add(btn_add_new_floor);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "Form_RoomsAccessories";
            Text = "Form_RoomsAccessories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFloors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label_num_of_floors;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridViewFloors;
        private DataGridViewTextBoxColumn RoomAccName;
        private Button btn_delete_floor;
        private Button btn_update_floor;
        private Button btn_add_new_floor;
    }
}