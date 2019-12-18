namespace GetBmp
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.lblDeviceLists = new System.Windows.Forms.Label();
            this.cmbDeviceLists = new System.Windows.Forms.ComboBox();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.btnTakePic = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbImage = new AForge.Controls.PictureBox();
            this.btnSavePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(554, 275);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // lblDeviceLists
            // 
            this.lblDeviceLists.AutoSize = true;
            this.lblDeviceLists.Location = new System.Drawing.Point(8, 300);
            this.lblDeviceLists.Name = "lblDeviceLists";
            this.lblDeviceLists.Size = new System.Drawing.Size(53, 12);
            this.lblDeviceLists.TabIndex = 1;
            this.lblDeviceLists.Text = "设备列表";
            // 
            // cmbDeviceLists
            // 
            this.cmbDeviceLists.FormattingEnabled = true;
            this.cmbDeviceLists.Location = new System.Drawing.Point(73, 295);
            this.cmbDeviceLists.Name = "cmbDeviceLists";
            this.cmbDeviceLists.Size = new System.Drawing.Size(140, 20);
            this.cmbDeviceLists.TabIndex = 2;
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(235, 293);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(66, 23);
            this.btnOpenCamera.TabIndex = 3;
            this.btnOpenCamera.Text = "打开相机";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
            // 
            // btnTakePic
            // 
            this.btnTakePic.Enabled = false;
            this.btnTakePic.Location = new System.Drawing.Point(307, 293);
            this.btnTakePic.Name = "btnTakePic";
            this.btnTakePic.Size = new System.Drawing.Size(64, 23);
            this.btnTakePic.TabIndex = 4;
            this.btnTakePic.Text = "拍照";
            this.btnTakePic.UseVisualStyleBackColor = true;
            this.btnTakePic.Click += new System.EventHandler(this.btnTakePic_Click);
            // 
            // btnExit
            // 
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(456, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "关闭相机";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = null;
            this.pbImage.Location = new System.Drawing.Point(442, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 84);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // btnSavePic
            // 
            this.btnSavePic.Enabled = false;
            this.btnSavePic.Location = new System.Drawing.Point(377, 293);
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(73, 23);
            this.btnSavePic.TabIndex = 7;
            this.btnSavePic.Text = "保存图片";
            this.btnSavePic.UseVisualStyleBackColor = true;
            this.btnSavePic.Click += new System.EventHandler(this.btnSavePic_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 336);
            this.Controls.Add(this.btnSavePic);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTakePic);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.cmbDeviceLists);
            this.Controls.Add(this.lblDeviceLists);
            this.Controls.Add(this.videoSourcePlayer);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsCapture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Label lblDeviceLists;
        private System.Windows.Forms.ComboBox cmbDeviceLists;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Button btnTakePic;
        private System.Windows.Forms.Button btnExit;
        private AForge.Controls.PictureBox pbImage;
        private System.Windows.Forms.Button btnSavePic;
    }
}

