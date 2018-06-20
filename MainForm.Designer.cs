namespace DefinitioEyes
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._detectionButton = new System.Windows.Forms.Button();
            this._activeMode = new System.Windows.Forms.ComboBox();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.OpenFileDialog();
            this._label1 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._label6 = new System.Windows.Forms.Label();
            this._fullPathHaarCascade = new System.Windows.Forms.TextBox();
            this._scaleFactor = new System.Windows.Forms.NumericUpDown();
            this._minNeighbors = new System.Windows.Forms.NumericUpDown();
            this._minSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._scaleFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minNeighbors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._minSize)).BeginInit();
            this.SuspendLayout();
            // 
            // _detectionButton
            // 
            this._detectionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._detectionButton.Location = new System.Drawing.Point(483, 217);
            this._detectionButton.Name = "_detectionButton";
            this._detectionButton.Size = new System.Drawing.Size(105, 35);
            this._detectionButton.TabIndex = 2;
            this._detectionButton.Text = "Запустить";
            this._detectionButton.UseVisualStyleBackColor = true;
            this._detectionButton.Click += new System.EventHandler(this.Detection);
            // 
            // _activeMode
            // 
            this._activeMode.FormattingEnabled = true;
            this._activeMode.Items.AddRange(new object[] {
            "Видео",
            "Фото"});
            this._activeMode.Location = new System.Drawing.Point(389, 12);
            this._activeMode.Name = "_activeMode";
            this._activeMode.Size = new System.Drawing.Size(93, 21);
            this._activeMode.TabIndex = 5;
            // 
            // _pictureBox
            // 
            this._pictureBox.Location = new System.Drawing.Point(12, 12);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(320, 240);
            this._pictureBox.TabIndex = 6;
            this._pictureBox.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.FileName = "LoadImage";
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(338, 15);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(45, 13);
            this._label1.TabIndex = 7;
            this._label1.Text = "Режим:";
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Location = new System.Drawing.Point(338, 46);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(132, 13);
            this._label2.TabIndex = 8;
            this._label2.Text = "Настройки обнаружения";
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Location = new System.Drawing.Point(338, 68);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(205, 13);
            this._label3.TabIndex = 9;
            this._label3.Text = "Полный путь до .xml файла с каскадом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Коэффициент увеличения изображения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Группировка предварительно обнаруженных событий";
            // 
            // _label6
            // 
            this._label6.AutoSize = true;
            this._label6.Location = new System.Drawing.Point(338, 154);
            this._label6.Name = "_label6";
            this._label6.Size = new System.Drawing.Size(198, 13);
            this._label6.TabIndex = 12;
            this._label6.Text = "Максимальный размер изображения";
            // 
            // FullPathHaarCascade
            // 
            this._fullPathHaarCascade.Location = new System.Drawing.Point(549, 65);
            this._fullPathHaarCascade.Name = "FullPathHaarCascade";
            this._fullPathHaarCascade.Size = new System.Drawing.Size(156, 20);
            this._fullPathHaarCascade.TabIndex = 13;
            this._fullPathHaarCascade.Text = "haarcascade_eye.xml";
            // 
            // ScaleFactor
            // 
            this._scaleFactor.DecimalPlaces = 1;
            this._scaleFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._scaleFactor.Location = new System.Drawing.Point(549, 97);
            this._scaleFactor.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._scaleFactor.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this._scaleFactor.Name = "ScaleFactor";
            this._scaleFactor.Size = new System.Drawing.Size(120, 20);
            this._scaleFactor.TabIndex = 14;
            this._scaleFactor.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // _minNeighbors
            // 
            this._minNeighbors.Location = new System.Drawing.Point(625, 125);
            this._minNeighbors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._minNeighbors.Name = "_minNeighbors";
            this._minNeighbors.Size = new System.Drawing.Size(120, 20);
            this._minNeighbors.TabIndex = 15;
            this._minNeighbors.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _minSize
            // 
            this._minSize.Location = new System.Drawing.Point(542, 154);
            this._minSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._minSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._minSize.Name = "_minSize";
            this._minSize.Size = new System.Drawing.Size(120, 20);
            this._minSize.TabIndex = 16;
            this._minSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 261);
            this.Controls.Add(this._minSize);
            this.Controls.Add(this._minNeighbors);
            this.Controls.Add(this._scaleFactor);
            this.Controls.Add(this._fullPathHaarCascade);
            this.Controls.Add(this._label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._label3);
            this.Controls.Add(this._label2);
            this.Controls.Add(this._label1);
            this.Controls.Add(this._pictureBox);
            this.Controls.Add(this._activeMode);
            this.Controls.Add(this._detectionButton);
            this.Name = "MainForm";
            this.Text = "Eye detection";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._scaleFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minNeighbors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._minSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _detectionButton;
        private System.Windows.Forms.ComboBox _activeMode;
        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.OpenFileDialog LoadImage;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _label6;
        private System.Windows.Forms.TextBox _fullPathHaarCascade;
        private System.Windows.Forms.NumericUpDown _scaleFactor;
        private System.Windows.Forms.NumericUpDown _minNeighbors;
        private System.Windows.Forms.NumericUpDown _minSize;
    }
}

