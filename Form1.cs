using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_01_Fedorova02
{
    public partial class Form1 : Form
    {
        int w, h;
        int oldX, oldY;
        string figName;
        int [] count = new int[3];
        List<Figure> lst = new List<Figure>();
        Figure createFigure(string figType)
        {
            switch (figType)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                case "Triangle":
                    return new Triangle();
            }
            return null;
        }
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Figure fig in lst)
                fig.selected = false;
            for(int i = lst.Count - 1; i >=0; i--)
            {
                Figure fig = lst[i];
                fig.selected |= fig.test(e.X, e.Y);
                if (fig.selected == true)
                    break;
            }
            picture.Invalidate();
        }
        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int dx = e.X - oldX;
                int dy = e.Y - oldY;
                foreach(Figure fig in lst)
                {
                    if (fig.selected == false)
                        continue;
                    fig.posX += dx;
                    fig.posY += dy;
                }
                picture.Invalidate();
            }
            oldX = e.X;
            oldY = e.Y;
        }
        private void bAddFig_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(cbChooseFigure.Text);
            if (fig == null)
                return;
            fig.posX = picture.Width / 2;
            fig.posY = picture.Height / 2;
            lst.Add(fig);
            count[cbChooseFigure.SelectedIndex]++;
            figName = cbChooseFigure.SelectedItem.ToString() + count[cbChooseFigure.SelectedIndex].ToString();
            lbFigs.Items.Insert(count[cbChooseFigure.SelectedIndex]-1, figName);
            picture.Invalidate();
        }
        private void bDelFig_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i < lst.Count)
            {
                if (lst[i].selected == true)
                    lst.RemoveAt(i);
                i++;
            }
            picture.Invalidate();
        }
        private void picture_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, picture.Width, picture.Height);
            foreach (Figure fig in lst)
                fig.draw(e.Graphics);
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
