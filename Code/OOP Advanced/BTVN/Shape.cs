using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public abstract class Shape
    {
        protected string name;
        protected string type;
        public string Type
        {
            get{return type;}
        }

        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        public Shape()
        {
            Name="No Name";
            type="Shape";
        }
        public Shape(string name)
        {
            Name= name;
            type="shape";
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public virtual void ShowInfor()
        {
            System.Console.WriteLine("Shape: "+type);
            System.Console.WriteLine("Name:"+Name);
        }

    }
}