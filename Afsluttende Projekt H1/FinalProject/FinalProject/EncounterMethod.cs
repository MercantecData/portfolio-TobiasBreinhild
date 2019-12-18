using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProject
{
    class EncounterMethod
    {
        public int playerHP = 500;
        public int playerDMG = 50;

        public void RandomEncounter()
        {
            Random randomNumber = new Random();

            int randomEncounterOdds = randomNumber.Next(1, 10);

            if (randomEncounterOdds == 1)
            {
                Console.WriteLine("You encountered a friendly NPC! \n ");
                NpcEncounter();
            }
            else if (randomEncounterOdds == 2)
            {
                Console.WriteLine("You found an item!");
            }
            else if (randomEncounterOdds == 3)
            {
                Console.WriteLine("Oh no! An enemy!");
                EnemyEncounter();
            }
            else if (randomEncounterOdds == 4)
            {
                Console.WriteLine("You've reached a new POI");
                POIEncounter();
            }
            else if (randomEncounterOdds >= 5)
            {
                Console.WriteLine("You encountered nothing!");
            }
        }

        public void POIEncounter()
        {
            bool isExploring = true;

            string[] names = { "TownsVille", "SumTown", "LakeVille", "ForestVille", "MountainVille" };

            int[] citizens = { 20, 40, 60, 80, 100 };

            string[] shops = { "Weapons'n'Stuff", "Buy my things!", "Just Food", "Heavy Clothes", "That Random One" };

            Random random = new Random();

            int randomPOI = random.Next(0, 5);

            PointOfInterest pointOfInterest = new PointOfInterest(names[randomPOI], citizens[randomPOI], shops[randomPOI]);

            Console.WriteLine("Welcome to '" + pointOfInterest.name + "'! There is a total of " + pointOfInterest.amountOfCitizens + " citizens and '" + pointOfInterest.shop + "' is the shop we got here! Enjoy your stay! \n ");
            Console.WriteLine("What would you like to do in " + pointOfInterest.name + "? \n1. Visit the shop \n2. Talk to a random citizen \n3. Leave " + pointOfInterest.name);

            while (isExploring)
            {
                string poiDecision = Console.ReadLine();

                if (poiDecision == "1")
                {
                    bool isShopping = true;
                    Console.WriteLine("Welcome to " + pointOfInterest.shop + "! What can I do for you today? \n ");
                    Console.WriteLine("1. Buy \n2. Sell \n3. Leave \n ");

                    while(isShopping)
                    {
                        string shopDecision = Console.ReadLine();

                        if (shopDecision == "1")
                        {
                            Console.WriteLine("What do you want to buy? (Coming soon!)");
                        }
                        else if (shopDecision == "2")
                        {
                            Console.WriteLine("What do you have to sell? (Coming soon!)");
                        }
                        else if (shopDecision == "3")
                        {
                            Console.WriteLine("Alright! See ya!");
                            isShopping = false;
                        }
                        else
                        {
                            Console.WriteLine("You sadly can't do that in my shop!");
                        }
                    }
                }
                else if (poiDecision == "2")
                {
                    Console.WriteLine("Suh dude! \n ");
                }
                else if (poiDecision == "3")
                {
                    Console.WriteLine("Thanks for visiting! \n ");
                    isExploring = false;
                }
                else
                {
                    Console.WriteLine("You can't do that here! \n ");
                }
            }
        }

        public void EnemyEncounter()
        {
            bool isDeciding = true;

            string[] difficulties = { "Very Easy", "Easy", "Medium", "Hard", "Very Hard", "Insane", "Deadly", "Impossible"};

            int[] hpAmounts = { 100, 150, 250, 400, 600, 900, 1500, 5000 };

            int[] dmgAmounts = { 10, 15, 25, 40, 60, 90, 150, 500};

            Random random = new Random();

            int randomDifficulty = random.Next(0, 8);

            Enemy enemy = new Enemy(difficulties[randomDifficulty], hpAmounts[randomDifficulty], dmgAmounts[randomDifficulty]);

            Console.WriteLine("This enemy is '" + enemy.difficulty + "' difficulty which has " + enemy.enemyHP + " HP and can do " + enemy.enemyDMG + " damage! \nAre you sure you want to attack it? \n1. Yes \n2. No \n ");

            

            while (isDeciding)
            {
                bool isBattling = true;

                string yesNo = Console.ReadLine();

                Console.WriteLine(" \nLet's do this! \n ");

                while (isBattling)
                {

                    if (yesNo == "1" || yesNo == "yes" || yesNo == "y")
                    {
                        enemy.enemyHP -= playerDMG;
                        Console.WriteLine("You hit the enemy for " + playerDMG + " damage! \nIt's at " + enemy.enemyHP + " HP!");

                        if (enemy.enemyHP <= 0)
                        {
                            Console.WriteLine("You defeated the enemy! Congrats!");
                            isBattling = false;
                            isDeciding = false;
                        }
                        else if (enemy.enemyHP > 0)
                        {

                            playerHP -= enemy.enemyDMG;
                            Console.WriteLine("The enemy hit you for " + enemy.enemyDMG + " damage! \nYou are at " + playerHP + " HP!");

                            if (playerHP <= 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(" \n \n \n \n \n \n \n \n \n \n \n \n \n                                                      YOU DIED! \n \n \n \n \n \n \n \n \n \n \n \n \n \n ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ReadLine();
                                isBattling = false;
                                isDeciding = false;
                            }
                        }
                    }
                    else if (yesNo == "2" || yesNo == "no" || yesNo == "n")
                    {
                        int luckyEscape = random.Next(1, 3);
                        if (luckyEscape == 1)
                        {
                            Console.WriteLine("You got away!");
                            isBattling = false;
                            isDeciding = false;
                        }
                        else if (luckyEscape == 2)
                        {
                            Console.WriteLine("You couldn't get away! \n ");
                            playerHP -= enemy.enemyDMG;
                            Console.WriteLine("The enemy hit you for " + enemy.enemyDMG + " damage! \nYou are at " + playerHP + " HP!");
                            if (playerHP <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("YOU DIED!");
                                isBattling = false;
                                isDeciding = false;
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        isBattling = false;
                    }
                }
            }
           
        }

        public void NpcEncounter()
        {
            string[] names = { "James", "Michael", "Paul", "Tom", "Alan", "Dan", "Mary", "Sarah", "Catherine", "Rachel" };

            string[] jobs = { "Farmer", "Musician", "Baker", "Comedian", "Lumberjack", "Blacksmith", "Cook", "Butcher", "Artist", "Armorer" };

            Random random = new Random();

            int randomName = random.Next(0, 10);
            int randomJob = random.Next(0, 10);

            NPC npc = new NPC(names[randomName], jobs[randomJob]);

            Console.WriteLine("Hey, my name is " + npc.name + " and I am a " + npc.job + "! \n ");
            Console.WriteLine("Would you like to 'talk' to the " + npc.job + " or 'buy' something from the " + npc.job + "?");

            string npcDecision = Console.ReadLine();
            switch (npc.job)
            {
                case "Farmer":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("Have you seen my sheep? It likes to run away sometimes!");
                    }
                    break;

                case "Musician":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.Beep(523, 125);
                        Thread.Sleep(200);
                        Console.Beep(392, 125);
                        Thread.Sleep(200);
                        Console.Beep(330, 125);
                        Thread.Sleep(200);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(466, 125);
                        Thread.Sleep(10);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);

                        Console.WriteLine("That's my jam!");
                    }
                    break;

                case "Baker":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("Let's get this bread!");
                    }
                    break;

                case "Comedian":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("Want to hear a joke? Me neither!");
                    }
                    break;

                case "Lumberjack":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("I like to chop down trees!");
                    }
                    break;

                case "Blacksmith":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("I have made a lot of stuff in my time. Once I made a 2 meter long sword!");
                    }
                    break;

                case "Cook":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("Food is SO good! I like it very much!");
                    }
                    break;

                case "Butcher":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("Choppy Chop Chop!");
                    }
                    break;

                case "Artist":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("It's relaxing to sit here and paint the nature. Very refreshing!");
                    }
                    break;

                case "Armorer":
                    if (npcDecision == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (npcDecision == "talk")
                    {
                        Console.WriteLine("This armor is too heavy. Should have made a lighter set!");
                    }
                    break;

                default:
                    Console.WriteLine("ERROR: CODE NOT GOOD. CODE NEEDS ATTENTION");
                    break;
            }
        }
    }
}
