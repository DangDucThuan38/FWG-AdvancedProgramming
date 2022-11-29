using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuProgramBase
{
    public class MenuProgram
    {
        private const int EXIT = 0;
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = Getchoice();
                Process(choice);
                running = choice != EXIT;
            }
        }
        protected abstract void PrintMenu();
        protected abstract void Process(int choice);
        protected int choice()
        {
            System.Console.Write("Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}