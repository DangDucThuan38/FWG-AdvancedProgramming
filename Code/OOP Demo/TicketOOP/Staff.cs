using System;


namespace TicketOOP
{
    public class Staff
    {
        private int PRICE = 10;//Giá của cố định của một bộ phim
        private double VIP_REDUCE = 0.25;// Giảm giá người mua là VIP

        private string[] movies = { "Black Adam", "Black Pather 2", "Detective Conan","Avatar","Fast & Furious 7","Avengers: Endgame"};
        public void PrintMovies(string[] movies)
        {
            Console.WriteLine("List of movies:");

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + movies[i]);
            }
        }
        public void PrintTicket(Ticket t)
        {
            // print ticket attributes (movie, seats, number)
            Console.WriteLine("------Ticket-----");
            Console.WriteLine("Movie name: " + t.Movie);
            Console.WriteLine("Seats: " + t.Seats);
            Console.WriteLine("Number of tickets: " + t.Number);
        }
        public void PrintInvoice(Customer c)
        {
            // calculate payment based customer's ticket & vip
            double payment = c.MyTicket.Number * PRICE;
            if (c.VIP==true) payment -= payment * VIP_REDUCE;
            System.Console.WriteLine("The amount you have to pay is=" + payment+"$");
        }

        public bool IsSellingContinue()
        {
           
            Console.Write("Do you want to continue buying tickets? (y/n): ");
            string select = Console.ReadLine();
            bool selling=select == "y";
            return selling;

        }

        public void SellTickets()
        {
            bool selling = true;
            while (selling)
            {
                PrintMovies(movies);

                Customer c = new Customer();
                int choice = c.GetMovieChoice(movies.Length);
                int nTickets = c.GetNumberOfTickets();
                string seats = c.GetSeats(nTickets);
                string movie = movies[choice];

                Ticket t = new Ticket(movie, seats, nTickets);
                
                PrintTicket(t);

                c.MyTicket = t;

                 c.SetVIP();

                PrintInvoice(c); 
                selling=IsSellingContinue();
            }
            System.Console.WriteLine("Thank you for using the service!See you again");
        }
    }

}