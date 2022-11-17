using System;

namespace TicketOOP
{
    public class Customer
    {
        private int MIN_TICKET = 1;
        private int MAX_TICKET = 5;
        public bool VIP { get; set; }
        public Ticket MyTicket { get; set; }

        public Customer()
        {
            MyTicket = new Ticket();
        }

        public int GetMovieChoice(int maxChoice)

        {
            bool invalidChoice = true;
            int choice = 0;
            while (invalidChoice)
            {
                // ask user to enter a choice (1, 2, 3, ..)
                // then return choice
                Console.Write("Your Choice:");
                choice = int.Parse(Console.ReadLine());
                invalidChoice = (choice < 1) || (choice > maxChoice);
                if (invalidChoice) System.Console.WriteLine("Invalid Choice! Again!");
            }
            return choice;

        }



        public int GetNumberOfTickets()
        {
            // ask user to enter number of tickets
            // return number
            bool invalidNumberofTicket = true;
            int nTickets = 1;
            while (invalidNumberofTicket)
            {
                Console.Write("Enter number of tickets:");
                nTickets = int.Parse(Console.ReadLine());
                invalidNumberofTicket = (nTickets < MIN_TICKET) || (nTickets > MAX_TICKET);
                if (invalidNumberofTicket)
                    System.Console.WriteLine("Number must be in [1,5].Try again");


            }

            return nTickets;

        }

        public string GetSeats(int nTickets)
        {
            // use for loop to ask user enter seats, concat seat to a string
            // return seats string
            string seats = MyTicket.Seats;
            // use for loop to repeat nTickets time, asking 
            for (int i = 0; i < nTickets; i++)
            {
                Console.WriteLine("Choose your seats:");
                string seat = Console.ReadLine();
                seats += seat + " ";
            }
            return seats;
        }

        public void SetVIP()
        {
            // ask user if user wants to be VIP or not
            // set VIP property
            System.Console.WriteLine("______________________________");
            Console.Write("Are you Vip member? (y/n):");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                VIP = true;
            }
            else if (answer == "n")
            {
                VIP = false;
            }

        }

        internal int GetMovieChoice()
        {
            throw new NotImplementedException();
        }
    }
}