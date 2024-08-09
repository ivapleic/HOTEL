namespace HotelApp.user_controls
{
    partial class AddServices_AddNewForm
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
            btn_add = new Button();
            txtServiceDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtServicePrice = new TextBox();
            label3 = new Label();
            txtServiceName = new TextBox();
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
            label1.Location = new Point(203, 20);
            label1.Name = "label1";
            label1.Size = new Size(409, 51);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW SERVICE";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(749, 474);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 25;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(593, 474);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(139, 57);
            btn_add.TabIndex = 24;
            btn_add.Text = "Add ";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceDescription.Location = new Point(429, 342);
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(277, 39);
            txtServiceDescription.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(203, 353);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 22;
            label5.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(362, 119);
            label4.Name = "label4";
            label4.Size = new Size(190, 34);
            label4.TabIndex = 21;
            label4.Text = "Fill new data";
            // 
            // txtServicePrice
            // 
            txtServicePrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServicePrice.Location = new Point(429, 281);
            txtServicePrice.Multiline = true;
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(277, 39);
            txtServicePrice.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 280);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 19;
            label3.Text = "Service price :";
            // 
            // txtServiceName
            // 
            txtServiceName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceName.Location = new Point(429, 207);
            txtServiceName.Multiline = true;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(277, 38);
            txtServiceName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 206);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 17;
            label2.Text = "Service name : ";
            // 
            // AddServices_AddNewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 554);
            Controls.Add(btn_cancel);
            Controls.Add(btn_add);
            Controls.Add(txtServiceDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtServicePrice);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AddServices_AddNewForm";
            Text = "AddServices_AddNewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_cancel;
        private Button btn_add;
        private TextBox txtServiceDescription;
        private Label label5;
        private Label label4;
        private TextBox txtServicePrice;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
    }
}