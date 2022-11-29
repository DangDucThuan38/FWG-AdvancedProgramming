using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveManagement
{
    public abstract class Customer
    {
        protected int id;
        public int ID
        {
            get{return id;}
            set{id=value;}
        }
        public static int count =0;
        protected string name;
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
        protected string email;
        public string Email
        {
            get{return email;}
            set{email=value;}
        }
        public Customer()
        {
            Name="No Name";
            Email="fpt.edu.vn";
            id=++count;
        }
        public Customer(string name,string email)
        {
            Name=name;
            Email=email;
            id=++count;
        }
        public virtual void ShowInfor()
        {
            System.Console.Write("ID"+ID+",Name:"+Name+",Email: "+Email);
        }
        public abstract double GetPayMent();

    }
}