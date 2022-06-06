namespace DesingPatterns.Command;

public class Reciver
{
    public void DoSomething(string s)
    {
        Console.WriteLine($"First of possible actions: works with data: {s}");
    }

    public void DoSomethingElse(string s)
    {
        Console.WriteLine($"Second of possible actions: works with data: {s}");

    }
}