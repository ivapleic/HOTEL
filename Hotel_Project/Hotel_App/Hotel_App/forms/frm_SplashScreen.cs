using System;
using System.Threading;
using System.Windows.Forms;

public class frm_SplashScreen : Form
{
    //************************************************
    public Thread Thread_MAIN_INIT; // posebni thread za INIT programa
    public delegate void Delegate_CloseForm(); // delegate za izlaz iz forme
    public delegate void Delegate_UpdateProgress(int InVal); // progress
    //************************************************
    public bool EnterLICENCE = false;
    //************************************************
    public bool FormCloseOK = false;
    //************************************************
    // test database connection variables
    private Thread TestDbaseThreadRef;
    public bool DBhost_OK = false;
    //************************************************

    #region MAIN FUNCTIONS

    public frm_SplashScreen()
    {
        try
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call.
            
            //Set_GUI_Display();
        }
        catch (Exception ex)
        {

        }
    }

    //private void frm_splashscreen_Load(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        //**************************************************************
    //        UltraProgressBarMain.Value = 0;
    //        //**************************************************************
    //        Thread_MAIN_INIT = new Thread(new ThreadStart(MAIN_INIT));
    //        Thread_MAIN_INIT.Start();
    //        //**************************************************************
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //private void frm_splashscreen_KeyDown(object sender, KeyEventArgs e)
    //{
    //    try
    //    {
    //        if (e.KeyCode == Keys.F6)
    //        {
    //            EnterLICENCE = true;
    //        }
    //        else if (e.KeyValue == 115) // ovo je ALT+F4
    //        {
    //            e.Handled = true;
    //        }
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //private void frm_PUBLIC_Splashscreen_FormClosing(object sender, FormClosingEventArgs e)
    //{
    //    try
    //    {
    //        if (FormCloseOK == false)
    //        {
    //            e.Cancel = true;
    //        }
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //public void CallDelegate_CloseForm()
    //{
    //    try
    //    {
    //        this.BeginInvoke(new Delegate_CloseForm(EventHandler_CloseForm));
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //public void CallDelegate_UpdateProgress(int inVal)
    //{
    //    try
    //    {
    //        this.BeginInvoke(new Delegate_UpdateProgress(EventHandler_Progress), inVal);
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //private void EventHandler_Progress(int inValue)
    //{
    //    try
    //    {
    //        //*****************************************************
    //        if (inValue > 100)
    //        {
    //            inValue = 100;
    //        }
    //        //*****************************************************
    //        UltraProgressBarMain.Value = inValue;
    //        //*****************************************************
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //private void EventHandler_CloseForm()
    //{
    //    try
    //    {
    //        this.DialogResult = DialogResult.OK;
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //private void MAIN_INIT()
    //{
    //    try
    //    {
    //        //*************************************************************************
    //        //********************************* NFI
    //        //*************************************************************************
    //        CallDelegate_UpdateProgress(5);
    //        nfi.NumberDecimalSeparator = ",";
    //        nfi.NumberGroupSeparator = "";
    //        nfi.NumberDecimalDigits = 9;
    //        CallDelegate_UpdateProgress(10);
    //        //*************************************************************************
    //        //********************************* INIT CONFIG DATA
    //        //*************************************************************************
    //        //Init_Config_LICENCE();
    //        //CallDelegate_UpdateProgress(15);
    //        //Init_Config_MAIN();
    //        //*************************************************************************
    //        //*************************************************************************
    //        mod_lic_INIT_HW_INFO();
    //        CallDelegate_UpdateProgress(50);
    //        Thread.Sleep(500);
    //        //*************************************************************************
    //        //TestDbaseHOST_MAIN();
    //        CallDelegate_UpdateProgress(70);
    //        Thread.Sleep(500);
    //        //*************************************************************************
    //        FormCloseOK = true;
    //        CallDelegate_UpdateProgress(100);
    //        Thread.Sleep(500);
    //        //*************************************************************************
    //        //*************************************************************************
    //        // FUNKCIJA KOJA U PUBLIC OBJEKTE STAVI SVE SLIKE KOJE SE KORISTE U PROGRAMU
    //        //  LoadAllImagesFromResources()
    //        //*************************************************************************
    //        CallDelegate_CloseForm();
    //        //*************************************************************************
    //    }
    //    catch (Exception ex)
    //    {
    //        FormCloseOK = true;
    //        CallDelegate_CloseForm();
    //    }
    //}

    //private void Set_GUI_Display()
    //{
    //    try
    //    {
    //        this.BackColor = Color_Form_BackColor;
    //        SET_GUI_FORM_PROGRESS_BAR(UltraProgressBarMain);
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //#endregion

    //#region TEST DATABASE HOST - SEPARATE THREAD

    //private void TestDbaseHOST_MAIN()
    //{
    //    try
    //    {
    //        //*******************************************************
    //        int i;
    //        //*******************************************************
    //        for (i = 0; i <= 2; i++)
    //        {
    //            TestDbaseHOST_START();
    //            if (DBhost_OK == true)
    //            {
    //                break;
    //            }
    //        }
    //        //*******************************************************
    //    }
    //    catch (Exception ex)
    //    {

    //    }
    //}

    //private void TestDbaseHOST_START()
    //{
    //    try
    //    {
    //        int TimeOut = Convert.ToInt32(5 * 1000);
    //        WaitHandle[] handles = new WaitHandle[] { new AutoResetEvent(false) };
    //        //**************************** START PROCEDURE IN NEW THREAD
    //        ThreadPool.QueueUserWorkItem(new WaitCallback(TestDbaseHOSTWorkerThread), handles[0]);
    //        bool finished = WaitHandle.WaitAll(handles, TimeOut, true);
    //        //*************************************************************************
    //        //*************************************************************************
    //        if (finished)
    //        {
    //            // THREAD JE ZAVRSIO - STO NE MORA ZNACITI DA JE VEZA NA BAZU OK
    //        }
    //        else
    //        {
    //            DBhost_OK = false;
    //            //THREAD NIJE NI ZAVRSIO NEGO SE DESIO TIMEOUT
    //            TestDbaseThreadRef.Abort();  // abort worker thread
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //}

    //private void TestDbaseHOSTWorkerThread(object state)
    //{
    //    try
    //    {
    //        // set worker thread to public pointer
    //        TestDbaseThreadRef = Thread.CurrentThread;
    //        AutoResetEvent are = (AutoResetEvent)state;
    //        //**************************************************************
    //        //**************************************************************
    //        try
    //        {
    //            //****************************************************************
    //            // database connection string (spaja se na master bazu samo da se vidi da li postoji SQL server)
    //            string v_CONNECTION_STRING = "";
    //            v_CONNECTION_STRING += "server=";
    //            v_CONNECTION_STRING += var_Config_DBASE.DBase_HOST;
    //            v_CONNECTION_STRING += ";database=";
    //            v_CONNECTION_STRING += "master";
    //            v_CONNECTION_STRING += ";uid=";
    //            v_CONNECTION_STRING += var_Config_DBASE.DBase_USER;
    //            v_CONNECTION_STRING += ";pwd=";
    //            v_CONNECTION_STRING += var_Config_DBASE.DBase_PASSWORD;
    //            v_CONNECTION_STRING += ";timeout=";
    //            v_CONNECTION_STRING += "7";
    //            v_CONNECTION_STRING += ";";
    //            //****************************************************************
    //            cls_db_API DbaseObj = new cls_db_API(v_CONNECTION_STRING);
    //            DbaseObj.OpenConnection();
    //            DbaseObj.CloseConnection();
    //            //*************************************************
    //            DBhost_OK = true;
    //            //*************************************************
    //        }
    //        catch (Exception ex)
    //        {
    //            DBhost_OK = false;
    //        }
    //        //**************************************************************
    //        //**************************************************************
    //        // inform callBackHandle that function is finished
    //        are.Set();
    //        //**************************************************************
    //        //**************************************************************
    //    }
    //    catch (Exception ex)
    //    {
    //    }
    //}

    #endregion

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SplashScreen));
            this.SuspendLayout();
            // 
            // frm_SplashScreen
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 575);
            this.Name = "frm_SplashScreen";
            this.Load += new System.EventHandler(this.frm_SplashScreen_Load);
            this.ResumeLayout(false);

    }

    private void frm_SplashScreen_Load(object sender, EventArgs e)
    {

    }
}
