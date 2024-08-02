﻿namespace HotelApp.user_controls
{
    partial class RoomDetailsForm
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
            room_number_label = new Label();
            label1 = new Label();
            panel2 = new Panel();
            room_available_label = new Label();
            room_description_label = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            room_type_label = new Label();
            floor_number_label = new Label();
            label3 = new Label();
            panel3 = new Panel();
            accessories_listBox = new ListBox();
            label12 = new Label();
            panel4 = new Panel();
            room_image5 = new PictureBox();
            room_image4 = new PictureBox();
            room_image3 = new PictureBox();
            room_image2 = new PictureBox();
            room_image1 = new PictureBox();
            label11 = new Label();
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
            panel1.Controls.Add(room_number_label);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 104);
            panel1.TabIndex = 0;
            // 
            // room_number_label
            // 
            room_number_label.AutoSize = true;
            room_number_label.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            room_number_label.ForeColor = Color.FromArgb(40, 86, 182);
            room_number_label.Location = new Point(371, 18);
            room_number_label.Name = "room_number_label";
            room_number_label.Size = new Size(167, 56);
            room_number_label.TabIndex = 1;
            room_number_label.Text = "npr 45";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(0, 18);
            label1.Name = "label1";
            label1.Size = new Size(392, 56);
            label1.TabIndex = 0;
            label1.Text = "Room number : ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(room_available_label);
            panel2.Controls.Add(room_description_label);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(room_type_label);
            panel2.Controls.Add(floor_number_label);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(29, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 339);
            panel2.TabIndex = 1;
            // 
            // room_available_label
            // 
            room_available_label.AutoSize = true;
            room_available_label.Font = new Font("Century Gothic", 11F);
            room_available_label.Location = new Point(147, 109);
            room_available_label.Name = "room_available_label";
            room_available_label.Size = new Size(57, 25);
            room_available_label.TabIndex = 7;
            room_available_label.Text = "True";
            // 
            // room_description_label
            // 
            room_description_label.AutoSize = true;
            room_description_label.Font = new Font("Century Gothic", 11F);
            room_description_label.Location = new Point(229, 157);
            room_description_label.Name = "room_description_label";
            room_description_label.Size = new Size(158, 25);
            room_description_label.TabIndex = 6;
            room_description_label.Text = "Neki dugi opis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 66);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 5;
            label8.Text = "Floor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11F);
            label7.Location = new Point(12, 109);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 4;
            label7.Text = "Available :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11F);
            label6.Location = new Point(12, 157);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 3;
            label6.Text = "Room Description :";
            // 
            // room_type_label
            // 
            room_type_label.AutoSize = true;
            room_type_label.Font = new Font("Century Gothic", 11F);
            room_type_label.Location = new Point(161, 19);
            room_type_label.Name = "room_type_label";
            room_type_label.Size = new Size(0, 25);
            room_type_label.TabIndex = 2;
            // 
            // floor_number_label
            // 
            floor_number_label.AutoSize = true;
            floor_number_label.Font = new Font("Century Gothic", 11F);
            floor_number_label.Location = new Point(94, 66);
            floor_number_label.Name = "floor_number_label";
            floor_number_label.Size = new Size(24, 25);
            floor_number_label.TabIndex = 1;
            floor_number_label.Text = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F);
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 0;
            label3.Text = "Room Type : ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(accessories_listBox);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(812, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 339);
            panel3.TabIndex = 2;
            // 
            // accessories_listBox
            // 
            accessories_listBox.BorderStyle = BorderStyle.None;
            accessories_listBox.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accessories_listBox.FormattingEnabled = true;
            accessories_listBox.ItemHeight = 26;
            accessories_listBox.Location = new Point(128, 66);
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
            panel4.Controls.Add(room_image5);
            panel4.Controls.Add(room_image4);
            panel4.Controls.Add(room_image3);
            panel4.Controls.Add(room_image2);
            panel4.Controls.Add(room_image1);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(29, 478);
            panel4.Name = "panel4";
            panel4.Size = new Size(1400, 337);
            panel4.TabIndex = 3;
            // 
            // room_image5
            // 
            room_image5.Location = new Point(1116, 80);
            room_image5.Name = "room_image5";
            room_image5.Size = new Size(270, 235);
            room_image5.TabIndex = 5;
            room_image5.TabStop = false;
            // 
            // room_image4
            // 
            room_image4.Location = new Point(840, 80);
            room_image4.Name = "room_image4";
            room_image4.Size = new Size(270, 235);
            room_image4.TabIndex = 4;
            room_image4.TabStop = false;
            room_image4.Click += room_image4_Click;
            // 
            // room_image3
            // 
            room_image3.Location = new Point(564, 79);
            room_image3.Name = "room_image3";
            room_image3.Size = new Size(270, 235);
            room_image3.TabIndex = 3;
            room_image3.TabStop = false;
            // 
            // room_image2
            // 
            room_image2.Location = new Point(288, 79);
            room_image2.Name = "room_image2";
            room_image2.Size = new Size(270, 235);
            room_image2.TabIndex = 2;
            room_image2.TabStop = false;
            // 
            // room_image1
            // 
            room_image1.BackColor = Color.Transparent;
            room_image1.Location = new Point(12, 79);
            room_image1.Name = "room_image1";
            room_image1.Size = new Size(270, 235);
            room_image1.TabIndex = 1;
            room_image1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 11);
            label11.Name = "label11";
            label11.Size = new Size(162, 25);
            label11.TabIndex = 0;
            label11.Text = "Room Images";
            // 
            // RoomDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1456, 866);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RoomDetailsForm";
            Text = "RoomDetailsForm";
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
        private Label room_number_label;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label room_type_label;
        private Label floor_number_label;
        private Label label3;
        private Label room_available_label;
        private Label room_description_label;
        private Panel panel3;
        private Label label12;
        private Panel panel4;
        private PictureBox room_image4;
        private PictureBox room_image3;
        private PictureBox room_image2;
        private PictureBox room_image1;
        private Label label11;
        private ListBox accessories_listBox;
        private PictureBox room_image5;
    }
}