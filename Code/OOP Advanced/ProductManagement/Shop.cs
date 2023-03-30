using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Shop
    {
        private List<Product> products;

        public Shop()
        {
            products = new List<Product>();
        }
        public void PrintMenu()
        {
            System.Console.WriteLine("1. Add new Product");
            System.Console.WriteLine("2. Sale Product");
            System.Console.WriteLine("0. Quit");
        }

        public int GetChoice()
        {
            System.Console.Write("Your choice:");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
        public void AddNewProduct()
        {
            System.Console.WriteLine("Normal Product or Sale Product? (n/s)");
            string answer = Console.ReadLine();
            Product p = AddProduct();
            if (answer == "n")
            {
                products.Add(p);
            }
            else
            {
                System.Console.Write("Enter  % SaleProduct:");
                int sale = int.Parse(Console.ReadLine());
                SaleProduct s = new SaleProduct(p.Name, p.Price, sale / 100.0);
                products.Add(s);
            }

        }
        public Product AddProduct()
        {
            System.Console.Write("Enter Product Name:");
            string name = Console.ReadLine();
            System.Console.Write("Enter Price:");
            double price = double.Parse(Console.ReadLine());
            Product p = new Product(name, price);
            return p;

        }

        public void SellProduct()
        {
            System.Console.Write("Enter Name Product:");
            string name = System.Console.ReadLine();

            foreach (Product p in products)
            {
                  if(p.Name == name)
                {
                    p.ShowInfor();
                    System.Console.WriteLine("Product " + p.Name + "sold!");
                    return;
                }
            }
            System.Console.WriteLine("Product Not Found!");
        }



        public void Run()
        {
            bool running = true;
           
            while(running)
            {
                PrintMenu();
                int choice= GetChoice();

                if(choice==1) AddNewProduct();
                else if(choice==2) SellProduct();
                else System.Console.WriteLine("Program terminated");

                running = choice !=0;

            }
        }









    }
}