using System;


namespace TicketOOP
{
    public class Ticket
    {
        private string movie;
        private string seats;
        private int number;

        // TODO: write properties, default constructor & parameterized constructor
        public string Movie 
        {
            get { return movie; }
            set { movie = value; }
        }
        public string Seats 
        {
            get { return seats; }
            set { seats = value; }
        }
        public int Number 
        {
            get { return number; }
            set { number = value; }
        }
        public Ticket()
        {
            Movie = "";
            Seats = "";
            Number = 1;
        }

        public Ticket(string movie, string seats, int number)
        {
            this.movie=movie;
            this.seats=seats;
            this.number=number;
        }

    
    }
}