using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public class Creditcard
    {
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string cvv;
        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }

        public Creditcard(string number, string date, string cvv)
        {
            Amount = 100000;
            Number = number;
            Date = date;
            Cvv = cvv;
        }
    }
}