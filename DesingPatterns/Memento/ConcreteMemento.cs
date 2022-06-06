namespace DesingPatterns.Memento;

public class ConcreteMemento : IMemento
{
    private string _state;

    private DateTime _date;

    public ConcreteMemento(string state)
    {
        _state = state;
        _date = DateTime.Now;
    }

    public string GetName() => $"{_date} / ({_state.Substring(0,9)})";

    public string GetState() => _state;

    public DateTime GetDate() => _date;
}