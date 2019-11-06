using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class ReturningBook
    {
        public static void ReturningBookMethod()
        {
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
        }
    }
}
