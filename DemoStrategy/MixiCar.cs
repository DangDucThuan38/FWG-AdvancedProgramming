using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class MixiCar: MenuProgram
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
            System.Console.WriteLine("|         1. Enter Product                  |");
            System.Console.WriteLine("|         2. Show Information products      |");
            System.Console.WriteLine("|         3. Remove Product                 |");
            System.Console.WriteLine("|         4. Choose Method to Payment       |");
            System.Console.WriteLine("|         0. Exit Program                   |");
            System.Console.WriteLine("|___________________________________________|");
        }

        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddCar(); break;
                case 2: Show(); break;
                case 3: RemoveCar(); break;
                case 4: PrintMenu2(); int choice_ = Getchoice(); ChoosePayment(choice_); break;
                case 0: System.Console.WriteLine("You Exited Program.Bye See You Again !"); break;
                default: System.Console.WriteLine("Invalid choice"); break;
            }
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

        public void RemoveCar()
        {
            System.Console.WriteLine("Please Enter Code Product: ");
            string code = Console.ReadLine();
            foreach (Car car in cars)
            {
                if (car.CodeCar == code)
                {
                    cars.Remove(car);
                    System.Console.WriteLine("Delete Product successfully.!");
                    return;
                }
            }
        }
        // Thêm sản phẩm là car 
        public void AddCar()
        {
            System.Console.WriteLine("--- Please Enter Information of Car ---");
            System.Console.Write("Enter Code of Car: ");
            string codecar = Console.ReadLine();
            System.Console.Write("Enter Name Product: ");
            string name = Console.ReadLine();
            System.Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            System.Console.Write("Date of manufacture: ");
            string date = Console.ReadLine();
            System.Console.Write("Enter Made In:");
            string made = System.Console.ReadLine();
            System.Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            System.Console.Write("Enter Power:");
            string power = Console.ReadLine();
            cars.Add(new Car(codecar, name, price, made, description, power, date));
        }

        // nhập sản phẩm vào list car dây mà

        public void Show()
        {

            foreach (Car car in cars)
            {
                car.Show();
            }

        }
        //Menu con khi nhấn chọn Phương thức thanh toán
        protected void PrintMenu2()
        {
            System.Console.WriteLine(" _________________________________");
            System.Console.WriteLine("|   Please Choose method Payment  |");
            System.Console.WriteLine("|        1. Payment in Cash       |");
            System.Console.WriteLine("|        2. Payment in Card       |");
            System.Console.WriteLine("|        3. Payment in E-Banking  |");
            System.Console.WriteLine("|        0. Exit Payment          |");
            System.Console.WriteLine("|_________________________________|");
        }

        protected void ChoosePayment(int choice)
        {

            switch (choice)
            {
                case 1: PayCash(); break;
                case 2: PayCard(); break;
                case 3: PayEbanking(); break;
                case 0: System.Console.WriteLine("Exit Payment"); break;
                default: System.Console.WriteLine("Invalid choice.Please Try Agian!"); break;
            }
        }

        private void PayCash()
        {
            System.Console.Write("Enter Name Customer:");
            string name = Console.ReadLine();
            System.Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            System.Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();
            IPaymentable cash = new PayByCash(name, age, address, phone);
            System.Console.WriteLine("------------------------------------");
            Show();
            ChangePay(cash);

        }

        private void PayCard()
        {
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
            System.Console.WriteLine("------------------------------");
            Show();
            ChangePay(card);
        }

        private void PayEbanking()
        {
            System.Console.Write("Enter Account: ");
            string account = Console.ReadLine();
            System.Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            System.Console.Write("Enter");
            string verification = Console.ReadLine();
            IPaymentable ebanking = new PayByEBanking(account, password, verification);
            System.Console.WriteLine("-------------------------");
            Show();
            ChangePay(ebanking);
        }
       
    }
}