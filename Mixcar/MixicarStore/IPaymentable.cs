using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public interface IPaymentable
    {
        public void Pay(double total);
    }
}