using System;
using System.Threading;

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

            int bookBorrowingTime = 7;

            kidsBook.name = "Bob and the GoKart";
            horrorBook.name = "Blood and Gore";
            aVeryLongHarryPotterBook.name = "Harry Potter and The Very Long Book";

            string[] books = { kidsBook.name, horrorBook.name, aVeryLongHarryPotterBook.name };

            string[] borrowedBook = { "None" };

            Console.WriteLine(" ");
            Console.WriteLine("Welcome to the Library! What can I help you with?");
            Console.WriteLine(" ");

            while (isRunning)
            {
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
                        Console.WriteLine("Which book would you like to borrow?");
                        Console.WriteLine(" ");
                        Console.WriteLine("1. Bob and the GoKart");
                        Console.WriteLine("2. Blood and Gore");
                        Console.WriteLine("3. Harry Potter and The Very Long Book");
                        Console.WriteLine(" ");

                        string borrowBook = Console.ReadLine();

                        if (borrowBook == "1")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + books[0]);
                            borrowedBook[0] = books[0];
                        }
                        else if (borrowBook == "2")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + books[1]);
                            borrowedBook[0] = books[1];
                        }
                        else if (borrowBook == "3")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + books[2]);
                            borrowedBook[0] = books[2];
                        }

                        break;

                    case "2":
                        if (borrowedBook[0] == books[0])
                        {
                            Console.WriteLine("You have returned: " + books[0]);
                            borrowedBook[0] = "None";
                        }
                        else if (borrowedBook[0] == books[1])
                        {
                            Console.WriteLine("You have returned: " + books[1]);
                            borrowedBook[0] = "None";
                        }
                        else if (borrowedBook[0] == books[2])
                        {
                            Console.WriteLine("You have returned: " + books[2]);
                            borrowedBook[0] = "None";
                        }
                        else
                        {
                            Console.WriteLine("You currently don't have any books to return");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Let me just check want you have borrowed");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(" ");
                        Console.WriteLine("You are currently borrowing: " + borrowedBook[0]);
                        break;

                    case "4":
                        Console.WriteLine("How many days would you like to extend it by? It's currently on " + bookBorrowingTime + " days.");
                        Console.WriteLine(" ");

                        int extendTime = int.Parse(Console.ReadLine());
                        bookBorrowingTime = bookBorrowingTime + extendTime;
                        Console.WriteLine(" ");

                        Console.WriteLine("The borrow time on '" + borrowedBook[0] + "' has been extended by " + extendTime + " days!");
                        Console.WriteLine(" ");
                        Console.WriteLine("You should return '" + borrowedBook[0] + "' in " + bookBorrowingTime + " days!");
                        Console.WriteLine(" ");
                        break;

                    case "5":
                        Console.WriteLine("See you again soon! Bye!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("I don't understand?!");
                        break;
                }


            }
        }
    }
}
