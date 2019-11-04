using System;

namespace portfolioThing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { };

            int i = 0;

            int input = int.Parse(Console.ReadLine());

            while (i < input)
            {
                numbers[i] = i;

                i += 1;
            }
        }
    }
}
