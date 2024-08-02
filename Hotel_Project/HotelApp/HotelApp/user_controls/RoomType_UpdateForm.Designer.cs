namespace HotelApp.user_controls
{
    partial class RoomType_UpdateForm
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
            btn_cancel = new Button();
            btn_update = new Button();
            txtNumberOfChildren = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNumberOfPersons = new TextBox();
            label3 = new Label();
            txtRoomtypeName = new TextBox();
            label2 = new Label();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(236, 18);
            label1.Name = "label1";
            label1.Size = new Size(437, 51);
            label1.TabIndex = 0;
            label1.Text = "UPDATE ROOM TYPE";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(732, 460);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 25;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(576, 460);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(139, 57);
            btn_update.TabIndex = 24;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txtNumberOfChildren
            // 
            txtNumberOfChildren.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfChildren.Location = new Point(412, 328);
            txtNumberOfChildren.Multiline = true;
            txtNumberOfChildren.Name = "txtNumberOfChildren";
            txtNumberOfChildren.Size = new Size(277, 39);
            txtNumberOfChildren.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(149, 339);
            label5.Name = "label5";
            label5.Size = new Size(257, 28);
            label5.TabIndex = 22;
            label5.Text = "Number of children : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(345, 105);
            label4.Name = "label4";
            label4.Size = new Size(227, 34);
            label4.TabIndex = 21;
            label4.Text = "Insert new data";
            // 
            // txtNumberOfPersons
            // 
            txtNumberOfPersons.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumberOfPersons.Location = new Point(412, 267);
            txtNumberOfPersons.Multiline = true;
            txtNumberOfPersons.Name = "txtNumberOfPersons";
            txtNumberOfPersons.Size = new Size(277, 39);
            txtNumberOfPersons.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 267);
            label3.Name = "label3";
            label3.Size = new Size(253, 28);
            label3.TabIndex = 19;
            label3.Text = "Number of persons : ";
            // 
            // txtRoomtypeName
            // 
            txtRoomtypeName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomtypeName.Location = new Point(412, 193);
            txtRoomtypeName.Multiline = true;
            txtRoomtypeName.Name = "txtRoomtypeName";
            txtRoomtypeName.Size = new Size(277, 38);
            txtRoomtypeName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 192);
            label2.Name = "label2";
            label2.Size = new Size(234, 28);
            label2.TabIndex = 17;
            label2.Text = "Room type name : ";
            // 
            // RoomType_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 554);
            Controls.Add(btn_cancel);
            Controls.Add(btn_update);
            Controls.Add(txtNumberOfChildren);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNumberOfPersons);
            Controls.Add(label3);
            Controls.Add(txtRoomtypeName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RoomType_UpdateForm";
            Text = "RoomType_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_cancel;
        private Button btn_update;
        private TextBox txtNumberOfChildren;
        private Label label5;
        private Label label4;
        private TextBox txtNumberOfPersons;
        private Label label3;
        private TextBox txtRoomtypeName;
        private Label label2;
    }
}