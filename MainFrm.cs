using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using AForge.Controls;
using AForge.Video.DirectShow;

namespace GetBmp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        public FilterInfoCollection videoDevices;

        /// <summary>
        /// 窗体初始化时，枚举所有视频输入设备，并加载到cmbDeviceLists中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                    throw new ApplicationException();
                foreach (FilterInfo device in videoDevices)
                {
                    cmbDeviceLists.Items.Add(device.Name);
                }
                cmbDeviceLists.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                cmbDeviceLists.Items.Add("No local capture devices");
                videoDevices = null;
            }
        }

        /// <summary>
        /// 打开相机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[cmbDeviceLists.SelectedIndex].MonikerString);
            this.videoSourcePlayer.VideoSource = videoSource;
            this.videoSourcePlayer.Start();
            this.btnOpenCamera.Enabled = false;
            this.btnTakePic.Enabled = true;
            this.btnExit.Enabled = true;
        }

        /// <summary>
        /// 拍照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTakePic_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.videoSourcePlayer.IsRunning)
                {
                    this.pbImage.Visible = true;
                    Bitmap bitMap = this.videoSourcePlayer.GetCurrentVideoFrame();
                    this.pbImage.Image = bitMap;
                    //设置图片相对控件的大小
                    this.pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.btnSavePic.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("摄像头异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 获取文件路径
        /// </summary>
        /// <returns></returns>
        private string GetImagePath()
        {
            string personImgPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)
                         + Path.DirectorySeparatorChar.ToString() + "Imgs";
            if (!Directory.Exists(personImgPath))
            {
                Directory.CreateDirectory(personImgPath);
            }

            return personImgPath;
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();
            this.btnOpenCamera.Enabled = true;
            this.btnTakePic.Enabled = false;
            this.btnExit.Enabled = false;
            this.pbImage.Visible = false;
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePic_Click(object sender, EventArgs e)
        {
            BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                                    videoSourcePlayer.GetCurrentVideoFrame().GetHbitmap(),
                                    IntPtr.Zero,
                                     Int32Rect.Empty,
                                    BitmapSizeOptions.FromEmptyOptions());
            PngBitmapEncoder pE = new PngBitmapEncoder();
            pE.Frames.Add(BitmapFrame.Create(bitmapSource));
            string picName = GetImagePath() + "\\" + "Test" + ".bmp";
            if (File.Exists(picName))
            {
                File.Delete(picName);
            }
            using (Stream stream = File.Create(picName))
            {
                pE.Save(stream);
            }
            MessageBox.Show("保存成功！根路径Imgs文件夹下！");
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();
        }
    }
}
