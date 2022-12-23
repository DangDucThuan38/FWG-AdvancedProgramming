using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class PayByCash : IPaymentable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "Customer Default";
                else name = value;
            }

        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100) age = 18;
                else age = value;
            }

        }
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (value == "") address = "HN";
                else address = value;
            }

        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == "") phone = "0988899xxx";
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
            System.Console.WriteLine("_____________Mixi Car Store____________");
            System.Console.WriteLine("--------------Cash payment invoice----------------");
            System.Console.WriteLine("Name Customer: " + Name);
            System.Console.WriteLine("Age: " + Age);
            System.Console.WriteLine("Address: " + Address);
            System.Console.WriteLine("Phone Number: " + Phone);
            System.Console.WriteLine("Total Money: " + amount);
            System.Console.WriteLine("|        PayMent: " + (amount * (100 + 2) / 100) + "     |");

        }
        public void Add()
        {

        }
    }
}