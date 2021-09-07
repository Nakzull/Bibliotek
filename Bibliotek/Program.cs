using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();
            bookManager.AddHarryPotter(5);
            bookManager.AddLordOfTheRings(4);
            bookManager.AddEragon(2);
            bookManager.AddRedRising(3);
            
            for (; ; )
            {
                int harryPotterCount = bookManager.CountHarryPotter();
                int lordOfTheRingsCount = bookManager.CountLordOfTheRings();
                int eragonCount = bookManager.CountEragon();
                int redRisingCount = bookManager.CountRedRising();
                Console.WriteLine("Which book do you wish to borrow? ");
                Console.WriteLine($"1. Harry Potter - number in stock: {harryPotterCount}");

                Console.WriteLine($"2. Lord Of The Rings - number in stock: {lordOfTheRingsCount}");

                Console.WriteLine($"3. Eragon - number in stock: {eragonCount}");

                Console.WriteLine($"4. Red Rising - number in stock: {redRisingCount}");

                Console.WriteLine("5. Done selecting books");
                int userWish = Convert.ToInt32(Console.ReadLine());
                if (userWish == 1)
                    bookManager.ReserveBookHarryPotter();
                else if (userWish == 2)
                    bookManager.ReserveBookLordOfTheRings();
                else if (userWish == 3)
                    bookManager.ReserveBookEragon();
                else if (userWish == 4)
                    bookManager.ReserveBookRedRising();
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


