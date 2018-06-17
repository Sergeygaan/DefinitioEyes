using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefinitioEyes
{
    /// <summary>
    /// Класс, для работы с фото
    /// </summary>
    class Photo : IMode
    {
        /// <summary>
        /// Переменная, хранящаяя в себе объект в который будет выводиться изображение
        /// </summary>
        private PictureBox _pictureBox;

        /// <summary>
        /// Переменная, хранящаяя в класс, который используется для обнаружения глаз человека
        /// </summary>
        private ObjectDetection _eyeDetection;

        /// <summary>
        /// Переменная, хранящаяя в класс для загрузки и сохранения фото
        /// </summary>
        private ActionsImage _workImage;

        /// <summary>
        /// Метод, инициализации переменных
        /// </summary>
        /// <param name="pictureBox"> Переменная, хранящаяя в себе объект в который будет выводиться изображение.</param>
        public Photo(PictureBox pictureBox)
        {
            _workImage = new ActionsImage();

            _pictureBox = pictureBox;
        }

        /// <summary>
        /// Метод, по обнаружению глаз человека на фото
        /// </summary>
        /// <param name="eyeDetection"> Класс, обнаружения объектов.</param>
        public void Start(ObjectDetection eyeDetection)
        {
            if (eyeDetection == null)
            {
                return;
            }

            _eyeDetection = eyeDetection;

            try
            {
                _pictureBox.Image = _workImage.LoadImage();

                _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                var IMG = new Image<Bgr, byte>((Bitmap)_pictureBox.Image);

                //Вывод результата
                _pictureBox.Image = _eyeDetection.Detection(IMG).Bitmap;

                IMG.Dispose();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /// <summary>
        /// Метод, необходимый для завершения обработки. Если это необходимо
        /// </summary>
        public void Stop()
        {
            //throw new NotImplementedException();
        }
    }
}
