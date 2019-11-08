using System;

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
                        string chooseBook = Console.ReadLine();
                        bool borrowingBook = true;

                        while (borrowingBook)
                        {
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

                        break;

                    case "4":

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
