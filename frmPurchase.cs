using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jilani_Cards
{
    public partial class frmPurchase : Form
    {
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            if (getLocation() == 1)
                getLocation_Sqlite();
        }



        private int getLocation()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from location", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ddlLocationID.DataSource = ds.Tables[0];
                ddlLocationID.DisplayMember = "location";
                ddlLocationID.ValueMember = "id";
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                isconnected = 1;
            }

            finally
            {
                cn = null;
            }

            return isconnected;
        }



        private void getLocation_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from location", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ddlLocationID.DataSource = ds.Tables[0];
                ddlLocationID.DisplayMember = "location";
                ddlLocationID.ValueMember = "id";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            finally
            {
                cn = null;
            }

        }



        private void frmPurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
