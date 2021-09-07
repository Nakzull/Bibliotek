using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bibliotek
{
    public class BookManager
    {
        // Instantiate my books and a list of books and a stack of books.
        Book harryPotter = new Book("Harry Potter", "J.K. Rowling", 2002, "Bloomsbury Publishing", 1);
        Book lordOfTheRings = new Book("Lord Of The Rings", "J.R. Tolkien", 1960, "Allen & Unwin", 2);
        Book eragon = new Book("Eragon", "Christopher Paolini", 2005, "Paolini", 1);
        Book redRising = new Book("Red Rising", "Pierce Brown", 2010, "Del Rey Books", 5);       
        List<Book> books = new List<Book>();
        Stack<Book> userBookCart = new Stack<Book>();
        
        //Methods for adding each book to the list of books.
        public void AddHarryPotter(int book)
        {
            for (int i = 0; i < book; i++ )
            books.Add(harryPotter);
        }
        public void AddLordOfTheRings(int book)
        {
            for (int i = 0; i < book; i++)
                books.Add(lordOfTheRings);
        }
        public void AddEragon(int book)
        {
            for (int i = 0; i < book; i++)
                books.Add(eragon);
        }
        public void AddRedRising(int book)
        {
            for (int i = 0; i < book; i++)
                books.Add(redRising);
        }
        // Methods for checking if there are any of the book left in the list of books and if so reserve it by adding it to the stack of books.
        public void ReserveBookHarryPotter()
        {
            if (books.Contains(harryPotter) == true)
            {
                userBookCart.Push(harryPotter);
                books.Remove(harryPotter);
            }
            else
                Console.WriteLine("That book is unfortunately out of stock");
        }
        public void ReserveBookLordOfTheRings()
        {
            if (books.Contains(lordOfTheRings) == true)
            {
                userBookCart.Push(lordOfTheRings);
                books.Remove(lordOfTheRings);
            }
            else
                Console.WriteLine("That book is unfortunately out of stock");
        }
        public void ReserveBookEragon()
        {
            if (books.Contains(eragon) == true)
            {
                userBookCart.Push(eragon);
                books.Remove(eragon);
            }
            else
                Console.WriteLine("That book is unfortunately out of stock");
        }
        public void ReserveBookRedRising()
        {
            if (books.Contains(redRising) == true)
            {
                userBookCart.Push(redRising);
                books.Remove(redRising);
            }
            else
                Console.WriteLine("That book is unfortunately out of stock");
        }
        // Methods for counting the amount of each book currently in the list of books.
        public int CountHarryPotter()
        {
            int length = books.Count;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (books[i].name == "Harry Potter")
                {
                    count++;
                }
            }
            return count;
        }
        public int CountLordOfTheRings()
        {
            int length = books.Count;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (books[i].name == "Lord Of The Rings")
                {
                    count++;
                }
            }
            return count;
        }
        public int CountEragon()
        {
            int length = books.Count;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (books[i].name == "Eragon")
                {
                    count++;
                }
            }
            return count;
        }
        public int CountRedRising()
        {
            int length = books.Count;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (books[i].name == "Red Rising")
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
                Console.WriteLine("You selected {0}\nDo you still wish to borrow that book? (yes/no)", userBookCart.Peek().name);
                string userConfirm = Console.ReadLine().ToLower();
                if (userConfirm == "no")
                {
                    Console.WriteLine("{0} has been removed from your cart", userBookCart.Peek().name);
                    if (userBookCart.Peek().name == "Harry Potter")
                        AddHarryPotter(1);
                    else if (userBookCart.Peek().name == "Lord Of The Rings")
                        AddLordOfTheRings(1);
                    else if (userBookCart.Peek().name == "Eragon")
                        AddEragon(1);
                    else if (userBookCart.Peek().name == "Red Rising")
                        AddRedRising(1);
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
        }
    }
}


