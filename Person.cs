using System;

public class Person : IComparable<Person>
{
    // person's name
    private string name;
    // person's age
    private int age;

    public Person(string name)
    {
        this.name = name;
        // default age
        this.age = 0;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    // compare by name
    public int CompareTo(Person? other)
    {
        if (other == null) return 1;
        return this.name.CompareTo(other.name);
    }
}
