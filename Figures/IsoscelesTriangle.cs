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
        public Color Color { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        public Point BottomLeft { get; set; }
        
        public Point TopMiddle { get; set; }
        public int Thickness { get; set; }

        public void Draw(Graphics g)
        {

            Pen pen1 = new Pen(Color);
            pen1.Width = Thickness;

            int leftX = StartPoint.X; // 10
            int rightX = EndPoint.X; // 5

            if (leftX > rightX)
            {
                leftX = EndPoint.X; // 5
                rightX = StartPoint.X; // 10
            }

            int bottomY = StartPoint.Y;
            int topY = EndPoint.Y;

            if (bottomY < topY)
            {
                bottomY = EndPoint.Y;
                topY = StartPoint.Y;
            }


            // равнобедренный треугольник 2-я точка
            TopMiddle = new Point((leftX + rightX) / 2, topY);
            BottomRight = new Point(rightX, bottomY);
            BottomLeft = new Point(leftX, bottomY);

            // сама прорисовка
            g.DrawLine(pen1, TopMiddle, BottomLeft);
            g.DrawLine(pen1, TopMiddle, BottomRight);
            g.DrawLine(pen1, BottomLeft, BottomRight);
        }

        public bool Hittest(Point point)
        {
            double x1 = TopMiddle.X;
            double y1 = TopMiddle.Y;
            double x2 = BottomRight.X;
            double y2 = BottomRight.Y;
            double x3 = BottomLeft.X;
            double y3 = BottomLeft.Y;

            double x0 = point.X;
            double y0 = point.Y;
            double a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            double b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            double c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0))
            {
                return true;
            }
            return false;
        }

    }
}
