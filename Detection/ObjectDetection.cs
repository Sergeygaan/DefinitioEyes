using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ObjectDetection(string FullPathHaarCascade, double ScaleFactor, int MinNeighbors, int MinSize)
        {
            //Загрузка HaarCascade для обнаружения лиц
            _haarCascade = new HaarCascade(FullPathHaarCascade);

            _scaleFactor = ScaleFactor;
            _minNeighbors = MinNeighbors;
            _minSize = MinSize;
        }

        /// <summary>
        /// Метод, обнаружения объекта с учетом загруженных переменных
        /// </summary>
        public Image<Bgr, Byte> EyeDetection(Image<Bgr, Byte> _currentImage)
        {
            //Преобразование в серые цвета
            Image<Gray, byte> _gray = _currentImage.Convert<Gray, Byte>();

            //Распознание лиц
            MCvAvgComp[][] facesDetected = _gray.DetectHaarCascade(
                _haarCascade,
                _scaleFactor, //Коэффициент увеличения изображения 1,2
                _minNeighbors, //Группировка предварительно обнаруженных событий. Чем их меньше, тем больше ложных тревог 5
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, //Минимальный размер
                new Size(_minSize, _minSize)); //Максимальный размер 20

            //Действие для каждого обнаруженного элемента
            foreach (MCvAvgComp CurrentFace in facesDetected[0])
            {
                //Выделение найденного лица
                _currentImage.Draw(CurrentFace.rect, new Bgr(Color.Red), 1);
            }

            return _currentImage;
        }
    }
}
