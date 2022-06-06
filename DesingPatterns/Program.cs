// See https://aka.ms/new-console-template for more information

using DesingPatterns.Builder;
using DesingPatterns.Command;
using DesingPatterns.Mediator;
using DesingPatterns.Mediator.Components;
using DesingPatterns.Memento;
using DesingPatterns.Observer;
using DesingPatterns.Strategy;
using DesingPatterns.Template;
using Client = DesingPatterns.Factory.Client;

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
        Console.WriteLine("===============================");
        Command();
        Console.WriteLine("===============================");
        Memento();
        Console.WriteLine("===============================");
        Template();
        Console.WriteLine("===============================");
        Strategy();
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

    private static void Command()
    {
        var invoker = new Invoker();
        invoker.SetOnStart(new SimpleCommand("Hi all"));
        var reciver = new Reciver();
        invoker.SetOnFinish(new ComplexCommand(reciver, "Send Email", "Save Raport"));
        
        invoker.DoSomethingImportant();
    }

    private static void Memento()
    {
        Originator originator = new Originator("Super-duper-super-puper-super.");
        Caretaker caretaker = new Caretaker(originator);

        caretaker.Backup();
        originator.DoSomething();

        caretaker.Backup();
        originator.DoSomething();

        caretaker.Backup();
        originator.DoSomething();

        Console.WriteLine();
        caretaker.ShowHistory();

        Console.WriteLine("\nClient: Now, let's rollback!\n");
        caretaker.Undo();

        Console.WriteLine("\n\nClient: Once more!\n");
        caretaker.Undo();

        Console.WriteLine();
    }

    private static void Template()
    {
        Console.WriteLine("Same client code can work with different subclasses:");

        DesingPatterns.Template.Client.ClientCode(new ConcreteClass1());

        Console.Write("\n");
            
        Console.WriteLine("Same client code can work with different subclasses:");
        DesingPatterns.Template.Client.ClientCode(new ConcreteClass2());
    }

    private static void Strategy()
    {
        var context = new Context();

        Console.WriteLine("Client: Strategy is set to normal sorting.");
        context.SetStrategy(new ConcreteStrategyA());
        context.DoBusinessLogic();
            
        Console.WriteLine();
            
        Console.WriteLine("Client: Strategy is set to reverse sorting.");
        context.SetStrategy(new ConcreteStrategyB());
        context.DoBusinessLogic();
    }
}