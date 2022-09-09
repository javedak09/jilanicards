using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.VisualBasic;

namespace Jilani_Cards
{
    public partial class frmItemCode : Form
    {
        public frmItemCode()
        {
            InitializeComponent();
        }

        private void cmdAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlCategory.Text))
                MessageBox.Show("Please enter category", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (AddCategory() == 1)
                    AddCategory_Sqlite();


                ddlCategory.Text = "";

                if (getCategory() == 1)
                    getCategory_Sqlite();
            }
        }


        private void getColor()
        {
            try
            {
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                comboSource.Add("Select Color", "0");
                comboSource.Add("Red", "1");
                comboSource.Add("Blue", "2");
                comboSource.Add("Green", "3");

                ddlColor.DataSource = new BindingSource(comboSource, null);
                ddlColor.DisplayMember = "Key";
                ddlColor.ValueMember = "Value";

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private int AddCategory()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("insert into itemcoding_category (category) values('" + ddlCategory.Text + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Category created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void AddCategory_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("insert into itemcoding_category (category) values('" + ddlCategory.Text + "')", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Category created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        private int getCategory()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from itemcoding_category", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ddlCategory.DataSource = ds.Tables[0];
                ddlCategory.DisplayMember = "category";
                ddlCategory.ValueMember = "id";
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





        private int getCategory_Sqlite()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from itemcoding_category", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ddlCategory.DataSource = ds.Tables[0];
                ddlCategory.DisplayMember = "category";
                ddlCategory.ValueMember = "id";
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

        private void frmItemCode_Load(object sender, EventArgs e)
        {
            if (getCategory() == 1)
                getCategory_Sqlite();


            if (FillGrid() == 1)
                FillGrid_Sqlite();

            getColor();

            txtItemCode.ReadOnly = false;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("Please enter item code", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtdesc.Text))
            {
                MessageBox.Show("Please enter item description", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(ddlCategory.Text))
            {
                MessageBox.Show("Please select item category", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtunit.Text))
            {
                MessageBox.Show("Please enter item unit", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtopenqty.Text))
            {
                MessageBox.Show("Please enter item opening quantity", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(ddlColor.Text))
            {
                MessageBox.Show("Please enter item color ", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddItemCoding();
                AddItemCoding_Sqlite();



                if (FillGrid() == 1)
                    FillGrid_Sqlite();


                ClearFields();

            }
        }


        private int AddItemCoding()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                string val_rdo_cp = "";
                string val_rdo_sp = "";


                if (chkCP.Checked)
                {
                    val_rdo_cp = "1";
                }

                if (chkSP.Checked)
                {
                    val_rdo_sp = "1";
                }




                SqlDataAdapter da = new SqlDataAdapter("insert into itemcoding (itemcode, itemdesc, itemcategory, itemunit, itemopenqty, itemcolor, cp, sp, cpvalue, spvalue) values('" + txtItemCode.Text + "', '" + txtdesc.Text + "', '" + ddlCategory.SelectedValue + "', '" + txtunit.Text + "', '" + txtopenqty.Text + "', '" + ddlColor.Text + "', '" + val_rdo_cp + "', '" + val_rdo_sp + "', '" + txtCostPrice.Text + "', '" + txtSalePrice.Text + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Category created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                if (ex.Message == "Violation of UNIQUE KEY constraint 'IX_itemcoding'. Cannot insert duplicate key in object 'dbo.itemcoding'. The duplicate key value is (1).\r\nThe statement has been terminated.")
                {
                    MessageBox.Show("Item Code already exist", "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                isconnected = 1;
            }

            finally
            {
                cn = null;
            }

            return isconnected;
        }



        private void AddItemCoding_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {

                string val_rdo_cp = "";
                string val_rdo_sp = "";


                if (chkCP.Checked)
                {
                    val_rdo_cp = "1";
                }

                if (chkSP.Checked)
                {
                    val_rdo_sp = "1";
                }


                SQLiteDataAdapter da = new SQLiteDataAdapter("insert into itemcoding (itemcode, itemdesc, itemcategory, itemunit, itemopenqty, itemcolor, cp, sp, cpvalue, spvalue) values('" + txtItemCode.Text + "', '" + txtdesc.Text + "', '" + ddlCategory.SelectedValue + "', '" + txtunit.Text + "', '" + txtopenqty.Text + "', '" + ddlColor.Text + "', '" + val_rdo_cp + "', '" + val_rdo_sp + "', '" + txtCostPrice.Text + "', '" + txtSalePrice.Text + "')", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Category created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtItemCode.Text = "";
            txtdesc.Text = "";
            ddlCategory.SelectedValue = 0;
            txtunit.Text = "";
            txtopenqty.Text = "";
            ddlColor.SelectedValue = 0;
            chkCP.Checked = false;
            chkSP.Checked = false;
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";

            txtItemCode.Focus();
        }


        private int FillGrid()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [id],[itemcode],[itemdesc],[itemcategory],[itemunit],[itemopenqty],[itemcolor], case when [cp] = 1 then 'CP' end, case when [sp] = 1 then 'SP' end, [cpvalue],[spvalue] FROM [itemcoding]", cn.cn);
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



        private void FillGrid_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT id,itemcode,itemdesc,itemcategory,itemunit,itemopenqty,itemcolor, case when cp = 1 then 'CP' end 'CP', case when sp = 1 then 'SP' end 'SP', cpvalue,spvalue FROM itemcoding", cn.cn1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgItemCoding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgItemCoding.Rows.Count > 0)
            {
                txtItemCode.Text = dgItemCoding.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdesc.Text = dgItemCoding.Rows[e.RowIndex].Cells[2].Value.ToString();
                ddlCategory.SelectedValue = dgItemCoding.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtunit.Text = dgItemCoding.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtopenqty.Text = dgItemCoding.Rows[e.RowIndex].Cells[5].Value.ToString();

                ddlColor.Text = dgItemCoding.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (dgItemCoding.Rows[e.RowIndex].Cells[7].Value.ToString() == "CP")
                {
                    chkCP.Checked = true;
                }

                if (dgItemCoding.Rows[e.RowIndex].Cells[8].Value.ToString() == "SP")
                {
                    chkSP.Checked = true;
                }


                txtCostPrice.Text = dgItemCoding.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtSalePrice.Text = dgItemCoding.Rows[e.RowIndex].Cells[10].Value.ToString();

                txtItemCode.ReadOnly = true;
            }
        }

        private void frmItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                SendKeys.Send("{TAB}");

        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("Please enter item code ", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateItemCode();
                UpdateItemCode_Sqlite();


                if (FillGrid() == 1)
                    FillGrid_Sqlite();


                ClearFields();

            }

        }



        private int UpdateItemCode()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {

                string val_rdo_cp = "";
                string val_rdo_sp = "";


                if (chkCP.Checked)
                {
                    val_rdo_cp = "1";
                }

                if (chkSP.Checked)
                {
                    val_rdo_sp = "1";
                }


                SqlDataAdapter da = new SqlDataAdapter("update itemcoding set itemdesc = '" + txtdesc.Text + "', itemcategory = '" + ddlCategory.SelectedValue + "', itemunit = '" + txtunit.Text + "', itemopenqty = '" + txtopenqty.Text + "', itemcolor = '" + ddlColor.Text + "', cp = '" + val_rdo_cp + "', sp = '" + val_rdo_sp + "', cpvalue = '" + txtCostPrice.Text + "', spvalue = '" + txtSalePrice.Text + "' where itemcode = '" + txtItemCode.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Item coding updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        private void UpdateItemCode_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {

                string val_rdo_cp = "";
                string val_rdo_sp = "";


                if (chkCP.Checked)
                {
                    val_rdo_cp = "1";
                }

                if (chkSP.Checked)
                {
                    val_rdo_sp = "1";
                }


                SQLiteDataAdapter da = new SQLiteDataAdapter("update itemcoding set itemdesc = '" + txtdesc.Text + "', itemcategory = '" + ddlCategory.SelectedValue + "', itemunit = '" + txtunit.Text + "', itemopenqty = '" + txtopenqty.Text + "', itemcolor = '" + ddlColor.Text + "', cp = '" + val_rdo_cp + "', sp = '" + val_rdo_sp + "', cpvalue = '" + txtCostPrice.Text + "', spvalue = '" + txtSalePrice.Text + "' where itemcode = '" + txtItemCode.Text + "'", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Item coding updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtItemCode.Text))
            {
                MessageBox.Show("Please enter item code ", "Blank Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DeleteItem();
                DeleteItem_Sqlite();

                if (FillGrid() == 1)
                    FillGrid_Sqlite();

                ClearFields();
            }
        }



        private int DeleteItem()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("delete itemcoding where itemcode = '" + txtItemCode.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Item coding deleted", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            finally
            {
                cn = null;
            }

            return isconnected;
        }



        private void DeleteItem_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("delete itemcoding where itemcode = '" + txtItemCode.Text + "'", cn.cn1);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Item coding deleted", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void rdoCP_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rdoSP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgItemCoding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
