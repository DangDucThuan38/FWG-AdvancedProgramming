using System;


namespace OOPAuthor
{
    public class Author
    {
        private string name;
        public string Name{get { return name; } }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if(value == ""){
                    System.Console.WriteLine("Email is Null");
                    email="abc@fpt.edu.vn";
                } 
                else email = value;
            }
        }
        public char gender;
        public char Gender { get { return gender; }}


        public Author(string name, string email,char gender)
        {
            this.name = name;
            Email=email;
            this.gender=gender;
        }

        public string ToString()
        {
             return "Author [Name=" + Name +" Email=" + Email + "Gender=" + Gender+"]";
        }


        
    }
}
   
