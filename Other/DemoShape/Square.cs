using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class Square :Rectangle
    {
        private double side;

        public double Side
        {
            get{return side;}
            set{side=value;}
        }
        public Square()
        {
            side=height=width=1;
        }
        public Square(string name,double side) :base(name,side,side)
        {
            side=width=height;

        }

    }
}