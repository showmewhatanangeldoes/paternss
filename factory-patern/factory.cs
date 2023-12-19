using System;
public interface IProduct
{
    void Operation();
}

public class ConcreteProduct : IProduct
{
    public void Operation()
    {
        Console.WriteLine("Виконати дію");
    }
}

public class Factory
{
    public IProduct CreateProduct()
    {
        return new ConcreteProduct();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Factory factory = new Factory();
        IProduct product = factory.CreateProduct();
        product.Operation(); 
    }
}