using System;

class Prototype
{
    public string Title { get; set; }
    public int Id { get; set; }

    public Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Prototype prototype = new Prototype();
        prototype.Id = 1;
        prototype.Title = "Prototype Object";

        Prototype clonedObject = prototype.Clone();
        clonedObject.Id = 2;

        Console.WriteLine($"Original object: ID - {prototype.Id}, Title - {prototype.Title}");
        Console.WriteLine($"Cloned object: ID - {clonedObject.Id}, Title - {clonedObject.Title}");
    }
}