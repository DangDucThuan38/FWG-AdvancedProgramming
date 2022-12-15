using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class DailyBreakMenu
    {
        public void ShowMenu()
        {
           
            Breakfast bf=CreateBreakfast();
            bf.Show();
            string answer=Console.ReadLine();
            System.Console.WriteLine("Great Choice! Please wait a moment.");
        }
        protected abstract Breakfast CreateBreakfast();

    }
}