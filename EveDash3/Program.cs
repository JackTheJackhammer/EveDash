using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIHandler;
using EveDash3.backend.sso;
using System.IO;
using System.Diagnostics;
using EveDash3.backend;
using EveDash3.backend.httpclient;
using EveDash3.backend.api.sql;
using EveDash3.backend.api;
using EveDash3.ui;
static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread] 
    static void Main()
    {


        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        //init sso
        SSO_Handler.InitializeSSO_Handler();
        //bug.WriteLine(SQLHandler.LegacyQueryEveDB("SELECT * FROM stastations LIMIT 5"));


        //SSO_Handler.refreshAuth(SSO_Handler.refreshToken);
        //Debug.WriteLine("25");
        //Debug.WriteLine(MiscFunctions.TryGetSolutionDirectoryInfo());
        PrecomputedValuesGenerator.UpdateQuickPriceReferenceTable();

        //initialize windows
        DashboardWindow mainwindow = new UIHandler.DashboardWindow();
        Application.Run(new UIHandler.DashboardWindow());

        //SSO_Handler.SendInitialAuth();
    }

}



