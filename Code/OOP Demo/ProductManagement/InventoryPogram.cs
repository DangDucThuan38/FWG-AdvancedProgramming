using System;


namespace ProductManagement
{
    public class InventoryPogram
    {
        private Inventory myInventory;

        public InventoryPogram()
        {
            myInventory = new Inventory();
        }
        public void Run()
        {

            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                running = Process(choice);
               

            }
        }
        public void PrintMenu()
        {
            System.Console.WriteLine("1. Import Product");
            System.Console.WriteLine("2. Export Product");
            System.Console.WriteLine("3. Show all products");
            System.Console.WriteLine("0.Exit");
        }
        public int GetChoice()
        {
            System.Console.Write("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public bool Process(int choice)
        {
            bool running=true;
            switch (choice)
            {
                case 1:
                    myInventory.Import();
                    break;
                case 2:
                    myInventory.Export();
                    break;
                case 3:
                    myInventory.ShowProducts();
                    break;
                case 0:
                running=false;
                break;

                default:
                    System.Console.WriteLine("Your choice invalid.Please choose again");
                    break;

            }
            return running;

        }
        //private bool IsContinue()
        //{
        //    System.Console.Write("Continue (y/n): ");
        //    string choice = Console.ReadLine();
        //    return choice == "y";
        //}


    }
}