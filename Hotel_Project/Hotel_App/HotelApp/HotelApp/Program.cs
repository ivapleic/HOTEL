﻿using System;
using System.Windows.Forms;

namespace HotelApp.modules
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            mod_startup.Startup();
        }
    }
}
