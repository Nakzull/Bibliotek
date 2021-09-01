using System;
using System.Collections.Generic;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter", "J.K. Rowling", 2002, "Bloomsbury Publishing", 1, 5);
            Book lordOfTheRings = new Book("Lord of the Rings", "J.R. Tolkien", 1960, "Allen & Unwin", 2 , 4);
            Book eragon = new Book("Eragon", "Christopher Paolini", 2005, "Paolini", 1, 2);
            Book redRising = new Book("Red Rising", "Pierce Brown", 2010, "Del Rey Books", 5 , 3);
            List<Book> books = new List<Book>();
            books.Add(harryPotter);
            books.Add(lordOfTheRings);
            books.Add(eragon);
            books.Add(redRising);
            Stack<Book> userBookCart = new Stack<Book>();
            ReturnPoint:
            Console.WriteLine("Which book do you wish to borrow? (1-5)\n1: Harry Potter - number in stock: {0}\n2: Lord of the Rings - number in stock: {1}\n3: Eragon - number in stock: {2}\n4: Red Rising - number in stock: {3}\n5: Checkout your books", harryPotter.stock, lordOfTheRings.stock, eragon.stock, redRising.stock);
            int userWish = Convert.ToInt32(Console.ReadLine());
            switch (userWish)
            {
                case 1:
                    if (harryPotter.stock > 0)
                    {
                        userBookCart.Push(harryPotter);
                        harryPotter.stock--;
                    }
                    else
                        Console.WriteLine("That book is unfortunately out of stock");
                    goto ReturnPoint;
                case 2:
                    if (lordOfTheRings.stock > 0)
                    {
                        userBookCart.Push(lordOfTheRings);
                        lordOfTheRings.stock--;
                    }
                    else
                        Console.WriteLine("That book is unfortunately out of stock");
                    goto ReturnPoint;
                case 3:
                    if (eragon.stock > 0)
                    {
                        userBookCart.Push(eragon);
                        eragon.stock--;
                    }
                    else
                        Console.WriteLine("That book is unfortunately out of stock");
                    goto ReturnPoint;
                case 4:
                    if (redRising.stock > 0)
                    {
                        userBookCart.Push(redRising);
                        redRising.stock--;
                    }
                    else
                        Console.WriteLine("That book is unfortunately out of stock");
                    goto ReturnPoint;
                case 5:
                    int count = userBookCart.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("You selected {0}\nDo you still wish to borrow that book? (yes/no)", userBookCart.Peek().name);
                        string userConfirm = Console.ReadLine();
                        if (userConfirm == "no")
                        {
                            Console.WriteLine("{0} has been removed from your cart", userBookCart.Peek().name);
                            if (userBookCart.Peek().name == "Harry Potter")
                                harryPotter.stock++;
                            else if (userBookCart.Peek().name == "Lord of the Rings")
                                lordOfTheRings.stock++;
                            else if (userBookCart.Peek().name == "Eragon")
                                eragon.stock++;
                            else if (userBookCart.Peek().name == "Red Rising")
                                redRising.stock++;
                            userBookCart.Pop();
                        }
                        else if (userConfirm == "yes")
                        {
                            Console.WriteLine("{0} has been checked out", userBookCart.Peek().name);
                            userBookCart.Pop();
                        }
                        else
                            Console.WriteLine("Please type either yes or no");
                    }
                    break;
            }    
        }
    }
}
