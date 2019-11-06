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
                    bool borrowing = true;

                    while (borrowing)
                    {
                        Console.WriteLine("Which book would you like to borrow?");
                        Console.WriteLine(" ");
                        Console.WriteLine("1. Bob and the GoKart");
                        Console.WriteLine("2. Blood and Gore");
                        Console.WriteLine("3. Harry Potter and The Very Long Book");
                        Console.WriteLine(" ");

                        string borrowBook = Console.ReadLine();
                        Console.WriteLine(" ");

                        if (borrowBook == "1")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + Program.books[0]);
                            Program.borrowedBook[0] = Program.books[0];
                            Program.bookBorrowingTime = 7;
                            borrowing = false;
                        }
                        else if (borrowBook == "2")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + Program.books[1]);
                            Program.borrowedBook[0] = Program.books[1];
                            Program.bookBorrowingTime = 7;
                            borrowing = false;
                        }
                        else if (borrowBook == "3")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + Program.books[2]);
                            Program.borrowedBook[0] = Program.books[2];
                            Program.bookBorrowingTime = 7;
                            borrowing = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine(" ");
                        }
                    }

                    break;

                case "2":
                    if (Program.borrowedBook[0] == Program.books[0])
                    {
                        Console.WriteLine("You have returned: " + Program.books[0]);
                        Program.borrowedBook[0] = "None";
                    }
                    else if (Program.borrowedBook[0] == Program.books[1])
                    {
                        Console.WriteLine("You have returned: " + Program.books[1]);
                        Program.borrowedBook[0] = "None";
                    }
                    else if (Program.borrowedBook[0] == Program.books[2])
                    {
                        Console.WriteLine("You have returned: " + Program.books[2]);
                        Program.borrowedBook[0] = "None";
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
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine("You are currently borrowing: " + Program.borrowedBook[0]);
                    break;

                case "4":
                    bool borrowTime = true;

                    while (borrowTime)
                    {
                        Console.WriteLine("How many days would you like to extend it by? It's currently on " + Program.bookBorrowingTime + " days.");
                        Console.WriteLine(" ");

                        string extendTime = Console.ReadLine();
                        Console.WriteLine(" ");

                        try
                        {
                            Program.bookBorrowingTime += Convert.ToInt32(extendTime);
                            Console.WriteLine("The borrow time on '" + Program.borrowedBook[0] + "' has been extended by " + extendTime + " days!");
                            Console.WriteLine(" ");
                            Console.WriteLine("You should return '" + Program.borrowedBook[0] + "' in " + Program.bookBorrowingTime + " days!");
                            Console.WriteLine(" ");
                            borrowTime = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid amount");
                            Console.WriteLine(" ");
                        }
                    }
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
