using System;
using System.Collections.Generic;

class SnakeAndLadderGame
{
    private static Dictionary<int, int> snakes = new Dictionary<int, int>
    {
        { 29, 9 },
        { 38, 15 },
        { 47, 5 },
        { 53, 33 },
        { 62, 37 },
        { 86, 54 },
        { 92, 70 },
        { 97, 25 }
    };

    private static Dictionary<int, int> ladders = new Dictionary<int, int>
    {
        { 2, 23 },
        { 8, 34 },
        { 20, 77 },
        { 32, 68 },
        { 41, 79 },
        { 82, 100 },
        { 85, 95 }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Snake and Ladder Game!");

        // Get player names
        Console.Write("Enter name for Player 1: ");
        string player1 = Console.ReadLine();
        Console.Write("Enter name for Player 2: ");
        string player2 = Console.ReadLine();

        // Initialize player positions
        int position1 = 0;
        int position2 = 0;

        bool isPlayer1Turn = true;
        Random rand = new Random();

        while (position1 < 100 && position2 < 100)
        {
            if (isPlayer1Turn)
            {
                Console.WriteLine($"{player1}'s turn. Press 'r' to roll the dice.");
                Console.ReadKey();
                int roll = rand.Next(1, 7);
                Console.WriteLine($"{player1} rolled a {roll}");
                position1 += roll;
                position1 = CheckForSnakesOrLadders(position1);
                Console.WriteLine($"{player1} is now at position {position1}");
                if (position1 >= 100)
                {
                    Console.WriteLine($"{player1} wins!");
                    break;
                }
                isPlayer1Turn = false;
            }
            else
            {
                Console.WriteLine($"{player2}'s turn. Press 'r' to roll the dice.");
                Console.ReadKey();
                int roll = rand.Next(1, 7);
                Console.WriteLine($"{player2} rolled a {roll}");
                position2 += roll;
                position2 = CheckForSnakesOrLadders(position2);
                Console.WriteLine($"{player2} is now at position {position2}");
                if (position2 >= 100)
                {
                    Console.WriteLine($"{player2} wins!");
                    break;
                }
                isPlayer1Turn = true;
            }
        }
    }

    private static int CheckForSnakesOrLadders(int position)
    {
        if (snakes.ContainsKey(position))
        {
            Console.WriteLine($"Oh no! Bitten by a snake. Slipping from {position} to {snakes[position]}");
            return snakes[position];
        }
        if (ladders.ContainsKey(position))
        {
            Console.WriteLine($"Yay! Climbed a ladder. Moving from {position} to {ladders[position]}");
            return ladders[position];
        }
        return position;
    }
}
