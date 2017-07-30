using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Vision.Motion;

namespace ProcessVideo
{
    public partial class Form1 : Form
    {
        public static VideoCaptureDevice cam;//cam ise bizim kullanacağımız aygıt.
        Thread procImg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void toolOpenDevice_Click(object sender, EventArgs e)
        {
            Form selectDevice = new SelectDevice();
            selectDevice.ShowDialog();
            if (cam != null)
            {
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                cam.Start();
                //cam.DesiredFrameSize = new Size(320, 240);
                //cam.DesiredFrameRate = 24;
            }
        }

        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
                try
                {
                    Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
                    //picVideo.Image = bit;
                    procImg = new Thread(new ParameterizedThreadStart(processImage));
                    procImg.Start(bit);
                }
                catch { }
        }

        private void processImage(object obj)
        {
            try
            {
                Bitmap bmp = (Bitmap)obj;
                Grayscale filterG = new Grayscale(0.2125, 0.7154, 0.0721);
                Bitmap grayImg = filterG.Apply(bmp);
                Threshold filterT = new Threshold(50);
                grayImg = filterT.Apply(grayImg);
                picVideo.Image = grayImg;
            }
            catch { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cam.Stop();
            procImg.Abort();
        }

        
    }
}
