using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Car
    {
        public string Name { get; set; }
        public string CodeCar { get; set; }
        public double Price { get; set; }
        public string Made { get; set; }
        public string Description { get; set; }
        public string Power { get; set; }
        public string Date { get; set; }

        public Car()
        {

        }
        public Car(string codecar, string name, double price, string made, string description, string power, string date)
        {
            CodeCar = codecar;
            Name = name;
            Price = price;
            Made = made;
            Description = description;
            Power = power;
            Date = date;
        }

        public void Show()
        {
            System.Console.WriteLine("Code Car: "+CodeCar+"Name: "+Name+"Price: "+Price+"Made In: "+Made+"Description: "+Description+"Power: "+Power+"Date: "+Date);
        }
    }
}