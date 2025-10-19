using System;

class Program
{
    static void Main(string[] args)
    {
        // create array
        Book[] books = new Book[2];

        Person author1 = new Person("J.K. Rowling");
        // set age
        author1.Age = 58;
        books[0] = new Book("Harry Potter", author1);

        // Stephen King author
        books[1] = new Horror("The Shining");

        // loop through books
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine("Book " + (i + 1) + ":");
            Console.WriteLine("Author: " + books[i].Author.Name);
            Console.WriteLine("Title: " + books[i].Title);
            // empty line
            Console.WriteLine();
        }

        Console.WriteLine("Book summaries:");
        // first book
        books[0].GetSummary();
        Console.WriteLine();
        // second book
        books[1].GetSummary();
    }
}
