using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    public class Book
    {
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private int Year;

        public int year
        {
            get { return Year; }
            set { Year = value; }
        }

        private string Author;

        public string author
        {
            get { return Author; }
            set { Author = value; }
        }

        private string Publisher;

        public string publisher
        {
            get { return Publisher; }
            set { Publisher = value; }
        }

        private int Version;

        public int version
        {
            get { return Version; }
            set { Version = value; }
        }

        public Book(string Name, string Author, int Year, string Publisher, int Version)
        {
            name = Name;
            author = Author;
            year = Year;
            publisher = Publisher;
            version = Version;
        }
    }
}
