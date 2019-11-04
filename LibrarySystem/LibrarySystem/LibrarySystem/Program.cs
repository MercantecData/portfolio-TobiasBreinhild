using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Book kidsBook = new Book();
            Book horrorBook = new Book();
            Book aVeryLongHarryPotterBook = new Book();

            kidsBook.name = "Bob and the GoKart";
            horrorBook.name = "Blood and Gore";
            aVeryLongHarryPotterBook.name = "Harry Potter and The Very Long Book";

            string[] books = { kidsBook.name, horrorBook.name, aVeryLongHarryPotterBook.name };

            string[] borrowedBook = new string[1];

            while(isRunning)
            {
                Console.WriteLine("Welcome to the Library! What can I help you with?");
                Console.WriteLine(" ");
                Console.WriteLine("1. Borrow a book");
                Console.WriteLine("2. Return a book");
                Console.WriteLine("3. Check for borrowed books");
                Console.WriteLine("4. Edit the borrowing time of a book");
                Console.WriteLine("5. Exit the Library");
                Console.WriteLine(" ");

                string libraryOptions = Console.ReadLine();

                switch (libraryOptions)
                {
                    case "1":
                        Console.WriteLine("Which book would you like to borrow?");
                        break;
                    case "2":
                        Console.WriteLine("Which book would you like to return?");
                        break;
                    case "3":
                        Console.WriteLine("Let me just check want you have borrowed");
                        break;
                    case "4":
                        Console.WriteLine("What should the new time be?");
                        break;
                    case "5":
                        Console.WriteLine("See you again soon! Bye!");
                        break;
                    default:
                        Console.WriteLine("I don't understand?!");
                        break;
                }


            }
        }
    }
}
