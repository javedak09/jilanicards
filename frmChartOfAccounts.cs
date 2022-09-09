using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jilani_Cards
{
    public partial class frmChartOfAccounts : Form
    {
        public frmChartOfAccounts()
        {
            InitializeComponent();
        }

        private void frmChartOfAccounts_Load(object sender, EventArgs e)
        {
            searchingDropDown();

            if (getNature() == 1)
                getNature_Sqlite();


            if (getAccountID() == 1)
                getAccountID_Sqlite();


            if (FillGrid() == 1)
                FillGrid_Sqlite();

        }


        private void ClearFields()
        {
            txtaccountid.Text = "";
            txtacctitle.Text = "";
            txtopenbalance.Text = "";
            rdoCr.Checked = false;
            rdoDr.Checked = false;
            ddlnature.SelectedValue = 0;
            txtstax.Text = "";
            txtntnno.Text = "";
            txtphone.Text = "";
            txtaddr1.Text = "";
            txtaddr2.Text = "";
            txtaddr3.Text = "";
            chkActiveAcc.Checked = false;
            chkLeaveAcc.Checked = false;

            txtaccountid.Focus();
        }



        private int FillGrid()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, accountid, acctitle, openbalance, case when drcr = 1 then 'DR' else 'CR' end, case when nature = 1 then 'Account Payable' else 'Account Receivable' end, stax, ntnno, phone, addr1, addr2, addr3, actype1, actype2 FROM chartaccounts", cn.cn);
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



        private void FillGrid_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT id, accountid, acctitle, openbalance, case when drcr = 1 then 'DR' else 'CR' end, case when nature = 1 then 'Account Payable' else 'Account Receivable' end, stax, ntnno, phone, addr1, addr2, addr3, actype1, actype2 FROM chartaccounts", cn.cn1);
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


        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtaccountid.Text))
            {
                MessageBox.Show("Please enter account id", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtacctitle.Text))
            {
                MessageBox.Show("Please enter account title", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtopenbalance.Text))
            {
                MessageBox.Show("Please enter opening balance ", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!rdoDr.Checked && !rdoCr.Checked)
            {
                MessageBox.Show("Please select debit / credit option", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(ddlnature.Text))
            {
                MessageBox.Show("Please select nature", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtstax.Text))
            {
                MessageBox.Show("Please enter sales tax no", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtntnno.Text))
            {
                MessageBox.Show("Please enter NTN No", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("Please enter phone No", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtaddr1.Text))
            {
                MessageBox.Show("Please enter address ", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!chkActiveAcc.Checked && !chkLeaveAcc.Checked)
            {
                MessageBox.Show("Please select Account Leave or Active Account option ", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddChartAccount();
                AddChartAccount_Sqlite();


                if (FillGrid() == 1)
                    FillGrid_Sqlite();

                ClearFields();

                if (getAccountID() == 1)
                    getAccountID_Sqlite();

            }
        }


        private int AddChartAccount()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                string val_drcr = "";
                string val_actype1 = "";
                string val_actype2 = "";

                if (rdoDr.Checked)
                    val_drcr = "1";
                else if (rdoCr.Checked)
                    val_drcr = "2";

                if (chkLeaveAcc.Checked)
                    val_actype1 = "1";
                else if (chkLeaveAcc.Checked)
                    val_actype2 = "2";


                SqlDataAdapter da = new SqlDataAdapter("insert into chartaccounts (accountid, acctitle, openbalance, drcr, nature, stax, ntnno, phone, addr1, addr2, addr3, actype1, actype2) values ('" + txtaccountid.Text + "', '" + txtacctitle.Text + "', '" + txtopenbalance.Text + "', '" + val_drcr + "', '" + ddlnature.SelectedValue + "', '" + txtstax.Text + "', '" + txtntnno.Text + "', '" + txtphone.Text + "', '" + txtaddr1.Text + "', '" + txtaddr2.Text + "', '" + txtaddr3.Text + "', '" + val_actype1 + "', '" + val_actype2 + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Chart of Account created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                if (ex.Message == "")
                {
                    MessageBox.Show("Chart of account already exist", "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);                    
                }
                else
                {
                    //MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    isconnected = 1;
                }
                    
            }

            finally
            {
                cn = null;
            }

            return isconnected;
        }




        private void AddChartAccount_Sqlite()
        {

            CConnection cn = new CConnection();

            try
            {
                string val_drcr = "";
                string val_actype1 = "";
                string val_actype2 = "";

                if (rdoDr.Checked)
                    val_drcr = "1";
                else if (rdoCr.Checked)
                    val_drcr = "2";

                if (chkLeaveAcc.Checked)
                    val_actype1 = "1";
                else if (chkLeaveAcc.Checked)
                    val_actype2 = "2";


                SqlDataAdapter da = new SqlDataAdapter("insert into chartaccounts (accountid, acctitle, openbalance, drcr, nature, stax, ntnno, phone, addr1, addr2, addr3, actype1, actype2) values ('" + txtaccountid.Text + "', '" + txtacctitle.Text + "', '" + txtopenbalance.Text + "', '" + val_drcr + "', '" + ddlnature.SelectedValue + "', '" + txtstax.Text + "', '" + txtntnno.Text + "', '" + txtphone.Text + "', '" + txtaddr1.Text + "', '" + txtaddr2.Text + "', '" + txtaddr3.Text + "', '" + val_actype1 + "', '" + val_actype2 + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                MessageBox.Show("Chart of Account created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {

            }

            finally
            {
                cn = null;
            }
        }



        private int getAccountID()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select concat('00000', max(convert(numeric, accountid))) accountid from chartaccounts", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["accountid"].ToString() == "00000")
                                txtaccountid.Text = ds.Tables[0].Rows[0]["accountid"].ToString();
                            else
                                txtaccountid.Text = ds.Tables[0].Rows[0]["accountid"].ToString();
                        }
                    }
                }
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



        private int getAccountID_Sqlite()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select concat('00000', max(convert(numeric, accountid))) accountid from chartaccounts", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0]["accountid"].ToString() == "00000")
                                txtaccountid.Text = ds.Tables[0].Rows[0]["accountid"].ToString();
                            else
                                txtaccountid.Text = ds.Tables[0].Rows[0]["accountid"].ToString();
                        }
                    }
                }
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



        private int getNature()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from nature", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ddlnature.DataSource = ds.Tables[0];
                ddlnature.DisplayMember = "nature";
                ddlnature.ValueMember = "id";
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



        private void getNature_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from nature", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ddlnature.DataSource = ds.Tables[0];
                ddlnature.DisplayMember = "nature";
                ddlnature.ValueMember = "id";
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



        private void searchingDropDown()
        {
            try
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                comboSource.Add("Account Name", "1");

                ddlSearch.DataSource = new BindingSource(comboSource, null);
                ddlSearch.DisplayMember = "Key";
                ddlSearch.ValueMember = "Value";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmChartOfAccounts_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void frmChartOfAccounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");
        }


                

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            UpdateChartAccount();
            UpdateChartAccount_Sqlite();
        }


        private int UpdateChartAccount()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {

                string val_drcr = "";
                string val_actype1 = "";
                string val_actype2 = "";

                if (rdoDr.Checked)
                    val_drcr = "1";
                else if (rdoCr.Checked)
                    val_drcr = "2";

                if (chkLeaveAcc.Checked)
                    val_actype1 = "1";
                
                if (chkLeaveAcc.Checked)
                    val_actype2 = "2";


                SqlDataAdapter da = new SqlDataAdapter("update chartaccounts set acctitle = '" + txtacctitle.Text + "', openbalance = '" + txtopenbalance.Text + "', drcr = '" + val_drcr + "', nature = '" + ddlnature.SelectedValue + "', stax = '" + txtstax.Text + "', ntnno = '" + txtntnno.Text + "', phone = '" + txtphone.Text + "', addr1 = '" + txtaddr1.Text + "', addr2 = '" + txtaddr2.Text + "', addr3 = '" + txtaddr3.Text + "', actype1 = '" + val_actype1 + "', actype2 = '" + val_actype2 +  "' where accountid = '" + txtaccountid.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Chart of accounts updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        private void UpdateChartAccount_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {

                string val_drcr = "";
                string val_actype1 = "";
                string val_actype2 = "";

                if (rdoDr.Checked)
                    val_drcr = "1";
                else if (rdoCr.Checked)
                    val_drcr = "2";

                if (chkLeaveAcc.Checked)
                    val_actype1 = "1";

                if (chkLeaveAcc.Checked)
                    val_actype2 = "2";


                SQLiteDataAdapter da = new SQLiteDataAdapter("update chartaccounts set acctitle = '" + txtacctitle.Text + "', openbalance = '" + txtopenbalance.Text + "', drcr = '" + val_drcr + "', nature = '" + ddlnature.SelectedValue + "', stax = '" + txtstax.Text + "', ntnno = '" + txtntnno.Text + "', phone = '" + txtphone.Text + "', addr1 = '" + txtaddr1.Text + "', addr2 = '" + txtaddr2.Text + "', addr3 = '" + txtaddr3.Text + "', actype1 = '" + val_actype1 + "', actype2 = '" + val_actype2 + "' where accountid = '" + txtaccountid.Text + "'", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Chart of accounts updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void cmdDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
