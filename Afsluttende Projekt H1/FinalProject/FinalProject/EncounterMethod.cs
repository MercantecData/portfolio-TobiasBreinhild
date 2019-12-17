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
            }
            else if (randomEncounterOdds >= 5)
            {
                Console.WriteLine("You encountered nothing!");
            }
        }

        public void EnemyEncounter()
        {
            bool isBattling = true;

            string[] difficulties = { "Very Easy", "Easy", "Medium", "Hard", "Very Hard", "Insane", "Deadly", "Impossible"};

            int[] hpAmounts = { 100, 150, 250, 400, 600, 900, 1500, 5000 };

            int[] dmgAmounts = { 10, 15, 25, 40, 60, 90, 150, 500};

            Random random = new Random();

            int randomDifficulty = random.Next(0, 9);

            Enemy enemy = new Enemy(difficulties[randomDifficulty], hpAmounts[randomDifficulty], dmgAmounts[randomDifficulty]);

            Console.WriteLine("This enemy is '" + enemy.difficulty + "' difficulty! Are you sure you want to attack it? \n1. Yes \n2. No \n ");

            string yesNo = Console.ReadLine();

            Console.WriteLine(" \nLet's do this! \n ");

            while (isBattling)
            {
                if(yesNo == "1")
                {
                    enemy.enemyHP -= playerDMG;
                    Console.WriteLine("You hit the enemy for " + playerDMG + " damage! \nIt's at " + enemy.enemyHP + " HP!");
                    playerHP -= enemy.enemyDMG;
                    Console.WriteLine("The enemy hit you for " + enemy.enemyDMG + " damage! \nYou are at " + playerHP + " HP!");

                    if(enemy.enemyHP < 0)
                    {
                        Console.WriteLine("You defeated the enemy! Congrats!");
                        isBattling = false;
                    }
                    else if(playerHP < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("YOU DIED!");
                        isBattling = false;
                    }
                }
                else if (yesNo == "2")
                {
                    int luckyEscape = random.Next(1, 3);
                    if(luckyEscape == 1)
                    {
                        Console.WriteLine("You got away!");
                        isBattling = false;
                    }
                    else if(luckyEscape == 2)
                    {
                        Console.WriteLine("You couldn't get away! \n ");
                        playerHP -= enemy.enemyDMG;
                        Console.WriteLine("The enemy hit you for " + enemy.enemyDMG + " damage! \nYou are at " + playerHP + " HP!");

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

            switch (npc.job)
            {
                case "Farmer":
                    string farmerConversation = Console.ReadLine();
                    if (farmerConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (farmerConversation == "talk")
                    {
                        Console.WriteLine("Have you seen my sheep? It likes to run away sometimes!");
                    }
                    break;

                case "Musician":
                    string musicianConversation = Console.ReadLine();
                    if (musicianConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (musicianConversation == "talk")
                    {
                        Console.Beep(523, 125);
                        Thread.Sleep(250);
                        Console.Beep(392, 125);
                        Thread.Sleep(250);
                        Console.Beep(330, 125);
                        Thread.Sleep(250);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);
                        Console.Beep(494, 125);
                        Thread.Sleep(125);
                        Console.Beep(466, 125);
                        Thread.Sleep(42);
                        Console.Beep(440, 125);
                        Thread.Sleep(125);

                        Console.WriteLine("That's my jam!");
                    }
                    break;

                case "Baker":
                    string bakerConversation = Console.ReadLine();
                    if (bakerConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (bakerConversation == "talk")
                    {
                        Console.WriteLine("Let's get this bread!");
                    }
                    break;

                case "Comedian":
                    string comedianConversation = Console.ReadLine();
                    if (comedianConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (comedianConversation == "talk")
                    {
                        Console.WriteLine("Want to hear a joke? Me neither!");
                    }
                    break;

                case "Lumberjack":
                    string lumberjackConversation = Console.ReadLine();
                    if (lumberjackConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (lumberjackConversation == "talk")
                    {
                        Console.WriteLine("I like to chop down trees!");
                    }
                    break;

                case "Blacksmith":
                    string blacksmithConversation = Console.ReadLine();
                    if (blacksmithConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (blacksmithConversation == "talk")
                    {
                        Console.WriteLine("I have made a lot of stuff in my time. Once I made a 2 meter long sword!");
                    }
                    break;

                case "Cook":
                    string cookConversation = Console.ReadLine();
                    if (cookConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (cookConversation == "talk")
                    {
                        Console.WriteLine("Food is SO good! I like it very much!");
                    }
                    break;

                case "Butcher":
                    string butcherConversation = Console.ReadLine();
                    if (butcherConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (butcherConversation == "talk")
                    {
                        Console.WriteLine("Choppy Chop Chop!");
                    }
                    break;

                case "Artist":
                    string artistConversation = Console.ReadLine();
                    if (artistConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (artistConversation == "talk")
                    {
                        Console.WriteLine("It's relaxing to sit here and paint the nature. Very refreshing!");
                    }
                    break;

                case "Armorer":
                    string armorerConversation = Console.ReadLine();
                    if (armorerConversation == "buy")
                    {
                        Console.WriteLine("Sorry, I don't have anything you can buy. (Coming Soon!)");
                    }
                    else if (armorerConversation == "talk")
                    {
                        Console.WriteLine("This armor is too heavy. Should have made a lighter set!");
                    }
                    break;

                default:
                    Console.WriteLine("ERROR: CODE NOT GOOD");
                    break;
            }
        }
    }
}
