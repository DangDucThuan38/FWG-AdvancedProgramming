using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kethua
{
    public class Cat :Animal
    {
        public Cat():base()
        {
            
        }

        public override void Infor()
        {
            Console.WriteLine("name:"  + name+"height:" + height);

        }
        public override string ToString()
        {
            return "Name[name=" + name + "height=" + height + "age=" + age + "color=" + color+"]";
        }
    }
}