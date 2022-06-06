namespace DesingPatterns.Template;

public class ConcreteClass1 : AbstractClass
{
    protected override void RequiredOperation1() => Console.WriteLine("ConcreteClass 1: \n Implement Operation 1");

    protected override void RequiredOperation2() => Console.WriteLine("ConcreteClass 1: \n Implement Operation 2");
}