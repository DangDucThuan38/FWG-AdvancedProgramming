using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class SaleEmployee : Employee
    {
        protected double Nproducts { get; set; }
        public SaleEmployee(string name, int age, double salary, double nproducts) : base(name, age, salary)
        {
            Nproducts = nproducts;
        }
        public override string ToString()
        {
            return "Sale Name: "+Name+",Age: "+",Salary: "+Salary+",Nproducts: "+Nproducts;

        }
    }
}