using System;

namespace AuthorOOP// Note: actual namespace depends on the project name.
{
 class Program
    {
        static void Main(string[] args)
        {
           Author a1= new Author("Tan","fpt.edu.vn",'m');
           System.Console.WriteLine(a1.ToString());
        }
    }
}