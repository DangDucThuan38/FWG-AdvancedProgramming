using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1
{
    public class PayPal
    {
        public string Email{get; set;}
        public string Password{get;set;}

        public PayPal(string email,string password)
        {
            Email=email;
            Password=password;

        }
    }
}