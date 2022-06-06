namespace DesingPatterns.Command;

public class SimpleCommand : ICommand
{
    private string _payload = string.Empty;

    public SimpleCommand(string payload)
    {
        _payload = payload;
    }
    
    public void Execute()
    {
        Console.WriteLine($"Simple command: do simple things \n Payload: {_payload}");
    }
}