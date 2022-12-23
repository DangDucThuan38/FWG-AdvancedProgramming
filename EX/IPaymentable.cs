using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public interface IPaymentable
    {
        public void Pay(double amount);
    }

}