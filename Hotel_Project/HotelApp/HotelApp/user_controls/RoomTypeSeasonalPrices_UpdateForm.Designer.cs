namespace HotelApp.user_controls
{
    partial class RoomTypeSeasonalPrices_UpdateForm
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
            comboBox_seasons = new ComboBox();
            comboBox_roomTypes = new ComboBox();
            label6 = new Label();
            btn_cancel = new Button();
            btn_update_price = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(155, 31, 33);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 81);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(266, 19);
            label1.Name = "label1";
            label1.Size = new Size(312, 51);
            label1.TabIndex = 0;
            label1.Text = "UPDATE PRICE";
            // 
            // comboBox_seasons
            // 
            comboBox_seasons.FormattingEnabled = true;
            comboBox_seasons.Location = new Point(429, 277);
            comboBox_seasons.Name = "comboBox_seasons";
            comboBox_seasons.Size = new Size(277, 33);
            comboBox_seasons.TabIndex = 47;
            // 
            // comboBox_roomTypes
            // 
            comboBox_roomTypes.FormattingEnabled = true;
            comboBox_roomTypes.Location = new Point(429, 214);
            comboBox_roomTypes.Name = "comboBox_roomTypes";
            comboBox_roomTypes.Size = new Size(277, 33);
            comboBox_roomTypes.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(712, 339);
            label6.Name = "label6";
            label6.Size = new Size(31, 34);
            label6.TabIndex = 45;
            label6.Text = "€";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(155, 31, 33);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(749, 471);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 44;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_update_price
            // 
            btn_update_price.BackColor = Color.FromArgb(155, 31, 33);
            btn_update_price.ForeColor = Color.White;
            btn_update_price.Location = new Point(593, 471);
            btn_update_price.Name = "btn_update_price";
            btn_update_price.Size = new Size(139, 57);
            btn_update_price.TabIndex = 43;
            btn_update_price.Text = "Update";
            btn_update_price.UseVisualStyleBackColor = false;
            btn_update_price.Click += btn_update_price_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(429, 339);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(277, 39);
            txtPrice.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(317, 339);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 41;
            label5.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(362, 116);
            label4.Name = "label4";
            label4.Size = new Size(225, 34);
            label4.TabIndex = 40;
            label4.Text = "Enter new data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 277);
            label3.Name = "label3";
            label3.Size = new Size(211, 28);
            label3.TabIndex = 39;
            label3.Text = "Seasonal Period :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 214);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 38;
            label2.Text = "Room type :";
            // 
            // RoomTypeSeasonalPrices_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 554);
            Controls.Add(comboBox_seasons);
            Controls.Add(comboBox_roomTypes);
            Controls.Add(label6);
            Controls.Add(btn_cancel);
            Controls.Add(btn_update_price);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RoomTypeSeasonalPrices_UpdateForm";
            Text = "RoomTypeSeasonalPrices_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox_seasons;
        private ComboBox comboBox_roomTypes;
        private Label label6;
        private Button btn_cancel;
        private Button btn_update_price;
        private TextBox txtPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}