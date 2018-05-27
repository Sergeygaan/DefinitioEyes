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
    /// <summary>
    /// Класс, являющийся гланым в программе.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Переменная, хранящая в себе классы команд.
        /// </summary>
        private List<IMode> _modesDetection = new List<IMode>();

        /// <summary>
        /// Переменная, хранящаяя в себе класс для работы с видео потоком
        /// </summary>
        private Video _videoDetection;

        /// <summary>
        /// Переменная, хранящаяя в себе класс для работы с фото
        /// </summary>
        private Photo _photoDetection;

        /// <summary>
        /// Метод, инициализации всех объектов
        /// </summary>
        public FrmPrincipal()
        {      
            InitializeComponent();
            ActiveMode.SelectedIndex = 0;

            _modesDetection.Add(new Video(pictureBox1, CreateObjectDetection()));
            _modesDetection.Add(new Photo(pictureBox1, CreateObjectDetection()));
        }

        /// <summary>
        /// Метод, включающий обнаружение объекта с учетом выбранного режима
        /// </summary>
        private void Detection(object sender, EventArgs e)
        {
            foreach(var currentMode in _modesDetection)
            {
                currentMode.Stop();
            }

            _modesDetection[ActiveMode.SelectedIndex].Start();
        }

        /// <summary>
        /// Метод, для создания класса, который используется для обнаружения глаз человека
        /// </summary>
        private ObjectDetection CreateObjectDetection()
        {
            return new ObjectDetection(FullPathHaarCascade.Text, Convert.ToDouble(ScaleFactor.Value), Convert.ToInt16(MinNeighbors.Value), Convert.ToInt16(MinSize.Value));
        }
    }
}