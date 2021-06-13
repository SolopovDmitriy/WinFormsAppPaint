using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    class Line : IFigure
    {
        public Point topLeftPoint { get; set; }
        public Point bottomRightPoint { get; set; }

        public void draw(Graphics g)
        {
            Pen pen1 = new Pen(Color.Green);
            pen1.Width = 5; 
            g.DrawLine(pen1, topLeftPoint, bottomRightPoint);
        }
    }
}
