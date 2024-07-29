namespace HotelApp.user_controls
{
    partial class Accessories_AddNewForm
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
            txtAccName = new TextBox();
            label3 = new Label();
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
            panel1.Size = new Size(800, 81);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 78, 128);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(497, 51);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW ACCESSORY";
            // 
            // txtAccName
            // 
            txtAccName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAccName.Location = new Point(257, 127);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(305, 37);
            txtAccName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 132);
            label3.Name = "label3";
            label3.Size = new Size(213, 28);
            label3.TabIndex = 5;
            label3.Text = "Accessory Name";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(644, 383);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(112, 34);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(509, 383);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(112, 34);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Accessories_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancel);
            Controls.Add(btn_add);
            Controls.Add(txtAccName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Accessories_AddNewForm";
            Text = "Accessories_AddNewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtAccName;
        private Label label3;
        private Button btn_cancel;
        private Button btn_add;
    }
}