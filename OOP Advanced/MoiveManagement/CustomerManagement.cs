using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveManagement
{
    public  class CustomerManagement: MenuProgram
    {
        //private List<PPVCustomer> ppvcustomers;
        //private List<SubcribeCustomer> subcribeCustomers;

        private List<Customer> customers;
        public CustomerManagement()
        {
            customers= new List<Customer>();

            //ppvcustomers=new List<PPVCustomer>();
            //subcribeCustomers= new List<SubcribeCustomer>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add new PPVCustomer");
            System.Console.WriteLine("2. Add new SubCustomer");
            System.Console.WriteLine("3. PrintBill");
            System.Console.WriteLine("0. Exit!");
        }
        protected override void Process(int choice)
        {
            switch(choice)
            {
                case 1:AddPPVCustomer();break;
                case 2:AddSubCustomer(); break;
                case 3:PrintBill(); break;
                case 0: break;
                default:
                System.Console.WriteLine("Invaild Choice.Please Try Again!");
                break;
            }

        }
    
        private void AddPPVCustomer()
        {
            System.Console.Write("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.Write("Eneter Your Email: ");
            string email=Console.ReadLine();
            System.Console.Write("Enter Your Moives: ");
            int moives= int.Parse(Console.ReadLine());
            //Customer c= new Customer(name,email,moives);
            customers.Add(new PPVCustomer(name,email,moives));
        }
        private void AddSubCustomer()
        {
            System.Console.Write("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.Write("Eneter Your Email: ");
            string email=Console.ReadLine();
            System.Console.Write("Enter Your SubType: ");
            int subType= int.Parse(Console.ReadLine());
            customers.Add(new SubcribeCustomer(name,email,subType));
           
        }
        private void PrintBill()
        {
            foreach(Customer c in customers)
            {
                c.ShowInfor();
                System.Console.WriteLine("Payment: "+c.GetPayMent());
                System.Console.WriteLine("---------------------------");
            }


        }

    }
}