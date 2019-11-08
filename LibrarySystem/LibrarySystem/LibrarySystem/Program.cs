using System;
using System.Threading;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Library library = new Library();

            Console.WriteLine(library.WelcomeMessage());

            Console.WriteLine(" \nWhat do you want to do? \n ");

            while (isRunning)
            {

                Console.WriteLine("1.Borrow a Book \n2.Return Borrowed Book \n3.Check for Borrowed Book \n4.Extend Time on Book \n5.Exit the Library \n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Which book would you like to borrow?\n \n1. Bob and Bob \n2. Bob and Bob gets married \n3. Bob and Bob's Lifestory \n");
                        bool borrowingBook = true;

                        while (borrowingBook)
                        {
                            string chooseBook = Console.ReadLine();

                            switch (chooseBook)
                            {
                                case "1":
                                    library.BorrowBook1();
                                    Console.WriteLine("You have borrowed: " + library.borrowedBook[0] + "\n");
                                    borrowingBook = false;
                                    break;

                                case "2":
                                    library.BorrowBook2();
                                    Console.WriteLine("You have borrowed: " + library.borrowedBook[0] + "\n");
                                    borrowingBook = false;
                                    break;

                                case "3":
                                    library.BorrowBook3();
                                    Console.WriteLine("You have borrowed: " + library.borrowedBook[0] + "\n");
                                    borrowingBook = false;
                                    break;

                                default:
                                    Console.WriteLine("Not a book \n");
                                    break;
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("You have returned: " + library.borrowedBook[0] + "\n");
                        library.borrowedBook[0] = "Nothing";
                        break;

                    case "3":
                        Console.Write("Let me check what you have borrowed");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.Write(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(".");
                        Thread.Sleep(1000);
                        Console.WriteLine(" \nYou are currently borrowing: " + library.borrowedBook[0] + "\n");

                        break;

                    case "4":
                        Console.WriteLine("How many days would you like to extend it by? It's currently on " + library.extendBorrowingTime + " days \n");

                        bool isExtending = true;

                        while (isExtending)
                        {

                            string extendTime = Console.ReadLine();

                            try
                            {
                                library.extendBorrowingTime += Convert.ToInt32(extendTime);
                                Console.WriteLine("You have extended the time on '" + library.borrowedBook[0] + "' to " + library.extendBorrowingTime + " days \n");
                                isExtending = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input \n");
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("See you again soon!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("I don't understand \n ");
                        break;
                }
            }
        }
    }
}
