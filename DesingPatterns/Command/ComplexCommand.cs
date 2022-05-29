namespace DesingPatterns.Command;

public class ComplexCommand : ICommand
{
    private Reciver _reciver;
    private string _a;
    private string _b;

    public ComplexCommand(Reciver reciver, string a, string b)
    {
        _reciver = reciver;
        _a = a;
        _b = b;
    }

    public void Execute()
    {
        Console.WriteLine($"Do complex things \n data: \na: {_a} \n b:{_b}");
        _reciver.DoSomething(_a);
        _reciver.DoSomethingElse(_b);
    }
}