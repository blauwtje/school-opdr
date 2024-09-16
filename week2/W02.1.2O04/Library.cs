class Library
{
    public int MaximumSize;
    private List<Book> books;
    public Library(int maximumsize)
    {
        MaximumSize = maximumsize;
        books = new List<Book>();
    }
    public bool AddBook(int id, string title)
    {
        if (books.Count < MaximumSize)
        {
            Book newBook = new Book(id, title);
            books.Add(newBook);
            return true;
        }
        else
        {
            return false;
        }
    }
    public string FindBookByID()
    {

    }

}