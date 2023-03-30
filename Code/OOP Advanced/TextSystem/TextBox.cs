using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextSystem
{
    public class TextBox
    {
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public TextBox(string t)
        {
            t = text;
        }
        public void Print()
        {
            int n = Text.Length;
            for (int i = 0; i < n + 4; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("* " + Text + " *");
            for (int i = 0; i < n + 4; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }


    }
}