using System;

namespace portfolioThing
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            int[] numbers = new int[input];

            int i = 0;
            
            while (i < input)
            {
                numbers[i] = i;

                Console.WriteLine(numbers[i]);

                i += 1;
            }

            Console.WriteLine(input);
        }
    }
}
