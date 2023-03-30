using System;

namespace Fibonaci // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter n: ");
            int x= int.Parse(Console.ReadLine());


            System.Console.WriteLine("Dãy Fibonacci: ");
            for(int i = 0; i < x;i++)
            {
                System.Console.Write(fibonacci(i)+",");
            }
        }
        public static int fibonacci(int n)
        {
            if(n < 0)
            {
                return 0;
            }
            else if(n ==0  || n==1)
            {
                return 1;
            } 
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }

        }
    }
}