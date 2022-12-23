using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class PayByCreditCard
    {
          public string Name { get; set; }
        public string Date { get; set; }
        public string Cvv { get; set; }
        public string CardNumber { get; set; }

        public PayByCreditCard(string name, string date, string cvv, string cardNumber)
        {
            Name = name;
            Date = date;
            Cvv = cvv;
            CardNumber = cardNumber;
        }
        public void Pay(double amount)
        {
            System.Console.WriteLine("You have successfully paid for your product with PayCreditCard payment method.");
            System.Console.WriteLine("_____________Luxury Car Store____________");
            System.Console.WriteLine("--------------Electronic bill----------------");
            System.Console.WriteLine("Name CreditCard: " + Name);
            System.Console.WriteLine("Number CreditCard: " + CardNumber);
            System.Console.WriteLine("Date: " + Date);
            System.Console.WriteLine("Cvv: " + Cvv);
            System.Console.WriteLine("Total Money: " + amount);
            System.Console.WriteLine("Total Money: " + amount);
            System.Console.WriteLine("|        PayMent: " + (amount * (100 - 2) / 100) + "     |");

        }
        public void Add()
        {

        }
    }
}