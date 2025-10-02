using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figurki;

namespace OAIP_Figures
{
    public partial class Form3 : Form
    {
        //плплплплпл
        bool flag;
        int numPoints = 3;
        int i = 0;
        Triangle triangle;
        Form1 mainForm;
        public Form3(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonAddPoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    triangle = new Triangle(numPoints);
                    flag = true;
                    int pointX = int.Parse(textBoxForX.Text);
                    int pointY = int.Parse(textBoxForY.Text);
                    if (pointX <= Init.pictureBox.Width && pointY <= Init.pictureBox.Height)
                    {
                        triangle.pointFs[i].X = pointX;
                        triangle.pointFs[i].Y = pointY;
                    }
                    else
                    {
                        MessageBox.Show("Слишком большое число");
                        return;
                    }
                    i++;
                    label2.Text = $"Номер вводимой точки: {i + 1}";
               
                }
                else if (i != numPoints)
                {
                    int pointX = int.Parse(textBoxForX.Text);
                    int pointY = int.Parse(textBoxForY.Text);
                    if (pointX <= Init.pictureBox.Width && pointY <= Init.pictureBox.Height)
                    {
                        triangle.pointFs[i].X = pointX;
                        triangle.pointFs[i].Y = pointY;
                    }
                    else
                    {
                        MessageBox.Show("Слишком большое число");
                        return;
                    }
                    i++;
                    if (i >= numPoints)
                    {
                        label2.Text = "Номер вводимой точки:";
                        buttonAddPoint.Enabled = false;
                        buttonDrawTriangle.Enabled = true;
                        textBoxForX.Enabled = false;
                        textBoxForY.Enabled = false;
                        flag = false;
                        return;
                    }
                    label2.Text = $"Номер вводимой точки: {i + 1}";
                }
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            catch (System.FormatException)
            {
                MessageBox.Show("В доступоные поля введите целые числа");
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Слишком большое число");
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }

        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            triangle.Draw();
            ShapeContainer.AddFigure(triangle);
            mainForm.comboBox1.Items.Add(triangle);
            buttonDrawTriangle.Enabled = false;
            textBoxForX.Enabled = true;
            textBoxForY.Enabled = true;
            buttonAddPoint.Enabled = true;
            label2.Text = "Номер вводимой точки: 1";
            i = 0;
            textBoxForX.Text = "";
            textBoxForY.Text = "";
        }
        private void YourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверяем, является ли символ цифрой или знаком минус
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                // Запрещаем ввод
                e.Handled = true;
            }
            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
