namespace DragonballZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Introduction.WelcomeText();
            Console.WriteLine("Welcome to the Dragonball Z game!");

            // Initialise the game variables
            int playerHealth = 100;
            int opponentHealth = 100;

            // Start the game loop
            while (playerHealth > 0 && opponentHealth > 0)
            {
                // Display the game status
                Console.WriteLine($"Player Health: {playerHealth}");
                Console.WriteLine($"Opponent Health: {opponentHealth}");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Charge");

                // Get the user input
                int userInput = int.Parse(Console.ReadLine());

                // Update the game state based on the user input
                switch (userInput)
                {
                    case 1:
                        // Player attacks the opponent
                        int damage = new Random().Next(10, 21);
                        opponentHealth -= damage;
                        Console.WriteLine($"You attacked and dealt {damage}");
                        break;
                    case 2:
                        // Player defends against the opponent's attack
                        Console.WriteLine("You defended against the opponent's attack.");
                        break;
                    case 3:
                        // Player charges up their energy
                        Console.WriteLine("You charged up your energy.");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                // Opponent's turn
                int opponentMove = new Random().Next(1, 4);
                switch (opponentMove)
                {
                    case 1:
                        // Opponent attacks the player
                        int opponentDamage = new Random().Next(10, 21);
                        playerHealth -= opponentDamage;
                        Console.WriteLine($"Opponent attacked and dealt {opponentHealth} damage to you.");
                        break;
                    case 2:
                        // Opponent defends against the player's attack
                        Console.WriteLine($"Opponent defended against your attack.");
                        break;
                    case 3:
                        // Opponent charges up their energy
                        Console.WriteLine("Opponent charged up their energy.");
                        break;
                    default:
                        break;
                }
            }

            // Display the game result
            if (playerHealth <= 0)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("You win!");
            }
        }
    }
}