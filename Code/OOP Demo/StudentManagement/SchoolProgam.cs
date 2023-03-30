
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class SchoolProgam
    {


        // attribute: school
        private School mySchool;

        // default constructor
        public SchoolProgam()
        {
            mySchool = new School("Greenwich");
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                running = Process(choice);
            }
        }
        // PrintMenu
        private void PrintMenu()
        {
            System.Console.WriteLine("1. Import Student");
            System.Console.WriteLine("2. DropOut Student");
            System.Console.WriteLine("3. Show infor Student");
            System.Console.WriteLine("0. Exit");
        }

        // GetChoice
        private int GetChoice()
        {
            System.Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        // Process
        public bool Process(int choice)
        {
            bool running =true;
            switch(choice)
            {
                case 1:mySchool.Enroll();
                break;
                case 2:mySchool.DropOupt();
                break;
                case 3:mySchool.ShowStudents();
                break;
                case 0: running = false;
                break;
                default:
                System.Console.WriteLine("Your choice is Invalid.Please choose");
                break;
                
            }
            return running;
        }

    }
}