using System;

namespace LibrarySystem
{
    class Program
    {
        public static Book kidsBook = new Book();
        public static Book horrorBook = new Book();
        public static Book aVeryLongHarryPotterBook = new Book();

        public static string[] books = { kidsBook.name, horrorBook.name, aVeryLongHarryPotterBook.name };

        public static string[] borrowedBook = { "None" };

        public static int bookBorrowingTime = 7;

        public static bool isRunning = true;

        static void Main(string[] args)
        {

            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Library! What can I help you with?");
            Console.WriteLine(" ");

            while (isRunning)
            {
                LibraryOptions.LibraryOption();
            }
        }
    }
}
