using System;
using System.Threading;

namespace LibrarySystem
{
    class LibraryOptions
    {
        public static bool isRunning = true;

        public static void LibraryOption()
        {
            Program.books[0] = "Bob and the GoKart";
            Program.books[1] = "Blood and Gore";
            Program.books[2] = "Harry Potter and The Very Long Book";

            Console.WriteLine(" ");
            Console.WriteLine("1. Borrow a book");
            Console.WriteLine("2. Return a book");
            Console.WriteLine("3. Check for borrowed books");
            Console.WriteLine("4. Extend the borrowing time of a book");
            Console.WriteLine("5. Exit the Library");
            Console.WriteLine(" ");

            string libraryOptions = Console.ReadLine();
            Console.WriteLine(" ");

            switch (libraryOptions)
            {
                case "1":
                    Borrowing.BorrowingMethod();
                    break;

                case "2":
                    ReturningBook.ReturningBookMethod();
                    break;

                case "3":
                    CheckBorrowedBook.CheckBorrowedBookMethod();
                    break;

                case "4":
                    ExtendBorrowTime.ExtendBorrowTimeMethod();
                    break;

                case "5":
                    Console.WriteLine("See you again soon! Bye!");
                    Program.isRunning = false;
                    break;

                default:
                    Console.WriteLine("I don't understand?!");
                    Console.WriteLine(" ");
                    break;
            }
        }
    }
}
