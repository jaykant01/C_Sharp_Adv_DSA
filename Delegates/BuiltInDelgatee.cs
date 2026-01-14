namespace Delegates;

public class BuiltInDelgatee
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static void Print(string msg)
    {
        Console.WriteLine(msg);
    }
}
