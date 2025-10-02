using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figurki;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace OAIP_Figures
{
    public partial class Form2 : Form
    {
        bool flag;
        int numPoints;
        int i = 0;
        Polygon polygon;
        Form1 mainForm;

        public Form2(Form1 mainForm)
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
                    numPoints = int.Parse(textBoxCountPoint.Text);
                    if (numPoints >= 3)
                    {
                        polygon = new Polygon(numPoints);
                        flag = true;
                        textBoxCountPoint.Enabled = false;
                        textBoxForX.Enabled = true;
                        textBoxForY.Enabled = true;
                        label4.Text = $"Номер вводимой точки: {i + 1}";
                    }
                    else
                    {
                        MessageBox.Show("Полигон не может содержать меньше 3 вершин");
                        textBoxCountPoint.Text = "";
                    }
                }
                else if (i != numPoints)
                {
                    int pointX = int.Parse(textBoxForX.Text);
                    int pointY = int.Parse(textBoxForY.Text);
                    if (pointX <= Init.pictureBox.Width && pointY <= Init.pictureBox.Height)
                    {
                        polygon.pointFs[i].X = pointX;
                        polygon.pointFs[i].Y = pointY;
                    }
                    else
                    {
                        MessageBox.Show("Слишком большое число");
                        return;
                    }
                    i++;
                    if (i >= numPoints)
                    {
                        label4.Text = "Номер вводимой точки:";
                        buttonAddPoint.Enabled = false;
                        buttonDrawPolygon.Enabled = true;
                        textBoxForX.Enabled = false;
                        textBoxForY.Enabled = false;
                        flag = false;
                        return;
                    }
                    label4.Text = $"Номер вводимой точки: {i + 1}";
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

        private void buttonDrawPolygon_Click(object sender, EventArgs e)
        {
            polygon.Draw();
            ShapeContainer.AddFigure(polygon);
            mainForm.comboBox1.Items.Add(polygon);
            buttonDrawPolygon.Enabled = false;
            textBoxCountPoint.Enabled = true;
            textBoxForX.Enabled = false;
            textBoxForY.Enabled = false;
            buttonAddPoint.Enabled = true;
            label4.Text = "Номер вводимой точки:";
            i = 0;
            textBoxForX.Text = "";
            textBoxForY.Text = "";
            textBoxCountPoint.Text = "";
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
 
