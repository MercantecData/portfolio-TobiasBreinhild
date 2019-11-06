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

        }
    }
}
