using HotelApp.forms_main;
using System;
using System.Windows.Forms;

namespace HotelApp.modules
{
    internal class mod_startup
    {
        public static void Startup()
        {
            try
            {
                // Prikazivanje Splash Screena
                frm_SplashScreen splashScreen = new frm_SplashScreen();
                splashScreen.ShowDialog();
        
                while (true)
                {
                    form_login loginForm = new form_login();
                    loginForm.FormClosed += (s, args) =>
                    {
                        if (loginForm.DialogResult == DialogResult.OK)
                        {
                            // Prijavljen je korisnik
                            form_user userForm = new form_user();
                            userForm.ShowDialog();
                        }
                        else if (loginForm.DialogResult == DialogResult.Yes)
                        {
                            // Prijavljen je administrator
                            form_admin adminForm = new form_admin();
                            adminForm.ShowDialog();
                        }
                    };
                    loginForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
