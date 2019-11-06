using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class Borrowing
    {
        public static void BorrowingMethod()
        {
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

        }
    }
}
