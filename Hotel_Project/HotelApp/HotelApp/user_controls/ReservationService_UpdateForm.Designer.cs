namespace HotelApp.user_controls
{
    partial class ReservationService_UpdateForm
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
            panel1 = new Panel();
            label1 = new Label();
            textBox_amount = new TextBox();
            label3 = new Label();
            label_service_name = new Label();
            btn_exit = new Button();
            btn_update_services = new Button();
            label2 = new Label();
            dateTimePicker_con_date = new DateTimePicker();
            label66 = new Label();
            dateTimePicker_res_date = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label_service_price = new Label();
            lbl_service_name = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 31, 33);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 86);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(320, 43);
            label1.TabIndex = 0;
            label1.Text = "UPDATE SERVICES";
            // 
            // textBox_amount
            // 
            textBox_amount.Location = new Point(275, 284);
            textBox_amount.Multiline = true;
            textBox_amount.Name = "textBox_amount";
            textBox_amount.Size = new Size(141, 29);
            textBox_amount.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(129, 279);
            label3.Name = "label3";
            label3.Size = new Size(139, 34);
            label3.TabIndex = 43;
            label3.Text = "Amount :";
            // 
            // label_service_name
            // 
            label_service_name.AutoSize = true;
            label_service_name.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_service_name.Location = new Point(361, 128);
            label_service_name.Name = "label_service_name";
            label_service_name.Size = new Size(0, 34);
            label_service_name.TabIndex = 41;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_exit.BackColor = Color.FromArgb(155, 31, 33);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(653, 563);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(133, 51);
            btn_exit.TabIndex = 40;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_update_services
            // 
            btn_update_services.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_services.BackColor = Color.FromArgb(155, 31, 33);
            btn_update_services.ForeColor = Color.White;
            btn_update_services.Location = new Point(500, 563);
            btn_update_services.Name = "btn_update_services";
            btn_update_services.Size = new Size(128, 51);
            btn_update_services.TabIndex = 39;
            btn_update_services.Text = "Update";
            btn_update_services.UseVisualStyleBackColor = false;
            btn_update_services.Click += btn_update_services_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 433);
            label2.Name = "label2";
            label2.Size = new Size(287, 34);
            label2.TabIndex = 38;
            label2.Text = "Consumation date :";
            // 
            // dateTimePicker_con_date
            // 
            dateTimePicker_con_date.Anchor = AnchorStyles.None;
            dateTimePicker_con_date.Font = new Font("Century Gothic", 10F);
            dateTimePicker_con_date.Location = new Point(422, 436);
            dateTimePicker_con_date.Name = "dateTimePicker_con_date";
            dateTimePicker_con_date.Size = new Size(255, 32);
            dateTimePicker_con_date.TabIndex = 37;
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label66.Location = new Point(129, 364);
            label66.Name = "label66";
            label66.Size = new Size(264, 34);
            label66.TabIndex = 36;
            label66.Text = "Reservation date :";
            // 
            // dateTimePicker_res_date
            // 
            dateTimePicker_res_date.Anchor = AnchorStyles.None;
            dateTimePicker_res_date.Font = new Font("Century Gothic", 10F);
            dateTimePicker_res_date.Location = new Point(399, 366);
            dateTimePicker_res_date.Name = "dateTimePicker_res_date";
            dateTimePicker_res_date.Size = new Size(255, 32);
            dateTimePicker_res_date.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(129, 196);
            label6.Name = "label6";
            label6.Size = new Size(208, 34);
            label6.TabIndex = 34;
            label6.Text = "Service price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(129, 128);
            label5.Name = "label5";
            label5.Size = new Size(218, 34);
            label5.TabIndex = 33;
            label5.Text = "Service name :";
            // 
            // label_service_price
            // 
            label_service_price.AutoSize = true;
            label_service_price.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_service_price.Location = new Point(343, 196);
            label_service_price.Name = "label_service_price";
            label_service_price.Size = new Size(208, 34);
            label_service_price.TabIndex = 42;
            label_service_price.Text = "Service price :";
            // 
            // lbl_service_name
            // 
            lbl_service_name.AutoSize = true;
            lbl_service_name.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_service_name.Location = new Point(361, 128);
            lbl_service_name.Name = "lbl_service_name";
            lbl_service_name.Size = new Size(218, 34);
            lbl_service_name.TabIndex = 45;
            lbl_service_name.Text = "Service name :";
            // 
            // ReservationService_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(798, 636);
            Controls.Add(lbl_service_name);
            Controls.Add(textBox_amount);
            Controls.Add(label3);
            Controls.Add(label_service_price);
            Controls.Add(label_service_name);
            Controls.Add(btn_exit);
            Controls.Add(btn_update_services);
            Controls.Add(label2);
            Controls.Add(dateTimePicker_con_date);
            Controls.Add(label66);
            Controls.Add(dateTimePicker_res_date);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "ReservationService_UpdateForm";
            Text = "ReservationService_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox_amount;
        private Label label3;
        private Label label_service_name;
        private Button btn_exit;
        private Button btn_update_services;
        private Label label2;
        private DateTimePicker dateTimePicker_con_date;
        private Label label66;
        private DateTimePicker dateTimePicker_res_date;
        private Label label6;
        private Label label5;
        private Label label_service_price;
        private Label lbl_service_name;
    }
}