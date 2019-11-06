using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class ExtendBorrowTime
    {
        public static void ExtendBorrowTimeMethod()
        {
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
        }
    }
}
