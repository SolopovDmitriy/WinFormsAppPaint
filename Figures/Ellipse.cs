﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppPaint.Figures
{
    class Ellipse : IFigure // элипс
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        
        public void draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
