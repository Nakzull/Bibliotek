using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    public class Book
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }

        public Book(string name, string author, int year, string publisher, int version)
        {
            Name = name;
            Author = author;
            Year = year;
            Publisher = publisher;
            Version = version;
        }
    }
}
