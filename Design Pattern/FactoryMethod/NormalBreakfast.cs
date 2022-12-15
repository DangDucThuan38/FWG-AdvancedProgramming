using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NormalBreakfast : Breakfast
    {
        public override void Show()
        {
            System.Console.WriteLine("-----Normal Daily Breakfast-----");
            System.Console.WriteLine("Today we have: ");
            System.Console.WriteLine("1. Bread");
            System.Console.WriteLine("2. Eggs");
            System.Console.WriteLine("3. Coffee");
            System.Console.WriteLine("What do you choose? :");

        }
    }
}