namespace DesingPatterns.Observer;

public interface IObserver
{
    void Update(ISubject subject);
}