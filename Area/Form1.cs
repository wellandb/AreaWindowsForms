using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCircCalc_Click(object sender, EventArgs e)
        {
            string rad = txtRadius.Text;
            double radius = 0;
            try
            {
                radius = Convert.ToDouble(rad);
            }catch {
                MessageBox.Show("Wrong number format for radius");
                return;
                //throw new Exception("Wrong number format for radius");
            }
            double area = Math.PI * Math.Pow(radius, 2);
            lblCircAns.Text = "Area: " + Convert.ToString(area);

            float radiusF = (float)radius;
            Graphics g = pctCirc.CreateGraphics();
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 3);
            g.DrawEllipse(blackPen, pctRec.Width / 2 - (radiusF / 2), 10, radiusF, radiusF);
            g.Dispose();
        }


        private void btnTriCalc_Click(object sender, EventArgs e)
        {
            string sideA = txtTriSideA.Text;
            string sideB = txtTriSideB.Text;
            string sideC = txtTriSideC.Text;
            double a;
            double b;
            double c;
            try
            {
                a = Convert.ToDouble(sideA);
            }
            catch
            {
                MessageBox.Show("Wrong number format for side A");
                return;
                //throw new Exception("Wrong number format for side A");
            }
            try
            {
                b = Convert.ToDouble(sideB);
            }
            catch
            {

                MessageBox.Show("Wrong number format for side B");
                return;
                //throw new Exception("Wrong number format for side B");
            }
            try
            {
                c = Convert.ToDouble(sideC);
            }
            catch
            {

                MessageBox.Show("Wrong number format for side C");
                return;
                //throw new Exception("Wrong number format for side C");
            }
            if(a+b <= c | a + c <= b| c + b <= a)
            {
                MessageBox.Show("These 3 sides don't make a triangle");
                return;
                //throw new Exception("These 3 sides don't make a triangle");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            lblTriAns.Text = "Area: " + Convert.ToString(area);


            float sdeA = Convert.ToSingle(a);
            float sdeB = Convert.ToSingle(b);
            float sdeC = Convert.ToSingle(c);
            Graphics g = pctTri.CreateGraphics();
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 3);
            float x = (float)(Math.Pow(sdeC,2)+ Math.Pow(sdeA, 2)- Math.Pow(sdeB, 2))/(2*sdeA);
            float y = (float)Math.Sqrt(Math.Pow(sdeC, 2) - Math.Pow(Math.Pow(sdeC, 2)+ Math.Pow(sdeA, 2)- Math.Pow(sdeB, 2), 2) /(4* Math.Pow(sdeA, 2)));
            g.DrawPolygon(blackPen, new PointF[] { new Point ((int)(pctRec.Width / 2 - (sdeA / 2)), 10), new Point ((int)(pctRec.Width / 2 + (sdeA / 2)), 10), new Point((int)(pctRec.Width / 2 - (sdeA / 2) + x), (int)(10+y))});
            g.Dispose();
        }

        private void btnRecCalc_Click(object sender, EventArgs e)
        {
            string sideA = txtRecSideA.Text;
            string sideB = txtRecSideB.Text;
            double a;
            double b;
            try
            {
                a = Convert.ToDouble(sideA);
            }
            catch
            {
                MessageBox.Show("Wrong number format for side A");
                return;
                //throw new Exception("Wrong number format for side A");
            }
            try
            {
                b = Convert.ToDouble(sideB);
            }
            catch
            {
                MessageBox.Show("Wrong number format for side B");
                return;
                //throw new Exception("Wrong number format for side B");
            }
            double area = a*b;
            lblRecAns.Text = "Area: " + Convert.ToString(area);
            // Draw rectangle
            float width = Convert.ToSingle(b);
            float height = Convert.ToSingle(a);
            Graphics g = pctRec.CreateGraphics();
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 3);
            g.DrawRectangle(blackPen, pctRec.Width/2 - (width / 2), 10, width, height);
            g.Dispose();
        }

    }
}
