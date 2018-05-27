namespace DefinitioEyes
{
    partial class FrmPrincipal
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
            this.DetectionButton = new System.Windows.Forms.Button();
            this.ActiveMode = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FullPathHaarCascade = new System.Windows.Forms.TextBox();
            this.ScaleFactor = new System.Windows.Forms.NumericUpDown();
            this.MinNeighbors = new System.Windows.Forms.NumericUpDown();
            this.MinSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNeighbors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSize)).BeginInit();
            this.SuspendLayout();
            // 
            // DetectionButton
            // 
            this.DetectionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DetectionButton.Location = new System.Drawing.Point(483, 217);
            this.DetectionButton.Name = "DetectionButton";
            this.DetectionButton.Size = new System.Drawing.Size(105, 35);
            this.DetectionButton.TabIndex = 2;
            this.DetectionButton.Text = "Запустить";
            this.DetectionButton.UseVisualStyleBackColor = true;
            this.DetectionButton.Click += new System.EventHandler(this.Detection);
            // 
            // ActiveMode
            // 
            this.ActiveMode.FormattingEnabled = true;
            this.ActiveMode.Items.AddRange(new object[] {
            "Видео",
            "Фото"});
            this.ActiveMode.Location = new System.Drawing.Point(389, 12);
            this.ActiveMode.Name = "ActiveMode";
            this.ActiveMode.Size = new System.Drawing.Size(93, 21);
            this.ActiveMode.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.FileName = "LoadImage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Режим:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Настройки обнаружения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Полный путь до .xml файла с каскадом";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Максимальный размер изображения";
            // 
            // FullPathHaarCascade
            // 
            this.FullPathHaarCascade.Location = new System.Drawing.Point(549, 65);
            this.FullPathHaarCascade.Name = "FullPathHaarCascade";
            this.FullPathHaarCascade.Size = new System.Drawing.Size(156, 20);
            this.FullPathHaarCascade.TabIndex = 13;
            this.FullPathHaarCascade.Text = "haarcascade_eye.xml";
            // 
            // ScaleFactor
            // 
            this.ScaleFactor.DecimalPlaces = 1;
            this.ScaleFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScaleFactor.Location = new System.Drawing.Point(549, 97);
            this.ScaleFactor.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleFactor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ScaleFactor.Name = "ScaleFactor";
            this.ScaleFactor.Size = new System.Drawing.Size(120, 20);
            this.ScaleFactor.TabIndex = 14;
            this.ScaleFactor.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // MinNeighbors
            // 
            this.MinNeighbors.Location = new System.Drawing.Point(625, 125);
            this.MinNeighbors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinNeighbors.Name = "MinNeighbors";
            this.MinNeighbors.Size = new System.Drawing.Size(120, 20);
            this.MinNeighbors.TabIndex = 15;
            this.MinNeighbors.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MinSize
            // 
            this.MinSize.Location = new System.Drawing.Point(542, 154);
            this.MinSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinSize.Name = "MinSize";
            this.MinSize.Size = new System.Drawing.Size(120, 20);
            this.MinSize.TabIndex = 16;
            this.MinSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 261);
            this.Controls.Add(this.MinSize);
            this.Controls.Add(this.MinNeighbors);
            this.Controls.Add(this.ScaleFactor);
            this.Controls.Add(this.FullPathHaarCascade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ActiveMode);
            this.Controls.Add(this.DetectionButton);
            this.Name = "FrmPrincipal";
            this.Text = "Eye detection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNeighbors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DetectionButton;
        private System.Windows.Forms.ComboBox ActiveMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog LoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FullPathHaarCascade;
        private System.Windows.Forms.NumericUpDown ScaleFactor;
        private System.Windows.Forms.NumericUpDown MinNeighbors;
        private System.Windows.Forms.NumericUpDown MinSize;
    }
}

