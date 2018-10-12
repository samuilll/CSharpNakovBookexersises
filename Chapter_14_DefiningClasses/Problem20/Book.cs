namespace Chapter_14_DefiningClasses.Problem20
{
    class Book
    {
        public Book(string title, string author, int editionYear, string iSBN)
        {
            Title = title;
            Author = author;
            EditionYear = editionYear;
            ISBN = iSBN;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public int EditionYear { get; set; }
        public string ISBN { get; set; }

        public override string ToString()
        {
            return $"{this.Title} by {this.Author}, edition:{this.EditionYear}, ISBN:{this.ISBN}";
        }
    }
}