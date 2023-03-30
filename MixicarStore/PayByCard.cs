using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public class PayByCard : IPaymentable
    {
        private const double discount=2;
        private const double percent=100;

        private string cardholder;
        private string namecard;
        private string cardNumber;
        private string date;
        private string cvv;

        public string Cardholder
        {
            get { return cardholder; }
            set
            {
                if (cardholder == "") cardholder = "Nguyen Van XXX";
                else cardholder = value;
            }
        }
        public string Namecard
        {
            get { return namecard; }
            set
            {
                if (value == "") namecard = "Default";
                else namecard = value;
            }
        }
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value == "") cardNumber = "xxxxxx58761";
                else cardNumber = value;
            }
        }
        public string Date
        {
            get { return date; }
            set
            {
                if (value == "") date = "28/12/2022";
                else date = value;
            }
        }
        public string CVV
        {
            get { return cvv; }
            set
            {
                if (cvv == "") cvv = "xxx9";
                else cvv = value;
            }
        }

        public PayByCard(string cardholder, string namecard, string cardNumber, string date, string cvv)
        {
            Cardholder = cardholder;
            Namecard = namecard;
            CardNumber = cardNumber;
            Date = date;
            CVV = cvv;
        }
        public void Pay(double total)
        {
            HeadBill(); 
             System.Console.WriteLine("You have successfully paid for your product with Credit Card payment method.");
            System.Console.WriteLine(" _________________________________________");
            System.Console.WriteLine(" _________________________________________");
            System.Console.WriteLine("|****************Mixi Car Store***************|");
            System.Console.WriteLine("|                     *****                   |");
            System.Console.WriteLine("|--------------Card payment invoice-----------|");
            System.Console.WriteLine("|                                             |");
            System.Console.WriteLine("           Card Holder: " + Cardholder );
            System.Console.WriteLine("           Name Card: " + Namecard );
            System.Console.WriteLine("           Number Card: " + CardNumber);
            System.Console.WriteLine("           Date Valid: " + Date );
            System.Console.WriteLine("           CVV: " + CVV );
            System.Console.WriteLine("           Total Money: " + total );
            System.Console.WriteLine("           The money have to pay: " + (total * (percent - discount) / percent) );
            System.Console.WriteLine(" _____________________________________________");
        }
        public void HeadBill()
        {
          
        }



    }
}