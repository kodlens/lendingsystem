
namespace LendingSystem
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMembers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUsers,
            this.toolStripButtonMembers,
            this.toolStripButtonLoan,
            this.toolStripButton1,
            this.toolStripButtonLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 86);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUsers
            // 
            this.toolStripButtonUsers.Image = global::LendingSystem.Properties.Resources.Admin_icon64x64;
            this.toolStripButtonUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsers.Name = "toolStripButtonUsers";
            this.toolStripButtonUsers.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonUsers.Text = "Users";
            this.toolStripButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUsers.Click += new System.EventHandler(this.toolStripButtonUsers_Click);
            // 
            // toolStripButtonMembers
            // 
            this.toolStripButtonMembers.Image = global::LendingSystem.Properties.Resources.Groups_Meeting_Dark_icon64x64;
            this.toolStripButtonMembers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonMembers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMembers.Name = "toolStripButtonMembers";
            this.toolStripButtonMembers.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonMembers.Text = "Members";
            this.toolStripButtonMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonMembers.Click += new System.EventHandler(this.toolStripButtonMembers_Click);
            // 
            // toolStripButtonLoan
            // 
            this.toolStripButtonLoan.Image = global::LendingSystem.Properties.Resources.Cash_register_icon64x64;
            this.toolStripButtonLoan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonLoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoan.Name = "toolStripButtonLoan";
            this.toolStripButtonLoan.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonLoan.Text = "Loan";
            this.toolStripButtonLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonLoan.Click += new System.EventHandler(this.toolStripButtonLoan_Click);
            // 
            // toolStripButtonLogout
            // 
            this.toolStripButtonLogout.Image = global::LendingSystem.Properties.Resources.logout_icon64x64;
            this.toolStripButtonLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogout.Name = "toolStripButtonLogout";
            this.toolStripButtonLogout.Size = new System.Drawing.Size(68, 83);
            this.toolStripButtonLogout.Text = "Logout";
            this.toolStripButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonLogout.Click += new System.EventHandler(this.toolStripButtonLogout_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::LendingSystem.Properties.Resources.plateno;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 83);
            this.toolStripButton1.Text = "Pay Loan";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 609);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LENDING SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonMembers;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogout;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoan;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

