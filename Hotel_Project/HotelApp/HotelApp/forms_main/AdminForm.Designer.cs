namespace HotelApp.forms_main
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            ContextMenuStrip = new ContextMenuStrip(components);
            meniToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label_DateTime = new Label();
            label1 = new Label();
            label_UserName = new Label();
            ContextMenuStrip.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.BackColor = SystemColors.ActiveCaption;
            ContextMenuStrip.ImageScalingSize = new Size(24, 24);
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { meniToolStripMenuItem });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(124, 36);
            // 
            // meniToolStripMenuItem
            // 
            meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            meniToolStripMenuItem.Size = new Size(123, 32);
            meniToolStripMenuItem.Text = "Meni";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 78, 128);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1421, 78);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(1421, 558);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(label_DateTime);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label_UserName);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(1421, 70);
            panel2.TabIndex = 4;
            // 
            // label_DateTime
            // 
            label_DateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_DateTime.AutoSize = true;
            label_DateTime.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_DateTime.Location = new Point(1130, 23);
            label_DateTime.Name = "label_DateTime";
            label_DateTime.Size = new Size(279, 34);
            label_DateTime.TabIndex = 2;
            label_DateTime.Text = "10.02.2024 12:43:33";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 34);
            label1.TabIndex = 0;
            label1.Text = "User: ";
            // 
            // label_UserName
            // 
            label_UserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_UserName.AutoSize = true;
            label_UserName.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_UserName.Location = new Point(96, 24);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(182, 34);
            label_UserName.TabIndex = 1;
            label_UserName.Text = "Ime Prezime";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1421, 636);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "AdminForm";
            Text = "AdminForm";
            WindowState = FormWindowState.Maximized;
            ContextMenuStrip.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem meniToolStripMenuItem;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Label label_DateTime;
        private Label label_UserName;
        private Panel panel2;
    }
}