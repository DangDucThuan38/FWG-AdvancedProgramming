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

        public double Total()
        {
            double sum = 0;
            foreach (Car c in cars)
            {
                sum += c.Price;
            }
            return sum;
        }

        // Hàm thanh toán chuyền vào tổng số tiền và giảm giá tuy theo cách phương thức thanh toán
        public void pay(IPaymentable paymentable)
        {
            foreach (Car car in cars)
            {
                car.Show();
            }
            double amount = Total();
            paymentable.Pay(amount);
        }


        // Xóa Car bằng cách nhập tên car muốn xóa
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
            System.Console.WriteLine("Please Choose method Payment");
            System.Console.WriteLine("1. Payment in cash");
            System.Console.WriteLine("2. Payment in PayPal");
            System.Console.WriteLine("3. Payment in Credit Card");
            System.Console.WriteLine("0. Exit Payment");
        }

        protected void ChoosePayment(int choice)
        {
            switch (choice)
            {
                case 1:// Thực hiện nhập thông tin và in ra đối với thanh toán bằng tiền mặt

                    break;
                case 2:// Thực hiện nhập tin của phương thức PayPal và in ra

                    break;
                case 3:// Thực hiện nhập thông tin của phương thức Credit card và in ra

                    break;
                case 0: System.Console.WriteLine("Exit Payment"); break;
                default: System.Console.WriteLine("Invalid choice.Please Try Agian!"); break;
            }
        }
    }
}