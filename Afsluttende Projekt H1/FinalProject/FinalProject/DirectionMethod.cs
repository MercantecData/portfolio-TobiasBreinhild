using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class DirectionMethod
    {
        public static void Game()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("Which direction would you like to go first? \n \nLeft? \nStraight? \nRight? \n");

                bool isChoosing = true;
                while (isChoosing)
                {
                    string input = Console.ReadLine();

                    if (input == "left" || input == "l")
                    {
                        Console.WriteLine("You went left");
                        EncounterMethod.RandomEncounter();
                        Console.WriteLine("\nWhere would you like to go next? \n");
                    }
                    else if (input == "straight" || input == "s")
                    {
                        Console.WriteLine("You went straight");
                        EncounterMethod.RandomEncounter();
                        Console.WriteLine("\nWhere would you like to go next? \n");
                    }
                    else if (input == "right" || input == "r")
                    {
                        Console.WriteLine("You went right");
                        EncounterMethod.RandomEncounter();
                        Console.WriteLine("\nWhere would you like to go next? \n");
                    }
                    else
                    {
                        Console.WriteLine("You didn't move!");
                        Console.WriteLine("\nWhere would you like to go next? \n");
                    }
                }
            }
        }
    }
}
