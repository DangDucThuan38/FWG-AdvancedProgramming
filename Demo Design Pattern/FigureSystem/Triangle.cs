using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FigureSystem
{
    public class Triangle : Figure
    {
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public Triangle(int h)
        {
            height = h;
        }
        public override void Draw()
        {
            for (int i = 0; i <= Height; i++)
            {
                DrawLine(i);

            }


        }
    }
}