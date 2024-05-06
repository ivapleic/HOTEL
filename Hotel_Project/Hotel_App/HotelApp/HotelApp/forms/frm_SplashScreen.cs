using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelApp.modules
{
    public partial class frm_SplashScreen : Form
    {
        private Thread Thread_MAIN_INIT; // Posebni thread za inicijalizaciju programa
        private bool FormCloseOK = false; //Je li forma spremna za zatvaranje

        public frm_SplashScreen()
        {
            InitializeComponent();
        }

        private void frm_SplashScreen_Load(object sender, EventArgs e)
        {
            Thread_MAIN_INIT = new Thread(new ThreadStart(MAIN_INIT));
            Thread_MAIN_INIT.Start();
        }

        private void MAIN_INIT()
        {
            Thread.Sleep(3000); // Simulacija čekanja 3 sekunde

            this.Invoke(new MethodInvoker(delegate ()
            {
                FormCloseOK = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }));
        }
    }
}
