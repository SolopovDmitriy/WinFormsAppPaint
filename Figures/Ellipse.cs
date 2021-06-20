using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    class Ellipse : IFigure // элипс
    {
        public Color Color { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int Thickness { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Color);
            pen1.Width = Thickness;
            g.DrawEllipse(pen1, StartPoint.X, StartPoint.Y, EndPoint.X - StartPoint.X, EndPoint.Y);
        }
    }
}
