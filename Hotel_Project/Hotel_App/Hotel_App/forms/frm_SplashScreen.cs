using System;
using System.Threading;
using System.Windows.Forms;

public class frm_SplashScreen : Form
{
    public frm_SplashScreen()
    {
     
    }
    private void frm_SplashScreen_Load(object sender, EventArgs e)
    {

    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SplashScreen));
            this.SuspendLayout();
            // 
            // frm_SplashScreen
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 579);
            this.Name = "frm_SplashScreen";
            this.ResumeLayout(false);

    }
}
