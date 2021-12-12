using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace MainWinFormApp
{
    public partial class UserDashboard : Form
    {
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["JJLLinDBConnection"].ConnectionString;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );


        public UserDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
            CustUpdateForm frm = new CustUpdateForm();
            frm.ShowDialog();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnLogout.Height;
            pnlNav.Top = btnLogout.Top;
            pnlNav.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(46, 51, 73);
            LogoutForm frm = new LogoutForm();
            frm.ShowDialog();
        }

        private void btnGameMachineUsage_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGameMachineUsage.Height;
            pnlNav.Top = btnGameMachineUsage.Top;
            pnlNav.Left = btnGameMachineUsage.Left;
            btnGameMachineUsage.BackColor = Color.FromArgb(46, 51, 73);
            panelGMU.Visible = true;
        }

        private void btnGameMachineUsage_Leave(object sender, EventArgs e)
        {
            btnGameMachineUsage.BackColor = Color.FromArgb(0, 0, 0);
            panelGMU.Visible = false;
        }
    }
    
}
