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
    class Photo : IMode
    {
        private PictureBox _pictureBox;
        private ObjectDetection _eyeDetection;
        private ActionsImage _workImage;

        public Photo(PictureBox PictureBox, ObjectDetection EyeDetection)
        {
            _workImage = new ActionsImage();

            _pictureBox = PictureBox;
            _eyeDetection = EyeDetection;
        }

        public void Start()
        {
            try
            {
                _pictureBox.Image = _workImage.LoadImage();

                _pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                var IMG = new Image<Bgr, byte>((Bitmap)_pictureBox.Image);

                //Вывод результата
                _pictureBox.Image = _eyeDetection.EyeDetection(IMG).Bitmap;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Stop()
        {
            //throw new NotImplementedException();
        }
    }
}
