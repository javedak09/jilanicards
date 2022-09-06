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
                MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show(ex.Message, "Exception Raised", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            else
            {
                if (AddItemCoding() == 1)
                    AddItemCoding_Sqlite();


                if (FillGrid() == 1)
                    FillGrid_Sqlite();

            }
        }


        private int AddItemCoding()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("insert into itemcoding (itemcode, itemdesc, itemcategory, itemunit, itemopenqty) values('" + txtItemCode.Text + "', '" + txtdesc.Text + "', '" + ddlCategory.SelectedValue + "', '" + txtunit.Text + "', '" + txtopenqty.Text + "')", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Category created", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void AddItemCoding_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("insert into itemcoding (itemcode, itemdesc, itemcategory, itemunit, itemopenqty) values('" + txtItemCode.Text + "', '" + txtdesc.Text + "', '" + ddlCategory.SelectedValue + "', '" + txtunit.Text + "', '" + txtopenqty.Text + "')", cn.cn1);
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



        private int FillGrid()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from itemcoding", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dgItemCoding.DataSource = ds.Tables[0];
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



        private void FillGrid_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from itemcoding", cn.cn1);
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
                ddlCategory.Text = dgItemCoding.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtunit.Text = dgItemCoding.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtopenqty.Text = dgItemCoding.Rows[e.RowIndex].Cells[5].Value.ToString();

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
                if (UpdateItemCode() == 1)
                    UpdateItemCode_Sqlite();

                if (FillGrid() == 1)
                    FillGrid_Sqlite();
            }           

        }



        private int UpdateItemCode()
        {
            int isconnected = 0;

            CConnection cn = new CConnection();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("update itemcoding set itemdesc ='" + txtdesc.Text + "', itemcategory = '" + ddlCategory.SelectedValue + "', itemunit = '" + txtunit.Text + "', itemopenqty'" + txtopenqty.Text + "' where itemcode = '" + txtItemCode.Text + "'", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Item coding updated", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        private void UpdateItemCode_Sqlite()
        {
            CConnection cn = new CConnection();

            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("update itemcoding set itemdesc ='" + txtdesc.Text + "', itemcategory = '" + ddlCategory.SelectedValue + "', itemunit = '" + txtunit.Text + "', itemopenqty'" + txtopenqty.Text + "' where itemcode = '" + txtItemCode.Text + "'", cn.cn1);
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
            }
        }


        private void DeleteItem()
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

    }
}
