using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Figurki
{
    public class Polygon : Figure
    {
        public PointF[] pointFs;
        public Polygon(int count)
        {
            pointFs = new PointF[count];
        }

        public override void Draw()
        {
            try
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                g.DrawPolygon(Init.pen, pointFs);
                Init.pictureBox.Image = Init.bitmap;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Слишком большое число");
            }
        }

        public override void MoveTo(int x, int y)
        {
            bool bounds = true;

            for (int i = 0; i < pointFs.Length; i++)
            {
                if (pointFs[i].X + x < 0 ||
                    pointFs[i].X + x > Init.pictureBox.Width ||
                    pointFs[i].Y + y < 0 ||
                    pointFs[i].Y + y > Init.pictureBox.Height)
                {
                    bounds = false;
                    break;
                }
            }

            if (bounds == true)
            {
                for (int i = 0; i < pointFs.Length; i++)
                {
                    pointFs[i].X += x;
                    pointFs[i].Y += y;
                }
                DeleteF(this, false);
                Draw();
            }
            else
            {
                MessageBox.Show("Фигура достигла края!");
            }
        }
    }
}
