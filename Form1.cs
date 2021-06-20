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
        private Color figureColor;
        private IFigure currentFigure;
        private int figureThickness;


        public Form1()
        {
            InitializeComponent();
            figureColor = Color.Black;
            figureThickness = 5;

            string[] names = {nameof(EquilateralTriangle), "Circle", nameof(Figures.Rectangle), nameof(Ellipse), nameof(RightTriangle), nameof(IsoscelesTriangle), nameof(Line)};
            toolStripComboBoxFigures.Items.AddRange(names);

            string[] thicknessNames = { "1", "3", "5" };
            toolStripComboBoxThickness.Items.AddRange(thicknessNames);

            toolStripComboBoxThickness.SelectedIndex = 2;
            toolStripComboBoxFigures.SelectedIndex = 0;

            figures = new List<IFigure>();
            //Figures.RightTriangle rightTriangle = new Figures.RightTriangle
            //{
            //    EndPoint = new Point(10, 50),
            //    StartPoint = new Point(100, 200)               
            //};
            //figures.Add(rightTriangle);
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
                if(toolStripComboBoxFigures.Text == "IsoscelesTriangle")
                {
                    currentFigure = new Figures.IsoscelesTriangle();
                }
                if (toolStripComboBoxFigures.Text == "Rectangle")
                {
                    currentFigure = new Figures.Rectangle();
                }
                if (toolStripComboBoxFigures.Text == "Line")
                {
                    currentFigure = new Figures.Line();
                }
                if (toolStripComboBoxFigures.Text == "Ellipse")
                {
                    currentFigure = new Figures.Ellipse();
                }
                if (toolStripComboBoxFigures.Text == "Circle")
                {
                    currentFigure = new Figures.Circle();
                }
                if (toolStripComboBoxFigures.Text == nameof(RightTriangle))
                {
                    currentFigure = new Figures.RightTriangle();
                }

                if (toolStripComboBoxFigures.Text == nameof(EquilateralTriangle))
                {
                    currentFigure = new Figures.EquilateralTriangle();
                }

                currentFigure.Color = figureColor;
                currentFigure.Thickness = figureThickness;
                currentFigure.StartPoint = e.Location;
                currentFigure.EndPoint = e.Location;               
                figures.Add(currentFigure);
            }
           
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(currentFigure != null)
            {
                currentFigure.EndPoint = e.Location;
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
            foreach (IFigure figure in figures)
            {
                figure.Draw(g);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }

        private void toolStripMenuItemColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                figureColor = colorDialog1.Color;
            }
        }

        private void toolStripComboBoxThickness_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(toolStripComboBoxThickness.Text, out figureThickness);
        }
    }
}
