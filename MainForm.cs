using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DefinitioEyes
{
    /// <summary>
    /// Класс, являющийся гланым в программе.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная, хранящая в себе классы команд.
        /// </summary>
        private List<IMode> _modesDetection = new List<IMode>();

        /// <summary>
        /// Переменная, хранящаяя в себе класс для работы с видео потоком
        /// </summary>
        private Video _videoDetection;

        /// <summary>
        /// Переменная, хранящаяя в себе класс для работы с фото
        /// </summary>
        private Photo _photoDetection;

        /// <summary>
        /// Метод, инициализации всех объектов
        /// </summary>
        public MainForm()
        {      
            InitializeComponent();

            _activeMode.DropDownStyle = ComboBoxStyle.DropDownList;

            _activeMode.SelectedIndex = 0;

            _modesDetection.Add(new Video(_pictureBox));
            _modesDetection.Add(new Photo(_pictureBox));
        }

        /// <summary>
        /// Метод, включающий обнаружение объекта с учетом выбранного режима
        /// </summary>
        /// <param name="sender"> Объект, который вызвал событие.</param>
        /// <param name="events"> Cодержащих данные событий.</param>
        private void Detection(object sender, EventArgs events)
        {
            foreach(var currentMode in _modesDetection)
            {
                currentMode.Stop();
            }

            _modesDetection[_activeMode.SelectedIndex].Start(CreateObjectDetection());
        }

        /// <summary>
        /// Метод, для создания класса, который используется для обнаружения глаз человека
        /// </summary>
        private ObjectDetection CreateObjectDetection()
        {
            return new ObjectDetection(_fullPathHaarCascade.Text, Convert.ToDouble(_scaleFactor.Value), 
                                        Convert.ToInt16(_minNeighbors.Value), Convert.ToInt16(_minSize.Value));
        }
    }
}