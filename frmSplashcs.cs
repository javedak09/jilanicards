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
    public partial class frmSplashcs : Form
    {
        public frmSplashcs()
        {
            InitializeComponent();
        }

        private void frmSplashcs_Load(object sender, EventArgs e)
        {
            label2.Text = CVars.getAppName;
            label3.Text = CVars.getMobileNo;
            label4.Text = CVars.getEmailID;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;

                frmLogin frm = new frmLogin();
                frm.Show();

                this.Hide();
            }
            else
            {
                progressBar1.Value += 2;
            }
        }
    }
}
