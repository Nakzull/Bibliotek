using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            bookManager.AddBooks();

            for (; ; )
            {
                Console.WriteLine("Which book do you wish to borrow? ");
                for (int i = 0; i < bookManager.GetBooks().Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {bookManager.GetBooks()[i].Name} - number in stock: {bookManager.GetBooks()[i].Stock}");                   
                }
                Console.WriteLine("5. Done selecting books");
                int userWish = Convert.ToInt32(Console.ReadLine());
                if (userWish < 5)
                    bookManager.GetBook(userWish);
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

