using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public class EqualTriangle:IsoTriangle
    {
        protected double side;
        public double Side
        {
            get{return Base;}
            set{side=Base=value;}
        }
        public EqualTriangle()
        {
            type="EqualTriangle";
            Side=5.5;
        }
        public EqualTriangle(string name,double Side):base(name,Side,Side)
        {
            Side=Base;
            type="EqualTriangle";
        }
        public override void ShowInfor()
        {
            System.Console.WriteLine("Type: "+Type);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Side: "+Side);
            System.Console.WriteLine("Area  "+GetArea());
            System.Console.WriteLine("Perimeter: "+GetPerimeter());
        }
    }
}