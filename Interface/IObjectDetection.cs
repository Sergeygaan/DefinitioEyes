using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Image<Bgr, Byte> Detection(Image<Bgr, Byte> _currentImage);
    }
}
