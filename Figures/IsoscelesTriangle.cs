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
            Point topMiddle = new Point((leftX + rightX) / 2, topY);
            Point bottomRight = new Point(rightX, bottomY);
            Point bottomLeft = new Point(leftX, bottomY);

            // сама прорисовка
            g.DrawLine(pen1, topMiddle, bottomLeft);
            g.DrawLine(pen1, topMiddle, bottomRight);
            g.DrawLine(pen1, bottomLeft, bottomRight);
        }
    }
}
