class Library
{
    public int MaxSize;
    public List<Book> Books;
    public Library(int maxsize)
    {
        MaxSize = maxsize;
        Books = new List<Book>();
    }
    public bool AddBook(int id, string title)
    {
        if (Books.Count < MaxSize)
        {
            Book newBook = new Book(id, title);
            Books.Add(newBook);
            return true;
        }
        else
        {
            return false;
        }
    }
    public Book FindBookByID(int id)
    {
        foreach (Book book in Books)
        {
            if (book.ID == id)
            {
                return book;
            }
        }
        return null;
    }

    public void EditBookTitle(int id, string title)
    {
        Book book = FindBookByID(id);
        if (book != null)
        {
            book.Title = title;
        }
    }
    public void RemoveBookByTitle(string title)
    {
        for (int i = 0; i < Books.Count; i++)
        {
            if (Books[i].Title == title)
            {
                Books.RemoveAt(i);
                i--;
            }
        }
    }

}