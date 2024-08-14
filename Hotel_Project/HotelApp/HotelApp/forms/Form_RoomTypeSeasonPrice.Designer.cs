namespace HotelApp.forms
{
    partial class Form_RoomTypeSeasonPrice
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridViewPrices = new DataGridView();
            panel_prices = new Panel();
            btn_add_prices = new Button();
            btn_update_price = new Button();
            btn_delete_price = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrices).BeginInit();
            panel_prices.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
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
            label1.Size = new Size(680, 56);
            label1.TabIndex = 0;
            label1.Text = "Room Types Seasonal Prices";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewPrices
            // 
            dataGridViewPrices.AllowUserToAddRows = false;
            dataGridViewPrices.AllowUserToDeleteRows = false;
            dataGridViewPrices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPrices.BackgroundColor = Color.White;
            dataGridViewPrices.BorderStyle = BorderStyle.None;
            dataGridViewPrices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewPrices.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewPrices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPrices.ColumnHeadersHeight = 38;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewPrices.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPrices.EnableHeadersVisualStyles = false;
            dataGridViewPrices.GridColor = Color.White;
            dataGridViewPrices.Location = new Point(0, 0);
            dataGridViewPrices.MultiSelect = false;
            dataGridViewPrices.Name = "dataGridViewPrices";
            dataGridViewPrices.ReadOnly = true;
            dataGridViewPrices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPrices.RowHeadersVisible = false;
            dataGridViewPrices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewPrices.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPrices.RowTemplate.Height = 30;
            dataGridViewPrices.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewPrices.Size = new Size(1038, 510);
            dataGridViewPrices.TabIndex = 3;
            // 
            // panel_prices
            // 
            panel_prices.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel_prices.BackColor = Color.Silver;
            panel_prices.Controls.Add(dataGridViewPrices);
            panel_prices.Location = new Point(39, 125);
            panel_prices.Name = "panel_prices";
            panel_prices.Size = new Size(1038, 510);
            panel_prices.TabIndex = 4;
            // 
            // btn_add_prices
            // 
            btn_add_prices.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_prices.Location = new Point(1127, 211);
            btn_add_prices.Name = "btn_add_prices";
            btn_add_prices.Size = new Size(164, 58);
            btn_add_prices.TabIndex = 8;
            btn_add_prices.Text = "Add New";
            btn_add_prices.UseVisualStyleBackColor = true;
            btn_add_prices.Click += btn_add_prices_Click;
            // 
            // btn_update_price
            // 
            btn_update_price.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_price.Location = new Point(1127, 304);
            btn_update_price.Name = "btn_update_price";
            btn_update_price.Size = new Size(164, 58);
            btn_update_price.TabIndex = 9;
            btn_update_price.Text = "Update";
            btn_update_price.UseVisualStyleBackColor = true;
            btn_update_price.Click += btn_update_price_Click;
            // 
            // btn_delete_price
            // 
            btn_delete_price.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_price.Location = new Point(1127, 405);
            btn_delete_price.Name = "btn_delete_price";
            btn_delete_price.Size = new Size(164, 58);
            btn_delete_price.TabIndex = 10;
            btn_delete_price.Text = "Delete";
            btn_delete_price.UseVisualStyleBackColor = true;
            btn_delete_price.Click += btn_delete_price_Click;
            // 
            // Form_RoomTypeSeasonPrice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 659);
            Controls.Add(btn_delete_price);
            Controls.Add(btn_update_price);
            Controls.Add(btn_add_prices);
            Controls.Add(panel_prices);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "Form_RoomTypeSeasonPrice";
            Text = "Form_RoomTypeSeasonPrice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrices).EndInit();
            panel_prices.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewPrices;
        private Panel panel_prices;
        private Button btn_room_details;
        private Button btn_update_room;
        private Button btn_delete_room;
        private Button btn_add_prices;
        private Button btn_update_price;
        private Button btn_delete_price;
    }
}