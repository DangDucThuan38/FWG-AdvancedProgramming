using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixicarStore
{
    public class Car
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
        private string codecar;
        public string CodeCar
        {
            get { return codecar; }
            set
            {
                if (value == "") codecar = "Default";
                else codecar = value;
            }
        }
        private string made;
        public string Made
        {
            get { return made; }
            set
            {
                if (value == "") made = "Default";
                else made = value;
            }
        }
        private string power;
        public string Power
        {
            get { return power; }
            set
            {
                if (power == "") power = "Default";
                else power = value;
            }
        }
        private string date;

        public string Date
        {
            get { return date; }
            set
            {
                if (value == "") date = "Default date";
                else date = value;
            }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0) price = 100.0;
                else price = value;
            }
        }

        public Car(string codecar, string name, double price, string made, string description, string power, string date)
        {
            CodeCar = codecar;
            Name = name;
            Description = description;
            Price = price;
            Made = made;
            Power = power;
            Date = date;
        }

        public void Show()
        {
            System.Console.WriteLine("Code Car: " + CodeCar + ", Name Car: " + Name + ", Made In: "
            + Made + " ,Power: " + Power + ", Date: " + Date + ",Price: " + Price);
        }



    }
}