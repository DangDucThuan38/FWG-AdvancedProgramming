using FigureSystem;
using System;
using System.Collections.Generic;



List<Figure> figures = new List<Figure>();

figures.Add(new Rectangle(5, 3));
figures.Add(new Triangle(5));
figures.Add(new TextFigure("Hello"));


foreach (Figure f in figures)
{
    f.Draw();
    System.Console.WriteLine("------------------------------");

}