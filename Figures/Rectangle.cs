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
        public Color Color { get; set; }
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public int Thickness { get; set; }

        public void Draw(Graphics g)
        {
            Pen pen1 = new Pen(Color);
            pen1.Width = Thickness;

            if (StartPoint.X <= EndPoint.X && StartPoint.Y <= EndPoint.Y)
            {
                g.DrawRectangle(pen1, StartPoint.X, StartPoint.Y,
                EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
            }
            else if (StartPoint.X > EndPoint.X && StartPoint.Y <= EndPoint.Y)
            {
                g.DrawRectangle(pen1, EndPoint.X, StartPoint.Y,
                StartPoint.X - EndPoint.X, EndPoint.Y - StartPoint.Y);
            }
            else if (StartPoint.X <= EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                g.DrawRectangle(pen1, StartPoint.X, EndPoint.Y,
                EndPoint.X - StartPoint.X, StartPoint.Y - EndPoint.Y);
            }
            else if (StartPoint.X > EndPoint.X && StartPoint.Y > EndPoint.Y)
            {
                g.DrawRectangle(pen1, EndPoint.X, EndPoint.Y,
                StartPoint.X - EndPoint.X, StartPoint.Y - EndPoint.Y);
            }

        }


        //public void draw(Graphics g)
        //{
        //    Pen pen1 = new Pen(Color.Green);
        //    pen1.Width = 5;
        //    //g.DrawRectangle(pen1, topLeftPoint.X, topLeftPoint.Y,
        //    //    bottomRightPoint.X, bottomRightPoint.Y);

        //    g.DrawRectangle(pen1, StartPoint.X, StartPoint.Y,
        //        EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y);
        //}
    }
}




