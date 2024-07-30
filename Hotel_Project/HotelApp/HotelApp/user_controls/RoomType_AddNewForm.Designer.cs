namespace HotelApp.user_controls
{
    partial class RoomType_AddNewForm
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
            txtNumberOfPersons = new TextBox();
            label3 = new Label();
            txtRoomtypeName = new TextBox();
            label2 = new Label();
            txtNumberOfChildren = new TextBox();
            label5 = new Label();
            btn_cancel = new Button();
            btn_add = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 81);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(203, 20);
            label1.Name = "label1";
            label1.Size = new Size(482, 51);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW ROOM TYPE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 112);
            label4.Name = "label4";
            label4.Size = new Size(190, 34);
            label4.TabIndex = 12;
            label4.Text = "Fill new data";
            // 
            // txtNumberOfPersons
            // 
            txtNumberOfPersons.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfPersons.Location = new Point(427, 274);
            txtNumberOfPersons.Multiline = true;
            txtNumberOfPersons.Name = "txtNumberOfPersons";
            txtNumberOfPersons.Size = new Size(218, 39);
            txtNumberOfPersons.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(168, 274);
            label3.Name = "label3";
            label3.Size = new Size(253, 28);
            label3.TabIndex = 10;
            label3.Text = "Number of persons : ";
            // 
            // txtRoomtypeName
            // 
            txtRoomtypeName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomtypeName.Location = new Point(427, 200);
            txtRoomtypeName.Multiline = true;
            txtRoomtypeName.Name = "txtRoomtypeName";
            txtRoomtypeName.Size = new Size(218, 38);
            txtRoomtypeName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 199);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 8;
            label2.Text = "Room type name : ";
            // 
            // txtNumberOfChildren
            // 
            txtNumberOfChildren.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfChildren.Location = new Point(427, 335);
            txtNumberOfChildren.Multiline = true;
            txtNumberOfChildren.Name = "txtNumberOfChildren";
            txtNumberOfChildren.Size = new Size(218, 39);
            txtNumberOfChildren.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(164, 346);
            label5.Name = "label5";
            label5.Size = new Size(257, 28);
            label5.TabIndex = 13;
            label5.Text = "Number of children : ";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(747, 467);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 16;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(591, 467);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(139, 57);
            btn_add.TabIndex = 15;
            btn_add.Text = "Add ";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // RoomType_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 554);
            Controls.Add(btn_cancel);
            Controls.Add(btn_add);
            Controls.Add(txtNumberOfChildren);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNumberOfPersons);
            Controls.Add(label3);
            Controls.Add(txtRoomtypeName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RoomType_AddNewForm";
            Text = "RoomType_AddNewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox txtNumberOfPersons;
        private Label label3;
        private TextBox txtRoomtypeName;
        private Label label2;
        private TextBox txtNumberOfChildren;
        private Label label5;
        private Button btn_cancel;
        private Button btn_add;
    }
}