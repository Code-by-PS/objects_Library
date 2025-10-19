using System;

public class Horror : Book
{
    // Stephen King is author
    public Horror(string title) : base(title, new Person("Stephen King"))
    {
    }
}
