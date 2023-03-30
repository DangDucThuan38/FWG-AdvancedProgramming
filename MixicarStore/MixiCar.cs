using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public class MixiCar : MenuProgram
    {
        private List<Car> cars;

        public MixiCar()
        {
            cars = new List<Car>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine(" ___________________________________________");
            System.Console.WriteLine("|      -------------MixiCar--------------   |");
            System.Console.WriteLine("|         1. Buy Car with Cash              |");
            System.Console.WriteLine("|         2. Buy Car with CreditCard        |");
            System.Console.WriteLine("|         3. Buy Car with E-banking         |");
            System.Console.WriteLine("|         4. Clear purchase history         |");
            System.Console.WriteLine("|         0. Exit Program                   |");
            System.Console.WriteLine("|___________________________________________|");
        }

        public double Total()
        {
            double sum = 0;
            foreach (Car car in cars)
            {
                sum += car.Price;
            }
            return sum;
        }
        public void ChangePay(IPaymentable paymentable)
        {
            double total = Total();
            paymentable.Pay(total);
        }
        public void Show()
        {
            foreach (Car car in cars)
            {
                car.Show();
            }
        }
        public void RemoveCar()
        {
            cars.Clear();
            System.Console.WriteLine("Delete history Succefully.!");

        }
        protected override void Process(int choice)
        {

            switch (choice)
            {
                case 1:
                    IPaymentable cash = AddinforCash();
                    AddCar();
                    Show();
                    ChangePay(cash); break;
                case 2:
                    IPaymentable card = AddinforCard();
                    AddCar();
                    Show();
                    ChangePay(card); break;
                case 3:
                    IPaymentable ebanking = AddinforBanking();
                    AddCar();
                    Show();
                    ChangePay(ebanking);
                    break;
                case 4: RemoveCar(); break;
                //case 4: PrintMenu2(); int choice_ = Getchoice(); ChoosePayment(choice_); break;
                case 0: System.Console.WriteLine("You Exited Program.Bye See You Again !"); break;

                default: System.Console.WriteLine("Invalid choice"); break;
            }

        }
        // Thêm sản phẩm là car 
        public void AddCar()
        {
            
                System.Console.WriteLine("--- Please Enter Information of Car ---");
                System.Console.Write("Enter Name Product: ");
                string name = Console.ReadLine();
                System.Console.Write("Enter Description: ");
                string description = Console.ReadLine();
                System.Console.Write("Date of manufacture: ");
                string date = Console.ReadLine();
                System.Console.Write("Enter Made In:");
                string made = System.Console.ReadLine();
                double price = ReadDouble("Enter Price: ");
                System.Console.Write("Enter Power:");
                string power = Console.ReadLine();
                cars.Add(new Car(name, price, made, description, power, date));

        }

        public double ReadDouble(string get)
        {
            bool invalid = true;
            double x = 0;
            while (invalid)
            {
                try
                {
                    Console.Write(get);
                    x = int.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Input Valid .Please try Again.!");
                }
            }
            return x;

        }


        public int ReadInt(string get)
        {
            bool invalid = true;
            int n = 0;
            while (invalid)
            {
                try
                {
                    Console.Write(get);
                    n = int.Parse(Console.ReadLine());
                    invalid = false;
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("Input Valid .Please try Again.!");
                }
            }
            return n;

        }


        public IPaymentable AddinforCard()
        {

            System.Console.WriteLine("Please Enter information for Method Payment Card:");
            System.Console.Write("Enter CardHolder: ");
            string cardholder = Console.ReadLine();
            System.Console.Write("Enter Name CreditCard:  ");
            string namecard = Console.ReadLine();
            System.Console.Write("Enter Number Card: ");
            string cardNumber = Console.ReadLine();
            System.Console.Write("Enter Date: ");
            string date = Console.ReadLine();
            System.Console.Write("Enter Code Password: ");
            string cvv = Console.ReadLine();
            IPaymentable card = new PayByCard(cardholder, namecard, cardNumber, date, cvv);
            return card;


        }
        private IPaymentable AddinforCash()
        {
            System.Console.WriteLine("Please Enter information for Method Payment Cash:");
            System.Console.Write("Enter Name Customer:");
            string name = Console.ReadLine();
            int age = ReadInt("Enter Age: ");
            System.Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            System.Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            IPaymentable cash = new PayByCash(name, age, address, phone);
            return cash;

        }
        private IPaymentable AddinforBanking()
        {
            System.Console.WriteLine("Please Enter information for Method Payment E-banking:");
            System.Console.Write("Enter Account: ");
            string account = Console.ReadLine();
            System.Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            System.Console.Write("Enter Name Banking:");
            string banking = enter();
            System.Console.Write("Enter Code Verification: ");
            string verification = Console.ReadLine();
            IPaymentable ebanking = new PayByEBanking(account, password, verification, banking);
            return ebanking;
        }
        public string enter()
        {
            string banking = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("Techcombank, MBBank ,SacomBank: ");
                banking = Console.ReadLine();
                validChoice = banking == "TechcomBank" || banking == "MBBank"
                                                   || banking == "SacomBank";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid Banking. Please try again.");
                }
            }
            return banking;
        }

    }
}