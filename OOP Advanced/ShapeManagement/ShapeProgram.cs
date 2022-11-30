using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeManagement
{
    public class ShapeProgram :MenuProgram
    {
        private List<Shape> shapes;

        public ShapeProgram()
        {
            shapes=new List<Shape>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add new Crirle");
            System.Console.WriteLine("2. Add new Rectangle");
            System.Console.WriteLine("3. Add new Square");
            System.Console.WriteLine("4. Show All Shapes");
            System.Console.WriteLine("0. Exit!");
        }
        protected override void Process(int choice)
        {
            switch(choice)
            {
              
                case 1: AddCirle(); break;
                case 2: AddRectangle(); break;
                case 3: AddSquare(); break;
                case 4: ShowAllShapes();break;
                case 0: System.Console.WriteLine("Bye.See you again !");
                break;
                default: System.Console.WriteLine("Invalid Choice.Please Try Again!");
                break;
            }
        }

        private void AddCirle()
        {
            System.Console.Write("Enter Name: ");
            string name= Console.ReadLine();
            System.Console.Write("Enter Radius:");
            double radius=double.Parse(Console.ReadLine());
            shapes.Add(new Circle(name,radius));
        }
        private void AddRectangle()
        {
            System.Console.Write("Enter Name: ");
            string name= Console.ReadLine();
            System.Console.Write("Enter Width: ");
            double width= double.Parse(Console.ReadLine());
            System.Console.Write("Enter Height: ");
            double height= double.Parse(Console.ReadLine());
            shapes.Add(new Rectangle(name,width,height));
            
        }
        private void AddSquare()
        {
            System.Console.Write("Enter Name: ");
            string name= Console.ReadLine();
            System.Console.Write("Enter Side: ");
            double side= double.Parse(Console.ReadLine());
            shapes.Add(new Square(name,side));
        }

        private void ShowAllShapes()
        {
            foreach (Shape s in shapes)
            {
                s.ShowInfor();
                System.Console.WriteLine("--------------------------------");
                
            }
        }


        
    }
}