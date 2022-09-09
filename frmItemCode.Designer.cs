namespace Jilani_Cards
{
    partial class frmItemCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.dgItemCoding = new System.Windows.Forms.DataGridView();
            this.txtopenqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAddCategory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ddlColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSP = new System.Windows.Forms.CheckBox();
            this.chkCP = new System.Windows.Forms.CheckBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemCoding)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(128, 22);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(158, 23);
            this.txtItemCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(128, 80);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(158, 23);
            this.ddlCategory.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(340, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit";
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(389, 56);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(48, 23);
            this.txtunit.TabIndex = 2;
            // 
            // dgItemCoding
            // 
            this.dgItemCoding.AllowUserToAddRows = false;
            this.dgItemCoding.AllowUserToDeleteRows = false;
            this.dgItemCoding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemCoding.Location = new System.Drawing.Point(9, 212);
            this.dgItemCoding.Name = "dgItemCoding";
            this.dgItemCoding.ReadOnly = true;
            this.dgItemCoding.RowTemplate.Height = 25;
            this.dgItemCoding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemCoding.Size = new System.Drawing.Size(794, 148);
            this.dgItemCoding.TabIndex = 9;
            this.dgItemCoding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemCoding_CellClick);
            this.dgItemCoding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemCoding_CellContentClick);
            // 
            // txtopenqty
            // 
            this.txtopenqty.Location = new System.Drawing.Point(569, 53);
            this.txtopenqty.Name = "txtopenqty";
            this.txtopenqty.Size = new System.Drawing.Size(234, 23);
            this.txtopenqty.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(453, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opening Quantity";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(16, 118);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 9;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(97, 118);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 10;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(178, 118);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 11;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(128, 51);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(158, 23);
            this.txtdesc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description";
            // 
            // cmdAddCategory
            // 
            this.cmdAddCategory.Location = new System.Drawing.Point(293, 80);
            this.cmdAddCategory.Name = "cmdAddCategory";
            this.cmdAddCategory.Size = new System.Drawing.Size(92, 23);
            this.cmdAddCategory.TabIndex = 12;
            this.cmdAddCategory.Text = "Add Category";
            this.cmdAddCategory.UseVisualStyleBackColor = true;
            this.cmdAddCategory.Click += new System.EventHandler(this.cmdAddCategory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddlColor
            // 
            this.ddlColor.FormattingEnabled = true;
            this.ddlColor.Location = new System.Drawing.Point(569, 83);
            this.ddlColor.Name = "ddlColor";
            this.ddlColor.Size = new System.Drawing.Size(234, 23);
            this.ddlColor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(453, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkSP);
            this.groupBox2.Controls.Add(this.chkCP);
            this.groupBox2.Location = new System.Drawing.Point(569, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 42);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // chkSP
            // 
            this.chkSP.Location = new System.Drawing.Point(115, 17);
            this.chkSP.Name = "chkSP";
            this.chkSP.Size = new System.Drawing.Size(48, 19);
            this.chkSP.TabIndex = 1;
            this.chkSP.Text = "SP";
            this.chkSP.UseVisualStyleBackColor = true;
            // 
            // chkCP
            // 
            this.chkCP.Location = new System.Drawing.Point(56, 15);
            this.chkCP.Name = "chkCP";
            this.chkCP.Size = new System.Drawing.Size(46, 24);
            this.chkCP.TabIndex = 0;
            this.chkCP.Text = "CP";
            this.chkCP.UseVisualStyleBackColor = true;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.BackColor = System.Drawing.Color.White;
            this.txtCostPrice.Location = new System.Drawing.Point(566, 158);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(234, 23);
            this.txtCostPrice.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(450, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cost Price";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BackColor = System.Drawing.Color.White;
            this.txtSalePrice.Location = new System.Drawing.Point(566, 184);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(234, 23);
            this.txtSalePrice.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(450, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Sale Price";
            // 
            // frmItemCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 374);
            this.ControlBox = false;
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ddlColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdAddCategory);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtopenqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgItemCoding);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmItemCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Coding";
            this.Load += new System.EventHandler(this.frmItemCode_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmItemCode_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgItemCoding)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtItemCode;
        private Label label2;
        private ComboBox ddlCategory;
        private Label label3;
        private TextBox txtunit;
        private DataGridView dgItemCoding;
        private TextBox txtopenqty;
        private Label label4;
        private Button cmdAdd;
        private Button cmdUpdate;
        private Button cmdDelete;
        private TextBox txtdesc;
        private Label label5;
        private Button cmdAddCategory;
        private Button button1;
        private ComboBox ddlColor;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtCostPrice;
        private Label label7;
        private TextBox txtSalePrice;
        private Label label8;
        private CheckBox chkSP;
        private CheckBox chkCP;
    }
}