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
        public Photo(PictureBox PictureBox)
        {
            _workImage = new ActionsImage();

            _pictureBox = PictureBox;
        }

        /// <summary>
        /// Метод, по обнаружению глаз человека на фото
        /// </summary>
        public void Start(ObjectDetection EyeDetection)
        {
            if (EyeDetection == null)
            {
                return;
            }

            _eyeDetection = EyeDetection;

            try
            {
                _pictureBox.Image = _workImage.LoadImage();

                _pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                var IMG = new Image<Bgr, byte>((Bitmap)_pictureBox.Image);

                //Вывод результата
                _pictureBox.Image = _eyeDetection.Detection(IMG).Bitmap;
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
