using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public class OrDer
    {
        private PayStrategy payStrategy;

        public OrDer(PayStrategy p)
        {
            payStrategy=p;
        }
         public void processOrder(PayStrategy payStrategy) {
          payStrategy.collectPaymentDetails();
        // Here we could collect and store payment data from the strategy.
    }

    }
}