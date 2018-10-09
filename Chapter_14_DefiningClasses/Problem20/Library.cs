using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_14_DefiningClasses.Problem20
{
    class Library
    {
        private const string BookNotFindMessage = "There is no such book";

        public Library(string name)
        {
            Name = name;
            this.Books = new List<Book>();
        }

        public string Name { get; set; }
        public List<Book> Books { get; private set; }

        internal void AddBook(Book book)
        {
            this.Books.Add(book);
        }

        internal Book GetBookByAuthor(string author)
        {
            Book book = this.Books
                .FirstOrDefault(b => b.Author == author);

            if (book == null)
            {
                throw new NullReferenceException(BookNotFindMessage);
            }

            return book;
        }

        internal void DeleteBook(Book book)
        {
            Book bookToDelete = this.GetBookByAuthor(book.Author);

            this.Books.Remove(book);
        }

        internal string GetBookInfo(Book book)
        {
            return book.ToString();
        }

        internal void DonateInitialBooks()
        {
            this.Books.AddRange(new List<Book>()
            {
                new Book("It","Steven King",1983,"749832498375"),
                new Book("Crime and Punishment","Fyodor Dostoevski",1866,"345354354325"),
                new Book("Map and territory","Michelle Welbek",2003,"9878374832748374"),
                new Book("Alice in wonderland","Luois Carol",1888,"43543543545")
            });
        }
    }
}
