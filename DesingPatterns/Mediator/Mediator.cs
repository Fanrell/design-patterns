using System.Diagnostics;
using DesingPatterns.Mediator.Components;

namespace DesingPatterns.Mediator;

public class Mediator : IMediator
{
    private Component1 _component1;
    private Component2 _component2;
    public Mediator(Component1 component1, Component2 component2)
    {
        _component1 = component1;
        _component2 = component2;
        SetMediator(_component1);
        SetMediator(_component2);
    }
    
    public void Notify(object sender, string ev)
    {
        switch(ev.ToLower())
        {
            case ("a"):
                Console.WriteLine($"Mediator reacts on {ev} and triggers operations");
                this._component2.DoC();
                break;
            case ("d"):
                Console.WriteLine($"Mediator reacts on {ev} and triggers operations");
                this._component1.DoB();
                this._component2.DoC();
                break;
            default:
                Console.WriteLine($"{ev} was triggered");
                break;
        }
    }

    private void SetMediator<T>(T component) where T : BaseComponent
    {
        component.SetMediator(this);
    }
}