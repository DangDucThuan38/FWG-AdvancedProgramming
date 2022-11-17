using System;

namespace OOPinheriten // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
    //  Point2D p2a = new Point2D(1, 2);
    //  Console.WriteLine(p2a.ToString());  // toString()
    //  Point2D p2b = new Point2D();  // default constructor
    //  Console.WriteLine(p2b.ToString());
    //  // Test Setters and Getters
    //  p2a.X = 3;  // Test setters
    //  p2a.Y = 4;
    //  Console.WriteLine(p2a.ToString());  // toString()
    //  Console.WriteLine("x is: " + p2a.X);
    //  Console.WriteLine("y is: " + p2a.Y);

      /* Test Point3D */
      // Test constructors and toString()
      Point3D p3a = new Point3D(11, 12, 13);
      Console.WriteLine(p3a.ToString());  // toString()
      Point2D p3b = new Point3D();  // default constructor 
      Console.WriteLine(p3b.ToString());
      // Test Setters and Getters
      p3a.X = 21;  // in baseclass
      p3a.Y = 22;  // in baseclass
      p3a.Z = 23;  // in this class
      Console.WriteLine(p3a.ToString());  // toString()
      Console.WriteLine("x is: " + p3a.X);  // in baseclass
      Console.WriteLine("y is: " + p3a.Y);  // in baseclass
      Console.WriteLine("z is: " + p3a.Z);  // in this class


        }
    }
}