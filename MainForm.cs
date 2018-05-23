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
        //Объявление всех переменных, векторов и хааркаскадов
        private Image<Bgr, Byte> _currentFrame;
        private Capture _capture;
        private HaarCascade _eyes;

        public FrmPrincipal()
        {
            InitializeComponent();

            //Загрузка HaarCascade для обнаружения лиц
            _eyes = new HaarCascade("haarcascade_eye.xml");
        }


        private void Detection(object sender, EventArgs e)
        {
            //Инициализация камеры
            _capture = new Capture();
            _capture.QueryFrame();

            //Инициализация события  FrameGrabber
            Application.Idle += new EventHandler(FrameHandler);
            button1.Enabled = false;
        }

        private void FrameHandler(object sender, EventArgs e)
        {
            //Получение текущего изображение с камеры
            _currentFrame = _capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Преобразование в серые цвета
            Image<Gray, byte> _gray = _currentFrame.Convert<Gray, Byte>();

            //Распознание лиц
            MCvAvgComp[][] facesDetected = _gray.DetectHaarCascade(
                _eyes,
                1.2,
                5,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

            //Действие для каждого обнаруженного элемента
            foreach (MCvAvgComp CurrentFace in facesDetected[0])
            {
                //Выделение найденного лица
                _currentFrame.Draw(CurrentFace.rect, new Bgr(Color.Red), 1);
            }

            //Вывод результата
            imageBoxFrameGrabber.Image = _currentFrame;
        }
    }
}