using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WeekendMenu : DailyBreakMenu
    {
        protected override Breakfast CreateBreakfast()
        {
            return new WeenkendBreakfast();

        }
    }
}