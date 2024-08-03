namespace HotelApp.user_controls
{
    partial class Room_UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_UpdateForm));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            room_type_choose = new ComboBox();
            floor_choose = new ComboBox();
            checkBox_available = new CheckBox();
            room_description_input = new TextBox();
            room_number_input = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            room_type_label = new Label();
            label3 = new Label();
            panel3 = new Panel();
            remove_acc_btn = new Button();
            acessories_choose = new ComboBox();
            accessories_listBox = new ListBox();
            label12 = new Label();
            panel4 = new Panel();
            btn_remove_img5 = new Button();
            btn_add_img5 = new Button();
            btn_remove_img4 = new Button();
            btn_add_img4 = new Button();
            btn_remove_img3 = new Button();
            btn_add_img3 = new Button();
            btn_remove_img2 = new Button();
            btn_add_img2 = new Button();
            btn_remove_img1 = new Button();
            btn_add_img1 = new Button();
            room_image5 = new PictureBox();
            room_image4 = new PictureBox();
            room_image3 = new PictureBox();
            room_image2 = new PictureBox();
            room_image1 = new PictureBox();
            label11 = new Label();
            btn_cancel = new Button();
            btn_update_room = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)room_image5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room_image4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room_image3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room_image2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)room_image1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1456, 104);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(331, 56);
            label1.TabIndex = 0;
            label1.Text = "Update room";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(room_type_choose);
            panel2.Controls.Add(floor_choose);
            panel2.Controls.Add(checkBox_available);
            panel2.Controls.Add(room_description_input);
            panel2.Controls.Add(room_number_input);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(room_type_label);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(36, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 400);
            panel2.TabIndex = 3;
            // 
            // room_type_choose
            // 
            room_type_choose.FormattingEnabled = true;
            room_type_choose.Location = new Point(171, 80);
            room_type_choose.Name = "room_type_choose";
            room_type_choose.Size = new Size(301, 33);
            room_type_choose.TabIndex = 16;
            // 
            // floor_choose
            // 
            floor_choose.FormattingEnabled = true;
            floor_choose.Location = new Point(107, 135);
            floor_choose.Name = "floor_choose";
            floor_choose.Size = new Size(227, 33);
            floor_choose.TabIndex = 15;
            // 
            // checkBox_available
            // 
            checkBox_available.AutoSize = true;
            checkBox_available.Location = new Point(148, 201);
            checkBox_available.Name = "checkBox_available";
            checkBox_available.Size = new Size(121, 29);
            checkBox_available.TabIndex = 14;
            checkBox_available.Text = "checkBox1";
            checkBox_available.UseVisualStyleBackColor = true;
            // 
            // room_description_input
            // 
            room_description_input.Location = new Point(230, 266);
            room_description_input.Multiline = true;
            room_description_input.Name = "room_description_input";
            room_description_input.Size = new Size(521, 118);
            room_description_input.TabIndex = 13;
            // 
            // room_number_input
            // 
            room_number_input.Location = new Point(205, 20);
            room_number_input.Name = "room_number_input";
            room_number_input.Size = new Size(267, 31);
            room_number_input.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F);
            label2.Location = new Point(13, 20);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 9;
            label2.Text = "Room Number : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 137);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 5;
            label8.Text = "Floor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F);
            label7.Location = new Point(13, 201);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 4;
            label7.Text = "Available :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11F);
            label6.Location = new Point(13, 266);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 3;
            label6.Text = "Room Description :";
            // 
            // room_type_label
            // 
            room_type_label.AutoSize = true;
            room_type_label.Font = new Font("Century Gothic", 11F);
            room_type_label.Location = new Point(162, 66);
            room_type_label.Name = "room_type_label";
            room_type_label.Size = new Size(0, 25);
            room_type_label.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.Location = new Point(13, 82);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 0;
            label3.Text = "Room Type : ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(remove_acc_btn);
            panel3.Controls.Add(acessories_choose);
            panel3.Controls.Add(accessories_listBox);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(827, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 400);
            panel3.TabIndex = 4;
            // 
            // remove_acc_btn
            // 
            remove_acc_btn.Location = new Point(398, 74);
            remove_acc_btn.Name = "remove_acc_btn";
            remove_acc_btn.Size = new Size(112, 34);
            remove_acc_btn.TabIndex = 4;
            remove_acc_btn.Text = "Remove item";
            remove_acc_btn.UseVisualStyleBackColor = true;
            // 
            // acessories_choose
            // 
            acessories_choose.FormattingEnabled = true;
            acessories_choose.Location = new Point(21, 74);
            acessories_choose.Name = "acessories_choose";
            acessories_choose.Size = new Size(371, 33);
            acessories_choose.TabIndex = 3;
            // 
            // accessories_listBox
            // 
            accessories_listBox.BorderStyle = BorderStyle.None;
            accessories_listBox.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accessories_listBox.FormattingEnabled = true;
            accessories_listBox.ItemHeight = 26;
            accessories_listBox.Location = new Point(21, 137);
            accessories_listBox.Name = "accessories_listBox";
            accessories_listBox.Size = new Size(433, 208);
            accessories_listBox.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 19);
            label12.Name = "label12";
            label12.Size = new Size(260, 25);
            label12.TabIndex = 0;
            label12.Text = "Dodatni sadrzaji u sobi :";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoScroll = true;
            panel4.Controls.Add(btn_remove_img5);
            panel4.Controls.Add(btn_add_img5);
            panel4.Controls.Add(btn_remove_img4);
            panel4.Controls.Add(btn_add_img4);
            panel4.Controls.Add(btn_remove_img3);
            panel4.Controls.Add(btn_add_img3);
            panel4.Controls.Add(btn_remove_img2);
            panel4.Controls.Add(btn_add_img2);
            panel4.Controls.Add(btn_remove_img1);
            panel4.Controls.Add(btn_add_img1);
            panel4.Controls.Add(room_image5);
            panel4.Controls.Add(room_image4);
            panel4.Controls.Add(room_image3);
            panel4.Controls.Add(room_image2);
            panel4.Controls.Add(room_image1);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(36, 516);
            panel4.Name = "panel4";
            panel4.Size = new Size(1411, 337);
            panel4.TabIndex = 5;
            // 
            // btn_remove_img5
            // 
            btn_remove_img5.BackgroundImage = (Image)resources.GetObject("btn_remove_img5.BackgroundImage");
            btn_remove_img5.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove_img5.FlatAppearance.BorderSize = 0;
            btn_remove_img5.FlatStyle = FlatStyle.Flat;
            btn_remove_img5.Location = new Point(1341, 41);
            btn_remove_img5.Name = "btn_remove_img5";
            btn_remove_img5.Size = new Size(40, 40);
            btn_remove_img5.TabIndex = 15;
            btn_remove_img5.UseVisualStyleBackColor = true;
            // 
            // btn_add_img5
            // 
            btn_add_img5.BackColor = Color.White;
            btn_add_img5.BackgroundImage = (Image)resources.GetObject("btn_add_img5.BackgroundImage");
            btn_add_img5.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_img5.FlatAppearance.BorderSize = 0;
            btn_add_img5.FlatStyle = FlatStyle.Flat;
            btn_add_img5.Location = new Point(1295, 41);
            btn_add_img5.Name = "btn_add_img5";
            btn_add_img5.Size = new Size(40, 40);
            btn_add_img5.TabIndex = 14;
            btn_add_img5.UseVisualStyleBackColor = false;
            // 
            // btn_remove_img4
            // 
            btn_remove_img4.BackgroundImage = (Image)resources.GetObject("btn_remove_img4.BackgroundImage");
            btn_remove_img4.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove_img4.FlatAppearance.BorderSize = 0;
            btn_remove_img4.FlatStyle = FlatStyle.Flat;
            btn_remove_img4.Location = new Point(1069, 40);
            btn_remove_img4.Name = "btn_remove_img4";
            btn_remove_img4.Size = new Size(40, 40);
            btn_remove_img4.TabIndex = 13;
            btn_remove_img4.UseVisualStyleBackColor = true;
            // 
            // btn_add_img4
            // 
            btn_add_img4.BackColor = Color.White;
            btn_add_img4.BackgroundImage = (Image)resources.GetObject("btn_add_img4.BackgroundImage");
            btn_add_img4.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_img4.FlatAppearance.BorderSize = 0;
            btn_add_img4.FlatStyle = FlatStyle.Flat;
            btn_add_img4.Location = new Point(1023, 40);
            btn_add_img4.Name = "btn_add_img4";
            btn_add_img4.Size = new Size(40, 40);
            btn_add_img4.TabIndex = 12;
            btn_add_img4.UseVisualStyleBackColor = false;
            // 
            // btn_remove_img3
            // 
            btn_remove_img3.BackgroundImage = (Image)resources.GetObject("btn_remove_img3.BackgroundImage");
            btn_remove_img3.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove_img3.FlatAppearance.BorderSize = 0;
            btn_remove_img3.FlatStyle = FlatStyle.Flat;
            btn_remove_img3.Location = new Point(794, 40);
            btn_remove_img3.Name = "btn_remove_img3";
            btn_remove_img3.Size = new Size(40, 40);
            btn_remove_img3.TabIndex = 11;
            btn_remove_img3.UseVisualStyleBackColor = true;
            // 
            // btn_add_img3
            // 
            btn_add_img3.BackColor = Color.White;
            btn_add_img3.BackgroundImage = (Image)resources.GetObject("btn_add_img3.BackgroundImage");
            btn_add_img3.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_img3.FlatAppearance.BorderSize = 0;
            btn_add_img3.FlatStyle = FlatStyle.Flat;
            btn_add_img3.Location = new Point(748, 40);
            btn_add_img3.Name = "btn_add_img3";
            btn_add_img3.Size = new Size(40, 40);
            btn_add_img3.TabIndex = 10;
            btn_add_img3.UseVisualStyleBackColor = false;
            // 
            // btn_remove_img2
            // 
            btn_remove_img2.BackgroundImage = (Image)resources.GetObject("btn_remove_img2.BackgroundImage");
            btn_remove_img2.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove_img2.FlatAppearance.BorderSize = 0;
            btn_remove_img2.FlatStyle = FlatStyle.Flat;
            btn_remove_img2.Location = new Point(509, 40);
            btn_remove_img2.Name = "btn_remove_img2";
            btn_remove_img2.Size = new Size(40, 40);
            btn_remove_img2.TabIndex = 9;
            btn_remove_img2.UseVisualStyleBackColor = true;
            // 
            // btn_add_img2
            // 
            btn_add_img2.BackColor = Color.White;
            btn_add_img2.BackgroundImage = (Image)resources.GetObject("btn_add_img2.BackgroundImage");
            btn_add_img2.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_img2.FlatAppearance.BorderSize = 0;
            btn_add_img2.FlatStyle = FlatStyle.Flat;
            btn_add_img2.Location = new Point(463, 40);
            btn_add_img2.Name = "btn_add_img2";
            btn_add_img2.Size = new Size(40, 40);
            btn_add_img2.TabIndex = 8;
            btn_add_img2.UseVisualStyleBackColor = false;
            // 
            // btn_remove_img1
            // 
            btn_remove_img1.BackgroundImage = (Image)resources.GetObject("btn_remove_img1.BackgroundImage");
            btn_remove_img1.BackgroundImageLayout = ImageLayout.Stretch;
            btn_remove_img1.FlatAppearance.BorderSize = 0;
            btn_remove_img1.FlatStyle = FlatStyle.Flat;
            btn_remove_img1.Location = new Point(227, 40);
            btn_remove_img1.Name = "btn_remove_img1";
            btn_remove_img1.Size = new Size(40, 40);
            btn_remove_img1.TabIndex = 7;
            btn_remove_img1.UseVisualStyleBackColor = true;
            // 
            // btn_add_img1
            // 
            btn_add_img1.BackColor = Color.White;
            btn_add_img1.BackgroundImage = (Image)resources.GetObject("btn_add_img1.BackgroundImage");
            btn_add_img1.BackgroundImageLayout = ImageLayout.Stretch;
            btn_add_img1.FlatAppearance.BorderSize = 0;
            btn_add_img1.FlatStyle = FlatStyle.Flat;
            btn_add_img1.Location = new Point(181, 40);
            btn_add_img1.Name = "btn_add_img1";
            btn_add_img1.Size = new Size(40, 40);
            btn_add_img1.TabIndex = 6;
            btn_add_img1.UseVisualStyleBackColor = false;
            // 
            // room_image5
            // 
            room_image5.Location = new Point(1116, 87);
            room_image5.Name = "room_image5";
            room_image5.Size = new Size(270, 235);
            room_image5.TabIndex = 5;
            room_image5.TabStop = false;
            // 
            // room_image4
            // 
            room_image4.Location = new Point(840, 87);
            room_image4.Name = "room_image4";
            room_image4.Size = new Size(270, 235);
            room_image4.TabIndex = 4;
            room_image4.TabStop = false;
            // 
            // room_image3
            // 
            room_image3.Location = new Point(564, 86);
            room_image3.Name = "room_image3";
            room_image3.Size = new Size(270, 235);
            room_image3.TabIndex = 3;
            room_image3.TabStop = false;
            // 
            // room_image2
            // 
            room_image2.Location = new Point(288, 86);
            room_image2.Name = "room_image2";
            room_image2.Size = new Size(270, 235);
            room_image2.TabIndex = 2;
            room_image2.TabStop = false;
            // 
            // room_image1
            // 
            room_image1.BackColor = Color.Transparent;
            room_image1.Location = new Point(12, 86);
            room_image1.Name = "room_image1";
            room_image1.Size = new Size(270, 235);
            room_image1.TabIndex = 1;
            room_image1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(13, 11);
            label11.Name = "label11";
            label11.Size = new Size(162, 25);
            label11.TabIndex = 0;
            label11.Text = "Room Images";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(1285, 889);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(147, 50);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_update_room
            // 
            btn_update_room.Location = new Point(1122, 889);
            btn_update_room.Name = "btn_update_room";
            btn_update_room.Size = new Size(147, 50);
            btn_update_room.TabIndex = 7;
            btn_update_room.Text = "Update";
            btn_update_room.UseVisualStyleBackColor = true;
            // 
            // Room_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1456, 951);
            Controls.Add(btn_cancel);
            Controls.Add(btn_update_room);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Room_UpdateForm";
            Text = "Room_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)room_image5).EndInit();
            ((System.ComponentModel.ISupportInitialize)room_image4).EndInit();
            ((System.ComponentModel.ISupportInitialize)room_image3).EndInit();
            ((System.ComponentModel.ISupportInitialize)room_image2).EndInit();
            ((System.ComponentModel.ISupportInitialize)room_image1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox room_type_choose;
        private ComboBox floor_choose;
        private CheckBox checkBox_available;
        private TextBox room_description_input;
        private TextBox room_number_input;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label room_type_label;
        private Label label3;
        private Panel panel3;
        private Button remove_acc_btn;
        private ComboBox acessories_choose;
        private ListBox accessories_listBox;
        private Label label12;
        private Panel panel4;
        private Button btn_remove_img5;
        private Button btn_add_img5;
        private Button btn_remove_img4;
        private Button btn_add_img4;
        private Button btn_remove_img3;
        private Button btn_add_img3;
        private Button btn_remove_img2;
        private Button btn_add_img2;
        private Button btn_remove_img1;
        private Button btn_add_img1;
        private PictureBox room_image5;
        private PictureBox room_image4;
        private PictureBox room_image3;
        private PictureBox room_image2;
        private PictureBox room_image1;
        private Label label11;
        private Button btn_cancel;
        private Button btn_update_room;
    }
}