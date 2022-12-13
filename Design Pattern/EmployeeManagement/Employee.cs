using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        protected string Name{get;set;}
        protected int Age{get; set;}
        protected double Salary{get; set;}

        public Employee(string name,int age,double Salary)
        {
            Name=name;
            Age=age;
            Salary=Salary;
        }
        public virtual string ToString()
        {
             return "Name: "+Name+",Age: "+",Salary: "+Salary;
        }
    }
}