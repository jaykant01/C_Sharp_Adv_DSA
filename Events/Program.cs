namespace Events;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 
        //Button button = new Button();
        //ButtonHandler handler = new ButtonHandler();

        //// Subscribe to event
        //button.Click += handler.HandleClick;

        //// Trigger event
        //button.OnClick();


        // Problem 2
        Notifier notifier = new Notifier();
        MessageReceiver receiver = new MessageReceiver();

        // Subscribe to event
        notifier.MessageSent += receiver.OnMessageReceived;

        // Trigger event
        notifier.SendMessage("Hello, this is a custom event message!");

        Console.ReadKey();
    }
}
