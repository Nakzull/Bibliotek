using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatitiate my bookmanager and add books to the list of books.
            BookManager bookManager = new BookManager();
            bookManager.AddBooksToRegister();
            List<Book> bookLookUp = bookManager.GetBookLookUp();
            bookManager.AddBook(bookLookUp[0], 5);
            bookManager.AddBook(bookLookUp[1], 4);
            bookManager.AddBook(bookLookUp[2], 2);
            bookManager.AddBook(bookLookUp[3], 3);

            // Infinity loop.
            for (; ; )
            {
                // Variables used to count the total amount of each book in the current stack.
                int harryPotterCount = bookManager.CountBook("Harry Potter");
                int lordOfTheRingsCount = bookManager.CountBook("Lord Of The Rings");
                int eragonCount = bookManager.CountBook("Eragon");
                int redRisingCount = bookManager.CountBook("Red Rising");
                Console.WriteLine("Which book do you wish to borrow? ");
                Console.WriteLine($"1. Harry Potter - number in stock: {harryPotterCount}");
                Console.WriteLine($"2. Lord Of The Rings - number in stock: {lordOfTheRingsCount}");
                Console.WriteLine($"3. Eragon - number in stock: {eragonCount}");
                Console.WriteLine($"4. Red Rising - number in stock: {redRisingCount}");
                Console.WriteLine("5. Done selecting books");
                // Get the users input and check if it's valid.
                int userWish = Convert.ToInt32(Console.ReadLine());
                if (userWish >= 1 && userWish <= 4)
                    bookManager.ReserveBook(bookLookUp[userWish - 1]);
                else if (userWish == 5)
                {
                    bookManager.Checkout();
                }
                else
                    Console.WriteLine("Please input a valid output");
            }
        }
    }
}


