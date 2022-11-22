using System;

namespace ProductManagement // Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            //Product p1=new Product();
            //p1.ShowInfor();
            //SaleProduct s1=new SaleProduct("Apple",5.9,0.5);
            //s1.ShowInfor();


            bool running = true;
            Shop s1=new Shop();
            while(running)
            {
                s1.PrintMenu();
                int choice=s1.GetChoice();

                if(choice==1) s1.AddNewProduct();
                else if(choice==2) s1.SellProduct();
                else System.Console.WriteLine("Program terminated");

                running = choice !=0;

            }




        }
    }
}
