namespace DesingPatterns.Mediator.Components;

public class Component2 : BaseComponent
{
    public void DoC()
    {
        Console.WriteLine("Component 2 does C");
        
        this._mediator.Notify(this, "c");
    }
    
    public void DoD()
    {
        Console.WriteLine("Component 2 does D");
        
        this._mediator.Notify(this, "d");
    }
}