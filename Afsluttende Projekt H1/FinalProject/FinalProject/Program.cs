using System;
using System.Threading;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectionMethod directionMethod = new DirectionMethod();
            bool isRunning = true;

            Console.WriteLine("Welcome to The Great Adventure of I don't know!");

            Console.WriteLine("Choose an option to continue: \n ");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit Game");

            while (isRunning)
            {
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Write("Starting game");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    directionMethod.Game();
                    isRunning = false;
                }
                else if (input == "2")
                {
                    Console.WriteLine("Okay. Bye!");
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
