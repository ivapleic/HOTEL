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
            btn_add_new_acc = new Button();
            dataGridViewAccessories = new DataGridView();
            RoomAccID = new DataGridViewTextBoxColumn();
            RoomAccName = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccessories).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(600, 30);
            label1.Name = "label1";
            label1.Size = new Size(538, 51);
            label1.TabIndex = 0;
            label1.Text = "List of Room Accessories";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 86, 182);
            panel2.Controls.Add(label_num_of_acc);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(80, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 60);
            panel2.TabIndex = 2;
            panel2.UseWaitCursor = true;
            // 
            // label_num_of_acc
            // 
            label_num_of_acc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_num_of_acc.AutoSize = true;
            label_num_of_acc.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_num_of_acc.ForeColor = Color.White;
            label_num_of_acc.Location = new Point(292, 18);
            label_num_of_acc.Name = "label_num_of_acc";
            label_num_of_acc.Size = new Size(65, 25);
            label_num_of_acc.TabIndex = 1;
            label_num_of_acc.Text = "npr 7";
            label_num_of_acc.TextAlign = ContentAlignment.MiddleCenter;
            label_num_of_acc.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 18);
            label2.Name = "label2";
            label2.Size = new Size(267, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of accessories: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // btn_delete_floor
            // 
            btn_delete_floor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_floor.Location = new Point(730, 448);
            btn_delete_floor.Name = "btn_delete_floor";
            btn_delete_floor.Size = new Size(143, 58);
            btn_delete_floor.TabIndex = 9;
            btn_delete_floor.Text = "Delete";
            btn_delete_floor.UseVisualStyleBackColor = true;
            btn_delete_floor.Click += btn_delete_floor_Click;
            // 
            // btn_update_floor
            // 
            btn_update_floor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_floor.Location = new Point(730, 346);
            btn_update_floor.Name = "btn_update_floor";
            btn_update_floor.Size = new Size(143, 57);
            btn_update_floor.TabIndex = 8;
            btn_update_floor.Text = "Update";
            btn_update_floor.UseVisualStyleBackColor = true;
            btn_update_floor.Click += btn_update_floor_Click;
            // 
            // btn_add_new_acc
            // 
            btn_add_new_acc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_new_acc.Location = new Point(730, 246);
            btn_add_new_acc.Name = "btn_add_new_acc";
            btn_add_new_acc.Size = new Size(143, 59);
            btn_add_new_acc.TabIndex = 7;
            btn_add_new_acc.Text = "Add New";
            btn_add_new_acc.UseVisualStyleBackColor = true;
            btn_add_new_acc.Click += btn_add_new_acc_Click;
            // 
            // dataGridViewAccessories
            // 
            dataGridViewAccessories.AllowUserToAddRows = false;
            dataGridViewAccessories.AllowUserToDeleteRows = false;
            dataGridViewAccessories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAccessories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccessories.BackgroundColor = Color.White;
            dataGridViewAccessories.BorderStyle = BorderStyle.None;
            dataGridViewAccessories.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAccessories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAccessories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAccessories.ColumnHeadersHeight = 38;
            dataGridViewAccessories.Columns.AddRange(new DataGridViewColumn[] { RoomAccID, RoomAccName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAccessories.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAccessories.EnableHeadersVisualStyles = false;
            dataGridViewAccessories.Location = new Point(0, 0);
            dataGridViewAccessories.Name = "dataGridViewAccessories";
            dataGridViewAccessories.RowHeadersVisible = false;
            dataGridViewAccessories.RowHeadersWidth = 62;
            dataGridViewAccessories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAccessories.Size = new Size(575, 503);
            dataGridViewAccessories.TabIndex = 0;
            dataGridViewAccessories.CellClick += dataGridViewAccessories_CellClick;
            dataGridViewAccessories.DataBindingComplete += dataGridViewAccessories_DataBindingComplete;
            // 
            // RoomAccID
            // 
            RoomAccID.HeaderText = "Room Acc ID";
            RoomAccID.MinimumWidth = 8;
            RoomAccID.Name = "RoomAccID";
            RoomAccID.Visible = false;
            // 
            // RoomAccName
            // 
            RoomAccName.HeaderText = "Accessory Name";
            RoomAccName.MinimumWidth = 8;
            RoomAccName.Name = "RoomAccName";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(dataGridViewAccessories);
            panel3.Location = new Point(80, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(575, 503);
            panel3.TabIndex = 10;
            // 
            // Form_RoomsAccessories
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1349, 721);
            Controls.Add(panel3);
            Controls.Add(btn_delete_floor);
            Controls.Add(btn_update_floor);
            Controls.Add(btn_add_new_acc);
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
            panel3.ResumeLayout(false);
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
        private Button btn_add_new_acc;
        private DataGridView dataGridViewAccessories;
        private DataGridViewTextBoxColumn RoomAccID;
        private DataGridViewTextBoxColumn RoomAccName;
        private Panel panel3;
    }
}