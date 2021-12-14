
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
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnApplyLoan = new System.Windows.Forms.Button();
            this.btnUpdateLoan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.SuspendLayout();
            // 
            // flx
            // 
            this.flx.AllowEditing = false;
            this.flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flx.ColumnInfo = resources.GetString("flx.ColumnInfo");
            this.flx.ExtendLastCol = true;
            this.flx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flx.Location = new System.Drawing.Point(14, 106);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 22;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(1075, 438);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 2;
            // 
            // btnApplyLoan
            // 
            this.btnApplyLoan.Location = new System.Drawing.Point(14, 550);
            this.btnApplyLoan.Name = "btnApplyLoan";
            this.btnApplyLoan.Size = new System.Drawing.Size(148, 37);
            this.btnApplyLoan.TabIndex = 3;
            this.btnApplyLoan.Text = "Apply New Loan";
            this.btnApplyLoan.UseVisualStyleBackColor = true;
            this.btnApplyLoan.Click += new System.EventHandler(this.btnApplyLoan_Click);
            // 
            // btnUpdateLoan
            // 
            this.btnUpdateLoan.Location = new System.Drawing.Point(168, 550);
            this.btnUpdateLoan.Name = "btnUpdateLoan";
            this.btnUpdateLoan.Size = new System.Drawing.Size(131, 37);
            this.btnUpdateLoan.TabIndex = 4;
            this.btnUpdateLoan.Text = "Update Loan";
            this.btnUpdateLoan.UseVisualStyleBackColor = true;
            this.btnUpdateLoan.Click += new System.EventHandler(this.btnUpdateLoan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 23);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lastname:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(870, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 37);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // ApplyLoanMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 661);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdateLoan);
            this.Controls.Add(this.btnApplyLoan);
            this.Controls.Add(this.flx);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ApplyLoanMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Applications List";
            this.Load += new System.EventHandler(this.ApplyLoanMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.Button btnApplyLoan;
        private System.Windows.Forms.Button btnUpdateLoan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}