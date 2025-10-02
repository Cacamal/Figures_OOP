using Figurki;

namespace OAIP_Figures
{
    public partial class Form1 : Form
    {
        Rectagle rectagle;
        Ellipse ellipse;
        Square square;
        Circle circle;
        public Form1()
        {
            InitializeComponent();

            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
        }
        public void DrawRectangle()
        {
            try
            {
                int x = int.Parse(textBoxCoordX.Text);
                int y = int.Parse(textBoxCoordY.Text);
                int w = int.Parse(textBoxW.Text);
                int h = int.Parse(textBoxH.Text);

                if (x >= Init.pictureBox.Width - w || y >= Init.pictureBox.Height - h || x < 0 || y < 0)
                {
                    MessageBox.Show("������ ������ �� �������");
                    return;
                }
                else if (w <= 0 || h <= 0)
                {
                    MessageBox.Show("�� ����� ������������ ������");
                    return;
                }

                rectagle = new Rectagle(x, y, w, h);
                rectagle.Draw();
                ShapeContainer.AddFigure(rectagle);
                comboBox1.Items.Add(rectagle);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("�� ��� ��������� ���� '���������� � �������' ������� ����� �����");  
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");  
            }
        }
        public void DrawSquare()
        {
            try
            {
                int x = int.Parse(textBoxCoordX.Text);
                int y = int.Parse(textBoxCoordY.Text);
                int side = int.Parse(textBoxSide.Text);

                if (x >= Init.pictureBox.Width - side || y >= Init.pictureBox.Height - side || x < 0 || y < 0)
                {
                    MessageBox.Show("������ ������ �� �������!");
                    return;
                }
                else if (side <= 0)
                {
                    MessageBox.Show("�� ����� ������������ ������");
                    return;
                }

                square = new Square(x, y, side);
                square.Draw();
                ShapeContainer.AddFigure(square);
                comboBox1.Items.Add(square);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("�� ��� ��������� ���� '���������� � �������' ������� ����� �����");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");
            }
        }
        public void DrawEllipse()
        {
            try
            {
                int x = int.Parse(textBoxCoordX.Text);
                int y = int.Parse(textBoxCoordY.Text);
                int w = int.Parse(textBoxW.Text);
                int h = int.Parse(textBoxH.Text);

                if (x >= Init.pictureBox.Width - w || y >= Init.pictureBox.Height - h || x < 0 || y < 0)
                {
                    MessageBox.Show("������ ������ �� �������");
                    return;
                }
                else if (w <= 0 || h <= 0)
                {
                    MessageBox.Show("�� ����� ������������ ������");
                    return;
                }
                else if (w == h)
                {
                    MessageBox.Show("������ �� �������� ������!!!");
                    return;
                }

                ellipse = new Ellipse(x, y, w, h);
                ellipse.Draw();
                ShapeContainer.AddFigure(ellipse);
                comboBox1.Items.Add(ellipse);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("�� ��� ��������� ���� '���������� � �������' ������� ����� �����");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");
            }
        }
        public void DrawCircle()
        {
            try
            {
                int x = int.Parse(textBoxCoordX.Text);
                int y = int.Parse(textBoxCoordY.Text);
                int radius = int.Parse(textBoxSide.Text) * 2;

                if (x >= Init.pictureBox.Width - radius || y >= Init.pictureBox.Height - radius || x < 0 || y < 0)
                {
                    MessageBox.Show("������ ������ �� �������");
                    return;
                }
                else if (radius <= 0)
                {
                    MessageBox.Show("�� ����� ������������ ������");
                    return;
                }

                circle = new Circle(x, y, radius);
                circle.Draw();
                ShapeContainer.AddFigure(circle);
                comboBox1.Items.Add(circle);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("�� ��� ��������� ���� '���������� � �������' ������� ����� �����");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");
            }
        }
        public void DrawPolygon()
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            Block();
        }
        public void DrawTriangle()
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            Block();
        }
        
        
        private void DrawMyFigure()
        {
            try
            {
                int x = int.Parse(textBoxCoordX.Text);
                int y = int.Parse(textBoxCoordY.Text);
                int w = int.Parse(textBoxW.Text);
                int h = int.Parse(textBoxH.Text);

                if (x >= Init.pictureBox.Width - w || y >= Init.pictureBox.Height - h || x < 0 || y < 0)
                {
                    MessageBox.Show("������ ������ �� �������");
                    return;
                }
                else if (w <= 0 || h <= 0)
                {
                    MessageBox.Show("�� ����� ������������ ������");
                    return;
                }

                MyFigure myFigure = new MyFigure(x, y, w, h);
                myFigure.Draw();
                ShapeContainer.AddFigure(myFigure);
                comboBox1.Items.Add(myFigure);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("�� ���� ����� '����������' ������� ����� �����");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");
            }
        }

        //�����������
        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                int X = int.Parse(textBoxMovingX.Text);
                int Y = int.Parse(textBoxMovingY.Text);

                Figure figure = (Figure)comboBox1.SelectedItem;
                if (figure != null)
                {
                    figure.MoveTo(X, Y);
                }
                else
                {
                    MessageBox.Show("������ �� �������");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("������ �� �������");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");
            }
        }
        //��������� ������
        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            try
            {
                Figure figure = (Figure)comboBox1.SelectedItem;
                if (figure != null)
                {
                    if (figure.ToString() == "Figurki.Rectagle")
                    {
                        int w = int.Parse(textBoxWeightIncrease.Text);
                        int h = int.Parse(textBoxHeightIncrease.Text);
                        rectagle.Increase(w, h);
                    }
                    else if (figure.ToString() == "Figurki.Square")
                    {
                        int side = int.Parse(textBoxSideIncrease.Text);
                        square.Increase(side, side);
                    }
                    else if (figure.ToString() == "Figurki.Ellipse")
                    {
                        int w = int.Parse(textBoxWeightIncrease.Text);
                        int h = int.Parse(textBoxHeightIncrease.Text);
                        if(w == h)
                        {
                            MessageBox.Show("������ �� �������� ������");
                            return;
                        }
                        ellipse.Increase(w, h);
                    }
                    else if (figure.ToString() == "Figurki.Circle")
                    {
                        int side = int.Parse(textBoxSideIncrease.Text);
                        circle.Increase(side, side);
                    }
                }
                else
                {
                    MessageBox.Show("������ �� �������");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("�� ���� ����� '��������' ������� ����� �����");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������ ������ �� �������");
            }
        }

        //�������� ������
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("��� ����� ��� ��������");
                return;
            }
            Figure figure = (Figure)comboBox1.SelectedItem;
            if (figure != null)
            {
                figure.DeleteF(figure);
                comboBox1.Items.Remove(figure);
            }
            else
            {
                MessageBox.Show("�������� ������");
            }
        }

        //�������� �����
        private void buttonFullDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("��� ����� ��� �������");
                return;
            }
            pictureBox1.Image = null;
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.LavenderBlush);
            Init.pictureBox.Image = Init.bitmap;

            comboBox1.Items.Clear();
            ShapeContainer.figureList.Clear();
            MessageBox.Show("��� ������ �������");
        }

        //����� �� ����
        public void Block()
        {
            textBoxCoordX.Enabled = false;
            textBoxCoordY.Enabled = false;
            textBoxW.Enabled = false;
            textBoxH.Enabled = false;
            textBoxMovingX.Enabled = false;
            textBoxMovingY.Enabled = false;
            textBoxWeightIncrease.Enabled = false;
            textBoxHeightIncrease.Enabled = false;
            textBoxSideIncrease.Enabled = false;
            textBoxSide.Enabled = false;
        }
        //������ �� �������
        public void ClearText()
        {
            textBoxCoordX.Text = "";
            textBoxCoordY.Text = "";
            textBoxW.Text = "";
            textBoxH.Text = "";
            textBoxMovingX.Text = "";
            textBoxMovingY.Text = "";
            textBoxWeightIncrease.Text = "";
            textBoxHeightIncrease.Text = "";
            textBoxSideIncrease.Text = "";
            textBoxSide.Text = "";
        }
        //����� �� ����� ������ ��� ���������
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            ClearText();
            textBoxChooseFigure.Text = "�������������";
            textBoxCoordX.Enabled = true;
            textBoxCoordY.Enabled = true;
            textBoxW.Enabled = true;
            textBoxH.Enabled = true;
            textBoxSide.Enabled = false;
        }
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            ClearText();
            textBoxChooseFigure.Text = "�������";
            textBoxW.Enabled = false;
            textBoxH.Enabled = false;
            textBoxSide.Enabled = true;
            textBoxCoordX.Enabled = true;
            textBoxCoordY.Enabled = true;
        }
        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            ClearText();
            textBoxChooseFigure.Text = "������";
            textBoxCoordX.Enabled = true;
            textBoxCoordY.Enabled = true;
            textBoxW.Enabled = true;
            textBoxH.Enabled = true;
            textBoxSide.Enabled = false;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            ClearText();
            textBoxChooseFigure.Text = "����";
            textBoxW.Enabled = false;
            textBoxH.Enabled = false;
            textBoxSide.Enabled = true;
            textBoxCoordX.Enabled = true;
            textBoxCoordY.Enabled = true;
        }
        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            textBoxChooseFigure.Text = "�������";
            Block();
        }
        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            textBoxChooseFigure.Text = "�����������";
            Block();
        }
        private void MyFigure_Click(object sender, EventArgs e)
        {
            ClearText();
            textBoxChooseFigure.Text = "��� ������";
            textBoxCoordX.Enabled = true;
            textBoxCoordY.Enabled = true;
            textBoxW.Enabled = true;
            textBoxH.Enabled = true;
            textBoxSide.Enabled = false;
        }
        private void Drawing_Click(object sender, EventArgs e)
        {
            if (textBoxChooseFigure.Text == "�������������")
            {
                DrawRectangle();
                Block();
                ClearText();
                textBoxCoordX.Enabled = true;
                textBoxCoordY.Enabled = true;
                textBoxW.Enabled = true;
                textBoxH.Enabled = true;

            }
            else if (textBoxChooseFigure.Text == "�������")
            {
                DrawSquare();
                Block();
                ClearText();
                textBoxCoordX.Enabled = true;
                textBoxCoordY.Enabled = true;
                textBoxSide.Enabled = true;
            }
            else if (textBoxChooseFigure.Text == "������")
            {
                DrawEllipse();
                Block();
                ClearText();
                textBoxCoordX.Enabled = true;
                textBoxCoordY.Enabled = true;
                textBoxW.Enabled = true;
                textBoxH.Enabled = true;
            }
            else if (textBoxChooseFigure.Text == "����")
            {
                DrawCircle();
                Block();
                ClearText();
                textBoxCoordX.Enabled = true;
                textBoxCoordY.Enabled = true;
                textBoxSide.Enabled = true;
            }
            else if (textBoxChooseFigure.Text == "��� ������")
            {
                DrawMyFigure();
                Block();
                ClearText();
                textBoxCoordX.Enabled = true;
                textBoxCoordY.Enabled = true;
                textBoxW.Enabled = true;
                textBoxH.Enabled = true;
            }
            else if (textBoxChooseFigure.Text == "�������")
            {
                DrawPolygon();
                Block();
                ClearText();
            }
            else if (textBoxChooseFigure.Text == "�����������")
            {
                DrawTriangle();
                Block();
                ClearText();
            }
            else
            {
                MessageBox.Show("�������� ������");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Figurki.Rectagle")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
                textBoxWeightIncrease.Enabled = true;
                textBoxHeightIncrease.Enabled = true;
            }
            else if (comboBox1.Text == "Figurki.Square")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
                textBoxSideIncrease.Enabled = true;
            }
            else if (comboBox1.Text == "Figurki.Ellipse")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
                textBoxWeightIncrease.Enabled = true;
                textBoxHeightIncrease.Enabled = true;
            }
            else if (comboBox1.Text == "Figurki.Circle")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
                textBoxSideIncrease.Enabled = true;
            }
            else if (comboBox1.Text == "Figurki.Polygon")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
            }
            else if (comboBox1.Text == "Figurki.Triangle")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
            }
            else if (comboBox1.Text == "Figurki.MyFigure")
            {
                textBoxMovingX.Enabled = true;
                textBoxMovingY.Enabled = true;
                textBoxWeightIncrease.Enabled = true;
                textBoxHeightIncrease.Enabled = true;
            }
        }
        private void YourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ���������, �������� �� ������ ������ ��� ������ �����
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                // ��������� ����
                e.Handled = true;
            }
            if (e.KeyChar == '-' && ((TextBox)sender).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
