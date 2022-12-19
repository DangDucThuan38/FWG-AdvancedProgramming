using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class ManagerBookTicket: MenuProgram
    {
        private List<BookTicket> bookTickets;

        public ManagerBookTicket()
        {
            bookTickets= new List<BookTicket>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("---Ticket management system of the company Greenwich---");
            System.Console.WriteLine("            1. Add BookTicket. ");
            System.Console.WriteLine("            2. Search BookTicket. ");
            System.Console.WriteLine("            3. Delete BookTicket ");
            System.Console.WriteLine("            4. Show All infomation BookTicket ");
            System.Console.WriteLine("            0. Exit ");

        }
        protected override void Process(int choice)
        {
            switch(choice)
            {
                case 1: AddBookTicket();
                break;

                case 0: System.Console.WriteLine("You have exited the system.See you again!"); break;

                default: 
                System.Console.WriteLine("0000"); break;
            }
        }

        public void AddBookTicket()
        {
        
            

        }

        public void ShowBookTicket()
        {
            foreach(BookTicket b in bookTickets)
            {
                
            }
        }
    }
}