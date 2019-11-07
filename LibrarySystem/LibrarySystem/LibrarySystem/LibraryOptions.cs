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
                            Console.WriteLine("There you go! You have now borrowed " + Program.kidsBook.name);
                            Program.borrowedBook[0] = Program.kidsBook.name;
                            Program.bookBorrowingTime = 7;
                            borrowing = false;
                        }
                        else if (borrowBook == "2")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + Program.horrorBook.name);
                            Program.borrowedBook[0] = Program.horrorBook.name;
                            Program.bookBorrowingTime = 7;
                            borrowing = false;
                        }
                        else if (borrowBook == "3")
                        {
                            Console.WriteLine("There you go! You have now borrowed " + Program.aVeryLongHarryPotterBook.name);
                            Program.borrowedBook[0] = Program.aVeryLongHarryPotterBook.name;
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

                    if (Program.borrowedBook[0] == Program.kidsBook.name)
                    {
                        Console.WriteLine("You have returned: " + Program.kidsBook.name);
                        Program.borrowedBook[0] = "None";
                    }
                    else if (Program.borrowedBook[0] == Program.horrorBook.name)
                    {
                        Console.WriteLine("You have returned: " + Program.horrorBook.name);
                        Program.borrowedBook[0] = "None";
                    }
                    else if (Program.borrowedBook[0] == Program.aVeryLongHarryPotterBook.name)
                    {
                        Console.WriteLine("You have returned: " + Program.aVeryLongHarryPotterBook.name);
                        Program.borrowedBook[0] = "None";
                    }
                    else
                    {
                        Console.WriteLine("You currently don't have any books to return");
                    }
                    break;

                case "3":

                    Console.WriteLine("Let me just check what you have borrowed");
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
                    break;
            }
        }
    }
}
