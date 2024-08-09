namespace HotelApp.user_controls
{
    partial class AddServices_UpdateForm
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(40, 86, 182);
            label1.Location = new Point(203, 20);
            label1.Name = "label1";
            label1.Size = new Size(364, 51);
            label1.TabIndex = 0;
            label1.Text = "UPDATE SERVICE";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(747, 475);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(139, 57);
            btn_cancel.TabIndex = 34;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(591, 475);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(139, 57);
            btn_update.TabIndex = 33;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceDescription.Location = new Point(427, 343);
            txtServiceDescription.Multiline = true;
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Size = new Size(277, 39);
            txtServiceDescription.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(201, 354);
            label5.Name = "label5";
            label5.Size = new Size(156, 28);
            label5.TabIndex = 31;
            label5.Text = "Description :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 120);
            label4.Name = "label4";
            label4.Size = new Size(190, 34);
            label4.TabIndex = 30;
            label4.Text = "Fill new data";
            // 
            // txtServicePrice
            // 
            txtServicePrice.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServicePrice.Location = new Point(427, 282);
            txtServicePrice.Multiline = true;
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(277, 39);
            txtServicePrice.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 281);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 28;
            label3.Text = "Service price :";
            // 
            // txtServiceName
            // 
            txtServiceName.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtServiceName.Location = new Point(427, 208);
            txtServiceName.Multiline = true;
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(277, 38);
            txtServiceName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(187, 207);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 26;
            label2.Text = "Service name : ";
            // 
            // AddServices_UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(909, 554);
            Controls.Add(btn_cancel);
            Controls.Add(btn_update);
            Controls.Add(txtServiceDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtServicePrice);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AddServices_UpdateForm";
            Text = "AddServices_UpdateForm";
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
        private TextBox txtServiceDescription;
        private Label label5;
        private Label label4;
        private TextBox txtServicePrice;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
    }
}