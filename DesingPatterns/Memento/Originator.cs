namespace DesingPatterns.Memento;

public class Originator
{
    private string _state;

    public Originator(string state)
    {
        _state = state;
        Console.WriteLine($"Originator: \n Initial state {_state}");
    }

    public void DoSomething()
    {
        Console.WriteLine("Originator: \n WIP");
        _state = this.GenerateRandomString(30);
        Console.WriteLine($"Originator: \n Change state: {_state}");
    }

    public string GenerateRandomString(int length = 10)
    {
        string allowedSymbol = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string result = string.Empty;

        while (length > 0)
        {
            result += allowedSymbol[new Random().Next(0, allowedSymbol.Length)];
            
            Thread.Sleep(10);

            length--;
        }

        return result;
    }

    public IMemento Save()
    {
        return new ConcreteMemento(_state);
    }

    public void Restore(IMemento memento)
    {
        if (!(memento is ConcreteMemento))
        {
            throw new Exception($"Unknown memento class {memento.ToString()}");
        }

        _state = memento.GetState();
        Console.WriteLine($"Originator: \n State changed {_state}");
    }
}