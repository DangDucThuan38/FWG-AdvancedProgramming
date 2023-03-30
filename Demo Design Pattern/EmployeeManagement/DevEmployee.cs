using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DevEmployee : Employee
    {
        private string Lanuage { get; set; }
        public DevEmployee(string name, int age,double salary,string lanuage):base(name,age,salary)
        {
            Lanuage=lanuage;
        }
        public override string ToString()
        {
            return " Develper Name: "+Name+",Age: "+",Salary: "+Salary +",Language: "+Lanuage;

        }


    }
}