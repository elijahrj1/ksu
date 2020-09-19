using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab5
{
    class Book : Item
    {
        private string author;
        private string ISBN;

        public Book() : base() { }

        public Book(string title, string author, string ISBN) : base(title)
        {
            this.author = author;
            this.ISBN = ISBN;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public override string GetListing()
        {
            return "Book Title: " + this.GetTitle() + "\nAuthor: " + this.GetAuthor() + "\nISBN: #" + this.GetISBN();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
