namespace Delegates;

public class EmptyDel
{
    public delegate void MessagePrinter();

    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the application");
    }

    public static void ErrorMessage()
    {
        Console.WriteLine("An Error has Occurred!");
    }

    public static void SuccessMessage()
    {
        Console.WriteLine("Operation completed Successfully!");
    }
}
