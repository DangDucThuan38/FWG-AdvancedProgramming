
using System;

namespace TicketSelling // Note: actual namespace depends on the project name.
{
    class Program
    { 
        static string[] moives = { "Harry Potter", "The dark knight", "Detective Conan","The Lion King","The Matrix" };
        const int PRICE = 5;
        const double VIP_REDUCE=0.1;
        static void Main(string[] args)
        {
            bool choice= true;
            while (choice)
            {
            PrintMoives(moives);

            //Người dùng chọn phim
            string movie=moives[GetMoive()];

            //Người dùng chọn số lượng vé
            int nTickets=GetNumberOftickets();

            //Người dùng chọn ghế
            string seats=GetSeats(nTickets);

            //Hỏi có phải vip menber ko?
            bool VIP=IsVIPMenber();

            //In ra vé và hóa đơn
            PrinTickets(movie,nTickets,seats);

            PrintInvoice(nTickets,VIP);

            choice= IsContinue();
            }
            Console.WriteLine("Thanks your buy tickets!");
        }
      
        static bool IsContinue(){
             Console.Write("Do you want to continue buying tickets? (y/n): ");
                string select = Console.ReadLine();
                bool choice=select == "y";
                return choice;

        }
        static void PrintMoives(string[] moives)
        {
            Console.WriteLine("List of movies:");
           
            for(int i=0;i<moives.Length;i++)
            {
                Console.WriteLine((i+1)+"."+moives[i]);
            }

        }

        static int GetMoive()
        {
                // int choice=0;
                // bool validChoice=false;
                // while (!validChoice)
                // {
                //      Console.Write("Your Choice:");
                //       choice=int.Parse(Console.ReadLine());
                //           for(int i=0;i<moives.Length;i++)
                //         {
                
                //         }
                
                //      if (!validChoice)
                //     {
                //         Console.WriteLine("Invalid choice. Please try again.");
                //     }
                // }
                //    return choice-1;

                Console.Write("Your Choice:");
                int choice=int.Parse(Console.ReadLine());
                return choice-1;

        }
        static int GetNumberOftickets()
        {
            Console.Write("Enter number of tickets:");
            int nTickets=int.Parse(Console.ReadLine());
            return nTickets;
        }
        
        static string GetSeats(int nTickets)
        {
            string seats=" ";
            // use for loop to repeat nTickets time, asking 
            for(int i=0;i<nTickets;i++){
                Console.WriteLine("Choose your seats:");
                string seat=Console.ReadLine();
                seats += seat +" ";
            }
            return seats;

        }
        static bool IsVIPMenber()
        {
            Console.Write("Are you Vip member? (y/n):");
            string answer=Console.ReadLine();
            return answer == "y";
        }
        static void PrinTickets(string movie,int nTickets,string seat)
        {
            Console.WriteLine("Moive: " + movie);
            Console.WriteLine("Number of tickets: " + nTickets);
            Console.WriteLine("Seats: " + seat);

        }
        static void PrintInvoice(int nTickets,bool VIP)
        {
            double payment= nTickets* PRICE;
            if(VIP) payment-=payment * VIP_REDUCE;
            
            Console.WriteLine("Payment: " + payment);

        }
    }
}
