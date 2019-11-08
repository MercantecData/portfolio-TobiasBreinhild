using System;
using System.Threading;

namespace LibrarySystem
{
    class Library
    {
        Book kidsBook = new Book("Bob and Bob", 20);
        Book teenBook = new Book("Bob and Bob gets married", 100);
        Book adultBook = new Book("Bob and Bob's Lifestory", 2000);

        public string[] borrowedBook = { "Nothing" };

        public string WelcomeMessage()
        {
            string welcome = "Welcome to Bob and Bob's Library!";

            return welcome;
        }

        public void BorrowBook1()
        {
            borrowedBook[0] = kidsBook.title;
        }

        public void BorrowBook2()
        {
            borrowedBook[0] = teenBook.title;
        }

        public void BorrowBook3()
        {
            borrowedBook[0] = adultBook.title;
        }
    }
}
