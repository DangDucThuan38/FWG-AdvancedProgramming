using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX
{
    public class Car
    {

        private string codeProduct;
        public string CodeProduct
        {
            get { return codeProduct; }
            set { codeProduct = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") name = "Default name Car";
                else name = value;
            }

        }

        private string made;
        public string Made
        {
            get { return made; }
            set
            {
                if (value == "") made = "Made in Default";
                else made = value;
            }

        }


        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (value == "") description = "Description in Default";
                else description = value;
            }

        }

        private string power;
        public string Power
        {
            get { return power; }
            set
            {
                if (value == "") power = "Power of car is Default";
                else power = value;
            }

        }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0) price = 100.0;
                else price = value;

            }

        }
        public Car()
        {
            CodeProduct = "Mec200";
            Name = "MecAGM";
            Description = "Default";
            Made = "VietNam";
            Power = "200H";
            Price = 15000;
        }
        public Car(string codeProduct, string name, string description, string made, string power, double price)
        {
            CodeProduct = codeProduct;
            Name = name;
            Description = description;
            Made = made;
            Power = power;
            Price = price;
        }

        public void Show()

        {
            System.Console.WriteLine("Code of Prodcut:" + CodeProduct + " ||Name: " + Name + " || Description: "
            + Description + " || Power: " + Power + " || Made in: " + Made + "  || Price: " + Price);
            // System.Console.WriteLine("_____________Luxury Car Store____________");
            //System.Console.WriteLine("--------------Electronic bill----------------");
            //  System.Console.WriteLine("|Name Product|  |Description|   |Made In|  |Power|   |Price|");





        }
    }
}