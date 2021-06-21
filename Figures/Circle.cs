using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    class Circle : IFigure // окружность
    {
        public Color Color { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Point TopLeft { get; set; } 
        public Point BottomRight { get; set; }
        public int Thickness { get; set; }
        public int Radius { get; set; }
        public Point Center { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Color);
            pen1.Width = Thickness;
            Center = new Point((StartPoint.X + EndPoint.X) / 2, (StartPoint.Y + EndPoint.Y) / 2);
            Radius = (EndPoint.X - StartPoint.X)/2;
            g.DrawEllipse(pen1, StartPoint.X, StartPoint.Y, 2*Radius, 2*Radius);
        }

        public bool Hittest(Point point)
        {
            double distanceFromCenterToPoint = Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2));
            return distanceFromCenterToPoint < Radius;
        }
    }
}