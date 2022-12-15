using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Restaurant
    {
        private DailyBreakMenu menu;

        public void Open()
        {
            //get cuurent day of week
            DayOfWeek day= DateTime.Now.DayOfWeek;
            //Check if it is weekend or not
            if(day == DayOfWeek.Saturday || day==DayOfWeek.Sunday)
            {
                menu=new WeekendMenu();
            }
            else
            {
                menu =new NormalMenu();
            }
            System.Console.WriteLine("Today is {0}",day);
            System.Console.WriteLine("Opening thes restaurant...");

        }
        public void WellcomeCusomers()
        {
            while(true)
            {
                System.Console.WriteLine("Wellcome to the restaurant! ");
                menu.ShowMenu();
                System.Console.WriteLine("Waitting for new customer...");
                string c= Console.ReadLine();
                if(c=="q") break;
            }

        }
    }
}