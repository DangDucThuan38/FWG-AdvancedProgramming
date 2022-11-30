using System;

namespace OOPEmployee// Note: actual namespace depends on the project name.
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee e1= new Employee(1001,"","A",-5);
            System.Console.WriteLine(e1.FullName());
            System.Console.WriteLine(e1.AnnualSalary());
            System.Console.WriteLine(e1.ToString());
            
        }
    }
}
