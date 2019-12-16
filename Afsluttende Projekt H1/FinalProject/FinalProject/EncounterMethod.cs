using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class EncounterMethod
    {
        public static void RandomEncounter()
        {
            Random randomNumber = new Random();

            int randomEncounterOdds = randomNumber.Next(1, 10);

            if (randomEncounterOdds == 1)
            {
                Console.WriteLine("You encountered a friendly NPC!");
            }
            else if (randomEncounterOdds == 2)
            {
                Console.WriteLine("You found an item!");
            }
            else if (randomEncounterOdds == 3)
            {
                Console.WriteLine("Oh no! An enemy!");
            }
            else if (randomEncounterOdds == 4)
            {
                Console.WriteLine("You've reached a new POI");
            }
            else if (randomEncounterOdds >= 5)
            {
                Console.WriteLine("You encountered nothing!");
            }
        }
    }
}
