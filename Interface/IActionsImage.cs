﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitioEyes
{
    /// <summary>
    /// Интерфейс, для работы с файлами
    /// </summary>
    interface IActionsImage
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
