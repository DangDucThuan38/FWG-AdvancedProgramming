using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class BookTicket
    {
        protected static int count = 100;
        protected int id;
        // + ID : get (return "GCH" + id)
        public double Price {get ; set ;}
        public int ID
        {
            get { return id; }
        }
        //private TicketStrategy ticket;
        //private Customer customer;
     
        private TicketStrategy ticket;

        public BookTicket(double price,TicketStrategy t)
        {
            //ticket = t;
            Price=price;
            ticket = t;
            id = ++count;
        }
        public void AddCustomer()
        {
            System.Console.Write("Name Customer: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            System.Console.WriteLine("Gender: ");
            string gender = Console.ReadLine();
            System.Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Address: ");
            string address = Console.ReadLine();

        }
        public void AddTicket()
        {
            System.Console.WriteLine("Enter departure point:");
            string start = Console.ReadLine();
            System.Console.WriteLine("Enter destination: ");
            string end = Console.ReadLine();
            System.Console.WriteLine("Range: ");
            double length = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Seat: ");
            string seat = Console.ReadLine();
          //  ticket= new TicketStrategy( start,end,length,seat);
        }

        public void ShowInfor(Customer c, TicketStrategy t)
        {
            System.Console.WriteLine("Name: " + c.Name);
            System.Console.WriteLine("Age: " + c.Age);
            System.Console.WriteLine("Address: " + c.Address);
            System.Console.WriteLine("Gender: " + c.Gender);
            System.Console.WriteLine("Email: " + c.Email);
            System.Console.WriteLine("Deprature point: " + t.Start);
            System.Console.WriteLine("End: " + t.End);
            System.Console.WriteLine("Khoang  Canh: " + t.Length);
            System.Console.WriteLine("Seta: " + t.Seat);

        }

        public double GetPromotedPrice()
        {
            return ticket.GetPrice(Price);
        }



    }
}