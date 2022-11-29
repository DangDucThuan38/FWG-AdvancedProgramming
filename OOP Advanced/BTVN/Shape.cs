using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
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
            Name= name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public virtual void ShowInfor()
        {
            System.Console.WriteLine("Name:"+Name);
        }

    }
}