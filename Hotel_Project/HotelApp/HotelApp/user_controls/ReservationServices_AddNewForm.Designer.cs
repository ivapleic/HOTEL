namespace HotelApp.user_controls
{
    partial class ReservationServices_AddNewForm
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
            dataGridViewServices = new DataGridView();
            ServiceID = new DataGridViewTextBoxColumn();
            ServiceName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btn_close_form = new Button();
            btn_add_service = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 86);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(492, 43);
            label1.TabIndex = 0;
            label1.Text = "ADD ADDITIONAL SERVICES";
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.AllowUserToAddRows = false;
            dataGridViewServices.AllowUserToDeleteRows = false;
            dataGridViewServices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewServices.BackgroundColor = Color.White;
            dataGridViewServices.BorderStyle = BorderStyle.None;
            dataGridViewServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewServices.ColumnHeadersHeight = 38;
            dataGridViewServices.Columns.AddRange(new DataGridViewColumn[] { ServiceID, ServiceName, Price, Description });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewServices.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewServices.EnableHeadersVisualStyles = false;
            dataGridViewServices.Location = new Point(0, 0);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewServices.RowHeadersVisible = false;
            dataGridViewServices.RowHeadersWidth = 62;
            dataGridViewServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServices.Size = new Size(795, 454);
            dataGridViewServices.TabIndex = 4;
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
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(dataGridViewServices);
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 454);
            panel2.TabIndex = 5;
            // 
            // btn_close_form
            // 
            btn_close_form.Location = new Point(649, 572);
            btn_close_form.Name = "btn_close_form";
            btn_close_form.Size = new Size(135, 52);
            btn_close_form.TabIndex = 15;
            btn_close_form.Text = "Exit";
            btn_close_form.UseVisualStyleBackColor = true;
            btn_close_form.Click += btn_close_form_Click;
            // 
            // btn_add_service
            // 
            btn_add_service.Location = new Point(493, 572);
            btn_add_service.Name = "btn_add_service";
            btn_add_service.Size = new Size(135, 52);
            btn_add_service.TabIndex = 14;
            btn_add_service.Text = "Add";
            btn_add_service.UseVisualStyleBackColor = true;
            btn_add_service.Click += btn_add_service_Click;
            // 
            // ReservationServices_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 636);
            Controls.Add(btn_close_form);
            Controls.Add(btn_add_service);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReservationServices_AddNewForm";
            Text = "ReservationServices_AddNewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewServices;
        private Panel panel2;
        private Button btn_close_form;
        private Button btn_add_service;
        private DataGridViewTextBoxColumn ServiceID;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
    }
}