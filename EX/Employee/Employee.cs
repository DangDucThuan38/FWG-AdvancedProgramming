using System;

namespace Employee
{
    public class Employee
    {
        private string id;
        public string Id { get; }
        private string firstname;
        public string FirstName { get; }
        private string lastname;
        public string LastName { get; }
        private double salary;
        public double Salary { get; set; }

        public Employee(string id, string firstname, string lastname, double salary)
        {
            Id=id;
            FirstName=firstname;
            LastName=lastname;
            Salary = salary;
        }
        public string FullName()
        {
            return FirstName+" " +LastName;
        }
        public double AnuSalary()
        {
            return Salary*12;
        }
        public double RaiseSalary(double x)
        {
            Salary=Salary*x;
            return Salary;
        }
        public string ToString()
        {
            return "Employee[ID="+Id+"]";
        }
        

    }
}