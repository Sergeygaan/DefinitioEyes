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
    /// Класс, обнаружения объектов
    /// </summary>
    class ObjectDetection : IObjectDetection
    {
        /// <summary>
        /// Переменная, хранящаяя в себе загруженный каскад Хаара
        /// </summary>
        private HaarCascade _haarCascade;

        /// <summary>
        /// Переменная, хранящаяя в себе коэффициент увеличения изображения
        /// </summary>
        private double _scaleFactor;

        /// <summary>
        /// Переменная, хранящаяя в себе группировку предварительно обнаруженных событий
        /// </summary>
        private int _minNeighbors;

        /// <summary>
        /// Переменная, хранящаяя в себе максимальный размер изображения
        /// </summary>
        private int _minSize;

        /// <summary>
        /// Метод, инициализации переменных
        /// </summary>
        public ObjectDetection(string fullPathHaarCascade, double scaleFactor, int minNeighbors, int minSize)
        {
            //Загрузка HaarCascade для обнаружения лиц
            try
            {
                _haarCascade = new HaarCascade(fullPathHaarCascade);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            _scaleFactor = scaleFactor;
            _minNeighbors = minNeighbors;
            _minSize = minSize;
        }

        /// <summary>
        /// Метод, обнаружения объекта с учетом загруженных переменных
        /// </summary>
        public Image<Bgr, Byte> Detection(Image<Bgr, Byte> currentImage)
        {
            if (_haarCascade != null)
            {
                //Преобразование в серые цвета
                Image<Gray, byte> _gray = currentImage.Convert<Gray, Byte>();

                //Распознание лиц
                MCvAvgComp[][] facesDetected = _gray.DetectHaarCascade(
                    _haarCascade,
                    _scaleFactor, //Коэффициент увеличения изображения 
                    _minNeighbors, //Группировка предварительно обнаруженных событий
                    Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, //Минимальный размер
                    new Size(_minSize, _minSize)); //Максимальный размер 

                //Действие для каждого обнаруженного элемента
                foreach (MCvAvgComp CurrentFace in facesDetected[0])
                {
                    //Выделение найденного лица
                    currentImage.Draw(CurrentFace.rect, new Bgr(Color.Red), 1);
                }
            }

            return currentImage;
        }
    }
}
