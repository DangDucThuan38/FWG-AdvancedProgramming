using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public class PayByCash : IPaymentable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "Default Name";
                else name = value;
            }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (value == "") address = "Default Address";
                else address = value;
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0 || value > 100) age = 22;
                else age = value;

            }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == "") phone = "098899xxx";
                else phone = value;
            }
        }
        public PayByCash(string name, int age,string address,string phone)
        {
            Name= name;
            Age=age;
            Address=address;
            Phone=phone;
        }
        public void Pay(double total)
        {
            System.Console.WriteLine("You have successfully paid for your product with Cash payment method.");
            System.Console.WriteLine("_____________Mixi Car Store____________");
            System.Console.WriteLine("--------------Cash payment invoice----------------");
            System.Console.WriteLine("Name Customer: " + Name);
            System.Console.WriteLine("Age: " + Age);
            System.Console.WriteLine("Address: " + Address);
            System.Console.WriteLine("Phone Number: " + Phone);
            System.Console.WriteLine("Total Money: " + total);
            System.Console.WriteLine("|        PayMent: " + (total * (100 + 2) / 100) + "     |");
         

        }

        public  void Add()
        {
            System.Console.Write("Enter Name Customer:");
            string name= Console.ReadLine();
            System.Console.Write("Enter Age: ");
            int age= int.Parse(Console.ReadLine());
            System.Console.Write("Enter Address: ");
            string address= Console.ReadLine();
            System.Console.Write("Enter Phone Number: ");
            string phone= Console.ReadLine();
            
            PayByCash cash= new PayByCash(name,age,address,phone);

        }




    }
}