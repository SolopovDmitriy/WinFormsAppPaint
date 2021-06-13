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
        public Point topLeftPoint { get; set; }
        public Point bottomRightPoint { get; set; }
        
        public void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
