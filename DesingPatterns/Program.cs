// See https://aka.ms/new-console-template for more information

using DesingPatterns.Builder;
using DesingPatterns.Factory;
using DesingPatterns.Mediator;
using DesingPatterns.Mediator.Components;
using DesingPatterns.Observer;

class Program
{
    static void Main(string[] args)
    {
        Mediator();
        Console.WriteLine("===============================");
        Observer();
        Console.WriteLine("===============================");
        Factory();
        Console.WriteLine("===============================");
        Builder();
    }

    private static void Mediator()
    {
        Component1 component1 = new Component1();
        Component2 component2 = new Component2();
        new Mediator(component1, component2);
        
        Console.WriteLine("Client triggerts operation A");
        component1.DoA();
        
        Console.WriteLine("===========");
        
        Console.WriteLine("Client triggerts operation D");
        component2.DoD();
    }

    private static void Observer()
    {
        var subject = new Subject();
        var observerA = new ObserverA();
        var observerB = new ObserverB();
        
        subject.Attach(observerA);
        subject.Attach(observerB);
        
        subject.SomeBusinessLogic();
        subject.SomeBusinessLogic();
        
        subject.Detach(observerB);
        
        subject.SomeBusinessLogic();
    }

    private static void Factory()
    {
        var client = new Client();
        client.Main();
    }

    private static void Builder()
    {
        var director = new Director();
        var builder = new Builder();

        director.Builder = builder;
        
        Console.WriteLine("Basic");
        director.BuildMinimalViableProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
        
        Console.WriteLine("Full featured");
        director.BuildFullFeaturedProduct();
        Console.WriteLine(builder.GetProduct().ListParts());
        
        Console.WriteLine("Custom");
        builder.BuildPartB();
        builder.BuildPartC();
        Console.WriteLine(builder.GetProduct().ListParts());
    }
}