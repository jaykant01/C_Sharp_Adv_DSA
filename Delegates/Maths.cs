namespace Delegates;

public class Maths
{
    public delegate int MathOperation(int x, int y);

    public static int Add(int x, int y)
    {
        return x + y; 
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

}
