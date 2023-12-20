using System;

public class Singleton
{
    private static Singleton instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void SomeMethod()
    {
        Console.WriteLine("This is a method inside the Singleton instance.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Singleton instance = Singleton.GetInstance();
        instance.SomeMethod();

        Singleton anotherInstance = Singleton.GetInstance();
        anotherInstance.SomeMethod();

        if (instance == anotherInstance)
        {
            Console.WriteLine("Both instances are the same Singleton instance.");
        }
    }
}