using System;
using System.Drawing;
using System.Windows.Forms;

namespace DefinitioEyes
{
    /// <summary>
    /// Класс, для работы с файлами
    /// </summary>
    public class ActionsImage : IActionsImage
    {
        /// <summary>
        /// Метод, для загрузки изображения
        /// </summary>
        public Bitmap LoadImage()
        {
            Bitmap loadImage = null; 

            OpenFileDialog ppenFile = new OpenFileDialog();

            ppenFile.Title = "Open Image";
            ppenFile.Filter = "jpg files (*.bmp)|*.bmp|All files (*.*)|*.*";

            if (ppenFile.ShowDialog() == DialogResult.OK)
            {
                loadImage = new Bitmap(ppenFile.OpenFile());
            }

            ppenFile.Dispose();

            return loadImage;
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
