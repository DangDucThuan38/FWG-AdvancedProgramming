using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("GCH1001","Nguyen Van","A",65);
            System.Console.WriteLine(e1.FullName());
            System.Console.WriteLine(e1.RaiseSalary(1.07));
            System.Console.WriteLine(e1.FirstName);
            System.Console.WriteLine(e1.ToString());
            System.Console.WriteLine(e1.AnuSalary());

        }
    }
}
