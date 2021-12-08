using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWinFormApp
{
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
            //Application.Run(new frmforgetpw());
            //Application.Run(new frmMaintenance());
            //Application.Run(new frmCurrentCrowd());
            //Application.Run(new CustLoginForm());
            Application.Run(new frmCreateuserAcc());
            //Application.Run(new AdminMainpage());
            //Application.Run(new UserDashboard());
        }
    }
}
