using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public abstract class Shape
    {
        protected string name;
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        public Shape()
        {
            Name="No Name";
        }
        public Shape(string name)
        {
            Name=name;
        }
        public abstract double GetArea();
        public abstract double GetPermeter();
        public virtual void ShowInfor()
        {
            System.Console.WriteLine("Name: "+ Name);
        }
        
    }
}