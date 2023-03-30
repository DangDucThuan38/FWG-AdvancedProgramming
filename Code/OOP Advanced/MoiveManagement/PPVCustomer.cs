using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveManagement
{
    public class PPVCustomer:Customer
    {
        private const int PRICE=10;
        private int moives;
        public int Moives
        {
            get{return moives;}
            set{moives=value;}
        }
        public PPVCustomer()
        {

        }
        public PPVCustomer(string name,string email,int moives):base(name,email)
        {
            Moives=moives;
        }

        public override void ShowInfor()
        {
            System.Console.Write("ID: "+ID+",Name: "+Name+",Email: "+Email+",Moives: "+Moives);
        }
        public override double GetPayMent()
        {
            int payment=Moives*PRICE;
            return payment;
        } 

        
    }
}