using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;

namespace DefinitioEyes
{
    public partial class FrmPrincipal : Form
    {
        //Объявление всех переменных и хааркаскадов

        private List<IMode> _modesDetection = new List<IMode>();

        private Video _videoDetection;
        private Photo _photoDetection;

        public FrmPrincipal()
        {      
            InitializeComponent();
            ActiveMode.SelectedIndex = 0;

            _modesDetection.Add(new Video(pictureBox1, CreateObjectDetection()));
            _modesDetection.Add(new Photo(pictureBox1, CreateObjectDetection()));
        }


        private void Detection(object sender, EventArgs e)
        {
            foreach(var currentMode in _modesDetection)
            {
                currentMode.Stop();
            }

            _modesDetection[ActiveMode.SelectedIndex].Start();
        }

        private ObjectDetection CreateObjectDetection()
        {
            return new ObjectDetection(FullPathHaarCascade.Text, Convert.ToDouble(ScaleFactor.Value), Convert.ToInt16(MinNeighbors.Value), Convert.ToInt16(MinSize.Value));
        }
    }
}