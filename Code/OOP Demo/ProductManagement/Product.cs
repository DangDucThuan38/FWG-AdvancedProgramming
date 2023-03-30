using System;


namespace ProductManagement
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "No Name";
                else name = value;
            }


        }

        public int Price { get; set; }  // no attribute
        private static int count = 0;

        private int id;
        public int ID // Read Only
        {
            get { return id; }
        }
        public Product()
        {
            Name = "No Name";
            Price = 0;
            id = ++count;
        }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            id = ++count;
        }

        public void ShowInfor()
        {
            System.Console.WriteLine("ID: " + ID + " | Name product: " + Name + " | Price of product: " + Price + "$");

        }



    }
}