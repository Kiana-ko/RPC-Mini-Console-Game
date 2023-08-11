using System;
using System.Collections.Generic;

namespace App
{
    public class GameSettings
    {
        
        public int desiredGameRounds;
        public int gameItemsCount; 
        public int gameItems;

        public List<string> RPC_GameObjects { get; set; }


        public int DesiredGameRounds 
        {
            get { return desiredGameRounds; }
            set
            {
                if (value >= 1)
                {
                    desiredGameRounds = value;
                }

                if (value < 0)
                {
                    throw new InvalidOperationException("Only Positive numbers are allowed");
                }
            }
        }

        public int Number_Of_GameItems
        {
            get { return gameItemsCount; }
            set { gameItemsCount = value; }
        }

        public int GameItems
        {
            get { return gameItems; }
            set
            {
                if (value >= 1)
                {
                    gameItems = value;
                }

                if (value < 0)
                {
                    throw new InvalidOperationException("Only Positive numbers are allowed");
                }
            }
        }



        public GameSettings()
        {
            
            RPC_GameObjects = new List<string> { "Rock", "Paper", "Scissors" };
        }
    }
}
