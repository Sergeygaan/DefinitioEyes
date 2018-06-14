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
    /// Класс, для работы с файлами
    /// </summary>
    class ActionsImage : IActionsImage
    {
        /// <summary>
        /// Метод, для загрузки изображения
        /// </summary>
        public Bitmap LoadImage()
        {
            Bitmap LoadImage = null; 

            OpenFileDialog OpenFile = new OpenFileDialog();

            OpenFile.Title = "Open Image";
            OpenFile.Filter = "jpg files (*.bmp)|*.bmp|All files (*.*)|*.*";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                LoadImage = new Bitmap(OpenFile.OpenFile());
            }

            OpenFile.Dispose();

            return LoadImage;
        }

        /// <summary>
        /// Метод, для сохранения изображения
        /// </summary>
        public void SaveImage()
        {
            throw new NotImplementedException();
        }

    }
}
