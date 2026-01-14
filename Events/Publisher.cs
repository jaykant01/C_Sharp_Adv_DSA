namespace Events;

public class Publisher
{
    public event Action<string> NotifyUser;

    public void Send(string message)
    {
        NotifyUser?.Invoke(message);
    }
}


public class Subscriber
{
    public void OnNotify(string message)
    {
        Console.WriteLine("Received: " + message);
    }
}