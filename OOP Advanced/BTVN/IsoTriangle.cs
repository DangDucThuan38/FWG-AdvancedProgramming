using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public class IsoTriangle:NormalTriangle
    {
        protected double Base
        {
            get {return sideA;}
            set {Base=sideA;}
        }
        protected double Side
        {
            get{return sideC;}
            set{Side=sideB=sideC=value;}
        }
        public IsoTriangle()
        {
            type="IsoTriangle";
            Base=2;
            Side=3;
            name="Default";
        }
        public IsoTriangle(string name,double Base,double Side): base(name,Base,Side,Side)
        {
            Base=SideA;
            Side=SideB=SideC;
        }
         public override void ShowInfor()
        {
            System.Console.WriteLine("Type: "+Type);
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Base "+Base);
            System.Console.WriteLine("Side: "+Side);
            System.Console.WriteLine("Area  "+GetArea());
            System.Console.WriteLine("Perimeter: "+GetPerimeter());
            

        
        }
      


        
    }
}