namespace DesingPatterns.Command;

public class Invoker
{
    private ICommand _onStart;
    private ICommand _onFinish;

    public void SetOnStart(ICommand command)
    {
        _onStart = command;
    }
    
    public void SetOnFinish(ICommand command)
    {
        _onFinish = command;
    }

    public void DoSomethingImportant()
    {
        Console.WriteLine($"Invoker: Before start");
        if (_onStart is ICommand)
        {
            this._onStart.Execute();
        }
        Console.WriteLine("Invoker: Do something important");
        
        Console.WriteLine("Anything before end?");
        
        if (_onFinish is ICommand)
        {
            this._onFinish.Execute();
        }
    }
}