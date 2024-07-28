# Snake and Ladder Game 🎲🐍🪜


https://github.com/user-attachments/assets/69fcd8f1-6671-4a79-bf21-13aa53f61b56



Welcome to the Snake and Ladder Game! This is a simple two-player console application implemented in C# that lets you enjoy the classic board game.

## Features

- 🎮 Two-player gameplay
- 🎲 Random dice rolls
- 🐍 Snakes that take you down
- 🪜 Ladders that take you up
- 🎉 First player to reach position 100 wins!

## How to Play

1. Clone this repository to your local machine.
2. Open the project in your preferred C# IDE (e.g., Visual Studio, Visual Studio Code).
3. Build and run the project.
4. Follow the on-screen prompts to enter player names and take turns rolling the dice.

## Game Rules

- Players take turns to roll a dice.
- If a player lands on the bottom of a ladder, they move up to the top of the ladder.
- If a player lands on the head of a snake, they slide down to the tail of the snake.
- The first player to reach position 100 wins the game.

## Code Overview

The main game logic is contained in the `SnakeAndLadderGame` class. Here are some key parts of the code:

- **Snakes and Ladders Dictionary:** Positions of snakes and ladders are stored in dictionaries.
  ```csharp
  private static Dictionary<int, int> snakes = new Dictionary<int, int>
  {
      { 29, 9 },
      { 38, 20 },
      { 62, 17 },
      { 73, 53 },
      { 84, 64 },
      { 92, 72 },
      { 95, 75 },
      { 99, 78 }
  };

  private static Dictionary<int, int> ladders = new Dictionary<int, int>
  {
      { 2, 23 },
      { 6, 45 },
      { 20, 59 },
      { 52, 72 },
      { 57, 96 },
      { 71, 92 },
      { 80, 99 }
  };
  ```

- **Main Game Loop:** The game alternates turns between the two players until one of them reaches position 100.
  ```csharp
  while (position1 < 100 && position2 < 100)
  {
      if (isPlayer1Turn)
      {
          // Player 1's turn
      }
      else
      {
          // Player 2's turn
      }
  }
  ```

- **Checking for Snakes or Ladders:** The player's position is checked for snakes or ladders after every roll.
  ```csharp
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
  ```

## Getting Started

1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/snake-and-ladder-game.git
   ```
2. Open the project in your preferred C# IDE.
3. Build and run the project.

## Contributing

Feel free to fork this project and submit pull requests. Any contributions, whether they be bug fixes, new features, or performance improvements, are welcome!

