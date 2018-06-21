using Emgu.CV;
using Emgu.CV.Structure;
using System;
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
        /// <param name="pictureBox"> Переменная, хранящаяя в себе объект в который будет выводиться изображение.</param>
        public Video(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
        }

        /// <summary>
        /// Метод, по обнаружению глаз человека в видео потоке
        /// </summary>
        /// <param name="eyeDetection"> Класс, обнаружения объектов.</param>
        public void Start(ObjectDetection eyeDetection)
        {
            if(eyeDetection == null)
            {
                return;
            }

            _eyeDetection = eyeDetection;

            try
            {
                //Инициализация камеры
                _capture = new Capture();
                _capture.QueryFrame();

                //Инициализация события  FrameGrabber
                Application.Idle += FrameHandler;
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
            Application.Idle -= FrameHandler;

            if (_capture != null)
            {
                _capture.Dispose();
            }
        }

        /// <summary>
        /// Метод, для получения изображения с видеокамеры
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void FrameHandler(object sender, EventArgs events)
        {
            if (_capture != null)
            {
                //Получение текущего изображение с камеры
                Image<Bgr, Byte> currentFrame = _capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Вывод результата
                _pictureBox.Image = _eyeDetection.Detection(currentFrame).Bitmap;

                currentFrame.Dispose();
            }
        }
    }
}
