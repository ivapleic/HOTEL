using System;

namespace Hotel_App
{
    public static class StartupModule
    {
        public static void Main()
        {
            try
            {
                //*****************************************************************************
                //*********************** SPLASH SCREEN (INIT ALL PARAMETERS)
                //*****************************************************************************
                var mem_frm_splash = new frm_SplashScreen();
                mem_frm_splash.ShowDialog();
            }

            catch
            {

            }
        }
    }
}
