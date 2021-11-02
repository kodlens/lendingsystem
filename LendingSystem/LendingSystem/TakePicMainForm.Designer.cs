
namespace LendingSystem
{
    partial class TakePicMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakePicMainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Camera Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Webcam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(410, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Image Capture Result";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.videoSourcePlayer1.Location = new System.Drawing.Point(82, 182);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(315, 242);
            this.videoSourcePlayer1.TabIndex = 31;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(609, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 45);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnCapture.Image")));
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Location = new System.Drawing.Point(493, 430);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(110, 45);
            this.btnCapture.TabIndex = 29;
            this.btnCapture.Text = "Snapshoot";
            this.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapture.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(410, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(328, 119);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(108, 27);
            this.btnStop.TabIndex = 37;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(214, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 27);
            this.btnStart.TabIndex = 36;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1147, 10);
            this.label4.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 47);
            this.label5.TabIndex = 38;
            this.label5.Text = "TAKE PICTURE";
            // 
            // TakePicMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TakePicMainForm";
            this.Text = "TakePicMainForm";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}