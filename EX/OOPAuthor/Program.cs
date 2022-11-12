using System;

namespace OOPAuthor // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author a1 = new Author("Nguyen Van A", "", 'm');
            //System.Console.WriteLine(a1.Tostring());
            //System.Console.WriteLine(a1.Name);
            //System.Console.WriteLine("------------------------------------------------------");
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            //Console.WriteLine(ahTeck.Tostring());  // Test ToString()
            //ahTeck.Email = "paulTan@nowhere.com";  // Test setter
            //Console.WriteLine("name is: " + ahTeck.Name);     // Test getter
            //Console.WriteLine("email is: " + ahTeck.Email);   // Test getter
            //Console.WriteLine("gender is: " + ahTeck.Gender);




            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            Console.WriteLine(ahTeck.ToString());  // Author's ToString()

            Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            Console.WriteLine(dummyBook.ToString());  // Test Book's ToString()

            // Test Getters and Setters
            dummyBook.Price = 29.95;
            dummyBook.QTY = 28;
            Console.WriteLine("name is: " + dummyBook.Name);
            Console.WriteLine("price is: " + dummyBook.Price);
            Console.WriteLine("qty is: " + dummyBook.QTY);
            Console.WriteLine("Author is: " + dummyBook.Author.ToString());  // Author's ToString()
            Console.WriteLine("Author's name is: " + dummyBook.Author.Name);
            Console.WriteLine("Author's email is: " + dummyBook.Author.Email);

            // Use an anonymous instance of Author to construct a Book instance
            Book anotherBook = new Book("more Java",
                  new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            Console.WriteLine(anotherBook.ToString());  // ToString()


        }
    }
}