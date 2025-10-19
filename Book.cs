using System;

public class Book : IComparable<Book>
{
    // book title
    private string title;
    // book author
    private Person? author;

    public Book(string title)
    {
        this.title = title;
        // no author
        this.author = null;
    }

    public Book(string title, Person author)
    {
        this.title = title;
        this.author = author;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public Person? Author
    {
        get { return author; }
        set { author = value; }
    }

    // compare by title
    public int CompareTo(Book? other)
    {
        if (other == null) return 1;
        return this.title.CompareTo(other.title);
    }
    // print book info
    public void GetSummary()
    {
        Console.WriteLine("Title: " + title);
        if (author != null)
        {
            Console.WriteLine("Author: " + author.Name);
            Console.WriteLine("Author Age: " + author.Age);
        }
        else
        {
            Console.WriteLine("Author: Unknown");
        }
    }
}
