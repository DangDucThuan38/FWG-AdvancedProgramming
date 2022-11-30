using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public class Circle:Shape
    {
        private double radius;
        public double Radius
        {
            get{return radius;}
            set{radius=value;}

        }
        public Circle()
        {
            radius=2;
        }
        public Circle(string name,double radius ):base(name)
        {
            Radius=radius;
        }
        public override double GetArea()
        {
            return Math.PI*radius*radius;

        }
        public override double GetPerimeter()
        {
            return 2*Math.PI*radius;
        }

        public override void ShowInfor()
        {
            System.Console.WriteLine("Name: "+Name +"| Radius: "+Radius);
            System.Console.WriteLine("Area of Circle: "+GetArea());
            System.Console.WriteLine("Perimeter of Circle: "+GetPerimeter());

        }
    
    }
}