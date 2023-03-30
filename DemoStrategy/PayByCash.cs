using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class PayByCash:IPaymentable
    {
        private string name;

        private string address;
        private int age;
        private string phone;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "Default Name";
                else name = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (value == "") address = "Default Address";
                else address = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0 || value > 100) age = 22;
                else age = value;

            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == "") phone = "098899xxx";
                else phone = value;
            }
        }
        public PayByCash(string name, int age, string address, string phone)
        {
            Name = name;
            Age = age;
            Address = address;
            Phone = phone;
        }
        public void Pay(double amount)
        {
            System.Console.WriteLine("You have successfully paid for your product with Cash payment method.");
            System.Console.WriteLine(" _________________________________________");
            System.Console.WriteLine("|*************Mixi Car Store************|");
            System.Console.WriteLine("|                                         |");
            System.Console.WriteLine("|--------------Cash payment invoice------------|");
            System.Console.WriteLine("|                                         |");
            System.Console.WriteLine("|        Name Customer: " + Name + "        |");
            System.Console.WriteLine("|        Age: " + Age + "               |");
            System.Console.WriteLine("|        Address: " + Address + "|");
            System.Console.WriteLine("|        Phone Number: " + Phone + "|");
            System.Console.WriteLine("|        Total Money: " + amount + "                 |");
            System.Console.WriteLine("|        The money have to pay: " + (amount * (100 + 2) / 100) + "     |");
            System.Console.WriteLine(" __________________________________________");
        }
    }
}