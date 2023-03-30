using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPPInheritance
{
    public class Student : Person
    {
        public Student()
        {
            System.Console.WriteLine("Default constructor of Student");
        }
        public Student(string name,int age) :base(name,age)
        {
            System.Console.WriteLine("Parameters contructor of students");
        }
        
    }
}