using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double height;


        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle()
        {
            width = height = 2;
        }
        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
        public override double GetPermeter()
        {
            return (width + height) * 2;
        }
        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine("Width: " + Width + ",Height: " + Height);
            System.Console.WriteLine("Area: " + GetArea());
            System.Console.WriteLine("Permeter: " + GetPermeter());
        }
    }
}