namespace DesingPatterns.Template;

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperation1() => Console.WriteLine("ConcreteClass2: \n Implement Operation 1");

    protected override void RequiredOperation2() => Console.WriteLine("ConcreteClass2: \n Implement Operation 2");

    protected override void Hook1() => Console.WriteLine("ConcreteClass2: \n Override Hook 1");
}