namespace DesingPatterns.Mediator.Components;

public class Component1 : BaseComponent
{
    public void DoA()
    {
        Console.WriteLine("Component 1 does A");
        
        this._mediator.Notify(this, "a");
    }
    
    public void DoB()
    {
        Console.WriteLine("Component 1 does B");
        
        this._mediator.Notify(this, "b");
    }
}