using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public class OrDerManager: MenuProgram
    {
        private List<OrDer> orDers;

        public OrDerManager(PayStrategy p)
        {
            orDers= new List<OrDer>();
        }
        protected override void PrintMenu()
        {
            System.Console.WriteLine("---Wellcome to the Greenwich Store---");
            System.Console.WriteLine("Please choose product you want buy?");
            System.Console.WriteLine("1.  Computer Dell");
            System.Console.WriteLine("2.   Ram");
            System.Console.WriteLine("3.   CPU");
            System.Console.WriteLine("4.   SSD");
            System.Console.WriteLine("5.   HHD");
            System.Console.WriteLine("6.   Show All infomation");
            System.Console.WriteLine("0.   Exit Program");
        }

        protected void PrintMenu2()
        {
            System.Console.WriteLine("Hay chon phuong thuc thanh toan");
            System.Console.WriteLine("1. PayPal");
            System.Console.WriteLine("2. CreditCard");
        }

        protected override void Process(int choice)
        {
             int choice_;
            switch (choice)
            {
                case 1:PrintMenu2();
                choice_=Getchoice();
                break;
                 case 2:PrintMenu2();
                choice_=Getchoice();
                break;
                 case 3:PrintMenu2();
                choice_=Getchoice();
                break;
                 case 4:PrintMenu2();
                choice_=Getchoice();
                break;
                 case 5:PrintMenu2();
                choice_=Getchoice();
                break;
                 case 6:PrintMenu2();
                choice_=Getchoice();
                break;
                case 0: System.Console.WriteLine("You Exited Program!"); break;
                default:
                System.Console.WriteLine("");
                break;
            }
        }

         protected void ChoosePay(int choice)
        {
            switch (choice)
            {
                case 1: 
                    p = new PayByPayPal();

                break;
                case 2:
                break;
                case 3: break;
                default:
                System.Console.WriteLine("");
                break;
            }
        }

        
    }
}