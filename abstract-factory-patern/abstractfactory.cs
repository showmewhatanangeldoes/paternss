interface IAbstractProductA
{
    string MethodA();
}

interface IAbstractProductB
{
    string MethodB();
}

class ConcreteProductA1 : IAbstractProductA
{
    public string MethodA()
    {
        return "ConcreteProductA1: MethodA";
    }
}

class ConcreteProductA2 : IAbstractProductA
{
    public string MethodA()
    {
        return "ConcreteProductA2: MethodA";
    }
}

class ConcreteProductB1 : IAbstractProductB
{
    public string MethodB()
    {
        return "ConcreteProductB1: MethodB";
    }
}

class ConcreteProductB2 : IAbstractProductB
{
    public string MethodB()
    {
        return "ConcreteProductB2: MethodB";
    }
}

interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}
