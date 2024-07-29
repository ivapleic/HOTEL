namespace HotelApp.user_controls
{
    partial class Floor_AddNewForm
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
            txtFloorNumber = new TextBox();
            txtFloorDescription = new TextBox();
            label3 = new Label();
            btn_add = new Button();
            btn_cancel = new Button();
            label4 = new Label();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(263, 18);
            label1.Name = "label1";
            label1.Size = new Size(377, 51);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW FLOOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 196);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 1;
            label2.Text = "Floor Number : ";
            // 
            // txtFloorNumber
            // 
            txtFloorNumber.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFloorNumber.Location = new Point(443, 197);
            txtFloorNumber.Multiline = true;
            txtFloorNumber.Name = "txtFloorNumber";
            txtFloorNumber.Size = new Size(218, 38);
            txtFloorNumber.TabIndex = 2;
            // 
            // txtFloorDescription
            // 
            txtFloorDescription.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFloorDescription.Location = new Point(443, 271);
            txtFloorDescription.Multiline = true;
            txtFloorDescription.Name = "txtFloorDescription";
            txtFloorDescription.Size = new Size(218, 39);
            txtFloorDescription.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(211, 271);
            label3.Name = "label3";
            label3.Size = new Size(226, 28);
            label3.TabIndex = 3;
            label3.Text = "Floor Description : ";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(586, 448);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(139, 57);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(742, 448);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(368, 110);
            label4.Name = "label4";
            label4.Size = new Size(190, 34);
            label4.TabIndex = 7;
            label4.Text = "Fill new data";
            // 
            // Floor_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 554);
            Controls.Add(label4);
            Controls.Add(btn_cancel);
            Controls.Add(btn_add);
            Controls.Add(txtFloorDescription);
            Controls.Add(label3);
            Controls.Add(txtFloorNumber);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Floor_AddNewForm";
            Text = "AddNewFloor";
            FormClosed += AddNewFloorForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtFloorNumber;
        private TextBox txtFloorDescription;
        private Label label3;
        private Button btn_add;
        private Button btn_cancel;
        private Label label4;
    }
}