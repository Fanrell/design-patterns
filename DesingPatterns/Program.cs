// See https://aka.ms/new-console-template for more information

using DesingPatterns.Mediator;
using DesingPatterns.Mediator.Components;

class Program
{
    static void Main(string[] args)
    {
        Mediator();
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
}