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
                SqlDataAdapter da = new SqlDataAdapter("select * from loc_purchase", cn.cn);
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
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from loc_purchase", cn.cn1);
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

        private void dg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dg.Rows.Count > 1)
            {
                if (getData_ItemCoding(dg.Rows[e.RowIndex].Cells[0].Value.ToString()) == 1)
                    getData_ItemCoding_Sqlite(dg.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }


        private int getData_ItemCoding(string itemcode)
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [itemcode],[itemdesc],[itemopenqty], case when [cp] = 1 then 'CP' end 'CP', case when [sp] = 1 then 'SP' end 'SP', [cpvalue],[spvalue] FROM [itemcoding] where itemcode = '" + itemcode + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dgItemCoding.DataSource = ds.Tables[0];
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



        private void getData_ItemCoding_Sqlite(string itemcode)
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT [itemcode],[itemdesc],[itemopenqty], case when [cp] = 1 then 'CP' end 'CP', case when [sp] = 1 then 'SP' end 'SP', [cpvalue],[spvalue] FROM [itemcoding] where itemcode = '" + itemcode + "'", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dgItemCoding.DataSource = ds.Tables[0];
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



        private int getData_ItemCoding1(string itemcode)
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [itemcode] code, [itemdesc] description, [itemopenqty] qty FROM [itemcoding] where itemcode = '" + itemcode + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dg.DataSource = ds.Tables[0];
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



        private void getData_ItemCoding_Sqlite1(string itemcode)
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT id,itemcode,itemdesc,itemcategory,itemunit,itemopenqty,itemcolor, case when cp = 1 then 'CP' end 'CP', case when sp = 1 then 'SP' end 'SP', cpvalue,spvalue FROM itemcoding where itemcode = '" + itemcode + "'", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dg.DataSource = ds.Tables[0];
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




        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgItemCoding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgItemCoding.Rows.Count > 0)
            {
                dg.Rows.Clear();
                DataGridViewExtensions.CloneRowWithValues(dgItemCoding.Rows[e.RowIndex], dg);
            }
        }




        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddPurchase();
            AddPurchase_Sqlite();

            ClearFields();
        }


        private int AddPurchase()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                String str = txtDate.Value.ToShortDateString();

                string[] arr = str.Split('/');

                string mydt = arr[2] + "-" + arr[0] + "-" + arr[1];


                SqlDataAdapter da = new SqlDataAdapter("insert into purchase(acbalance, partycode, partyname, locid, voucherno, dt, othcharges, othchargesper, purdiscount, purdiscountper, total) values('" + lblAccBalance.Text + "', '" + txtItemCode.Text + "', '" + lblName.Text + "', '" + ddlLocationID.SelectedValue + "', '" + txtVoucherNo.Text + "', '" + mydt + "', '" + txtOtherCharges.Text + "', '" + txtPercentOtherChg.Text + "', '" + txtPurchaseDisct.Text + "', '" + txtPercentPurchaseDisc.Text + "', '" + txtTotal.Text + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                DataGridViewExtensions.CloneRowWithValues1(dgItemCoding.CurrentRow, dg);


                MessageBox.Show("Purchase created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                isconnected = 1;
            }

            finally
            {
                cn = null;
            }

            return isconnected;
        }



        private void AddPurchase_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                String str = txtDate.Value.ToShortDateString();

                string[] arr = str.Split('/');

                string mydt = arr[2] + "-" + arr[0] + "-" + arr[1];


                SQLiteDataAdapter  da = new SQLiteDataAdapter("insert into purchase(acbalance, partycode, partyname, locid, voucherno, dt, othcharges, othchargesper, purdiscount, purdiscountper, total) values('" + lblAccBalance.Text + "', '" + txtItemCode.Text + "', '" + lblName.Text + "', '" + ddlLocationID.SelectedValue + "', '" + txtVoucherNo.Text + "', '" + mydt + "', '" + txtOtherCharges.Text + "', '" + txtPercentOtherChg.Text + "', '" + txtPurchaseDisct.Text + "', '" + txtPercentPurchaseDisc.Text + "', '" + txtTotal.Text + "')", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);


                DataGridViewExtensions.CloneRowWithValues_Sqlite(dgItemCoding.CurrentRow, dg);


                MessageBox.Show("Purchase created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void ClearFields()
        {
            lblAccBalance.Text = "";
            txtItemCode.Text = "";
            lblName.Text = "";
            ddlLocationID.SelectedValue = "0";
            txtVoucherNo.Text = "";
            dg.Rows.Clear();
            dgItemCoding.Rows.Clear();

            txtItemCode.Focus();
            
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchase updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


    internal static class DataGridViewExtensions
    {
        public static void CloneRowWithValues(this DataGridViewRow SingleRow, DataGridView Target)
        {
            DataGridViewRow Results = (DataGridViewRow)SingleRow.Clone();
            for (Int32 Row = 0; Row < 3; Row++)
            {
                Results.Cells[Row].Value = SingleRow.Cells[Row].Value;
            }


            for (Int32 Row = 5; Row < 7; Row++)
            {
                Results.Cells[Row].Value = SingleRow.Cells[Row].Value;
            }


            Target.Rows.Add(Results);
        }



        public static void CloneRowWithValues1(this DataGridViewRow SingleRow, DataGridView Target)
        {
            CConnection cn = new CConnection();

            SqlDataAdapter da = null;
            DataSet ds = null;


            DataGridViewRow Results = (DataGridViewRow)SingleRow.Clone();
            for (Int32 Row = 0; Row < 1; Row++)
            {
                //Results.Cells[Row].Value = SingleRow.Cells[Row].Value;

                da = new SqlDataAdapter("insert into purchase_dtl(itemcode, description, qty, exdt, particulars, rate, amount) values('" + SingleRow.Cells[0].Value + "', '" + SingleRow.Cells[1].Value + "', '" + SingleRow.Cells[2].Value + "', '" + SingleRow.Cells[3].Value + "', '" + SingleRow.Cells[4].Value + "', '" + SingleRow.Cells[5].Value + "', '" + SingleRow.Cells[6].Value + "')", cn.cn);
                ds = new DataSet();
                da.Fill(ds);

            }

            MessageBox.Show("Purchase created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




        public static void CloneRowWithValues_Sqlite(this DataGridViewRow SingleRow, DataGridView Target)
        {
            CConnection cn = new CConnection();

            SQLiteDataAdapter da = null;
            DataSet ds = null;


            DataGridViewRow Results = (DataGridViewRow)SingleRow.Clone();
            for (Int32 Row = 0; Row < 1; Row++)
            {
                //Results.Cells[Row].Value = SingleRow.Cells[Row].Value;

                da = new SQLiteDataAdapter("insert into purchase_dtl(itemcode, description, qty, exdt, particulars, rate, amount) values('" + SingleRow.Cells[0].Value + "', '" + SingleRow.Cells[1].Value + "', '" + SingleRow.Cells[2].Value + "', '" + SingleRow.Cells[3].Value + "', '" + SingleRow.Cells[4].Value + "', '" + SingleRow.Cells[5].Value + "', '" + SingleRow.Cells[6].Value + "')", cn.cn1);
                ds = new DataSet();
                da.Fill(ds);

            }

            MessageBox.Show("Purchase created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
