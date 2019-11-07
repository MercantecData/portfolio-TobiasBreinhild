using System;
using System.Threading;

namespace LibrarySystem
{
    class Library
    {
        Book kidsBook = new Book("Bob and Bob", 20);
        Book teenBook = new Book("Bob and Bob gets married", 100);
        Book adultBook = new Book("Bob and Bob's Lifestory", 2000);

        public string WelcomeMessage()
        {
            string welcome = "Welcome to Bob and Bob's Library!";

            return welcome;
        }
    }
}
