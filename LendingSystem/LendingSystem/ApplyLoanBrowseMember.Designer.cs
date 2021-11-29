
namespace LendingSystem
{
    partial class ApplyLoanBrowseMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLoanBrowseMember));
            this.flx = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flx)).BeginInit();
            this.SuspendLayout();
            // 
            // flx
            // 
            this.flx.AllowEditing = false;
            this.flx.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.flx.ColumnInfo = resources.GetString("flx.ColumnInfo");
            this.flx.ExtendLastCol = true;
            this.flx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flx.Location = new System.Drawing.Point(12, 50);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 19;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(776, 371);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 19;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(381, 18);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(196, 22);
            this.txtfname.TabIndex = 31;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(79, 18);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(196, 22);
            this.txtlname.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Lastname:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(685, 427);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 32);
            this.btnSelect.TabIndex = 33;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ApplyLoanBrowseMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flx);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplyLoanBrowseMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Lists";
            this.Load += new System.EventHandler(this.ApplyLoanBrowseMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelect;
    }
}