namespace Events;

public class Notifier
{
    public event Action<string> MessageSent;

    public void SendMessage(string message)
    {
        Console.WriteLine("Notifier: Sending message...");
        MessageSent?.Invoke(message); 
    }
}

public class MessageReceiver
{
    public void OnMessageReceived(string message)
    {
        Console.WriteLine("Receiver got message: " + message);
    }
}