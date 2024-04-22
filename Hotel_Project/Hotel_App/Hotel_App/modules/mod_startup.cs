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
                //*****************************************************************************
                //*********************** DA LI JE ISPRAVNO IZRACNAT HWID RACUNALA
                //*****************************************************************************
                //    if (HW_ID_Long == "")
                //    {
                //        //var NewDBInfoForm = new frm_PUBLIC_messagebox(msgbox_startup_GET_HWID_Error, true, false, ObjSkin_FORMS);
                //        //NewDBInfoForm.ShowDialog();
                //        return;
                //    }
                //    //*****************************************************************************
                //    //*********************** DA LI JE LICENCA U REDU
                //    //*****************************************************************************
                //    //var varConfig_LICENCE_CHECKER = new cls_settings_licence_checker(HW_ID_Short, varConfig_LICENCE);
                //    //bool NeedToShow_LicForm;
                //    //...
                //    //*****************************************************************************
                //    //*********************** DATABASE
                //    //*****************************************************************************
                //    var var_Config_DBASE = new cls_settings_dbase("DESKTOP-4TKMESF", "Blue_HOTEL", "sa", "Bcpass123", 2000);
                //    var var_DatabaseObject = new cls_db(var_Config_DBASE, 4000);
                //    //*****************************************************************************
                //    //*****************************************************************************
                //    //*************** WHILE LOOP TO CONTROL MAIN FORMS
                //    //*****************************************************************************
                //    //*****************************************************************************
                //    var memfrm_frmMain = new frm_login();
                //    var memfrm_frmUser = new frm_user();
                //    var memfrm_frmAdmin = new frm_admin();
                //    //*****************************************************************************
                //    //*****************************************************************************
                //    while (true)
                //    {
                //        //****************************************************
                //        //****************************************************
                //        frm_login.Form_Close_OK = false;
                //        frm_login.txt_pswd.Clear();
                //        frm_login.ShowDialog();
                //        //****************************************************
                //        //****************************************************
                //        if (frm_login.DialogResult == DialogResult.OK) // LOGIN USER
                //        {
                //            memfrm_frmUser.Form_Close_OK = false;
                //            memfrm_frmUser.ShowDialog();
                //        }
                //        else if (frm_login.DialogResult == DialogResult.Yes) // LOGIN ADMIN
                //        {
                //            memfrm_frmAdmin.Form_Close_OK = false;
                //            memfrm_frmAdmin.DiplayWelcome_UserControl();
                //            memfrm_frmAdmin.ShowDialog();
                //        }
                //        //****************************************************
                //        //****************************************************
                //    }
                //    //*****************************************************************************
                //    //*****************************************************************************
                }
                catch /*(Exception ex)*/
                {
                //var ErrForm = new frm_MsgBox(ex.Message, ENUM_Messagebox_Style.MESSAGEBOX_ERROR);
                //ErrForm.ShowDialog();
                Console.WriteLine("A GRESKAA");
                }
            }
    }
    }
