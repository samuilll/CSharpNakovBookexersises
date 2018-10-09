using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Chapter_14_DefiningClasses.Problem20
{
    class Problem_20 : Problem
    {
        public override void Run()
        {
            //Just testing the program with random data
            Library library = new Library("Sofia municipal library");
            library.DonateInitialBooks();

            Book bookToDelete = library.GetBookByAuthor("Fyodor Dostoevski");
            library.DeleteBook(bookToDelete);

            Book bookToAdd = new Book("slaughterhouse 5", "Kurt Vonegut", 1971, "8768767676");
            library.AddBook(bookToAdd);

            foreach (Book book in library.Books)
            {
                Writer.WriteLine(book);
            }
        }
    }
}
