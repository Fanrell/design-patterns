namespace DesingPatterns.Factory;

public class Creator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new Product1();
    }
}