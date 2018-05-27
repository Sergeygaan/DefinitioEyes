using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitioEyes
{
    interface IObjectDetection
    {
        Image<Bgr, Byte> EyeDetection(Image<Bgr, Byte> _currentImage);
    }
}
