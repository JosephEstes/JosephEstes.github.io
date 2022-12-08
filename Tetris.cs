using System;
using System.Collections.Generic;

namespace Tetris
{
    class Program
    {
        // The game board is a two-dimensional array of characters
        static char[,] gameBoard = new char[20, 10];

        // The current position and shape of the falling tetromino
        static int tetrominoX = 0;
        static int tetrominoY = 0;
        static char[,] tetrominoShape = new char[4, 4];

        // A random number generator for choosing tetromino shapes
        static Random rand = new Random();

        static void Main(string[] args)
        {
            // Initialize the game board and tetromino
            InitializeGame();

            // Game loop
            while (true)
            {
                // Update the game state
                UpdateGame();

                // Print the game board
                PrintGameBoard();

                // Sleep for a short time to slow down the game
                System.Threading.Thread.Sleep(200);
            }
        }

        // Initialize the game board and tetromino
        static void InitializeGame()
        {
            // Fill the game board with empty spaces
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    gameBoard[i, j] = ' ';
                }
            }

            // Choose a random tetromino shape
            int shape = rand.Next(0, 7);
            switch (shape)
            {
                case 0:
                    tetrominoShape = new char[,]
                    {
                        { ' ', ' ', ' ', ' ' },
                        { ' ', ' ', ' ', ' ' },
                        { 'X', 'X', 'X', 'X' },
                        { ' ', ' ', ' ', ' ' }
                    };
                    break;
                case 1:
                    tetrominoShape = new char[,]
                    {
                        { ' ', ' ', ' ', ' ' },
                        { ' ', 'X', 'X', ' ' },
                        { ' ', 'X', 'X', ' ' },
                        { ' ', ' ', ' ', ' ' }
                    };
                    break;
                case 2:
                    tetrominoShape = new char[,]
                    {
                        { ' ', ' ', ' ', ' ' },
                        { ' ', 'X', 'X', ' ' },
                        { 'X', 'X', ' ', ' ' },
                        { ' ', ' ', ' ', ' ' }
                    };
                    break;
                case 3:
                    tetrominoShape = new char[,]
                    {
                        { ' ', ' ', ' ', ' ' },
                        { 'X', 'X', ' ', ' ' },
                        { ' ', 'X', 'X', ' ' },
                        { ' ', ' ', ' ', ' ' }
                    };
                    break;
                case 4:
                    tetrominoShape = new char[,]
                    {
                        { ' ', ' ', ' ', ' ' },
                        { ' ', 'X', ' ', ' ' },
                        { 'X', 'X', 'X', ' ' },
                        { ' ', ' ', ' ', ' ' }
                    };
                   
