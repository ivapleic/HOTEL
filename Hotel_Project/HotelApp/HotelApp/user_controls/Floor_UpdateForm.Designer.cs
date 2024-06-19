namespace HotelApp.user_controls
{
    partial class Floor_UpdateForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBox_floorNumber = new TextBox();
            txtBox_floorDescription = new TextBox();
            btn_save = new Button();
            btn_cancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 78, 128);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(303, 47);
            label1.TabIndex = 0;
            label1.Text = "UPDATE FLOOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F);
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(215, 34);
            label2.TabIndex = 1;
            label2.Text = "Floor number  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F);
            label3.Location = new Point(201, 109);
            label3.Name = "label3";
            label3.Size = new Size(0, 34);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F);
            label4.Location = new Point(44, 171);
            label4.Name = "label4";
            label4.Size = new Size(262, 34);
            label4.TabIndex = 3;
            label4.Text = "Floor description  :";
            // 
            // txtBox_floorNumber
            // 
            txtBox_floorNumber.Font = new Font("Century Gothic", 14F);
            txtBox_floorNumber.Location = new Point(265, 109);
            txtBox_floorNumber.Name = "txtBox_floorNumber";
            txtBox_floorNumber.Size = new Size(150, 42);
            txtBox_floorNumber.TabIndex = 4;
            // 
            // txtBox_floorDescription
            // 
            txtBox_floorDescription.Font = new Font("Century Gothic", 14F);
            txtBox_floorDescription.Location = new Point(326, 171);
            txtBox_floorDescription.Name = "txtBox_floorDescription";
            txtBox_floorDescription.Size = new Size(163, 42);
            txtBox_floorDescription.TabIndex = 5;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(629, 477);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 6;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btnUpdate_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(765, 477);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(112, 34);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Floor_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 548);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txtBox_floorDescription);
            Controls.Add(txtBox_floorNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Floor_UpdateForm";
            Text = "Floor_UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBox_floorNumber;
        private TextBox txtBox_floorDescription;
        private Button btn_save;
        private Button btn_cancel;
    }
}