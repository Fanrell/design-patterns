namespace DesingPatterns.Factory;

public class Creator2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new Product2();
    }
}