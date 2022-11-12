using System;


namespace OOPAuthor
{
    public class Book
    {
        private string name;
        public string Name
        {
            get { return name;}
        }
        private Author author;
        public Author Author
        {
            get {return author;}
        }

        private double price;
        public double Price
        {
            get {return price;}
            set{
                if (value<0) price=5;
                else price=value;
            
            }
        }
        private int Qty=0;
        public int QTY{
            get {return Qty;}
            set{Qty=value;}
        }
        public Book(string name, Author author, double price)
        {
            this.name = name;
            this.author = author;
            Price=price;
        }
        public Book(string name,Author author, double price, int Qty)
        {
          this.name = name;
            this.author = author;
            Price=price;
            this.Qty=Qty; 
        }
        public string ToString()
        {
            return "Book[Name=" + Name + ",Author[Name="+author.Name+"Email=" + author.Email +"Gender="+author.Gender + "]"+",Price=" + Price + ",Qty=" + QTY+"]";
        }
    }
}