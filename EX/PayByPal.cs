using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class PayByPal
    {
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value == "") email = "@fpt.edu.vn";
                else email = value;
            }

        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value == "") password = "abxzvch";
                else password = value;

            }
        }

        public PayByPal(string email, string pasword)
        {
            Email = email;
            Password = pasword;
        }
        public void Pay(double amount)
        {
            System.Console.WriteLine("You have successfully paid for your product with PayPal payment method.");
            System.Console.WriteLine(" _________________________________________");
            System.Console.WriteLine("|*************Luxury Car Store************|");
            System.Console.WriteLine("|                                         |");
            System.Console.WriteLine("|--------------Electronic bill------------|");
            System.Console.WriteLine("|                                         |");
            System.Console.WriteLine("|        Name Account: " + Email + "        |");
            System.Console.WriteLine("|        Password: " + Password + "               |");
            System.Console.WriteLine("|        Total Money: " + amount + "                 |");
            System.Console.WriteLine("|        PayMent: " + (amount * (100 - 3) / 100) + "     |");
            System.Console.WriteLine(" __________________________________________");
        }
        public void Add()
        {
            System.Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Password: ");
            string password = Console.ReadLine();
            PayByPal ob = new PayByPal(email, password);


        }

    }
}