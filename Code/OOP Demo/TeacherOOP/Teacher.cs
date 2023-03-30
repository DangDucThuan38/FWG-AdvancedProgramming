using System;

// Shift Alt F
namespace OOP
{
    public class Teacher  //Name class chữ hoa và tên biến chữ thường 
    {
        //attribue
        private string name;
        private string subject;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "John";
                else name = value; 
                
            }
        }

        public string Subject { get; set; }
        //{
        //get { return subject; }
        //set
        //{
        //   subject = value;
        //}
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 20)
                {
                    System.Console.WriteLine("Age entered is not valid ");
                    age = 22;
                }
                else age = value;
            }

        }




    }
}