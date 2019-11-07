using System;

namespace LibrarySystem
{
    class Program
    {
        public static Book kidsBook = new Book();
        public static Book horrorBook = new Book();
        public static Book aVeryLongHarryPotterBook = new Book();

        public static string[] borrowedBook = { "Nothing" };

        public static int bookBorrowingTime = 7;

        public static bool isRunning = true;

        static void Main(string[] args)
        {

            Console.WriteLine(" \nWelcome to the Library! What can I help you with? \n \nYou are able to borrow one book at a time");

            while (isRunning)
            {
                LibraryOptions.LibraryOption();
            }
        }
    }
}
