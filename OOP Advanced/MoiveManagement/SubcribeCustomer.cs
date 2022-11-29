using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveManagement
{
    public class SubcribeCustomer:Customer
    {
        private int MONTHLY=1;
        private double SALE=0.5;
        private int subType;
        public int SubType
        {
            get{return subType;}
            set{subType=value;}
        }
        public SubcribeCustomer()
        {
            subType=0;

        }
        public SubcribeCustomer(string name, string email,int subType):base(name,email)
        {
            SubType=subType;

        }
        public override void ShowInfor()
        {
            System.Console.Write("ID: "+ID+",Name: "+Name+",Email: "+Email+",SubType:"+SubType);

        }
        public override double GetPayMent()
        {
            if(subType==0)
            {
                return MONTHLY;
            }else
            {
                return MONTHLY*(1-SALE);
            }
        
        }
    }
}