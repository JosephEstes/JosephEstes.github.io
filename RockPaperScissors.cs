using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number to represent the computer's choice (0 for rock, 1 for paper, 2 for scissors)
            Random random = new Random();
            int computerChoice = random.Next(0, 3);

            // Prompt the player to choose rock, paper, or scissors
            Console.WriteLine("Choose rock (0), paper (1), or scissors (2):");

            // Read the player's choice
            int playerChoice = int.Parse(Console.ReadLine());

            // Determine the result of the game
            string result;
            if (computerChoice == playerChoice)
            {
                result = "draw";
            }
            else if (computerChoice == 0 && playerChoice == 1 || computerChoice == 1 && playerChoice == 2 || computerChoice == 2 && playerChoice == 0)
            {
                result = "player wins";
            }
            else
            {
                result = "computer wins";
            }

            // Print the result of the game
            Console.WriteLine($"Computer chose {computerChoice}. Player chose {playerChoice}. Result: {result}.");
        }
    }
}
