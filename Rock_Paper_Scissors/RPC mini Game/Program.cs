// See https://aka.ms/new-console-template for more information
using System;
using App;

class Program
{

    static void Main()
    {
        double RoundsPlayed = 0;
        double usersScore = 0;
        double computersScore = 0;
        double winnedRounds = 0;
        double lostRounds = 0;


        Console.WriteLine(" == Welcome to RPC Game, Let's begin: == ");
        Console.WriteLine(" \n");

        Console.WriteLine("Please Choose the Number Of Rounds You Wanna Play");
        Console.WriteLine($"." + 1);
        Console.WriteLine($"." + 2);
        Console.WriteLine($"." + 3);
        Console.WriteLine("\n");
        Console.ReadLine();
        Console.WriteLine(" \n == == == == == == == == == == == == == == == ");

        Console.WriteLine($"Ok, let's begin the game");
        Console.WriteLine("Please choose an option:");

        GameSettings gameSettings = new GameSettings();
        List<string> rpcGameObjects = gameSettings.RPC_GameObjects;
        string userChoice = ""; 
        bool validChoice = false;

        Console.WriteLine("\nPlease choose an option:");
        foreach (string gameObject in rpcGameObjects)
        {
            Console.WriteLine(gameObject); 
        }

        do
        {
            userChoice = Console.ReadLine();

            if (rpcGameObjects.Contains(userChoice, StringComparer.OrdinalIgnoreCase) && (userChoice == "Rock" || userChoice == "Scissors" || userChoice == "Paper"))
            {
                validChoice = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose from the available options (Rock, Scissors, or Paper).");
            }
        } while (!validChoice);

        Console.WriteLine("===== Shoot: ======");

        Console.WriteLine($"You chose: {userChoice}");

        string computerChoice = "";
        bool validChoice2 = false;


        Console.WriteLine("===== Computer's Choice: ======");


        Random random_ComputersChoice = new Random();

        
        
        computerChoice = rpcGameObjects[random_ComputersChoice.Next(rpcGameObjects.Count)];

        Console.WriteLine($"Computer chose: {computerChoice}");

        
        if (userChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It's a tie!");
        }
        else if (
            (userChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase)) ||
            (userChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase)) ||
            (userChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase))
        )
        {
            Console.WriteLine($"You win this round, congratss!");
            usersScore++;
            winnedRounds++;
        }
        else
        {
            Console.WriteLine($"Computer wins this round!");
            computersScore++;
            lostRounds++;
        }

        RoundsPlayed++;

        
        Console.WriteLine("\nDo you want to play another round? (yes/no)");
        string playAgain = Console.ReadLine();

        if (playAgain.Equals("no", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("\nGame Summary:");
            Console.WriteLine($"Total rounds played: {RoundsPlayed}");
            Console.WriteLine($"Your score: {usersScore}");
            Console.WriteLine($"Computer's score: {computersScore}");
            Console.WriteLine($"Rounds won: {winnedRounds}");
            Console.WriteLine($"Rounds lost: {lostRounds}");
            Console.WriteLine("Thanks for playing!");
        }
        else
        {
            validChoice = false;
            Console.Clear(); 
            Console.WriteLine("Let's play another round!");
           
        }

    }
}
