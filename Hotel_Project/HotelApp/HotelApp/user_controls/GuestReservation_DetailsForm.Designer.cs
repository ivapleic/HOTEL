namespace HotelApp.user_controls
{
    partial class GuestReservation_DetailsForm
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
            label18 = new Label();
            btn_close_form = new Button();
            label16 = new Label();
            label17 = new Label();
            labelLastName = new Label();
            label3 = new Label();
            labelFirstName = new Label();
            label34 = new Label();
            label_date_end = new Label();
            label_date_start = new Label();
            label_add_person = new Label();
            btn_guest_details = new Button();
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
            panel1.Size = new Size(886, 86);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(267, 43);
            label1.TabIndex = 0;
            label1.Text = "GUEST DETAILS";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 10F);
            label18.Location = new Point(144, 355);
            label18.Name = "label18";
            label18.Size = new Size(193, 23);
            label18.TabIndex = 56;
            label18.Text = "Additional person :";
            // 
            // btn_close_form
            // 
            btn_close_form.BackColor = Color.FromArgb(155, 31, 33);
            btn_close_form.ForeColor = Color.White;
            btn_close_form.Location = new Point(731, 431);
            btn_close_form.Name = "btn_close_form";
            btn_close_form.Size = new Size(135, 52);
            btn_close_form.TabIndex = 55;
            btn_close_form.Text = "Exit";
            btn_close_form.UseVisualStyleBackColor = false;
            btn_close_form.Click += btn_close_form_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(222, 299);
            label16.Name = "label16";
            label16.Size = new Size(115, 23);
            label16.TabIndex = 51;
            label16.Text = "Date end :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(222, 238);
            label17.Name = "label17";
            label17.Size = new Size(118, 23);
            label17.TabIndex = 50;
            label17.Text = "Date start :";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(350, 182);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(87, 23);
            labelLastName.TabIndex = 49;
            labelLastName.Text = "prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(218, 182);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 48;
            label3.Text = "Last Name :";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(344, 122);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(45, 23);
            labelFirstName.TabIndex = 47;
            labelFirstName.Text = "ime";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(218, 122);
            label34.Name = "label34";
            label34.Size = new Size(122, 23);
            label34.TabIndex = 46;
            label34.Text = "First Name :";
            // 
            // label_date_end
            // 
            label_date_end.AutoSize = true;
            label_date_end.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_date_end.Location = new Point(344, 299);
            label_date_end.Name = "label_date_end";
            label_date_end.Size = new Size(103, 23);
            label_date_end.TabIndex = 58;
            label_date_end.Text = "date end";
            // 
            // label_date_start
            // 
            label_date_start.AutoSize = true;
            label_date_start.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_date_start.Location = new Point(344, 238);
            label_date_start.Name = "label_date_start";
            label_date_start.Size = new Size(106, 23);
            label_date_start.TabIndex = 59;
            label_date_start.Text = "start date";
            // 
            // label_add_person
            // 
            label_add_person.AutoSize = true;
            label_add_person.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_add_person.Location = new Point(344, 355);
            label_add_person.Name = "label_add_person";
            label_add_person.Size = new Size(124, 23);
            label_add_person.TabIndex = 60;
            label_add_person.Text = "add person";
            // 
            // btn_guest_details
            // 
            btn_guest_details.BackColor = Color.FromArgb(155, 31, 33);
            btn_guest_details.ForeColor = Color.White;
            btn_guest_details.Location = new Point(437, 114);
            btn_guest_details.Name = "btn_guest_details";
            btn_guest_details.Size = new Size(135, 41);
            btn_guest_details.TabIndex = 61;
            btn_guest_details.Text = "Details";
            btn_guest_details.UseVisualStyleBackColor = false;
            btn_guest_details.Click += btn_guest_details_Click;
            // 
            // GuestReservation_DetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 500);
            Controls.Add(btn_guest_details);
            Controls.Add(label_add_person);
            Controls.Add(label_date_start);
            Controls.Add(label_date_end);
            Controls.Add(label18);
            Controls.Add(btn_close_form);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(labelLastName);
            Controls.Add(label3);
            Controls.Add(labelFirstName);
            Controls.Add(label34);
            Controls.Add(panel1);
            Name = "GuestReservation_DetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestReservation_DetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label18;
        private Button btn_close_form;
        private Label label16;
        private Label label17;
        private Label labelLastName;
        private Label label3;
        private Label labelFirstName;
        private Label label34;
        private Label label_date_end;
        private Label label_date_start;
        private Label label_add_person;
        private Button btn_guest_details;
    }
}