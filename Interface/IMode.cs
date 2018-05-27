using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitioEyes
{
    /// <summary>
    /// Интерфейс, для работы с режимами обнаружения
    /// </summary>
    interface IMode
    {
        /// <summary>
        /// Метод, по обнаружению глаз человека на фото
        /// </summary>
        void Start();

        /// <summary>
        /// Метод, необходимый для завершения обработки. Если это необходимо
        /// </summary>
        void Stop();
    }
}
