using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jilani_Cards
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmItemCode frm = new frmItemCode();
            frm.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdStockManager_Click(object sender, EventArgs e)
        {
            frmItemCode frm = new frmItemCode();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmChartOfAccounts frm = new frmChartOfAccounts();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = CVars.getAppName + " / " + CVars.getMobileNo + " / " + CVars.getEmailID;
        }
    }
}
