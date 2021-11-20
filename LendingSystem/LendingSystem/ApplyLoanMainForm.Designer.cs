
namespace LendingSystem
{
    partial class ApplyLoanMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLoanMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.numDayMonth = new System.Windows.Forms.NumericUpDown();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numInterest = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numAmountToLoan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseMember = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToLoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Controls.Add(this.numDayMonth);
            this.groupBox1.Controls.Add(this.lblAmountToPay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numInterest);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numAmountToLoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbLoanType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(381, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Information";
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(298, 85);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(118, 34);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // numDayMonth
            // 
            this.numDayMonth.Location = new System.Drawing.Point(300, 38);
            this.numDayMonth.Name = "numDayMonth";
            this.numDayMonth.Size = new System.Drawing.Size(118, 23);
            this.numDayMonth.TabIndex = 3;
            this.numDayMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPay.ForeColor = System.Drawing.Color.Red;
            this.lblAmountToPay.Location = new System.Drawing.Point(363, 122);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(202, 36);
            this.lblAmountToPay.TabIndex = 11;
            this.lblAmountToPay.Text = "0000.00";
            this.lblAmountToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label6.Location = new System.Drawing.Point(229, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Amount to Pay:";
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
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Items.AddRange(new object[] {
            "DAILY",
            "MONTHLY"});
            this.cmbLoanType.Location = new System.Drawing.Point(27, 38);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(163, 23);
            this.cmbLoanType.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseMember);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 165);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrower Information";
            // 
            // btnBrowseMember
            // 
            this.btnBrowseMember.Location = new System.Drawing.Point(252, 22);
            this.btnBrowseMember.Name = "btnBrowseMember";
            this.btnBrowseMember.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseMember.TabIndex = 7;
            this.btnBrowseMember.Text = "Browse";
            this.btnBrowseMember.UseVisualStyleBackColor = true;
            this.btnBrowseMember.Click += new System.EventHandler(this.btnBrowseMember_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middlename:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Firstname:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lastname:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 23);
            this.textBox1.TabIndex = 0;
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
            this.lblHeader.Size = new System.Drawing.Size(963, 47);
            this.lblHeader.TabIndex = 20;
            this.lblHeader.Text = "APPLY LOAN";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(554, 618);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(397, 45);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "APPLY";
            this.btnApply.UseVisualStyleBackColor = true;
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
            this.flx.Size = new System.Drawing.Size(927, 308);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flx);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(939, 349);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Computation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Loan Title:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(845, 23);
            this.textBox4.TabIndex = 22;
            // 
            // ApplyLoanMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 665);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyLoanMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountToLoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnBrowseMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAmountToLoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numInterest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label9;
        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.NumericUpDown numDayMonth;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
    }
}