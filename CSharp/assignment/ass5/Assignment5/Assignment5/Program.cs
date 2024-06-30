using System;

public class Book
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }

    public Book(string bookName, string authorName)
    {
        BookName = bookName;
        AuthorName = authorName;
    }

    public void Display()
    {
        Console.WriteLine($"Book Name: {BookName}, Author Name: {AuthorName}");
    }
}

public class BookShelf
{
    private Book[] books;

    public BookShelf()
    {
        books = new Book[5];
    }

    public Book this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }

    public void DisplayBooks()
    {
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null)
            {
                books[i].Display();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookShelf bookShelf = new BookShelf();

        bookShelf[0] = new Book("Book1", "Author1");
        bookShelf[1] = new Book("Book2", "Author2");
        bookShelf[2] = new Book("Book3", "Author3");
        bookShelf[3] = new Book("Book4", "Author4");
        bookShelf[4] = new Book("Book5", "Author5");

        bookShelf.DisplayBooks();

        Console.ReadLine();
    }
}