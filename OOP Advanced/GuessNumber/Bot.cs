using System;

namespace GuessNumber
{
    public class Bot : Player
    {
        public Bot() : base("Bot")//Goji contrutor parameter
        {

        }
        public override void GenerateNumber()
        {
            number = new Random().Next(1, 6);
        }
        public override int GuessNumber()
        {
            int n = new Random().Next(1, 6);
            System.Console.WriteLine(" Bot Guess the number: " +n);
            return n;
        }
        public override int Bet()
        {
            int bet=new Random().Next(1, balance + 1);
            System.Console.WriteLine("Bot bet:"+bet);
            return bet;
        }


    }
}