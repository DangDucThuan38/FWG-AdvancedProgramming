using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public class PayByEBanking : IPaymentable
    {
        private const double discount=3;
        private const double percent=100;
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
        public string Banking {get; set;}
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
        public PayByEBanking(string account, string password, string verification,string banking)
        {
            Account = account;
            Password = password;
            Verification = verification;
            Banking = banking;
        }

        public void Pay(double total)
        {
            System.Console.WriteLine("You have successfully paid for your product with EBaking payment method.");
            System.Console.WriteLine(" _____________________________________________");
            System.Console.WriteLine("|****************Mixi Car Store***************|");
            System.Console.WriteLine("|                     *****                   |");
            System.Console.WriteLine("|--------------Card payment invoice-----------|");
            System.Console.WriteLine("|                                             |");
            System.Console.WriteLine("           Name Account: " + Account );
            System.Console.WriteLine("           Name Banking: "+Banking);
            System.Console.WriteLine("           Password: " + Password );
            System.Console.WriteLine("           Verification: " + Verification );
            System.Console.WriteLine("           Total Money: " + total );
            System.Console.WriteLine("           The money have to pay: " + (total * (percent - discount) / percent) );
            System.Console.WriteLine(" ____________________________________________");
        }



    }
}