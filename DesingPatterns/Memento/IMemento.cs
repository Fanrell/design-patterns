namespace DesingPatterns.Memento;

public interface IMemento
{
    string GetName();
    string GetState();
    DateTime GetDate();
}