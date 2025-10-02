using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figurki
{
    public class MyFigure : Figure
    {
        public Rectagle body; // Основной корпус светофора
        public Triangle top; // Верхняя часть (крыша)
        public Circle topLight; // Верхний свет 
        public Circle bottomLight; // Нижний свет 
        public Rectagle pole; // Стойка светофора

        public MyFigure(int x, int y, int width, int height)
        {
            this.w = width;
            this.h = height;

            // Верхняя часть (треугольник)
            int topHeight = height / 4;
            int topBase = width;
            int topX = x;
            int topY = y;

            this.top = new Triangle(3);
            top.pointFs[0].X = topX + topBase / 2;  // Вершина треугольника
            top.pointFs[0].Y = topY;
            top.pointFs[1].X = topX;  // Левый угол
            top.pointFs[1].Y = topY + topHeight;
            top.pointFs[2].X = topX + topBase;  // Правый угол
            top.pointFs[2].Y = topY + topHeight;

            // Основной корпус
            int bodyWidth = width;
            int bodyHeight = height / 2;
            int bodyX = x;
            int bodyY = topY + topHeight;
            this.body = new Rectagle(bodyX, bodyY, bodyWidth, bodyHeight);

            // Огни светофора
            int lightRadius = bodyWidth / 3;
            int lightX = bodyX + (bodyWidth / 2) - (lightRadius / 2);
            int lightY1 = bodyY + (bodyHeight / 4) - lightRadius / 2; // Верхний свет
            int lightY2 = bodyY + (3 * bodyHeight / 4) - lightRadius / 2; // Нижний свет
            this.topLight = new Circle(lightX, lightY1, lightRadius);
            this.bottomLight = new Circle(lightX, lightY2, lightRadius);

            // Стойка
            int poleWidth = width / 4;
            int poleHeight = height / 2;
            int poleX = x + (width / 2) - (poleWidth / 2);
            int poleY = bodyY + bodyHeight;
            this.pole = new Rectagle(poleX, poleY, poleWidth, poleHeight);
        }

        public override void Draw()
        {
            this.top.Draw();
            this.body.Draw();
            this.topLight.Draw();
            this.bottomLight.Draw();
            this.pole.Draw();
        }

        public override void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;

            int left = (int)this.top.pointFs[1].X + x;
            int right = (int)this.top.pointFs[2].X + x;
            int top = (int)this.top.pointFs[0].Y + y;
            int bottom = this.pole.y + this.pole.h + y;
            if (left < 0 || right > Init.pictureBox.Width || top < 0 || bottom > Init.pictureBox.Height)
            {
                MessageBox.Show(
                    "Фигура достигла края!",
                    "Внимание!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.body.x += x;
            this.body.y += y;

            this.topLight.x += x;
            this.topLight.y += y;

            this.bottomLight.x += x;
            this.bottomLight.y += y;

            this.pole.x += x;
            this.pole.y += y;

            for (int i = 0; i < 3; i++)
            {
                this.top.pointFs[i].X += x;
                this.top.pointFs[i].Y += y;
            }

            this.DeleteF(this, false);
            this.Draw();
        }
    }
}
