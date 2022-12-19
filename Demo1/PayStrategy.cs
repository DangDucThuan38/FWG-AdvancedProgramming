using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public abstract class PayStrategy
    {
       public abstract double pay(int paymentAmount);
       public abstract void collectPaymentDetails();
    } 
    
}