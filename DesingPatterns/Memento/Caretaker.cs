namespace DesingPatterns.Memento;
/// <summary>
/// Class doesn't work with any concrete Memento class. Doesn't have access to originator. Work for all Memento via interface
/// </summary>
public class Caretaker
{
    private List<IMemento> _mementoes = new List<IMemento>();

    private Originator _originator = null;

    public Caretaker(Originator originator)
    {
        _originator = originator;
    }

    public void Backup()
    {
        Console.WriteLine("Caretaker: \n Saving Originator State....");
        this._mementoes.Add(_originator.Save());
    }

    public void Undo()
    {
        if (_mementoes.Count == 0) 
            return;

        var memento = _mementoes.Last();
        _mementoes.Remove(memento);
        
        Console.WriteLine($"Cartaker: \n Restoring State to: {memento.GetName()}");

        try
        {
            _originator.Restore(memento);
        }
        catch (Exception)
        {
            Undo();
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Caretaker: \n List of memento");

        foreach (var memento in _mementoes)
        {
            Console.WriteLine(memento.GetName());
        }
    }
}