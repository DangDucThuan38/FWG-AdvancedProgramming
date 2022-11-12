using System;

namespace TicketOOP
{
    public class Customer
    {
        public bool VIP { get; set; }
        public Ticket MyTicket { get; set; }

        public Customer()
        {
            MyTicket = new Ticket();
        }

        public int GetMovieChoice()
        {
            // ask user to enter a choice (1, 2, 3, ..)
            // then return choice
                Console.Write("Your Choice:");
                int choice=int.Parse(Console.ReadLine());
                return choice-1;
        }

        public int GetNumberOfTickets()
        {
            // ask user to enter number of tickets
            // return number
            Console.Write("Enter number of tickets:");
            int nTickets=int.Parse(Console.ReadLine());
            return nTickets;
         
        }

        public string GetSeats(int nTickets)
        {
            // use for loop to ask user enter seats, concat seat to a string
            // return seats string
             string seats = MyTicket.Seats;
            // use for loop to repeat nTickets time, asking 
            for(int i=0;i<nTickets;i++){
                Console.WriteLine("Choose your seats:");
                string seat=Console.ReadLine();
                seats += seat +" ";
            }
            return seats;
        }

        public void SetVIP()
        {
            // ask user if user wants to be VIP or not
            // set VIP property
             System.Console.WriteLine("______________________________");
             Console.Write("Are you Vip member? (y/n):");
             string answer=Console.ReadLine();
             if(answer=="y")
             {
                VIP=true;
             }else if(answer=="n")
             {
                VIP=false;
             }

        } 
        

    }
}