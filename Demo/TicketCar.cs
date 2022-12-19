using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class TicketCar:TicketStrategy
    {
        public TicketCar(string start,string end,double length,string seat):base(start,end,length,seat)
        {

        }
        public override double GetPrice(double price)
        {
            return price+ 5.5;
        }
        public override void ShowTicket()
        {
            base.ShowTicket();
            System.Console.WriteLine();
        }
    }
}