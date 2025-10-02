using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figurki
{
    public class Square : Rectagle
    {
        public Square(int x, int y, int w) : base (x, y, w, w)
        {
            
        }
        public override void Increase(int side, int none)
        {
            if (x + side >= Init.pictureBox.Width || y + side >= Init.pictureBox.Height || side < 0 || side < 0)
            {
                MessageBox.Show("Фигура не может измениться с этими значениями");
            }
            else
            {
                this.w = side;
                this.h = side;
                this.DeleteF(this, false);
                this.Draw();
            }
        }
    }
}
