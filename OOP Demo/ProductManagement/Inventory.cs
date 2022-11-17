
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

            //find product with ID & remove
            for (int i = 0; i < products.Count; i++)
            {
                if (ID == products[i].ID)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
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