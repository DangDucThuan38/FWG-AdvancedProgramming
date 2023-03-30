using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Candidate
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private double gpa;
        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
        public Candidate(string name,int age,double gpa)
        {
            Name=name;
            Age=age;
            GPA=gpa;
        }

        public override string ToString()
        {
            return "Name: "+Name+",  Age: "+Age+",  GPA: "+GPA;
        }
    }
}