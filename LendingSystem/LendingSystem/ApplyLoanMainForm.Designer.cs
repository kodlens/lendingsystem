
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
            this.flx.Location = new System.Drawing.Point(12, 92);
            this.flx.Name = "flx";
            this.flx.Rows.DefaultSize = 22;
            this.flx.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.flx.Size = new System.Drawing.Size(920, 390);
            this.flx.StyleInfo = resources.GetString("flx.StyleInfo");
            this.flx.TabIndex = 2;
            // 
            // ApplyLoanMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 591);
            this.Controls.Add(this.flx);
            this.Name = "ApplyLoanMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Applications List";
            this.Load += new System.EventHandler(this.ApplyLoanMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flx;
    }
}