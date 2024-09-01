namespace HotelApp.forms
{
    partial class Form_SeasonalPeriods
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
            dataGridViewSeasons = new DataGridView();
            SeasonID = new DataGridViewTextBoxColumn();
            SeasonName = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btn_update_season = new Button();
            btn_delete_season = new Button();
            btn_add_season = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeasons).BeginInit();
            panel2.SuspendLayout();
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
            label1.ForeColor = Color.FromArgb(155, 31, 33);
            label1.Location = new Point(600, 32);
            label1.Name = "label1";
            label1.Size = new Size(387, 56);
            label1.TabIndex = 0;
            label1.Text = "Seasonal Prices";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewSeasons
            // 
            dataGridViewSeasons.AllowUserToAddRows = false;
            dataGridViewSeasons.AllowUserToDeleteRows = false;
            dataGridViewSeasons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewSeasons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSeasons.BackgroundColor = Color.White;
            dataGridViewSeasons.BorderStyle = BorderStyle.None;
            dataGridViewSeasons.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewSeasons.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewSeasons.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSeasons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSeasons.ColumnHeadersHeight = 38;
            dataGridViewSeasons.Columns.AddRange(new DataGridViewColumn[] { SeasonID, SeasonName, StartDate, EndDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSeasons.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSeasons.EnableHeadersVisualStyles = false;
            dataGridViewSeasons.GridColor = Color.White;
            dataGridViewSeasons.Location = new Point(0, 0);
            dataGridViewSeasons.MultiSelect = false;
            dataGridViewSeasons.Name = "dataGridViewSeasons";
            dataGridViewSeasons.ReadOnly = true;
            dataGridViewSeasons.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSeasons.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSeasons.RowHeadersVisible = false;
            dataGridViewSeasons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewSeasons.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSeasons.RowTemplate.Height = 30;
            dataGridViewSeasons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSeasons.Size = new Size(997, 526);
            dataGridViewSeasons.TabIndex = 3;
            // 
            // SeasonID
            // 
            SeasonID.HeaderText = "Season ID";
            SeasonID.MinimumWidth = 8;
            SeasonID.Name = "SeasonID";
            SeasonID.ReadOnly = true;
            SeasonID.Visible = false;
            // 
            // SeasonName
            // 
            SeasonName.HeaderText = "Season Name";
            SeasonName.MinimumWidth = 8;
            SeasonName.Name = "SeasonName";
            SeasonName.ReadOnly = true;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Start Date";
            StartDate.MinimumWidth = 8;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "End Date";
            EndDate.MinimumWidth = 8;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(dataGridViewSeasons);
            panel2.Location = new Point(44, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 526);
            panel2.TabIndex = 4;
            // 
            // btn_update_season
            // 
            btn_update_season.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_update_season.BackColor = Color.FromArgb(155, 31, 33);
            btn_update_season.ForeColor = Color.White;
            btn_update_season.Location = new Point(1101, 443);
            btn_update_season.Name = "btn_update_season";
            btn_update_season.Size = new Size(163, 60);
            btn_update_season.TabIndex = 10;
            btn_update_season.Text = "Update";
            btn_update_season.UseVisualStyleBackColor = false;
            btn_update_season.Click += btn_update_season_Click;
            // 
            // btn_delete_season
            // 
            btn_delete_season.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_delete_season.BackColor = Color.FromArgb(155, 31, 33);
            btn_delete_season.ForeColor = Color.White;
            btn_delete_season.Location = new Point(1101, 341);
            btn_delete_season.Name = "btn_delete_season";
            btn_delete_season.Size = new Size(163, 62);
            btn_delete_season.TabIndex = 9;
            btn_delete_season.Text = "Delete";
            btn_delete_season.UseVisualStyleBackColor = false;
            btn_delete_season.Click += btn_delete_season_Click;
            // 
            // btn_add_season
            // 
            btn_add_season.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_add_season.BackColor = Color.FromArgb(155, 31, 33);
            btn_add_season.ForeColor = Color.White;
            btn_add_season.Location = new Point(1100, 246);
            btn_add_season.Name = "btn_add_season";
            btn_add_season.Size = new Size(164, 58);
            btn_add_season.TabIndex = 8;
            btn_add_season.Text = "Add New";
            btn_add_season.UseVisualStyleBackColor = false;
            btn_add_season.Click += btn_add_season_Click;
            // 
            // Form_SeasonalPeriods
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1320, 659);
            Controls.Add(btn_update_season);
            Controls.Add(btn_delete_season);
            Controls.Add(btn_add_season);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(265, 64);
            Name = "Form_SeasonalPeriods";
            Text = "Form_SeasonalPrices";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeasons).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewSeasons;
        private Panel panel2;
        private Button btn_update_season;
        private Button btn_delete_season;
        private Button btn_add_season;
        private DataGridViewTextBoxColumn SeasonID;
        private DataGridViewTextBoxColumn SeasonName;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
    }
}