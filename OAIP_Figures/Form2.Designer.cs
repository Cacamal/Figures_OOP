namespace OAIP_Figures
{
    partial class Form2
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
            label4 = new Label();
            buttonDrawPolygon = new Button();
            textBoxForX = new TextBox();
            buttonAddPoint = new Button();
            textBoxForY = new TextBox();
            textBoxCountPoint = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(buttonDrawPolygon);
            groupBox1.Controls.Add(textBoxForX);
            groupBox1.Controls.Add(buttonAddPoint);
            groupBox1.Controls.Add(textBoxForY);
            groupBox1.Controls.Add(textBoxCountPoint);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание многоугольника";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 58);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 8;
            label4.Text = "Номер вводимой точки:";
            // 
            // buttonDrawPolygon
            // 
            buttonDrawPolygon.Enabled = false;
            buttonDrawPolygon.Location = new Point(95, 204);
            buttonDrawPolygon.Name = "buttonDrawPolygon";
            buttonDrawPolygon.Size = new Size(208, 29);
            buttonDrawPolygon.TabIndex = 7;
            buttonDrawPolygon.Text = "Нарисовать полигон";
            buttonDrawPolygon.UseVisualStyleBackColor = true;
            buttonDrawPolygon.Click += buttonDrawPolygon_Click;
            // 
            // textBoxForX
            // 
            textBoxForX.Enabled = false;
            textBoxForX.Location = new Point(246, 87);
            textBoxForX.MaxLength = 4;
            textBoxForX.Name = "textBoxForX";
            textBoxForX.Size = new Size(125, 27);
            textBoxForX.TabIndex = 4;
            textBoxForX.KeyPress += YourTextBox_KeyPress;
            // 
            // buttonAddPoint
            // 
            buttonAddPoint.Location = new Point(95, 169);
            buttonAddPoint.Name = "buttonAddPoint";
            buttonAddPoint.Size = new Size(208, 29);
            buttonAddPoint.TabIndex = 6;
            buttonAddPoint.Text = "Добавить точку";
            buttonAddPoint.UseVisualStyleBackColor = true;
            buttonAddPoint.Click += buttonAddPoint_Click;
            // 
            // textBoxForY
            // 
            textBoxForY.Enabled = false;
            textBoxForY.Location = new Point(246, 120);
            textBoxForY.MaxLength = 4;
            textBoxForY.Name = "textBoxForY";
            textBoxForY.Size = new Size(125, 27);
            textBoxForY.TabIndex = 5;
            textBoxForY.KeyPress += YourTextBox_KeyPress;
            // 
            // textBoxCountPoint
            // 
            textBoxCountPoint.Location = new Point(244, 24);
            textBoxCountPoint.MaxLength = 4;
            textBoxCountPoint.Name = "textBoxCountPoint";
            textBoxCountPoint.Size = new Size(125, 27);
            textBoxCountPoint.TabIndex = 3;
            textBoxCountPoint.KeyPress += YourTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(190, 20);
            label3.TabIndex = 2;
            label3.Text = "Введите количество точек";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 117);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите координтау по Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 87);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите координтау по X:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 295);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonDrawPolygon;
        private Button buttonAddPoint;
        private TextBox textBoxForY;
        private TextBox textBoxForX;
        private TextBox textBoxCountPoint;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}