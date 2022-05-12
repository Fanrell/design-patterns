namespace DesingPatterns.Observer;

public class Subject : ISubject
{
    public int State { get; set; } = -0;

    private List<IObserver> _observers = new List<IObserver>();
    
    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attach an obesrver");
        this._observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
        Console.WriteLine("Subject: Detach an obesrver");
    }            

    public void Notify()
    {
        Console.WriteLine("Subject: Notifying obeservers");

        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\n Subject: I'm doing something");
        this.State = new Random().Next(0, 10);

        Thread.Sleep(15);
        
        Console.WriteLine($"Subject: My state - {this.State}");
        this.Notify();
    }
}