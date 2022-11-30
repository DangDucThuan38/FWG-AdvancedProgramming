using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPinheriten
{
    public class Point3D :Point2D
    {
        protected int z=0;
        public int Z{
            get{return z;}
            set{z = value;}
        }


        public Point3D() :base()
        {
          
        }
        public Point3D(int x, int y, int z) : base(x,y)
        {
            this.z=z;
        }
        public string ToString()
        {
            return "Point3D(" + X + ", " + Y + ", " + Z  + ")";
        }
        
    }
}