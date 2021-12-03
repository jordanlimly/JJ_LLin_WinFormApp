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
    public partial class AdminMainpage : Form
    {
        public AdminMainpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Current crowd btn click
        {
            tabControl1.SelectTab(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPopularity_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }
    }
}
