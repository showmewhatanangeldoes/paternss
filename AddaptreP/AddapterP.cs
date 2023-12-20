using System;

public interface ILegacyInterface
{
    void SpecificRequest();
}

public class LegacyClass : ILegacyInterface
{
    public void SpecificRequest()
    {
        Console.WriteLine("LegacyClass: SpecificRequest");
    }
}

public interface ITarget
{
    void Request();
}

public class Adapter : ITarget
{
    private readonly ILegacyInterface legacyObject;

    public Adapter(ILegacyInterface legacyObject)
    {
        this.legacyObject = legacyObject;
    }

    public void Request()
    {
        legacyObject.SpecificRequest();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILegacyInterface legacyObject = new LegacyClass();

        ITarget adapter = new Adapter(legacyObject);

        adapter.Request();
    }
}
