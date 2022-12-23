using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class PayByCreditCard
    {
        public string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "Default Name";
                else name = value;
            }

        }
        private string date;
        public string Date
        {
            get { return date; }
            set
            {
                if (value == "")
                    System.Console.WriteLine("Date invalid");
                else date = value;
            }
        }
        private string cvv;
        public string Cvv
        {
            get { return cvv; }
            set
            {
                if (value == "") cvv = "Default Cvv";
                else cvv = value;
            }
        }
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value == "") cardNumber = "Default Card Number";
                else cardNumber = value;
            }

        }

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
            System.Console.Write("Enter Name CreditCard: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Enter Card Number: ");
            string cardNumber = System.Console.ReadLine();
            System.Console.Write("Enter Date of Card: ");
            string date = System.Console.ReadLine();
            System.Console.Write("Enter verification code: ");
            string cvv = System.Console.ReadLine();

            PayByCreditCard pay = new PayByCreditCard(name, date, cvv, cardNumber);

        }
    }
}