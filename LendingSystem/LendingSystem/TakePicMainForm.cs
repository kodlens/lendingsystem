using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LendingSystem;
using AForge.Video;

namespace LendingSystem
{
    public partial class TakePicMainForm : Form
    {
        MembersAddEdit _frm;

        //CAMERA VARIABLES================
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] snapshotCapabilities;
        private ArrayList listCamera = new ArrayList();
        public string pathFolder = Application.StartupPath + @"\ImageCapture\";

        private Stopwatch stopWatch = null;
        private static bool needSnapshot = false;
        //CAMERA VARIABLES=======================


        public TakePicMainForm(MembersAddEdit _frm)
        {
            InitializeComponent();
            getListCameraUSB();
            this._frm = _frm;

        }

        private static string _usbcamera;
        public string usbcamera
        {
            get { return _usbcamera; }
            set { _usbcamera = value; }
        }

       
    }
}

    
           


     
  

