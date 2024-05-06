namespace HotelApp.modules
{
    partial class frm_SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SplashScreen));
            var progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(18, 462);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(657, 10);
            progressBar.TabIndex = 0;
            // 
            // frm_SplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 500);
            Controls.Add(progressBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blue Hotel";
            Load += frm_SplashScreen_Load;
            ResumeLayout(false);
        }



        #endregion
    }
}
