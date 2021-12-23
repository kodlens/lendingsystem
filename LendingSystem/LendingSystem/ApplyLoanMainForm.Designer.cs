
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLoanMainForm));
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applyNewLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLaonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteLoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApplyLoan = new System.Windows.Forms.Button();
            this.btnUpdateLoan = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flx
            // 
            this.flx.AllowEditing = false;
            this.flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flx.ColumnInfo = resources.GetString("flx.ColumnInfo");
            this.flx.ContextMenuStrip = this.contextMenuStrip1;
            this.flx.ExtendLastCol = true;
            this.flx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flx.Location = new System.Drawing.Point(14, 110);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 22;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(1165, 434);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyNewLoanToolStripMenuItem,
            this.updateLoanToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.openLaonToolStripMenuItem,
            this.closeLoanToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteLoanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 142);
            // 
            // applyNewLoanToolStripMenuItem
            // 
            this.applyNewLoanToolStripMenuItem.Name = "applyNewLoanToolStripMenuItem";
            this.applyNewLoanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.applyNewLoanToolStripMenuItem.Text = "Apply New Loan";
            // 
            // updateLoanToolStripMenuItem
            // 
            this.updateLoanToolStripMenuItem.Name = "updateLoanToolStripMenuItem";
            this.updateLoanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateLoanToolStripMenuItem.Text = "Update Loan";
            this.updateLoanToolStripMenuItem.Click += new System.EventHandler(this.updateLoanToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openLaonToolStripMenuItem
            // 
            this.openLaonToolStripMenuItem.Name = "openLaonToolStripMenuItem";
            this.openLaonToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openLaonToolStripMenuItem.Text = "Open Loan";
            this.openLaonToolStripMenuItem.Click += new System.EventHandler(this.openLaonToolStripMenuItem_Click);
            // 
            // closeLoanToolStripMenuItem
            // 
            this.closeLoanToolStripMenuItem.Name = "closeLoanToolStripMenuItem";
            this.closeLoanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.closeLoanToolStripMenuItem.Text = "Close Loan";
            this.closeLoanToolStripMenuItem.Click += new System.EventHandler(this.closeLoanToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // deleteLoanToolStripMenuItem
            // 
            this.deleteLoanToolStripMenuItem.Name = "deleteLoanToolStripMenuItem";
            this.deleteLoanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteLoanToolStripMenuItem.Text = "Delete Loan";
            this.deleteLoanToolStripMenuItem.Click += new System.EventHandler(this.deleteLoanToolStripMenuItem_Click);
            // 
            // btnApplyLoan
            // 
            this.btnApplyLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyLoan.Location = new System.Drawing.Point(9, 577);
            this.btnApplyLoan.Name = "btnApplyLoan";
            this.btnApplyLoan.Size = new System.Drawing.Size(148, 45);
            this.btnApplyLoan.TabIndex = 3;
            this.btnApplyLoan.Text = "Apply New Loan";
            this.btnApplyLoan.UseVisualStyleBackColor = true;
            this.btnApplyLoan.Click += new System.EventHandler(this.btnApplyLoan_Click);
            // 
            // btnUpdateLoan
            // 
            this.btnUpdateLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLoan.Location = new System.Drawing.Point(163, 577);
            this.btnUpdateLoan.Name = "btnUpdateLoan";
            this.btnUpdateLoan.Size = new System.Drawing.Size(131, 45);
            this.btnUpdateLoan.TabIndex = 4;
            this.btnUpdateLoan.Text = "Update Loan";
            this.btnUpdateLoan.UseVisualStyleBackColor = true;
            this.btnUpdateLoan.Click += new System.EventHandler(this.btnUpdateLoan_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(83, 81);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(215, 23);
            this.txtlname.TabIndex = 5;
            this.txtlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lastname:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1074, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 37);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firstname:";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(394, 81);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(215, 23);
            this.txtfname.TabIndex = 9;
            this.txtfname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfname_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loan ID:";
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(83, 52);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(215, 23);
            this.txtRef.TabIndex = 11;
            this.txtRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRef_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(300, 577);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Loan";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.lblHeader.Size = new System.Drawing.Size(1191, 47);
            this.lblHeader.TabIndex = 20;
            this.lblHeader.Text = "LOAN APPLICATION LIST";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1, 554);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(1191, 11);
            this.label4.TabIndex = 21;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApplyLoanMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 634);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.btnUpdateLoan);
            this.Controls.Add(this.btnApplyLoan);
            this.Controls.Add(this.flx);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyLoanMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Applications List";
            this.Load += new System.EventHandler(this.ApplyLoanMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.Button btnApplyLoan;
        private System.Windows.Forms.Button btnUpdateLoan;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applyNewLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateLoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteLoanToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolStripMenuItem closeLoanToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem openLaonToolStripMenuItem;
    }
}