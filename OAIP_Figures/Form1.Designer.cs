namespace OAIP_Figures
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label19 = new Label();
            buttonMove = new Button();
            MyFigure = new Button();
            buttonIncrease = new Button();
            textBoxSide = new TextBox();
            label17 = new Label();
            label6 = new Label();
            label18 = new Label();
            textBoxSideIncrease = new TextBox();
            label1 = new Label();
            textBoxHeightIncrease = new TextBox();
            textBoxChooseFigure = new TextBox();
            textBoxWeightIncrease = new TextBox();
            label2 = new Label();
            label16 = new Label();
            f = new Label();
            label15 = new Label();
            label3 = new Label();
            label14 = new Label();
            Drawing = new Button();
            buttonTriangle = new Button();
            label4 = new Label();
            buttonPolygon = new Button();
            textBoxCoordX = new TextBox();
            label13 = new Label();
            textBoxCoordY = new TextBox();
            buttonFullDelete = new Button();
            textBoxW = new TextBox();
            label11 = new Label();
            textBoxH = new TextBox();
            label12 = new Label();
            buttonDelete = new Button();
            textBoxMovingY = new TextBox();
            textBoxMovingX = new TextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            buttonEllipse = new Button();
            buttonCircle = new Button();
            buttonSquare = new Button();
            buttonRectangle = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.Location = new Point(473, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 700);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Thistle;
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(buttonMove);
            groupBox1.Controls.Add(MyFigure);
            groupBox1.Controls.Add(buttonIncrease);
            groupBox1.Controls.Add(textBoxSide);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(textBoxSideIncrease);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxHeightIncrease);
            groupBox1.Controls.Add(textBoxChooseFigure);
            groupBox1.Controls.Add(textBoxWeightIncrease);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(f);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(Drawing);
            groupBox1.Controls.Add(buttonTriangle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(buttonPolygon);
            groupBox1.Controls.Add(textBoxCoordX);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBoxCoordY);
            groupBox1.Controls.Add(buttonFullDelete);
            groupBox1.Controls.Add(textBoxW);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxH);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(textBoxMovingY);
            groupBox1.Controls.Add(textBoxMovingX);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(buttonEllipse);
            groupBox1.Controls.Add(buttonCircle);
            groupBox1.Controls.Add(buttonSquare);
            groupBox1.Controls.Add(buttonRectangle);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(25, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(442, 700);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(43, 352);
            label19.Name = "label19";
            label19.Size = new Size(74, 20);
            label19.TabIndex = 46;
            label19.Text = "/сторону:";
            // 
            // buttonMove
            // 
            buttonMove.Location = new Point(14, 581);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(117, 29);
            buttonMove.TabIndex = 45;
            buttonMove.Text = "Переместить";
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // MyFigure
            // 
            MyFigure.Location = new Point(276, 51);
            MyFigure.Name = "MyFigure";
            MyFigure.Size = new Size(140, 29);
            MyFigure.TabIndex = 39;
            MyFigure.Text = "Майне фигуре";
            MyFigure.UseVisualStyleBackColor = true;
            MyFigure.Click += MyFigure_Click;
            // 
            // buttonIncrease
            // 
            buttonIncrease.Location = new Point(201, 617);
            buttonIncrease.Name = "buttonIncrease";
            buttonIncrease.Size = new Size(94, 29);
            buttonIncrease.TabIndex = 38;
            buttonIncrease.Text = "Изменить";
            buttonIncrease.UseVisualStyleBackColor = true;
            buttonIncrease.Click += buttonIncrease_Click;
            // 
            // textBoxSide
            // 
            textBoxSide.Enabled = false;
            textBoxSide.Location = new Point(140, 345);
            textBoxSide.MaxLength = 4;
            textBoxSide.Name = "textBoxSide";
            textBoxSide.Size = new Size(125, 27);
            textBoxSide.TabIndex = 44;
            textBoxSide.KeyPress += YourTextBox_KeyPress;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(197, 585);
            label17.Name = "label17";
            label17.Size = new Size(122, 20);
            label17.TabIndex = 37;
            label17.Text = "сторону/радиус:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(70, 175);
            label6.Name = "label6";
            label6.Size = new Size(216, 25);
            label6.TabIndex = 10;
            label6.Text = "Координаты и Размеры";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(22, 332);
            label18.Name = "label18";
            label18.Size = new Size(117, 20);
            label18.TabIndex = 43;
            label18.Text = "Введите радиус";
            // 
            // textBoxSideIncrease
            // 
            textBoxSideIncrease.Enabled = false;
            textBoxSideIncrease.Location = new Point(322, 585);
            textBoxSideIncrease.MaxLength = 4;
            textBoxSideIncrease.Name = "textBoxSideIncrease";
            textBoxSideIncrease.Size = new Size(114, 27);
            textBoxSideIncrease.TabIndex = 36;
            textBoxSideIncrease.KeyPress += YourTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 206);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите X:";
            // 
            // textBoxHeightIncrease
            // 
            textBoxHeightIncrease.Enabled = false;
            textBoxHeightIncrease.Location = new Point(322, 551);
            textBoxHeightIncrease.MaxLength = 4;
            textBoxHeightIncrease.Name = "textBoxHeightIncrease";
            textBoxHeightIncrease.Size = new Size(114, 27);
            textBoxHeightIncrease.TabIndex = 35;
            textBoxHeightIncrease.KeyPress += YourTextBox_KeyPress;
            // 
            // textBoxChooseFigure
            // 
            textBoxChooseFigure.Enabled = false;
            textBoxChooseFigure.Location = new Point(296, 266);
            textBoxChooseFigure.Name = "textBoxChooseFigure";
            textBoxChooseFigure.Size = new Size(125, 27);
            textBoxChooseFigure.TabIndex = 42;
            // 
            // textBoxWeightIncrease
            // 
            textBoxWeightIncrease.Enabled = false;
            textBoxWeightIncrease.Location = new Point(322, 515);
            textBoxWeightIncrease.MaxLength = 4;
            textBoxWeightIncrease.Name = "textBoxWeightIncrease";
            textBoxWeightIncrease.Size = new Size(114, 27);
            textBoxWeightIncrease.TabIndex = 34;
            textBoxWeightIncrease.KeyPress += YourTextBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 239);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите Y:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(197, 551);
            label16.Name = "label16";
            label16.Size = new Size(82, 20);
            label16.TabIndex = 33;
            label16.Text = "Высоту на:";
            // 
            // f
            // 
            f.AutoSize = true;
            f.Location = new Point(291, 243);
            f.Name = "f";
            f.Size = new Size(145, 20);
            f.TabIndex = 41;
            f.Text = "Выбранная фигура:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(196, 518);
            label15.Name = "label15";
            label15.Size = new Size(90, 20);
            label15.TabIndex = 32;
            label15.Text = "Ширину на:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 272);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите W:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(197, 492);
            label14.Name = "label14";
            label14.Size = new Size(95, 20);
            label14.TabIndex = 31;
            label14.Text = "Измененить";
            // 
            // Drawing
            // 
            Drawing.Location = new Point(311, 299);
            Drawing.Name = "Drawing";
            Drawing.Size = new Size(101, 29);
            Drawing.TabIndex = 40;
            Drawing.Text = "Нарисовать";
            Drawing.UseVisualStyleBackColor = true;
            Drawing.Click += Drawing_Click;
            // 
            // buttonTriangle
            // 
            buttonTriangle.Location = new Point(176, 121);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(119, 29);
            buttonTriangle.TabIndex = 30;
            buttonTriangle.Text = "Треугольник";
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += buttonTriangle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 302);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Введите H:";
            // 
            // buttonPolygon
            // 
            buttonPolygon.Location = new Point(30, 121);
            buttonPolygon.Name = "buttonPolygon";
            buttonPolygon.Size = new Size(133, 29);
            buttonPolygon.TabIndex = 29;
            buttonPolygon.Text = "Полигон";
            buttonPolygon.UseVisualStyleBackColor = true;
            buttonPolygon.Click += buttonPolygon_Click;
            // 
            // textBoxCoordX
            // 
            textBoxCoordX.Enabled = false;
            textBoxCoordX.Location = new Point(140, 203);
            textBoxCoordX.MaxLength = 4;
            textBoxCoordX.Name = "textBoxCoordX";
            textBoxCoordX.Size = new Size(125, 27);
            textBoxCoordX.TabIndex = 4;
            textBoxCoordX.KeyPress += YourTextBox_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7F);
            label13.Location = new Point(174, 118);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 28;
            // 
            // textBoxCoordY
            // 
            textBoxCoordY.Enabled = false;
            textBoxCoordY.Location = new Point(140, 236);
            textBoxCoordY.MaxLength = 4;
            textBoxCoordY.Name = "textBoxCoordY";
            textBoxCoordY.Size = new Size(125, 27);
            textBoxCoordY.TabIndex = 5;
            textBoxCoordY.KeyPress += YourTextBox_KeyPress;
            // 
            // buttonFullDelete
            // 
            buttonFullDelete.Location = new Point(155, 665);
            buttonFullDelete.Name = "buttonFullDelete";
            buttonFullDelete.Size = new Size(149, 29);
            buttonFullDelete.TabIndex = 27;
            buttonFullDelete.Text = "Очистить все";
            buttonFullDelete.UseVisualStyleBackColor = true;
            buttonFullDelete.Click += buttonFullDelete_Click;
            // 
            // textBoxW
            // 
            textBoxW.Enabled = false;
            textBoxW.Location = new Point(140, 269);
            textBoxW.MaxLength = 4;
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new Size(125, 27);
            textBoxW.TabIndex = 6;
            textBoxW.KeyPress += YourTextBox_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7F);
            label11.Location = new Point(14, 368);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 26;
            // 
            // textBoxH
            // 
            textBoxH.Enabled = false;
            textBoxH.Location = new Point(140, 302);
            textBoxH.MaxLength = 4;
            textBoxH.Name = "textBoxH";
            textBoxH.Size = new Size(125, 27);
            textBoxH.TabIndex = 7;
            textBoxH.KeyPress += YourTextBox_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 435);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 25;
            label12.Text = "Выберите объект";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(198, 461);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxMovingY
            // 
            textBoxMovingY.Enabled = false;
            textBoxMovingY.Location = new Point(60, 548);
            textBoxMovingY.MaxLength = 4;
            textBoxMovingY.Name = "textBoxMovingY";
            textBoxMovingY.Size = new Size(117, 27);
            textBoxMovingY.TabIndex = 22;
            textBoxMovingY.KeyPress += YourTextBox_KeyPress;
            // 
            // textBoxMovingX
            // 
            textBoxMovingX.Enabled = false;
            textBoxMovingX.Location = new Point(60, 515);
            textBoxMovingX.MaxLength = 4;
            textBoxMovingX.Name = "textBoxMovingX";
            textBoxMovingX.Size = new Size(117, 27);
            textBoxMovingX.TabIndex = 21;
            textBoxMovingX.KeyPress += YourTextBox_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 461);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 551);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 18;
            label10.Text = "по Y:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 518);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 17;
            label9.Text = "по X:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 492);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 16;
            label8.Text = "Перемещение";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(43, 400);
            label7.Name = "label7";
            label7.Size = new Size(349, 25);
            label7.TabIndex = 15;
            label7.Text = "Перемещение, Изменение и Удаление";
            // 
            // buttonEllipse
            // 
            buttonEllipse.Location = new Point(176, 51);
            buttonEllipse.Name = "buttonEllipse";
            buttonEllipse.Size = new Size(94, 29);
            buttonEllipse.TabIndex = 14;
            buttonEllipse.Text = "Эллипс";
            buttonEllipse.UseVisualStyleBackColor = true;
            buttonEllipse.Click += buttonEllipse_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(176, 86);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(94, 29);
            buttonCircle.TabIndex = 13;
            buttonCircle.Text = "Круг";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.Location = new Point(29, 86);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(134, 29);
            buttonSquare.TabIndex = 12;
            buttonSquare.Text = "Квадрат";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonRectangle
            // 
            buttonRectangle.Location = new Point(30, 51);
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(134, 29);
            buttonRectangle.TabIndex = 11;
            buttonRectangle.Text = "Прямоугольник";
            buttonRectangle.UseVisualStyleBackColor = true;
            buttonRectangle.Click += buttonRectangle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(147, 23);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 9;
            label5.Text = "Выберите Фигуру";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1250, 741);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxH;
        private TextBox textBoxW;
        private TextBox textBoxCoordY;
        private TextBox textBoxCoordX;
        private Label label5;
        private Button buttonEllipse;
        private Button buttonCircle;
        private Button buttonSquare;
        private Button buttonRectangle;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBoxMovingY;
        private TextBox textBoxMovingX;
        private Button buttonDelete;
        private Label label12;
        private Label label11;
        private Button buttonFullDelete;
        private Label label13;
        private Button buttonPolygon;
        public ComboBox comboBox1;
        private Button buttonTriangle;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label17;
        private TextBox textBoxSideIncrease;
        private TextBox textBoxHeightIncrease;
        private TextBox textBoxWeightIncrease;
        private Button buttonIncrease;
        private Button MyFigure;
        private Button Drawing;
        private Label f;
        private TextBox textBoxChooseFigure;
        private TextBox textBoxSide;
        private Label label18;
        private Button buttonMove;
        private Label label19;
    }
}
