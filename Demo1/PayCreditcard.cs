using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public class PayCreditcard :PayStrategy
    {
        private Creditcard card;

        public override void collectPaymentDetails()
        {
            System.Console.WriteLine("Enter the card number: ");
            string number = Console.ReadLine();
            System.Console.WriteLine("Enter the card expiration date 'mm/yy': ");
            string date = Console.ReadLine();
            System.Console.WriteLine("Enter the CVV code: ");
            string cvv = Console.ReadLine();
            card = new Creditcard(number, date, cvv);
            // Validate credit card number...
        }
        public override double pay(int paymentAmount)
        {
            return card.Amount-paymentAmount;
        }
        
       

    }
}