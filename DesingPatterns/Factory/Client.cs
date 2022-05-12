namespace DesingPatterns.Factory;

public class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with the Creator1");
        ClienCode(new Creator1());
        
        Console.WriteLine("");
        
        Console.WriteLine("App: Launched with the Creator2");
        ClienCode(new Creator2());

    }

    public void ClienCode(Creator creator)
    {
        Console.WriteLine($"Client: I'm not aware of the creator's class, but it still works {creator.SomeOperation()}");
    }
}