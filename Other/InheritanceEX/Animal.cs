
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceEX
{
    public class Animal
    {
        protected string name;
        protected double height;
        protected int age;
        protected string color;
        public Animal()
        {
            name="Cat";
            height=15.5;
            age=18;
            color="white";
            
        }
        public Animal(string name, double height,int age,string color)
        {
            this.name = name;
            this.height= height;
            this.age = age;
            this.color= color;
        }
        
        public virtual void Infor()
        {
            Console.WriteLine("name: " + name+"height: " + height+"age: " + age+"color: " + color);
        }


    }
}