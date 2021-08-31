using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    class Book
    {
        public string name { get; set; }
        public int year { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int version { get; set; }

        public int stock { get; set; }

        public Book(string name, string author, int year, string publisher, int version, int stock)
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.publisher = publisher;
            this.version = version;
            this.stock = stock;
        }
    }
}
