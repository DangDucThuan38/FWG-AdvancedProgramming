
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
            Name = "Student not Name";
            Age = 0;
            Grade = 0;
            id = ++count;
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

        public void ShowInfor()
        {
            Console.WriteLine("ID: " + id+"| Name: " + Name+"| Age: " +Age+"| Grade: " +Grade);
        }
    }
}