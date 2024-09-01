namespace HotelApp.user_controls
{
    partial class SeasonalPeriod_AddNewForm
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
            label4 = new Label();
            btn_cancel = new Button();
            btn_add = new Button();
            dateTimePicker_endDate = new DateTimePicker();
            dateTimePicker_startDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtSeasonName = new TextBox();
            label5 = new Label();
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
            panel1.Size = new Size(945, 81);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 20);
            label1.Name = "label1";
            label1.Size = new Size(575, 51);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW SEASON PERIOD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(359, 112);
            label4.Name = "label4";
            label4.Size = new Size(190, 34);
            label4.TabIndex = 13;
            label4.Text = "Fill new data";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(155, 31, 33);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(776, 452);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 26;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(155, 31, 33);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(620, 452);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(139, 57);
            btn_add.TabIndex = 25;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dateTimePicker_endDate
            // 
            dateTimePicker_endDate.Location = new Point(402, 338);
            dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            dateTimePicker_endDate.Size = new Size(300, 31);
            dateTimePicker_endDate.TabIndex = 24;
            // 
            // dateTimePicker_startDate
            // 
            dateTimePicker_startDate.Location = new Point(402, 263);
            dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            dateTimePicker_startDate.Size = new Size(300, 31);
            dateTimePicker_startDate.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 340);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 22;
            label2.Text = "End date : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 266);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 21;
            label3.Text = "Start date : ";
            // 
            // txtSeasonName
            // 
            txtSeasonName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSeasonName.Location = new Point(402, 185);
            txtSeasonName.Multiline = true;
            txtSeasonName.Name = "txtSeasonName";
            txtSeasonName.Size = new Size(277, 38);
            txtSeasonName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(203, 184);
            label5.Name = "label5";
            label5.Size = new Size(191, 28);
            label5.TabIndex = 19;
            label5.Text = "Season name : ";
            // 
            // SeasonalPeriod_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(945, 533);
            Controls.Add(btn_cancel);
            Controls.Add(btn_add);
            Controls.Add(dateTimePicker_endDate);
            Controls.Add(dateTimePicker_startDate);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtSeasonName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "SeasonalPeriod_AddNewForm";
            Text = "SeasonalPeriod_AddNew";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Button btn_cancel;
        private Button btn_add;
        private DateTimePicker dateTimePicker_endDate;
        private DateTimePicker dateTimePicker_startDate;
        private Label label2;
        private Label label3;
        private TextBox txtSeasonName;
        private Label label5;
    }
}