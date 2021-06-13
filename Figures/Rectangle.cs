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
        public Point topLeftPoint { get; set; }
        public Point bottomRightPoint { get; set; }

        public void draw(Graphics g)
        {
            Pen pen1 = new Pen(Color.Green);
            pen1.Width = 5;
            //g.DrawRectangle(pen1, topLeftPoint.X, topLeftPoint.Y,
            //    bottomRightPoint.X, bottomRightPoint.Y);
           
            g.DrawRectangle(pen1, topLeftPoint.X, topLeftPoint.Y,
                bottomRightPoint.X - topLeftPoint.X, bottomRightPoint.Y - topLeftPoint.Y);
        }
    }
}
