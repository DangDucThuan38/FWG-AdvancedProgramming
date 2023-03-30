using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class PayByEBanking:IPaymentable
    {
       

        private string account;
        public string Account
        {
            get { return account; }
            set
            {
                if (value == "") account = "xxxfpt@edu.vn";
                else account = value;
            }
        }
        private string password;
        private string Password
        {
            get { return password; }
            set
            {
                if (value == "") password = "xxxxxxx";
                else password = value;

            }
        }
        private string verification;
        public string Verification
        {
            get { return verification; }
            set
            {
                if (value == "") verification = "xxxxx";
                else verification = value;
            }
        }
        public PayByEBanking(string account, string password, string verification)
        {
            Account = account;
            Password = password;
            Verification = verification;
        }

        public void Pay(double total)
        {
            System.Console.WriteLine("You have successfully paid for your product with EBaking payment method.");
            System.Console.WriteLine(" _________________________________________");
            System.Console.WriteLine("|*************Luxury Car Store************|");
            System.Console.WriteLine("|                                         |");
            System.Console.WriteLine("|--------------Electronic bill------------|");
            System.Console.WriteLine("|                                         |");
            System.Console.WriteLine("|        Name Account: " + Account + "        |");
            System.Console.WriteLine("|        Password: " + Password + "               |");
            System.Console.WriteLine("|        Verification: " + Verification + "|");
            System.Console.WriteLine("|        Total Money: " + total + "                 |");
            System.Console.WriteLine("|        The money have to pay: " + (total * (100 - 3) / 100) + "     |");
            System.Console.WriteLine(" __________________________________________");
        }
        
    }
}