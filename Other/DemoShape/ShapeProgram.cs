using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public class ShapeProgram:MenuProgram
    {
        private List<Shape> shapes;

        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("---Demo Shape---");
            System.Console.WriteLine("1. Add new Cricle");
            System.Console.WriteLine("2. Add new Rectangle ");
            System.Console.WriteLine("3. Add new Square ");
            System.Console.WriteLine("4. Show All Result");
            System.Console.WriteLine("0. Exit ");

        }

        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddCircle(); break;
                case 2: AddRectangle(); break;
                case 3: AddSquare(); break;
                case 4: ShowAll(); break;
                case 0: System.Console.WriteLine("Bye Bye"); break;
                default: System.Console.WriteLine("Invalid Choice. Please Try Again!");break;
            }

        }
        public void AddCircle()
        {
            System.Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            shapes.Add(new Circle(name, radius));
        }
        public void AddRectangle()
        {
            System.Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());
            System.Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name,width,height));
        }
        public void AddSquare()
        {
            System.Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Side: ");
            double side = double.Parse(Console.ReadLine());
          
            shapes.Add(new Square(name,side));

        }
        public void ShowAll()
        {
            foreach(Shape s in shapes)
            {
                s.ShowInfor();
                System.Console.WriteLine("________________________");
            }

        }
    }

}