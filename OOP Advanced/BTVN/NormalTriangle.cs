using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTVN
{
    public class NormalTriangle :Shape
    {
        protected double sideA;
        public double SideA
        {
            get{return sideA;}
            set{sideA=value;}
        }
        protected double sideB;
        public double SideB
        {
            get{return sideB;}
            set{sideB=value;}
        }
        protected double sideC;
        public double SideC
        {
            get{return sideC;}
            set{sideC=value;}
        }
        public NormalTriangle()
        {
            type="NormalTriangle";
            sideA=1.0;
            sideB=2.0;
            sideC=3.0;

        }
        public NormalTriangle(string name,double sideA,double sideB,double sideC):base(name)
        {
            type="NormalTriangle";
            SideA=sideA;
            SideB=sideB;
            SideC=sideC;
        }
        public override double GetArea()
        {
            double p=GetPerimeter()/2;

            return p*(p-sideA)*(p-sideB)*(p-sideC); 
        }
        public override double GetPerimeter()
        {
            return (sideA+sideB+sideC)/2;
        }
        public override void ShowInfor()
        {
            base.ShowInfor();
            System.Console.WriteLine("Type: "+Type);
            System.Console.WriteLine("SideA: "+sideA);
            System.Console.WriteLine("SideB: "+sideB);
            System.Console.WriteLine("SideC: "+sideC);
            System.Console.WriteLine("Area  "+GetArea());
            System.Console.WriteLine("Perimeter: "+GetPerimeter());
        }

    }
}