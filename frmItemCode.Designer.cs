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
            ((System.ComponentModel.ISupportInitialize)(this.dgItemCoding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(160, 27);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(158, 23);
            this.txtItemCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(160, 85);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(158, 23);
            this.ddlCategory.TabIndex = 3;
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
            this.txtunit.TabIndex = 5;
            // 
            // dgItemCoding
            // 
            this.dgItemCoding.AllowUserToAddRows = false;
            this.dgItemCoding.AllowUserToDeleteRows = false;
            this.dgItemCoding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemCoding.Location = new System.Drawing.Point(9, 162);
            this.dgItemCoding.Name = "dgItemCoding";
            this.dgItemCoding.ReadOnly = true;
            this.dgItemCoding.RowTemplate.Height = 25;
            this.dgItemCoding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemCoding.Size = new System.Drawing.Size(794, 198);
            this.dgItemCoding.TabIndex = 9;
            this.dgItemCoding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemCoding_CellClick);
            // 
            // txtopenqty
            // 
            this.txtopenqty.Location = new System.Drawing.Point(569, 53);
            this.txtopenqty.Name = "txtopenqty";
            this.txtopenqty.Size = new System.Drawing.Size(158, 23);
            this.txtopenqty.TabIndex = 11;
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
            this.cmdAdd.Location = new System.Drawing.Point(48, 123);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 12;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(129, 123);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 13;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(210, 123);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 14;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(160, 56);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(158, 23);
            this.txtdesc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description";
            // 
            // cmdAddCategory
            // 
            this.cmdAddCategory.Location = new System.Drawing.Point(325, 85);
            this.cmdAddCategory.Name = "cmdAddCategory";
            this.cmdAddCategory.Size = new System.Drawing.Size(92, 23);
            this.cmdAddCategory.TabIndex = 17;
            this.cmdAddCategory.Text = "Add Category";
            this.cmdAddCategory.UseVisualStyleBackColor = true;
            this.cmdAddCategory.Click += new System.EventHandler(this.cmdAddCategory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmItemCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 374);
            this.ControlBox = false;
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
    }
}