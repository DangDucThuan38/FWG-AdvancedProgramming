using System;


namespace OOPEmployee
{
    public class Employee
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }

        }

        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (value =="") firstname = "Cadi";
                else firstname = value;
            }
        }

        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set
            {
                if (value == "") lastname = "Jon";
                else lastname = value; 
            }
        }
        private int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0) salary = 5;
                else salary = value;
            }
        }
        public Employee(int id, string firstname, string lastname, int salary)
        {
            //this.id = id;
            //this.firstname = firstname;
            //this.lastname = lastname;
            //this.salary = salary;
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
        }
        public string FullName()
        {
            return firstname + " " + lastname;
        }
        public int AnnualSalary()
        {
            return salary * 12;
        }
        public string ToString()
        {
            return "Employee[id=" + id + "firstname=" + firstname + ",lastname=" + lastname + "salary=" + salary + "]";
        }


    }
}