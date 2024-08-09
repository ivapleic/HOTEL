namespace HotelApp.forms
{
    partial class Form_AddServices
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
            panel3 = new Panel();
            dataGridViewAddServices = new DataGridView();
            AddService_ID = new DataGridViewTextBoxColumn();
            AddService_Name = new DataGridViewTextBoxColumn();
            AddService_Price = new DataGridViewTextBoxColumn();
            AddService_Description = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label_num_of_add_services = new Label();
            label2 = new Label();
            btn_delete_add_service = new Button();
            btn_update_add_service = new Button();
            btn_add_new_add_service = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddServices).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 104);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(600, 30);
            label1.Name = "label1";
            label1.Size = new Size(610, 56);
            label1.TabIndex = 0;
            label1.Text = "List of Additional Services";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(dataGridViewAddServices);
            panel3.Location = new Point(87, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(944, 503);
            panel3.TabIndex = 4;
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
            dataGridViewAddServices.Columns.AddRange(new DataGridViewColumn[] { AddService_ID, AddService_Name, AddService_Price, AddService_Description });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAddServices.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAddServices.EnableHeadersVisualStyles = false;
            dataGridViewAddServices.Location = new Point(0, 0);
            dataGridViewAddServices.Name = "dataGridViewAddServices";
            dataGridViewAddServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewAddServices.RowHeadersVisible = false;
            dataGridViewAddServices.RowHeadersWidth = 62;
            dataGridViewAddServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAddServices.Size = new Size(944, 503);
            dataGridViewAddServices.TabIndex = 0;
            // 
            // AddService_ID
            // 
            AddService_ID.HeaderText = "Add Service ID";
            AddService_ID.MinimumWidth = 8;
            AddService_ID.Name = "AddService_ID";
            AddService_ID.Visible = false;
            // 
            // AddService_Name
            // 
            AddService_Name.HeaderText = "Name";
            AddService_Name.MinimumWidth = 8;
            AddService_Name.Name = "AddService_Name";
            // 
            // AddService_Price
            // 
            AddService_Price.HeaderText = "Price";
            AddService_Price.MinimumWidth = 8;
            AddService_Price.Name = "AddService_Price";
            // 
            // AddService_Description
            // 
            AddService_Description.HeaderText = "Description";
            AddService_Description.MinimumWidth = 8;
            AddService_Description.Name = "AddService_Description";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(40, 86, 182);
            panel2.Controls.Add(label_num_of_add_services);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(87, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(944, 60);
            panel2.TabIndex = 3;
            // 
            // label_num_of_add_services
            // 
            label_num_of_add_services.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_num_of_add_services.AutoSize = true;
            label_num_of_add_services.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_num_of_add_services.ForeColor = Color.White;
            label_num_of_add_services.Location = new Point(369, 18);
            label_num_of_add_services.Name = "label_num_of_add_services";
            label_num_of_add_services.Size = new Size(65, 25);
            label_num_of_add_services.TabIndex = 1;
            label_num_of_add_services.Text = "npr 7";
            label_num_of_add_services.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(349, 25);
            label2.TabIndex = 0;
            label2.Text = "Number of additional services : ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_delete_add_service
            // 
            btn_delete_add_service.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_add_service.Location = new Point(1120, 483);
            btn_delete_add_service.Name = "btn_delete_add_service";
            btn_delete_add_service.Size = new Size(162, 60);
            btn_delete_add_service.TabIndex = 9;
            btn_delete_add_service.Text = "Delete";
            btn_delete_add_service.UseVisualStyleBackColor = true;
            btn_delete_add_service.Click += btn_delete_add_service_Click;
            // 
            // btn_update_add_service
            // 
            btn_update_add_service.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_add_service.Location = new Point(1120, 344);
            btn_update_add_service.Name = "btn_update_add_service";
            btn_update_add_service.Size = new Size(162, 60);
            btn_update_add_service.TabIndex = 8;
            btn_update_add_service.Text = "Update";
            btn_update_add_service.UseVisualStyleBackColor = true;
            btn_update_add_service.Click += btn_update_add_service_Click;
            // 
            // btn_add_new_add_service
            // 
            btn_add_new_add_service.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_new_add_service.Location = new Point(1120, 205);
            btn_add_new_add_service.Name = "btn_add_new_add_service";
            btn_add_new_add_service.Size = new Size(164, 64);
            btn_add_new_add_service.TabIndex = 7;
            btn_add_new_add_service.Text = "Add New";
            btn_add_new_add_service.UseVisualStyleBackColor = true;
            btn_add_new_add_service.Click += btn_add_new_add_service_Click;
            // 
            // Form_AddServices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1342, 715);
            Controls.Add(btn_delete_add_service);
            Controls.Add(btn_update_add_service);
            Controls.Add(btn_add_new_add_service);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "Form_AddServices";
            Text = "Form_AddServices";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddServices).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private DataGridView dataGridViewAddServices;
        private DataGridViewTextBoxColumn FloorID;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn FloorDescription;
        private Panel panel2;
        private Label label_num_of_add_services;
        private Label label2;
        private DataGridViewTextBoxColumn AddService_ID;
        private DataGridViewTextBoxColumn AddService_Name;
        private DataGridViewTextBoxColumn AddService_Price;
        private DataGridViewTextBoxColumn AddService_Description;
        private Button btn_delete_add_service;
        private Button btn_update_add_service;
        private Button btn_add_new_add_service;
    }
}