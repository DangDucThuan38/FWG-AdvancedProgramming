using System;

namespace RSPOOP
{
    public class Player
    {
        private int balance;
        public int Balance
        {
            get { return balance; }

        }

        public Player()
        {
            balance = 10;

        }

        public string GetChoice()
        {
            string userChoice = "";
            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine("Choose Rock, Paper, or Scissors: ");
                userChoice = Console.ReadLine();
                validChoice = userChoice == "Rock" || userChoice == "Paper" || userChoice == "Scissors";
                if (!validChoice)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            return userChoice;


        }

        public bool IsPlayAgain()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string playAgain = Console.ReadLine();
            bool playing = playAgain == "y";
            return playing;

        }
        public void Deposit(int amount)
        {
            if (amount <= 0)
                System.Console.WriteLine("Invalid amount.Please try again.");
            else
                balance += amount;
        }
        public void UpdateBalance(int amount)
        {
            balance += amount;
        }


    }
}