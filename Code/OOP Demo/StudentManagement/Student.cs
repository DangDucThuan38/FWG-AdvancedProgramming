
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        // attributes: name, age, grade
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }



        // ID base count

        public static int count = 0;
        private int id;
        public int ID
        {
            get { return id; }
        }


        // default constructor
        public Student()
        {
            Name="No Name";
            Age=18;
            Grade=5;
            id=++count;

        }
        // parameter constructor
        public Student(string name, int age, double grade)
        {
            Name=name;
            Age=age;
            Grade=grade;
            id=++count;
        }


        // show info
        //public void ShowInfo()
        //{
        //    System.Console.WriteLine("ID: "+ID+"|Name: " + Name+"|Age: " + Age+"|Grade: " +Grade);
        //}


    }
}