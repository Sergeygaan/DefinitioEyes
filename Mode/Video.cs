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
    /// <summary>
    /// Класс, для работы с видео потоком
    /// </summary>
    class Video : IMode
    {
        /// <summary>
        /// Переменная, хранящаяя подключение к видео камере
        /// </summary>
        private Capture _capture;

        /// <summary>
        /// Переменная, хранящаяя в себе объект в который будет выводиться изображение
        /// </summary>
        private PictureBox _pictureBox;

        /// <summary>
        /// Переменная, хранящаяя класс, который используется для обнаружения глаз человека
        /// </summary>
        private ObjectDetection _eyeDetection;

        /// <summary>
        /// Метод, инициализации переменных
        /// </summary>
        public Video(PictureBox PictureBox, ObjectDetection EyeDetection)
        {
            _pictureBox = PictureBox;
            _eyeDetection = EyeDetection;
        }

        /// <summary>
        /// Метод, по обнаружению глаз человека в видео потоке
        /// </summary>
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

        /// <summary>
        /// Метод, необходимый для завершения обработки. Если это необходимо
        /// </summary>
        public void Stop()
        {
            Dispose();
        }

        /// <summary>
        /// Метод, для очистки всех необходимых переменных
        /// </summary>
        private void Dispose()
        {
            Application.Idle -= new EventHandler(FrameHandler);

            if (_capture != null)
            {
                _capture.Dispose();
            }
        }

        /// <summary>
        /// Метод, для получения изображения с видеокамеры
        /// </summary>
        private void FrameHandler(object sender, EventArgs e)
        {
            ////Получение текущего изображение с камеры
            Image<Bgr, Byte> _currentFrame = _capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Вывод результата
            _pictureBox.Image = _eyeDetection.EyeDetection(_currentFrame).Bitmap;
        }
    }
}
