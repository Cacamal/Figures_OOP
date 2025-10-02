namespace OAIP_Figures
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            buttonDrawTriangle = new Button();
            buttonAddPoint = new Button();
            textBoxForY = new TextBox();
            textBoxForX = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDrawTriangle);
            groupBox1.Controls.Add(buttonAddPoint);
            groupBox1.Controls.Add(textBoxForY);
            groupBox1.Controls.Add(textBoxForX);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание треугольника";
            // 
            // buttonDrawTriangle
            // 
            buttonDrawTriangle.Enabled = false;
            buttonDrawTriangle.Location = new Point(64, 183);
            buttonDrawTriangle.Name = "buttonDrawTriangle";
            buttonDrawTriangle.Size = new Size(210, 29);
            buttonDrawTriangle.TabIndex = 6;
            buttonDrawTriangle.Text = "Нарисовать треугольник";
            buttonDrawTriangle.UseVisualStyleBackColor = true;
            buttonDrawTriangle.Click += buttonDrawTriangle_Click;
            // 
            // buttonAddPoint
            // 
            buttonAddPoint.Location = new Point(64, 148);
            buttonAddPoint.Name = "buttonAddPoint";
            buttonAddPoint.Size = new Size(210, 29);
            buttonAddPoint.TabIndex = 5;
            buttonAddPoint.Text = "Добавить точку";
            buttonAddPoint.UseVisualStyleBackColor = true;
            buttonAddPoint.Click += buttonAddPoint_Click;
            // 
            // textBoxForY
            // 
            textBoxForY.Location = new Point(199, 103);
            textBoxForY.MaxLength = 4;
            textBoxForY.Name = "textBoxForY";
            textBoxForY.Size = new Size(125, 27);
            textBoxForY.TabIndex = 4;
            textBoxForY.KeyPress += YourTextBox_KeyPress;
            // 
            // textBoxForX
            // 
            textBoxForX.Location = new Point(199, 69);
            textBoxForX.MaxLength = 4;
            textBoxForX.Name = "textBoxForX";
            textBoxForX.Size = new Size(125, 27);
            textBoxForX.TabIndex = 3;
            textBoxForX.KeyPress += YourTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 106);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите координтау по Y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 39);
            label2.Name = "label2";
            label2.Size = new Size(190, 20);
            label2.TabIndex = 1;
            label2.Text = "Номер вводимой точки: 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 72);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите координтау по X:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 257);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxForY;
        private TextBox textBoxForX;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonDrawTriangle;
        private Button buttonAddPoint;
    }
}