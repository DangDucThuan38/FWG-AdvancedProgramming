using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public abstract class Member
    {
        protected string Name { get; set; }
        protected int Products { get; set; }
        protected const double PRICE = 100.0;
        public static double COMMISSION = 0.3;


        public Member(string name,int products)
        {
            Name = name;
            Products=products;
        }
        public abstract double GetSalary();
        public virtual void Show()
        {
            System.Console.WriteLine("Member: "+Name);
            System.Console.WriteLine("Product: "+Products);
            System.Console.WriteLine("Salary: "+GetSalary() +"$");
        }

    }
}