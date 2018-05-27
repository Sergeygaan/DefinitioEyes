using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitioEyes
{
    class Video : IMode
    {
        private Capture _capture;
        private PictureBox _pictureBox;
        private ObjectDetection _eyeDetection;

        public Video(PictureBox PictureBox, ObjectDetection EyeDetection)
        {
            _pictureBox = PictureBox;
            _eyeDetection = EyeDetection;
        }

        public void Start()
        {
            try
            {
                //Инициализация камеры
                _capture = new Capture();
                _capture.QueryFrame();

                //Инициализация события  FrameGrabber
                Application.Idle += new EventHandler(FrameHandler);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                Dispose();
            }
        }

        public void Stop()
        {
            Dispose();
        }

        private void Dispose()
        {
            Application.Idle -= new EventHandler(FrameHandler);

            if (_capture != null)
            {
                _capture.Dispose();
            }
        }

        private void FrameHandler(object sender, EventArgs e)
        {
            ////Получение текущего изображение с камеры
            Image<Bgr, Byte> _currentFrame = _capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Вывод результата
            _pictureBox.Image = _eyeDetection.EyeDetection(_currentFrame).Bitmap;
        }
    }
}
