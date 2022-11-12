using System;

namespace OOPCircle // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1= new Circle(5);
            System.Console.WriteLine(c1.Area());
            System.Console.WriteLine(c1.Circumference());
            System.Console.WriteLine(c1.ToString());
        }
    }
}
