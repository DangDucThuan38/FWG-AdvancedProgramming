
using System;

namespace OOP // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t= new Teacher();
            System.Console.Write("Enter name:");
            t.Name=Console.ReadLine();
            System.Console.Write("Enter Age:");
            t.Age=int.Parse(Console.ReadLine());
            System.Console.Write("Enter Subject:");
            t.Subject=Console.ReadLine();
            
        System.Console.WriteLine(t.Name);
        System.Console.WriteLine(t.Age);
        System.Console.WriteLine(t.Subject);
        }
    }
}