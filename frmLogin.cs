using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;

namespace Jilani_Cards
{
    public partial class frmLogin : Form
    {


        private void getCategory()
        {
            try
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                comboSource.Add("Select Category", "0");
                comboSource.Add("Warehouse", "1");
                comboSource.Add("Shop", "2");
                comboSource.Add("Godown", "3");

                txtcategory.DataSource = new BindingSource(comboSource, null);
                txtcategory.DisplayMember = "Key";
                txtcategory.ValueMember = "Value";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserid.Text))
            {
                MessageBox.Show("Please enter user id", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuserid.Focus();
            }
            else if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please enter password", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtcategory.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select category", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcategory.Focus();
            }
            else
            {
                if (Login() == 1)
                {
                    Login_Sqlite();
                }
            }
        }


        private int Login()
        {
            int isconnected = 0;

            try
            {
                CConnection cn = new CConnection();
                SqlDataAdapter da = new SqlDataAdapter("select * from users where userid='" + txtuserid.Text + "' and passwd='" + txtpassword.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                isconnected = 0;
            }

            catch (Exception ex)
            {
                isconnected = 1;
            }

            return isconnected;
        }


        private int Login_Sqlite()
        {
            int isconnected = 0;

            try
            {
                CConnection cn = new CConnection();
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from users where userid='" + txtuserid.Text + "' and passwd='" + txtpassword.Text + "'", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                isconnected = 0;
            }

            catch (Exception ex)
            {
                isconnected = 1;
            }

            return isconnected;
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            getCategory();
        }



        private void setSqliteVersion()
        {
            var new_version = ConfigurationSettings.AppSettings["dbver"];

            string stm = "PRAGMA user_version = " + new_version;

            CConnection cn = new CConnection();

            cn.MConnOpen();

            SQLiteCommand cmd = new SQLiteCommand(stm, cn.cn1);
            SQLiteDataReader dr = cmd.ExecuteReader();

            cn.MConnClose();
        }


        private Int64 getSqliteVersion()
        {
            string stm = "PRAGMA user_version";

            CConnection cn = new CConnection();

            cn.MConnOpen();

            SQLiteCommand cmd = new SQLiteCommand(stm, cn.cn1);

            SQLiteDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Console.WriteLine($"SQLite version: {dr.GetInt64(0)}");

                return dr.GetInt64(0);
            }

            cn.MConnClose();

            return -1;
        }



        private void alterTableQuery(string qry)
        {
            CConnection cn = new CConnection();

            cn.MConnOpen();

            SQLiteCommand cmd = new SQLiteCommand(qry, cn.cn1);
            SQLiteDataReader dr = cmd.ExecuteReader();

            cn.MConnClose();
        }


        private bool checkColumn(string colName)
        {
            bool iserror = false;

            try
            {
                CConnection cn = new CConnection();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select " + colName + " from camp_patient_dtl ", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Columns[colName].ToString() == "")
                {
                    //alterTableQuery_new(colName);
                }

                iserror = true;
            }

            catch (Exception ex)
            {
                alterTableQuery_new(colName);
                iserror = false;
            }

            return iserror;
        }





        private void alterTableQuery_new(string colName)
        {
            CConnection cn = new CConnection();

            cn.MConnOpen();

            SQLiteCommand cmd = new SQLiteCommand("ALTER TABLE camp_patient_dtl add column " + colName + " TEXT ", cn.cn1);
            SQLiteDataReader dr = cmd.ExecuteReader();





            //cmd = new SQLiteCommand("ALTER TABLE camp_patient_dtl add column mh010a TEXT", cn.cn);
            //dr = cmd.ExecuteReader();


            //cmd = new SQLiteCommand("ALTER TABLE camp_patient_dtl add column mh01705 TEXT", cn.cn);
            //dr = cmd.ExecuteReader();


            //cmd = new SQLiteCommand("ALTER TABLE camp_patient_dtl add column mh030 TEXT", cn.cn);
            //dr = cmd.ExecuteReader();


            //cmd = new SQLiteCommand("ALTER TABLE camp_patient_dtl add column mh031 TEXT", cn.cn);
            //dr = cmd.ExecuteReader();


            cn.MConnClose();
        }



        private void dbupgrade()
        {
            var curr_version = getSqliteVersion();

            var new_version = ConfigurationSettings.AppSettings["dbver"];


            if (curr_version != -1 && curr_version > Convert.ToInt64(new_version))
            {
                switch (curr_version)
                {
                    case 1:
                        var qry = "ALTER TABLE camp_patient_dtl add column mh01704 text";
                        alterTableQuery(qry);

                        setSqliteVersion();
                        goto default;

                    default:
                        break;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}