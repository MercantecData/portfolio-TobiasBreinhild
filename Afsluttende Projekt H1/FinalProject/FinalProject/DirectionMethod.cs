using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class DirectionMethod
    {
        public void Game()
        {
            EncounterMethod Encounters = new EncounterMethod();
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
                        Encounters.RandomEncounter();

                        if (Encounters.playerHP < 0)
                        {
                            isChoosing = false;
                        }

                        Console.WriteLine("\nWhich direction would you like to go next? \n");
                    }
                    else if (input == "straight" || input == "s")
                    {
                        Console.WriteLine("You went straight");
                        Encounters.RandomEncounter();

                        if (Encounters.playerHP < 0)
                        {
                            isChoosing = false;
                        }

                        Console.WriteLine("\nWhich direction would you like to go next? \n");
                    }
                    else if (input == "right" || input == "r")
                    {
                        Console.WriteLine("You went right");
                        Encounters.RandomEncounter();

                        if (Encounters.playerHP < 0)
                        {
                            isChoosing = false;
                        }

                        Console.WriteLine("\nWhich direction would you like to go next? \n");
                    }
                    else
                    {
                        Console.WriteLine("You didn't move!");
                        Console.WriteLine("\nWhich direction would you like to go next? \n");
                    }
                }
                isRunning = false;
            }
        }
    }
}
