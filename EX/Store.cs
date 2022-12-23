using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class Store : MenuProgram
    {
        private List<Car> cars;


        public Store()
        {
            cars = new List<Car>();
            // this.paymentable = paymentable;
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("-------------MixiCar--------------");
            System.Console.WriteLine("1. Enter Product");
            System.Console.WriteLine("2. Show Information products");
            System.Console.WriteLine("3. Remove Product");
            System.Console.WriteLine("4. Choose Method to Payment");
            System.Console.WriteLine("0. Exit Program");
        }
        protected override void Process(int choice)
        {

            switch (choice)
            {
                case 1:
                    AddCar();
                    break;
                case 2:
                    Show();
                    break;
                case 3:
                    RemoveCar();
                    break;
                case 4:
                    PrintMenu2();
                    int choice_ = Getchoice();
                    break;

                case 0:
                    System.Console.WriteLine("You Exited Program.Bye See You Again !");
                    break;

                default:
                    System.Console.WriteLine("Invalid choice");
                    break;
            }

        }
        
        protected void ChoosePayment(int choice)
        {
            switch (choice)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 0: System.Console.WriteLine("Exit Payment"); break;
                default: System.Console.WriteLine("Invalid choice.Please Try Agian!"); break;
            }
        }
        protected void PrintMenu2()
        {
            System.Console.WriteLine("Please Choose method Payment");
            System.Console.WriteLine("1. Payment in cash");
            System.Console.WriteLine("2. Payment in PayPal");
            System.Console.WriteLine("3. Payment in Credit Card");
            System.Console.WriteLine("0. Exit Payment");
        }
        public void pay(IPaymentable paymentable)
        {
            foreach (Car car in cars)
            {
                car.Show();
            }
            double amount = Total();
            paymentable.Pay(amount);
        }

        //public void AddPayment(IPaymentable paymentable)
        //{
        //    paymentable.Add();
        //}
        public void RemoveCar()
        {
            System.Console.WriteLine("PleaseEnter Name Product: ");
            string name = Console.ReadLine();
            foreach (Car car in cars)
            {
                if (car.Name == name)
                {
                    cars.Remove(car);
                    System.Console.WriteLine("Delete Product successfully.!");
                    return;
                }
            }
        }


        public void AddCar()
        {
            System.Console.WriteLine("--- Please Enter Information of Car ---");
            System.Console.Write("Enter Code of Product: ");
            string codeProduct = Console.ReadLine();
            System.Console.Write("Enter Name Product: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            System.Console.Write("Enter Made In:");
            string made = System.Console.ReadLine();
            System.Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            System.Console.Write("Enter Power:");
            string power = Console.ReadLine();
            cars.Add(new Car(codeProduct, name, description, made, power, price));

        }

        public double Total()
        {
            double sum = 0;
            foreach (Car c in cars)
            {
                sum += c.Price;
            }
            return sum;
        }

        public void Show()
        {

            foreach (Car car in cars)
            {
                car.Show();
            }

        }

    }
}