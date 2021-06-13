using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    class IsoscelesTriangle : IFigure // равнобедренный треугольник
    {
        public Point topLeftPoint { get; set; }
        public Point bottomRightPoint { get; set; }
        
        public void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
