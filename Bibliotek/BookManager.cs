using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotek
{
    public class BookManager
    {
        // Instantiate my books and a list with a register of books, a list of all books in the library and a stack of books.
        Book harryPotter = new Book("Harry Potter", "J.K. Rowling", 2002, "Bloomsbury Publishing", 1);
        Book lordOfTheRings = new Book("Lord Of The Rings", "J.R. Tolkien", 1960, "Allen & Unwin", 2);
        Book eragon = new Book("Eragon", "Christopher Paolini", 2005, "Paolini", 1);
        Book redRising = new Book("Red Rising", "Pierce Brown", 2010, "Del Rey Books", 5);
        List<Book> bookRegister = new List<Book>();
        List<Book> books = new List<Book>();
        Stack<Book> userBookCart = new Stack<Book>();

        // Method for adding one of each book to the register.
        public void AddBooksToRegister()
        {
            bookRegister.Add(harryPotter);
            bookRegister.Add(lordOfTheRings);
            bookRegister.Add(eragon);
            bookRegister.Add(redRising);
        }
        public List<Book> GetBookLookUp()
        {
            return bookRegister;
        }
    
        // Method for adding a book to the list of books.
        public void AddBook(Book book, int amount)
        {
            for (int i = 0; i < amount; i++ )
            books.Add(book);
        }
        // Method for checking if there are any of the book left in the list of books and if so reserve it by adding it to the stack of books.
        public void ReserveBook(Book name)
        {
            if (books.Contains(name) == true)
            {
                userBookCart.Push(name);
                books.Remove(name);
            }
            else
                Console.WriteLine("That book is unfortunately out of stock");
        }

        // Method for counting the amount of a book currently in the list of books.
        public int CountBook(string name)
        {
            int count = 0;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == name)
                {
                    count++;
                }
            }
            return count;
        }

    
        // Method for letting the user checkout the books he reserved in his stack of books earlier. The user will have to confirm each selection
        // before it's successfully checked out. If the user doesn't confirm the checkout the book will be returned to the list of books.
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
                    if (userBookCart.Peek().Name == "Harry Potter")
                        AddBook(harryPotter, 1);
                    else if (userBookCart.Peek().Name == "Lord Of The Rings")
                        AddBook(lordOfTheRings, 1);
                    else if (userBookCart.Peek().Name == "Eragon")
                        AddBook(eragon, 1);
                    else if (userBookCart.Peek().Name == "Red Rising")
                        AddBook(redRising, 1);
                    userBookCart.Pop();
                }
                else if (userConfirm == "yes")
                {
                    Console.WriteLine("{0} has been checked out", userBookCart.Peek().Name);
                    userBookCart.Pop();
                }
                else
                {
                    Console.WriteLine("Please type either yes or no");
                    count++;
                }
            }
        }
    }
}


