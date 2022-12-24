using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public class PayByCard : IPaymentable
    {
        private string name;

        private string cardNumber;

        private string date;
        private string verification;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "Default";
                else name = value;
            }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value == "") cardNumber = "xxxxxx58761";
                else cardNumber = value;
            }
        }
        public string Date
        {
            get { return date; }
            set
            {
                if (value == "") date = "28/12/2022";
                else date = value;
            }
        }
        public string Verification
        {
            get { return verification; }
            set
            {
                if (verification == "") verification = "xxx9";
                else verification = value;
            }
        }

        public PayByCard(string name, string cardNumber, string date, string verification)
        {
            Name = name;
            CardNumber = cardNumber;
            Date = date;
            Verification = verification;
        }
        public void Pay(double total)
        {
            System.Console.WriteLine("You have successfully paid for your product with PayCreditCard payment method.");
            System.Console.WriteLine("_____________Luxury Car Store____________");
            System.Console.WriteLine("--------------Bill----------------");
            System.Console.WriteLine("Name CreditCard: " + Name);
            System.Console.WriteLine("Number CreditCard: " + CardNumber);
            System.Console.WriteLine("Date: " + Date);
            System.Console.WriteLine("Verfication: " + Verification);
            System.Console.WriteLine("Total Money: " + total);
            System.Console.WriteLine("|        PayMent: " + (total * (100 - 2) / 100) + "     |");

        }
        public void Add()
        {
            System.Console.Write("Enter Name CreditCard:  ");
            string name = Console.ReadLine();

            System.Console.Write("Enter Number Card: ");
            string cardNumber = Console.ReadLine();

            System.Console.Write("Enter Date: ");
            string date = Console.ReadLine();

            System.Console.Write("Enter Code Verification: ");
            string verification = Console.ReadLine();

            PayByCard card= new PayByCard(name,cardNumber,date,verification);



        }


    }
}