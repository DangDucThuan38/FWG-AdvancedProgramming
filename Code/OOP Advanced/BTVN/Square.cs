using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public class Square:Rectangle
    {
        private double side;
        public double Side
        {
            get{return side;}
            set{side= value;}
        }
        public Square()
        {
           // width=height=side=1.0;
           side=1;
           type="Square";
        }
        public Square(string name,double side):base(name,side,side)
        {
           // side=width=height;
           Side=side;
            type="Square";

        }
    }
}