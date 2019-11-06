using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class ReturningBook
    {
        public static void ReturningBookMethod()
        {
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
        }
    }
}
