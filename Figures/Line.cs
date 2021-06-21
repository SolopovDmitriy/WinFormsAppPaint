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
        public Color Color { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public int Thickness { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Color);
            pen1.Width = Thickness; 
            g.DrawLine(pen1, StartPoint, EndPoint);
        }

        public bool Hittest(Point point)
        {
            return false; // TODO
        }
    }
}
