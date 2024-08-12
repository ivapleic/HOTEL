namespace HotelApp.user_controls
{
    partial class SeasonalPeriod_UpdateForm
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
            txtSeasonName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker_startDate = new DateTimePicker();
            dateTimePicker_endDate = new DateTimePicker();
            btn_cancel = new Button();
            btn_update = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 81);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(203, 20);
            label1.Name = "label1";
            label1.Size = new Size(582, 51);
            label1.TabIndex = 0;
            label1.Text = "UPDATE SEASONAL PERIOD";
            // 
            // txtSeasonName
            // 
            txtSeasonName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSeasonName.Location = new Point(323, 141);
            txtSeasonName.Multiline = true;
            txtSeasonName.Name = "txtSeasonName";
            txtSeasonName.Size = new Size(277, 38);
            txtSeasonName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 140);
            label2.Name = "label2";
            label2.Size = new Size(191, 28);
            label2.TabIndex = 10;
            label2.Text = "Season name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(171, 222);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 12;
            label3.Text = "Start date : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(179, 296);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 13;
            label4.Text = "End date : ";
            // 
            // dateTimePicker_startDate
            // 
            dateTimePicker_startDate.Location = new Point(323, 219);
            dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            dateTimePicker_startDate.Size = new Size(300, 31);
            dateTimePicker_startDate.TabIndex = 14;
            // 
            // dateTimePicker_endDate
            // 
            dateTimePicker_endDate.Location = new Point(323, 294);
            dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            dateTimePicker_endDate.Size = new Size(300, 31);
            dateTimePicker_endDate.TabIndex = 15;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(697, 408);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 18;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(541, 408);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(139, 57);
            btn_update.TabIndex = 17;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // SeasonalPeriod_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(857, 488);
            Controls.Add(btn_cancel);
            Controls.Add(btn_update);
            Controls.Add(dateTimePicker_endDate);
            Controls.Add(dateTimePicker_startDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSeasonName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "SeasonalPeriod_UpdateForm";
            Text = "SeasonalPeriod_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtSeasonName;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker_startDate;
        private DateTimePicker dateTimePicker_endDate;
        private Button btn_cancel;
        private Button btn_update;
    }
}