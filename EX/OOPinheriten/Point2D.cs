using System;


namespace OOPinheriten
{
    public class Point2D
    {
        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        protected int y;
           public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point2D()
        {
            x=0;
            y=0;
        }
        public Point2D(int x,int y)
        {
            this.x = x;
            this.y=y;
        }
        public string ToString()
        {
            return "Point(" + X + ", " + Y + ")";
        }
    }
}