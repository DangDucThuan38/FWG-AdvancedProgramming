using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class PayByCash:IPaymentable
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }

        public PayByCash(string name, string age, string address, string phone)
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