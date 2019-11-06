using System;
using System.Threading;

namespace LibrarySystem
{
    class LibraryOptions
    {
        public static bool isRunning = true;

        public static void LibraryOption()
        {
            Program.kidsBook.name = "Bob and the GoKart";
            Program.horrorBook.name = "Blood and Gore";
            Program.aVeryLongHarryPotterBook.name = "Harry Potter and The Very Long Book";

            Console.WriteLine(" \n1. Borrow a book \n2. Return a book \n3. Check for borrowed books \n4. Extend the borrowing time of a book\n5. Exit the Library \n ");
            
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
                    break;
            }
        }
    }
}
