using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
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
            System.Console.WriteLine("-----Demo Shape----");
            System.Console.WriteLine("1. Add new Crirle");
            System.Console.WriteLine("2. Add new Rectangle");
            System.Console.WriteLine("3. Add new Square");
            System.Console.WriteLine("4. Add new Triangle");
            //System.Console.WriteLine("5. Add new IsoTriangle ");
            //System.Console.WriteLine("6. EqualTrinagle ");
            System.Console.WriteLine("7. Show All");
            System.Console.WriteLine("0. Exit!");
        }
        protected void PrintMenu02()
        {
            System.Console.WriteLine("-----Triangle-----");
            System.Console.WriteLine("1. Add new Nomarlriangle");
            System.Console.WriteLine("2. Add new IsoTriangle ");
            System.Console.WriteLine("3. EqualTrinagle ");
            System.Console.WriteLine("4. Show All");
            System.Console.WriteLine("0. Exit!");

        }
         
        protected override void Process(int choice)
        {
            switch(choice)
            {
              
                case 1: AddCirle(); break;
                case 2: AddRectangle(); break;
                case 3: AddSquare(); break;
                case 4: PrintMenu02();
                      int choice_=Getchoice();
                      AddNormalMenu(choice_);
                    break;
                case 7: ShowAllShapes();break;
                case 0: System.Console.WriteLine("Bye.See you again !");
                break;
                default: System.Console.WriteLine("Invalid Choice.Please Try Again!");
                break;
            }
        }
        protected void AddNormalMenu(int choice)
        {
            switch(choice)
            {
                case 1: AddNormalTriangle(); break;
                case 2: AddIsoTriangle(); break;
                case 3: AddEqualTriangle(); break;
                case 4: ShowAllShapes();break;
                case 0:System.Console.WriteLine("Bye"); break;
                default: System.Console.WriteLine("Invalid choice.Please Try Agian!"); break;
            }
        }
        private void AddIsoTriangle()
        { 
            System.Console.Write("Enter Name: ");
            string name= Console.ReadLine();
            System.Console.Write("Enter Base:");
            double Base=double.Parse(Console.ReadLine());
            System.Console.Write("Enter SideB:");
            double Side=double.Parse(Console.ReadLine());
            shapes.Add(new IsoTriangle(name,Base,Side));


        }
        private void AddEqualTriangle()
        {
            System.Console.Write("Enter Name: ");
            string name= Console.ReadLine();
            System.Console.Write("Enter Side:");
            double side=double.Parse(Console.ReadLine());
            shapes.Add(new EqualTriangle(name,side));
        }
        private void AddNormalTriangle()
        {
            System.Console.Write("Enter Name: ");
            string name= Console.ReadLine();
            System.Console.Write("Enter SideA:");
            double sideA=double.Parse(Console.ReadLine());
            System.Console.Write("Enter SideB:");
            double sideB=double.Parse(Console.ReadLine());
            System.Console.Write("Enter SideC:");
            double sideC=double.Parse(Console.ReadLine());
            shapes.Add(new NormalTriangle(name,sideA,sideB,sideC));


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