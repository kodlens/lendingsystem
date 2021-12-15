
namespace LendingSystem
{
    partial class PayLoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayLoanForm));
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoanTitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblInterestAmount = new System.Windows.Forms.Label();
            this.numDayMonth = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numInterest = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numAmountToLoan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.flxMember = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToLoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flxMember)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(271, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Loan Ref:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(542, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Loan Title:";
            // 
            // txtLoanTitle
            // 
            this.txtLoanTitle.Location = new System.Drawing.Point(613, 46);
            this.txtLoanTitle.Name = "txtLoanTitle";
            this.txtLoanTitle.ReadOnly = true;
            this.txtLoanTitle.Size = new System.Drawing.Size(543, 22);
            this.txtLoanTitle.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flx);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(267, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 339);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computation";
            // 
            // flx
            // 
            this.flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flx.ColumnInfo = resources.GetString("flx.ColumnInfo");
            this.flx.ExtendLastCol = true;
            this.flx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flx.Location = new System.Drawing.Point(6, 22);
            this.flx.Name = "flx";
            this.flx.Rows.Count = 1;
            this.flx.Rows.DefaultSize = 19;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(878, 308);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 22;
            this.flx.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.flx_AfterEdit);
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(336, 46);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(190, 22);
            this.txtReference.TabIndex = 0;
            this.txtReference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReference_KeyDown);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(921, 592);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(240, 43);
            this.btnApply.TabIndex = 30;
            this.btnApply.Text = "SAVE (F5)";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(1168, 43);
            this.lblHeader.TabIndex = 31;
            this.lblHeader.Text = "LOAN PAYMENT";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtfname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtlname);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(267, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrower Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middlename:";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(87, 95);
            this.txtmname.Name = "txtmname";
            this.txtmname.ReadOnly = true;
            this.txtmname.Size = new System.Drawing.Size(204, 23);
            this.txtmname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firstname:";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(87, 66);
            this.txtfname.Name = "txtfname";
            this.txtfname.ReadOnly = true;
            this.txtfname.Size = new System.Drawing.Size(204, 23);
            this.txtfname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lastname:";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(87, 37);
            this.txtlname.Name = "txtlname";
            this.txtlname.ReadOnly = true;
            this.txtlname.Size = new System.Drawing.Size(204, 23);
            this.txtlname.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loan Type";
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.Enabled = false;
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Items.AddRange(new object[] {
            "DAILY",
            "MONTHLY"});
            this.cmbLoanType.Location = new System.Drawing.Point(27, 38);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(163, 23);
            this.cmbLoanType.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblInterestAmount);
            this.groupBox1.Controls.Add(this.numDayMonth);
            this.groupBox1.Controls.Add(this.lblTotalAmount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numInterest);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numAmountToLoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbLoanType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(586, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Information";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 35);
            this.label12.TabIndex = 13;
            this.label12.Text = "Interest Amount:";
            // 
            // lblInterestAmount
            // 
            this.lblInterestAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestAmount.ForeColor = System.Drawing.Color.Blue;
            this.lblInterestAmount.Location = new System.Drawing.Point(81, 122);
            this.lblInterestAmount.Name = "lblInterestAmount";
            this.lblInterestAmount.Size = new System.Drawing.Size(154, 36);
            this.lblInterestAmount.TabIndex = 12;
            this.lblInterestAmount.Text = "0000.00";
            this.lblInterestAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDayMonth
            // 
            this.numDayMonth.Location = new System.Drawing.Point(300, 38);
            this.numDayMonth.Name = "numDayMonth";
            this.numDayMonth.ReadOnly = true;
            this.numDayMonth.Size = new System.Drawing.Size(118, 23);
            this.numDayMonth.TabIndex = 3;
            this.numDayMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(390, 122);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(175, 36);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.Text = "0000.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "No. Days/Months";
            // 
            // numInterest
            // 
            this.numInterest.Location = new System.Drawing.Point(195, 38);
            this.numInterest.Name = "numInterest";
            this.numInterest.ReadOnly = true;
            this.numInterest.Size = new System.Drawing.Size(97, 23);
            this.numInterest.TabIndex = 2;
            this.numInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Interest(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Amount:";
            // 
            // numAmountToLoan
            // 
            this.numAmountToLoan.DecimalPlaces = 2;
            this.numAmountToLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmountToLoan.Location = new System.Drawing.Point(25, 88);
            this.numAmountToLoan.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAmountToLoan.Name = "numAmountToLoan";
            this.numAmountToLoan.ReadOnly = true;
            this.numAmountToLoan.Size = new System.Drawing.Size(265, 29);
            this.numAmountToLoan.TabIndex = 4;
            this.numAmountToLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount to Loan:";
            // 
            // flxMember
            // 
            this.flxMember.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flxMember.ColumnInfo = resources.GetString("flxMember.ColumnInfo");
            this.flxMember.ExtendLastCol = true;
            this.flxMember.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F);
            this.flxMember.Location = new System.Drawing.Point(6, 52);
            this.flxMember.Name = "flxMember";
            this.flxMember.Rows.Count = 1;
            this.flxMember.Rows.DefaultSize = 21;
            this.flxMember.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flxMember.Size = new System.Drawing.Size(237, 528);
            this.flxMember.StyleInfo = resources.GetString("flxMember.StyleInfo");
            this.flxMember.TabIndex = 23;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.flxMember);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 586);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Member";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(274, 593);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 36);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // PayLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 647);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLoanTitle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PayLoanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayLoanForm";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToLoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flxMember)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoanTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInterestAmount;
        private System.Windows.Forms.NumericUpDown numDayMonth;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numInterest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAmountToLoan;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1FlexGrid.C1FlexGrid flxMember;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
    }
}