using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_01_Fedorova02
{
    class Figure
    {
        public float posX, posY;
        public bool selected;

        virtual public bool test(float x, float y)
        {
            return false;
        }
        virtual public void draw(Graphics g)
        {

        }
    }
}
