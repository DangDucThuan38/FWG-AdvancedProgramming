using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class NormalMember : Member
    {
        public override double GetSalary()
        {
            return PRICE *Products *(1-COMMISSION);
        }
        public NormalMember(string name,int products):base(name,products)
        {

        }

    }
}