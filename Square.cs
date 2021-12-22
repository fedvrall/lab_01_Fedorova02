using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Fedorova02
{
    class Square : Figure
    {
        public float side;
        public float halfSide;
        public Square()
        {
        }
        public void set()
        {
            side = 100;
            halfSide = side * 0.5f;
        }

        public override bool test (float x, float y)
        {
            set();
            float xmin = posX - halfSide;
            float ymin = posY - halfSide;
            float xmax = posX + halfSide;
            float ymax = posY + halfSide;
            if (x < xmin || y < ymin)
                return false;
            if (x > xmax || y > ymax)
                return false;
            return true;
        }
        public override void draw(Graphics g)
        {
            set();
            float x0 = posX - halfSide;
            float y0 = posY - halfSide;
            Pen newPen = Pens.Black;
            if (selected)
                newPen = Pens.Red;
            g.DrawRectangle(newPen, x0, y0, side, side);
        }
    }
}
