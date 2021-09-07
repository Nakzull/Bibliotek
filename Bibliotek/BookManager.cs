using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotek
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();
        Stack<Book> userBookCart = new Stack<Book>();
        public List<Book> GetBooks()
        {
            return books;
        }
        public void AddBooks()
        {
            Book harryPotter = new Book("Harry Potter", "J.K. Rowling", 2002, "Bloomsbury Publishing", 1, 5);
            Book lordOfTheRings = new Book("Lord of the Rings", "J.R. Tolkien", 1960, "Allen & Unwin", 2, 4);
            Book eragon = new Book("Eragon", "Christopher Paolini", 2005, "Paolini", 1, 2);
            Book redRising = new Book("Red Rising", "Pierce Brown", 2010, "Del Rey Books", 5, 3);
            books.Add(harryPotter);
            books.Add(lordOfTheRings);
            books.Add(eragon);
            books.Add(redRising);
        }
        public void GetBook(int userWish)
        {
            if (books[userWish - 1].Stock > 0)
            {
                userBookCart.Push(books[userWish -1]);
                books[userWish - 1].Stock--;
            }
            else
                Console.WriteLine("That book is unfortunately out of stock");
        }
        public void Checkout()
        {
            int count = userBookCart.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("You selected {0}\nDo you still wish to borrow that book? (yes/no)", userBookCart.Peek().Name);
                string userConfirm = Console.ReadLine().ToLower();
                if (userConfirm == "no")
                {
                    Console.WriteLine("{0} has been removed from your cart", userBookCart.Peek().Name);
                    if (userBookCart.Peek().Name == books[i].Name)
                        books[i].Stock++;                   
                    userBookCart.Pop();
                }
                else if (userConfirm == "yes")
                {
                    Console.WriteLine("{0} has been checked out", userBookCart.Peek().Name);
                    userBookCart.Pop();
                }
                else
                    Console.WriteLine("Please type either yes or no");
            }
        }
    }
}


