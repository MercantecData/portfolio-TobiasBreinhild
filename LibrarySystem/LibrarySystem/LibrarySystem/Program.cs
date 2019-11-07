using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();


            Console.WriteLine(library.WelcomeMessage());
        }
    }
}
