using System;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the game board
            string[,] gameBoard = new string[,]
            {
                {"#", "#", "#", "#", "#", "#", "#", "#", "#", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", " ", " ", " ", " ", " ", " ", " ", " ", "#"},
                {"#", "#", "#", "#", "#", "#", "#", "#", "#", "#"}
            };

            // Initialize the game state
            bool gameOver = false;
            int pacmanX = 1;
            int pacmanY = 1;
            int ghost1X = 8;
            int ghost1Y = 8;
            int ghost2X = 5;
            int ghost2Y = 5;
            int score = 0;

            // Game loop
            while (!gameOver)
            {
                // Update the game state
                UpdateGameState(gameBoard, ref pacmanX, ref pacmanY, ref ghost1X, ref ghost1Y, ref ghost2X, ref ghost2Y, ref score);

                // Check if the game is over
                gameOver = IsGameOver(gameBoard, pacmanX, pacmanY, ghost1X, ghost1Y, ghost2X, ghost2Y);

                // Print the game board
                PrintGameBoard(gameBoard, pacmanX, pacmanY, ghost1X, ghost1Y, ghost2X, ghost2Y, score);
            }

            // Print a message when the game is over
            Console.WriteLine("Game Over!");
        }

static void UpdateGameState(string[,] gameBoard, ref int pacmanX, ref int pacmanY, ref int ghost1X, ref int ghost1Y, ref int ghost2X, ref int ghost2Y, ref int score)
{
    // Move Pac-Man
    Console.WriteLine("Enter a direction for Pac-Man (W = Up, S = Down, A = Left, D = Right):");
    ConsoleKey key = Console.ReadKey().Key;
    switch (key)
    {
        case ConsoleKey.W:
            if (gameBoard[pacmanY - 1, pacmanX] != "#")
            {
                pacmanY--;
            }
            break;
        case ConsoleKey.S:
            if (gameBoard[pacmanY + 1, pacmanX] != "#")
            {
                pacmanY++;
            }
            break;
        // Add cases for moving left and right here
        case ConsoleKey.A:
            if (gameBoard[pacmanY, pacmanX - 1] != "#")
            {
                pacmanX--;
            }
            break;
        case ConsoleKey.D:
            if (gameBoard[pacmanY, pacmanX + 1] != "#")
            {
                pacmanX++;
            }
            break;

        // Handle any other input
        default:
            // Do nothing
            break;
    }

// Move ghost 1
int dx = 0;
int dy = 0;
// Choose a random direction for the ghost to move in
Random rand = new Random();
int dir = rand.Next(0, 4);
switch (dir)
{
    case 0:
        // Move up
        dy = -1;
        break;
    case 1:
        // Move down
        dy = 1;
        break;
    case 2:
        // Move left
        dx = -1;
        break;
    case 3:
        // Move right
        dx = 1;
        break;
}
// Check if the space in the chosen direction is not a wall
if (gameBoard[ghost1Y + dy, ghost1X + dx] != "#")
{
    // Update the ghost's position
    ghost1X += dx;
    ghost1Y += dy;
}

// Move ghost 2
// Choose a random direction for the ghost to move in
dir = rand.Next(0, 4);
switch (dir)
{
    case 0:
        // Move up
        dy = -1;
        break;
    case 1:
        // Move down
        dy = 1;
        break;
    case 2:
        // Move left
        dx = -1;
        break;
    case 3:
        // Move right
        dx = 1;
        break;
}
// Check if the space in the chosen direction is not a wall
if (gameBoard[ghost2Y + dy, ghost2X + dx] != "#")
{
    // Update the ghost's position
    ghost2X += dx;
    ghost2Y += dy;
}

}

        
static bool IsGameOver(string[,] gameBoard, int pacmanX, int pacmanY, int ghost1X, int ghost1Y, int ghost2X, int ghost2Y)
{
    // Check if Pac-Man has collided with a ghost
    if ((pacmanX == ghost1X && pacmanY == ghost1Y) ||
        (pacmanX == ghost2X && pacmanY == ghost2Y))
    {
        return true;
    }

    // Count the number of dots on the game board
int numDots = 0;
for (int y = 0; y < gameBoard.GetLength(0); y++)
{
    for (int x = 0; x < gameBoard.GetLength(1); x++)
    {
        if (gameBoard[y, x] == ".")
        {
            numDots++;
        }
    }
}

// Check if the score is equal to the number of dots
if (score == numDots)
{
    return true;
}


    // Otherwise, the game is not over
    return false;
}

static void PrintGameBoard(string[,] gameBoard, int pacmanX, int pacmanY, int ghost1X, int ghost1Y, int ghost2X, int ghost2Y, int score)
{
    // Print the game board
    for (int y = 0; y < gameBoard.GetLength(0); y++)
    {
        for (int x = 0; x < gameBoard.GetLength(1); x++)
        {
            // Check if this is the position of Pac-Man
            if (x == pacmanX && y == pacmanY)
            {
                // Print Pac-Man
                Console.Write("P");
            }
            else if (x == ghost1X && y == ghost1Y)
            {
                // Print ghost 1
                Console.Write("G");
            }
            else if (x == ghost2X && y == ghost2Y)
            {
                // Print ghost 2
                Console.Write("G");
            }
            else
            {
                // Print the game board element
                Console.Write(gameBoard[y, x]);
            }
        }
        Console.WriteLine();
    }
    // Print the score
    Console.WriteLine("Score: " + score);
}
