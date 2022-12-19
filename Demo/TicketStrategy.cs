using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public abstract class TicketStrategy
    {
        private string start;
        private string end;
        private double length;
        private string seat;
        public string Start
        {
            get { return start; }
            set
            {
                if (start == "") start = "Default";
                else start = value;

            }
        }
        public string End
        {
            get { return end; }
            set
            {
                if (end == "") start = "Default";
                else end = value;

            }
        }
        public string Seat
        {
            get { return seat; }
            set
            {
                if (seat == "") seat = "Default";
                else seat = value;

            }
        }
        public double Length
        {
            get { return length; }
            set
            {
                if (length < 0) length = 1.0;
                else length = value;

            }
        }
        public TicketStrategy(string start, string end, double length, string seat)
        {
            Start = start;
            End = end;
            Length = length;
            Seat = seat;
        }
        public abstract double GetPrice(double price);
        public virtual void ShowTicket()
        {
            System.Console.WriteLine("Start: "+Start);
            System.Console.WriteLine("End : "+End);
            System.Console.WriteLine("Length: "+Length);
            System.Console.WriteLine("Seat: "+Seat);
        }





    }
}