using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
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
            radius=1;
        }
        public Circle(string name,double radius):base(name)
        {
            Radius=radius;
        }
        public override double GetArea()
        {
            return Math.PI *radius*radius;
        }
        public override double GetPermeter()
        {
            return Math.PI *radius*2;
        }
        public override void ShowInfor()
        {
           base.ShowInfor();
            System.Console.WriteLine("Radius: "+radius);
            System.Console.WriteLine("Area: "+GetArea());
            System.Console.WriteLine("Permeter: "+GetPermeter());
        }


    }
}