namespace Events;

public class Button
{
    public event Action Click;

    public void OnClick()
    {
        Console.WriteLine("Button clicked (inside Button class)");
        Click?.Invoke();  
    }
}

public class ButtonHandler
{
    public void HandleClick()
    {
        Console.WriteLine("Button click handled in another class");
    }
}
