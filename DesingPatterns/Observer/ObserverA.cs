namespace DesingPatterns.Observer;

public class ObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject).State < 3)
        {
            Console.WriteLine("Observer A reacted to the Event");
        }
    }
}