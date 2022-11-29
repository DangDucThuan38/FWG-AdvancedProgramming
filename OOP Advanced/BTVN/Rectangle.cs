using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public class Rectangle:Shape
    {
        protected double width;
        public double Width
        {
            get{return width;}
            set{width=value;}
        }
        protected double height;
        public double Height
        {
            get{return height;}
            set{height=value;}
        }
        public Rectangle()
        {
            height=1;
            width=1;
        }
        public Rectangle(string name,double width,double height):base(name)
        {
            Height=height;
            Width=width;
        }
        public override double GetArea()
        {
            return height*width;

        }
        public override double GetPerimeter()
        {
            return (width+height)/2;
        }

         public override void ShowInfor()
        {
            System.Console.WriteLine("Name: "+Name +"| Width: "+Width+" | Heigh: "+Height);
            System.Console.WriteLine("Area of Rectangle: "+GetArea());
            System.Console.WriteLine("Perimeter of Rectangle: "+GetPerimeter());

        }


    }
}