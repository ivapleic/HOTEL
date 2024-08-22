namespace HotelApp.user_controls
{
    partial class GuestReservation_AddNewForm
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
            labelFirstName = new Label();
            label34 = new Label();
            labelLastName = new Label();
            label3 = new Label();
            dateTimePicker_end = new DateTimePicker();
            dateTimePicker_start = new DateTimePicker();
            label16 = new Label();
            label17 = new Label();
            btn_close_form = new Button();
            btn_add_res_guest = new Button();
            checkBox_add_person = new CheckBox();
            label18 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 86);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(446, 43);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW GUEST DETAILS";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(352, 127);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(45, 23);
            labelFirstName.TabIndex = 7;
            labelFirstName.Text = "ime";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(226, 127);
            label34.Name = "label34";
            label34.Size = new Size(122, 23);
            label34.TabIndex = 6;
            label34.Text = "First Name :";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(358, 187);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(87, 23);
            labelLastName.TabIndex = 9;
            labelLastName.Text = "prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 187);
            label3.Name = "label3";
            label3.Size = new Size(126, 23);
            label3.TabIndex = 8;
            label3.Text = "Last Name :";
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Location = new Point(336, 314);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(300, 31);
            dateTimePicker_end.TabIndex = 14;
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Location = new Point(351, 257);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(300, 31);
            dateTimePicker_start.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(193, 304);
            label16.Name = "label16";
            label16.Size = new Size(115, 23);
            label16.TabIndex = 12;
            label16.Text = "Date end :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(188, 255);
            label17.Name = "label17";
            label17.Size = new Size(118, 23);
            label17.TabIndex = 11;
            label17.Text = "Date start :";
            // 
            // btn_close_form
            // 
            btn_close_form.Location = new Point(739, 436);
            btn_close_form.Name = "btn_close_form";
            btn_close_form.Size = new Size(135, 52);
            btn_close_form.TabIndex = 16;
            btn_close_form.Text = "Exit";
            btn_close_form.UseVisualStyleBackColor = true;
            btn_close_form.Click += btn_close_form_Click;
            // 
            // btn_add_res_guest
            // 
            btn_add_res_guest.Location = new Point(583, 436);
            btn_add_res_guest.Name = "btn_add_res_guest";
            btn_add_res_guest.Size = new Size(135, 52);
            btn_add_res_guest.TabIndex = 15;
            btn_add_res_guest.Text = "Add";
            btn_add_res_guest.UseVisualStyleBackColor = true;
            btn_add_res_guest.Click += btn_add_res_guest_Click;
            // 
            // checkBox_add_person
            // 
            checkBox_add_person.AutoSize = true;
            checkBox_add_person.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_add_person.Location = new Point(351, 380);
            checkBox_add_person.Name = "checkBox_add_person";
            checkBox_add_person.Size = new Size(22, 21);
            checkBox_add_person.TabIndex = 45;
            checkBox_add_person.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 10F);
            label18.Location = new Point(113, 378);
            label18.Name = "label18";
            label18.Size = new Size(193, 23);
            label18.TabIndex = 44;
            label18.Text = "Additional person :";
            // 
            // GuestReservation_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 500);
            Controls.Add(checkBox_add_person);
            Controls.Add(label18);
            Controls.Add(btn_close_form);
            Controls.Add(btn_add_res_guest);
            Controls.Add(dateTimePicker_end);
            Controls.Add(dateTimePicker_start);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(labelLastName);
            Controls.Add(label3);
            Controls.Add(labelFirstName);
            Controls.Add(label34);
            Controls.Add(panel1);
            Name = "GuestReservation_AddNewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuestReservation_AddNewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelFirstName;
        private Label label34;
        private Label labelLastName;
        private Label label3;
        private DateTimePicker dateTimePicker_end;
        private DateTimePicker dateTimePicker_start;
        private Label label16;
        private Label label17;
        private Button btn_close_form;
        private Button btn_add_res_guest;
        private CheckBox checkBox_add_person;
        private Label label18;
    }
}