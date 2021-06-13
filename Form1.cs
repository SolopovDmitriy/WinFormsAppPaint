using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppPaint.Figures;

namespace WinFormsAppPaint
{
    public partial class Form1 : Form
    {
        private List<IFigure> figures;
       
        private IFigure currentFigure;
       


        public Form1()
        {
            InitializeComponent();
            figures = new List<IFigure>();
            Figures.Line line1 = new Figures.Line
            {
                bottomRightPoint = new Point(10, 50),
                topLeftPoint = new Point(100, 200)
            };
            figures.Add(line1);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                currentFigure = new Figures.Line
                {
                    topLeftPoint = e.Location,
                    bottomRightPoint = e.Location
                };
                figures.Add(currentFigure);
            }
           
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(currentFigure != null)
            {
                currentFigure.bottomRightPoint = e.Location;
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            currentFigure = null;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (IFigure figure  in figures)
            {
                figure.draw(g);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }
    }
}
