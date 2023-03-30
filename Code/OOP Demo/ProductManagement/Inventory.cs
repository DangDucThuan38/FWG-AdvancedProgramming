
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Inventory
    {
        private List<Product> products; //null
        public Inventory()
        {
            products = new List<Product>();//empty list

        }

        public void Import()
        {
            System.Console.Write("Enter product name:");
            string name = Console.ReadLine();

            System.Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            products.Add(p);


        }
        public void Export()
        {
            System.Console.Write("Enter product ID:");
            int ID = int.Parse(Console.ReadLine());
            Product p = FindByID(ID);
            if (p == null) System.Console.WriteLine("Product not found!.Please try again");//p==null or( !p)
            else
            {
                products.Remove(p);
                System.Console.WriteLine("Product Remove!");

            }
        }

        public Product FindByID(int ID)
        {

            //find product with ID & remove

            foreach (Product p in products)
            {
                if (p.ID == ID)
                    return p;
            }
            return null;

        }



        public void ShowProducts()
        {
            System.Console.WriteLine("All products in Iventory");
            foreach (Product p in products)
            {
                p.ShowInfor();
            }
        }
    }
}