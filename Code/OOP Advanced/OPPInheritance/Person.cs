using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPPInheritance
{
    public class Person
    {
         private  string name;
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public int Age{get;set;}

        public Person()
        {
            name="Nguyen Van A";
            Age=1;
            System.Console.WriteLine("Default contructor of person");
        }

        public Person(string name,int age)
        {
            
            Name=name;
            Age=age;
            System.Console.WriteLine("Parameters contructor of person");
        }

        public void ShowInfor()
        {
            System.Console.WriteLine("Name: " + name+" ,Age: " + Age);
        }
    }
}