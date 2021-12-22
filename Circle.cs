using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Fedorova02
{
    class Circle : Figure
    {
        public float radius;
        public float radiusSquared;
        public float diameter;
        public Circle ()
        {
        }

        public void set()
        {
            radius = 50.0f;
            radiusSquared = radius * radius;
            diameter = radius * 2.0f;
        }

        override public bool test (float x, float y)
        {
            set();
            float dx = x - posX;
            float dy = y - posY;
            if (dx * dx + dy * dy <= radiusSquared)
                return true;
            return false;
        }

        public override void draw(Graphics g)
        {
            set();
            float x0 = posX - radius;
            float y0 = posY - radius;

            Pen newPen = new Pen(Color.Black);
            if (selected)
                newPen = Pens.Red;
            g.DrawEllipse(newPen, x0, y0, diameter, diameter);
        }
    }
}
