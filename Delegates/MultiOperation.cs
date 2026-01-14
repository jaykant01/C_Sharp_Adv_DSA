namespace Delegates;

public class MultiOperation
{
    public delegate void MyDelegate();

    public static void MethodOne()
    {
        Console.WriteLine("Method One Executed");
    }

    public static void MethodTwo()
    {
        Console.WriteLine("Method Two Executed");
    }

    public static void MethodThree()
    {
        Console.WriteLine("Method Three Executed");
    }
}
