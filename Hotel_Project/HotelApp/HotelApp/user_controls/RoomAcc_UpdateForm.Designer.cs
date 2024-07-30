namespace HotelApp.user_controls
{
    partial class RoomAcc_UpdateForm
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
            label5 = new Label();
            txtBox_accName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(165, 20);
            label1.Name = "label1";
            label1.Size = new Size(578, 47);
            label1.TabIndex = 0;
            label1.Text = "UPDATE ROOM ACCESSORIES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14F);
            label5.Location = new Point(351, 113);
            label5.Name = "label5";
            label5.Size = new Size(160, 34);
            label5.TabIndex = 9;
            label5.Text = "Insert data";
            // 
            // txtBox_accName
            // 
            txtBox_accName.Font = new Font("Century Gothic", 14F);
            txtBox_accName.Location = new Point(401, 213);
            txtBox_accName.Name = "txtBox_accName";
            txtBox_accName.Size = new Size(412, 42);
            txtBox_accName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F);
            label3.Location = new Point(395, 223);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F);
            label2.Location = new Point(143, 213);
            label2.Name = "label2";
            label2.Size = new Size(246, 34);
            label2.TabIndex = 10;
            label2.Text = "Acessory name  :";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(724, 450);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(148, 57);
            btn_cancel.TabIndex = 15;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(557, 450);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(147, 57);
            btn_save.TabIndex = 14;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // RoomAcc_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 548);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_accName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "RoomAcc_UpdateForm";
            Text = "RoomAcc_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private TextBox txtBox_accName;
        private Label label3;
        private Label label2;
        private Button btn_cancel;
        private Button btn_save;
    }
}