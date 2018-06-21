using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DefinitioEyes
{
    /// <summary>
    /// Класс, обнаружения объектов
    /// </summary>
    public class ObjectDetection : IObjectDetection
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
        /// <param name="eyeDetection"> Переменная, хранящая полный путь до загружаемого каскада Хаара.</param>
        /// <param name="scaleFactor"> Переменная, хранящая коэффициент увеличения изображения.</param>
        /// <param name="minNeighbors"> Переменная, хранящая группировку предварительно обнаруженных событий.</param>
        /// <param name="minSize"> Переменная, хранящая минимальный размер изображения.</param>
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
        /// <param name="currentImage"> Переменная, хранящая текущее изображение.</param>
        public Image<Bgr, Byte> Detection(Image<Bgr, Byte> currentImage)
        {
            if (_haarCascade != null)
            {
                //Преобразование в серые цвета
                Image<Gray, byte> grayCurrentImage = currentImage.Convert<Gray, Byte>();

                //Распознание лиц
                MCvAvgComp[][] facesDetected = grayCurrentImage.DetectHaarCascade(
                    _haarCascade,
                    _scaleFactor, 
                    _minNeighbors, 
                    Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, 
                    new Size(_minSize, _minSize)); 

                //Действие для каждого обнаруженного элемента
                foreach (MCvAvgComp currentEye in facesDetected[0])
                {
                    //Выделение найденного лица
                    currentImage.Draw(currentEye.rect, new Bgr(Color.Red), 1);
                }
            }

            return currentImage;
        }
    }
}
