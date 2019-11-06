using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LibrarySystem
{
    class CheckBorrowedBook
    {
        public static void CheckBorrowedBookMethod()
        {
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
        }
    }
}
