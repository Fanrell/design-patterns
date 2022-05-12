namespace DesingPatterns.Observer;

public class ObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
        {
            Console.WriteLine("Observer B reacted to the event");
        }
    }
}