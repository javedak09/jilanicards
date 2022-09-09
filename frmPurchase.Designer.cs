namespace Jilani_Cards
{
    partial class frmPurchase
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
            this.lblAccBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlLocationID = new System.Windows.Forms.ComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVoucher1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParticulars = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOtherCharges = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPercentOtherChg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPercentPurchaseDisc = new System.Windows.Forms.TextBox();
            this.txtPurchaseDisct = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dgItemCoding = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemCoding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A/c Balance:";
            // 
            // lblAccBalance
            // 
            this.lblAccBalance.BackColor = System.Drawing.Color.White;
            this.lblAccBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccBalance.Location = new System.Drawing.Point(113, 22);
            this.lblAccBalance.Name = "lblAccBalance";
            this.lblAccBalance.Size = new System.Drawing.Size(158, 23);
            this.lblAccBalance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Party Code";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(113, 52);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(158, 23);
            this.txtItemCode.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(333, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(212, 23);
            this.lblName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(279, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(387, 12);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(158, 23);
            this.txtVoucherNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(295, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Voucher No.";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(576, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(623, 9);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(165, 23);
            this.txtDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(552, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loc ID";
            // 
            // ddlLocationID
            // 
            this.ddlLocationID.FormattingEnabled = true;
            this.ddlLocationID.Location = new System.Drawing.Point(609, 44);
            this.ddlLocationID.Name = "ddlLocationID";
            this.ddlLocationID.Size = new System.Drawing.Size(179, 23);
            this.ddlLocationID.TabIndex = 11;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.description,
            this.qty,
            this.expirydt,
            this.particulars,
            this.rate,
            this.amount});
            this.dg.Location = new System.Drawing.Point(2, 95);
            this.dg.Name = "dg";
            this.dg.RowTemplate.Height = 25;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(796, 279);
            this.dg.TabIndex = 12;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            this.dg.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellValueChanged);
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            // 
            // expirydt
            // 
            this.expirydt.HeaderText = "Expiry Date";
            this.expirydt.Name = "expirydt";
            // 
            // particulars
            // 
            this.particulars.HeaderText = "Particulars";
            this.particulars.Name = "particulars";
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // txtVoucher1
            // 
            this.txtVoucher1.Location = new System.Drawing.Point(99, 472);
            this.txtVoucher1.Name = "txtVoucher1";
            this.txtVoucher1.Size = new System.Drawing.Size(158, 23);
            this.txtVoucher1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Voucher No.";
            // 
            // txtParticulars
            // 
            this.txtParticulars.Location = new System.Drawing.Point(334, 469);
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.Size = new System.Drawing.Size(200, 23);
            this.txtParticulars.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(268, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Particulars";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(606, 465);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(186, 23);
            this.txtRemarks.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(540, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Remarks";
            // 
            // txtOtherCharges
            // 
            this.txtOtherCharges.Location = new System.Drawing.Point(635, 382);
            this.txtOtherCharges.Name = "txtOtherCharges";
            this.txtOtherCharges.Size = new System.Drawing.Size(70, 23);
            this.txtOtherCharges.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(522, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Other Charges";
            // 
            // txtPercentOtherChg
            // 
            this.txtPercentOtherChg.Location = new System.Drawing.Point(725, 382);
            this.txtPercentOtherChg.Name = "txtPercentOtherChg";
            this.txtPercentOtherChg.Size = new System.Drawing.Size(70, 23);
            this.txtPercentOtherChg.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(706, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(706, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "%";
            // 
            // txtPercentPurchaseDisc
            // 
            this.txtPercentPurchaseDisc.Location = new System.Drawing.Point(725, 408);
            this.txtPercentPurchaseDisc.Name = "txtPercentPurchaseDisc";
            this.txtPercentPurchaseDisc.Size = new System.Drawing.Size(70, 23);
            this.txtPercentPurchaseDisc.TabIndex = 25;
            // 
            // txtPurchaseDisct
            // 
            this.txtPurchaseDisct.Location = new System.Drawing.Point(635, 408);
            this.txtPurchaseDisct.Name = "txtPurchaseDisct";
            this.txtPurchaseDisct.Size = new System.Drawing.Size(70, 23);
            this.txtPurchaseDisct.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(522, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Purchase Discount";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(635, 437);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 23);
            this.txtTotal.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(522, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total";
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(246, 391);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 32;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(165, 391);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 31;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(84, 391);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdate.TabIndex = 30;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(3, 391);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(75, 23);
            this.cmdAdd.TabIndex = 29;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dgItemCoding
            // 
            this.dgItemCoding.AllowUserToAddRows = false;
            this.dgItemCoding.AllowUserToDeleteRows = false;
            this.dgItemCoding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemCoding.Location = new System.Drawing.Point(4, 498);
            this.dgItemCoding.Name = "dgItemCoding";
            this.dgItemCoding.ReadOnly = true;
            this.dgItemCoding.RowTemplate.Height = 25;
            this.dgItemCoding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemCoding.Size = new System.Drawing.Size(794, 120);
            this.dgItemCoding.TabIndex = 33;
            this.dgItemCoding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemCoding_CellContentClick);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.ControlBox = false;
            this.Controls.Add(this.dgItemCoding);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPercentPurchaseDisc);
            this.Controls.Add(this.txtPurchaseDisct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPercentOtherChg);
            this.Controls.Add(this.txtOtherCharges);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtParticulars);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVoucher1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.ddlLocationID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccBalance);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPurchase_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemCoding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblAccBalance;
        private Label label2;
        private TextBox txtItemCode;
        private Label lblName;
        private Label label4;
        private TextBox txtVoucherNo;
        private Label label3;
        private Label label5;
        private DateTimePicker txtDate;
        private Label label6;
        private ComboBox ddlLocationID;
        private DataGridView dg;
        private TextBox txtVoucher1;
        private Label label7;
        private TextBox txtParticulars;
        private Label label8;
        private TextBox txtRemarks;
        private Label label9;
        private TextBox txtOtherCharges;
        private Label label10;
        private TextBox txtPercentOtherChg;
        private Label label11;
        private Label label12;
        private TextBox txtPercentPurchaseDisc;
        private TextBox txtPurchaseDisct;
        private Label label13;
        private TextBox txtTotal;
        private Label label14;
        private Button cmdExit;
        private Button cmdDelete;
        private Button cmdUpdate;
        private Button cmdAdd;
        private DataGridView dgItemCoding;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn expirydt;
        private DataGridViewTextBoxColumn particulars;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewTextBoxColumn amount;
    }
}