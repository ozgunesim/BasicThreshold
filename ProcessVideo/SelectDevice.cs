using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace ProcessVideo
{
    public partial class SelectDevice : Form
    {
        private FilterInfoCollection webcam;//webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi.
        //private VideoCaptureDevice cam;//cam ise bizim kullanacağımız aygıt.

        public SelectDevice()
        {
            InitializeComponent();
        }

        private void SelectDevice_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videocapturedevice in webcam)
            {
                camlist.Items.Add(videocapturedevice.Name);//kameraları combobox a dolduruyoruz.
            }
            camlist.SelectedItem = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.cam = new VideoCaptureDevice(webcam[camlist.SelectedIndex].MonikerString);
            this.Close();
        }
    }
}
