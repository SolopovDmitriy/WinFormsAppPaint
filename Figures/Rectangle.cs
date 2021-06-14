using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    class Rectangle : IFigure // прямоугольник, доделать (отрицательная ширина или высота - ошибка)
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public void draw(Graphics g)
        {
            Pen pen1 = new Pen(Color.Green);
            pen1.Width = 5;
            //g.DrawRectangle(pen1, topLeftPoint.X, topLeftPoint.Y,
            //    bottomRightPoint.X, bottomRightPoint.Y);
           
            g.DrawRectangle(pen1, StartPoint.X, StartPoint.Y,
                EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
        }
    }
}
