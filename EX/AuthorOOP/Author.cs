using System;


namespace AuthorOOP
{
    public class Author
    {
        public string Name { get; }
        public string Email { get; }
        public char Gender { get; }

        public Author(string name, string email, char gender)
        {
            Name=name;
            Email=email;
            Gender=gender;
        }
        public string ToString()
        {
            return "Author[Name=" + Name + ", Email=" + Email + ", Gender=" + Gender+"]";
        }
    }
}