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
            meniToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // meniToolStripMenuItem
            // 
            meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            meniToolStripMenuItem.Size = new Size(123, 32);
            meniToolStripMenuItem.Text = "Meni";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1421, 636);
            panel3.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.ActiveCaption;
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { meniToolStripMenuItem });
            contextMenuStrip1.Name = "ContextMenuStrip";
            contextMenuStrip1.Size = new Size(124, 36);
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1421, 636);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel3);
            Name = "AdminForm";
            Text = "AdminForm";
            WindowState = FormWindowState.Maximized;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem meniToolStripMenuItem;
        private Panel panel3;
        private ContextMenuStrip contextMenuStrip1;
    }
}