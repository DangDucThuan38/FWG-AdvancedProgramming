using System;


namespace OOPCircle
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return  radius*radius*Math.PI;
        }
        public double Circumference()
        {
            return radius*radius*Math.PI;
        }
        public string ToString()
        {
            return "Circle[" + radius +"]";
        }

    }
}