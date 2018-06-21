using System.Drawing;

namespace DefinitioEyes
{
    /// <summary>
    /// Интерфейс, для работы с файлами
    /// </summary>
    public interface IActionsImage
    {
        /// <summary>
        /// Метод, для загрузки изображения
        /// </summary>
        Bitmap LoadImage();

        /// <summary>
        /// Метод, для сохранения изображения
        /// </summary>
        void SaveImage();
    }
}
