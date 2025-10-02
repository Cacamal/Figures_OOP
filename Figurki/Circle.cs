using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figurki
{
    public class Circle : Ellipse
    {
        public Circle(int x, int y, int w) : base(x, y, w, w)
        {
            
        }

    }
}
