namespace Delegates;
// Delegate as Method Parameter
public class PerformOperation
{
    public delegate int DelegateName(int x, int y);

    public static int PerformOp(int a, int b, DelegateName op)
    {
        return op(a, b);
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

}
