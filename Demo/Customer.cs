using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class Customer
    {
        private string name;
        private string email;
        private string gender;
        private int age;
        private string address;

        public string Name
        {
            get {return name;}
            set 
            {
                if (name=="")name="Default Name";
                else name = value;
            }

        }
        public string Email
        {
            get{return email;}
            set
            {
                if(email=="")email="No email";
                else email= value;
            }
        }
        public string Gender
        {
            get{return gender;}
            set
            {
                if(gender=="")gender="Other";
                else gender=value;
            }

        }
        public int Age
        {
            get{return age;}
            set
            {
                if(age < 0 || age>100) age=20;
                else age= value;
            }
        }

        public string Address
        {
            get{return address;}
            set 
            {
                if(address=="")address="No Address";
                else address=value;
            }
        }
        public Customer()
        {
            Name="No Name";
            Email="abc@fpt.edu.vn";
            Gender="Male";
            Age=20;
            Address="Ha Noi";
        }
        public Customer (string name, string email,string gender,int age,string address)
        {
            Name=name;
            Email=email;
            Gender=gender;
            Age=age;
            Address=address;
        }
        public void ShowInfor()
        {
            System.Console.WriteLine("Name: "+Name);
            System.Console.WriteLine("Age: "+Age);
            System.Console.WriteLine("Address: "+Address);
            System.Console.WriteLine("Gender: "+Gender);
            System.Console.WriteLine("Email: "+Email);
        }
    }
}