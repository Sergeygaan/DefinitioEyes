using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace DefinitioEyes
{
    /// <summary>
    /// Интерфейс, для работы с методами обнаружения объектов
    /// </summary>
    interface IObjectDetection
    {
        /// <summary>
        /// Метод, обнаружения глаз человека
        /// </summary>
        /// <param name="currentImage"> Переменная, хранящая текущее изображение.</param>
        Image<Bgr, Byte> Detection(Image<Bgr, Byte> currentImage);
    }
}
