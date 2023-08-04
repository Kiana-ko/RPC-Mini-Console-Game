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

        Console.WriteLine($"You chose: {userChoice}");


        /*Allow the user to choose an object and display it in the command line
        then display the results and afterwards end the game if number of chosen
        rounds r 1 and if not continue the game until the game reaches the rounds
        the user has choosen when starting the game*/

    }
}

//End Of The App;
// If the user loses give me the option to retry, if they win say u won, congrats