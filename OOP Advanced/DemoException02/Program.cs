﻿using System;
class Program
{
    public static void Main(string[] args)
    {
        int a = ReadInt("Enter a: ");
        int b = ReadInt("Enter b: ");
        double e=ReadDouble("Enter e: ");
        int c=a/b;
        System.Console.WriteLine("Result: "+c);
    }
    public static int  ReadInt(string prompt)
    {
        bool invalid = true;
        int n = 0;
        while (invalid)
        {
            try
            {
                Console.Write(prompt);
                n = int.Parse(Console.ReadLine());
                invalid = false;
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Input Valid .Please try Again.!");
            }

        }
        return n;
    }
   public static double ReadDouble(string get)
   {
         bool invalid = true;
        double n = 0;
        while (invalid)
        {
            try
            {
                Console.Write(get);
                n = double.Parse(Console.ReadLine());
                invalid = false;
            }
            catch (FormatException)
            {

                System.Console.WriteLine("Input Valid .Please try Again.!");
            }

        }
        return n;

   }
}

