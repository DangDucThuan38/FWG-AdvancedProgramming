using System;

namespace kethua // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1= new Cat();
            Animal a1=new Animal();
            a1.Infor();
            c1.Infor();
            System.Console.WriteLine(c1);
          
        }
    }
}
