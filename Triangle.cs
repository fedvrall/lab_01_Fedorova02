using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Fedorova02
{
    class Triangle : Figure
    {
        public float side;
        public PointF[] points = new PointF[3];
        public Triangle()
        {
        }

        public void set()
        {
            side = 100.0f;
        }

        override public bool test(float x, float y)
        {
            float a = (points[0].X - x) * (points[1].Y - points[0].Y) - (points[1].X - points[0].X) * (points[0].Y - y);
            float b = (points[1].X - x) * (points[2].Y - points[1].Y) - (points[2].X - points[1].X) * (points[1].Y - y);
            float c = (points[2].X - x) * (points[0].Y - points[2].Y) - (points[0].X - points[2].X) * (points[2].Y - y);
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0))
                return true;
            else 
                return false;
        }

        public override void draw(Graphics g)
        {
            set();
            points[0].X = posX;
            points[0].Y = posY;
            points[1].X = (float)(posX + side * -Math.Cos(0));
            points[1].Y = (float)(posY + side * -Math.Sin(0));
            points[2].X = (float)(posX + side * -Math.Cos(Math.PI / 3));
            points[2].Y = (float)(posY + side * -Math.Sin(Math.PI / 3));
            Pen newPen = new Pen(Color.Black);
            if (selected)
                newPen = Pens.Red;
            g.DrawPolygon(newPen, points);
        }
    }
}
