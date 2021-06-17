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
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        
        public void draw(Graphics g)
        {
            Pen pen1 = new Pen(Color.Green);
            pen1.Width = 5;
            g.DrawEllipse(pen1, StartPoint.X, StartPoint.Y, EndPoint.X- StartPoint.X, EndPoint.X - StartPoint.X);
            
        }
    }
}
