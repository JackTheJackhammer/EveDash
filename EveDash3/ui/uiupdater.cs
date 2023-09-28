using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIHandler
{
    //this is basically all wrapper classes. if you needd to update the ui as a whole, send a request to this and 
    public static class UiUpdateHandler
    {

        public static DashboardWindow dashboardWindow;
        
        public static void DashboardWindowUpdate()
        {
            dashboardWindow.UpdateWindow();

        }



    }
}
