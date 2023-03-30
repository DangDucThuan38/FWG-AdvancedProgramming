using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FigureSystem
{
    public class Rectangle : Figure
    {
        private int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }

        }
        public Rectangle(int w, int h)
        {
           width=w;
           height=h;
        }
        public override void Draw()
        {
             for (int i = 0; i <= Height; i++)
            {
                DrawLine(Width);

            }

        }

    }
}