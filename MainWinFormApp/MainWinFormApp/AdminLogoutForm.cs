using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWinFormApp
{
    public partial class AdminLogoutForm : Form
    {
        public AdminLogoutForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AdminLoginForm.managerloggedin = "false";
            Application.Exit();
            //AdminLoginForm frm = new AdminLoginForm();  //open login form
            //this.Hide();
            //frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
