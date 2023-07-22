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

        Console.WriteLine("Please Choose the Number Of Rounds You Wanna Play");
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);

        // Create an instance of the GameSettings class
        GameSettings gameSettings = new GameSettings();

        // Access the RPC_GameObjects list
        List<string> rpcGameObjects = gameSettings.RPC_GameObjects;

        // Use the game objects as needed
        foreach (string gameObject in rpcGameObjects)
        {
            Console.WriteLine(gameObject);
        }
    }
}












//End Of The App;
// If the user loses give me the option to retry, if they win say u won, congrats