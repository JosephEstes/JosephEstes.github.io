using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the game board
            string[,] gameBoard = new string[3, 3]
            {
                {" ", " ", " "},
                {" ", " ", " "},
                {" ", " ", " "}
            };

            // Print the initial game board
            Console.WriteLine("Tic-Tac-Toe\n");
            PrintGameBoard(gameBoard);

            // Play the game until it ends
            string currentPlayer = "X";
            int remainingMoves = 9;
            while (remainingMoves > 0)
            {
                // If it's the computer's turn, make a move
                if (currentPlayer == "O")
                {
                    MakeComputerMove(gameBoard);
                    remainingMoves--;

                    // Print the updated game board
                    PrintGameBoard(gameBoard);

                    // Check if the game has been won
                    if (HasPlayerWon(gameBoard, currentPlayer))
                    {
                        Console.WriteLine("The computer wins!");
                        break;
                    }
                }
                else
                {
                    // Prompt the player to make a move
                    Console.WriteLine("Enter your move (row,column):");

                    // Read the player's move
                    int row = int.Parse(Console.ReadLine());
                    int column = int.Parse(Console.ReadLine());

                    // Make sure the move is valid
                    if (row < 0 || row > 2 || column < 0 || column > 2 || gameBoard[row, column] != " ")
                    {
                        Console.WriteLine("Invalid move. Try again.");
                        continue;
                    }

                    // Make the move and update the game state
                    gameBoard[row, column] = currentPlayer;
                    remainingMoves--;

                    // Print the updated game board
                    PrintGameBoard(gameBoard);

                    // Check if the game has been won
                    if (HasPlayerWon(gameBoard, currentPlayer))
                    {
                        Console.WriteLine("You win!");
                        break;
                    }
                }

                // Switch to the other player
                currentPlayer = (currentPlayer == "X" ? "O" : "X");
            }

            // If the game ended without a winner, it must be a draw
            if (remainingMoves == 0)
            {
                Console.WriteLine("The game ends in a draw.");
            }
        }

        static void PrintGameBoard(string[,] gameBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j]);
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("-+-+-");
                }
            }
        }

        static void MakeComputerMove(string[,] gameBoard)
        {
            // Find the first empty square
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] == " ")
                    {
                        // Make the move
                        gameBoard[i, j] = "O";

                        // Return from the method
                        return;
                    }
                }
            }
        }

        static bool HasPlayerWon(string[,] gameBoard, string player)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == player && gameBoard[i, 1] == player && gameBoard[i, 2] == player)
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] == player && gameBoard[1, i] == player && gameBoard[2, i] == player)
                {
                    return true;
                }
            }

            // Check diagonal (top-left to bottom-right)
            if (gameBoard[0, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 2] == player)
            {
                return true;
            }

            // Check diagonal (top-right to bottom-left)
            if (gameBoard[0, 2] == player && gameBoard[1, 1] == player && gameBoard[2, 0] == player)
            {
                return true;
            }

            // No winning condition has been met
            return false;
        }
    }
}
