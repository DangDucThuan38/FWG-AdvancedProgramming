using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public class PayByPayPal : PayStrategy
    {
       private PayPal payPal;
       private const double money=10000.0;

       public PayByPayPal(PayPal p)
       {
        payPal=p;
       }

      public override void collectPaymentDetails()
      {
        System.Console.WriteLine("Enter Email user's: ");
        string email= Console.ReadLine();
        System.Console.WriteLine("PassWord: ");
        string password= Console.ReadLine();

        payPal= new PayPal(email,password);
      }
      public override double pay(int paymentAmount)
      {
        return money- paymentAmount;

      }




    }
}