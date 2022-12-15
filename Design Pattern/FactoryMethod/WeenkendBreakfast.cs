using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WeenkendBreakfast : Breakfast
    {
        public override void Show()
        {
            System.Console.WriteLine("-----Weekend Breakfast-----");
            System.Console.WriteLine("Today we have: ");
            System.Console.WriteLine("1. Pancakes");
            System.Console.WriteLine("2. Sausages");
            System.Console.WriteLine("3. Cake");
            System.Console.WriteLine("4. Coffee");
            System.Console.WriteLine("What do you choose? : ");

        }
    }
}