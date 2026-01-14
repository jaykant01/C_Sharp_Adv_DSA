namespace Events;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 
        Button button = new Button();
        ButtonHandler handler = new ButtonHandler();

        // Subscribe to event
        button.Click += handler.HandleClick;

        // Trigger event
        button.OnClick();

        Console.ReadKey();
    }
}
