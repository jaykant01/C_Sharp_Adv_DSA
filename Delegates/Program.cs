using System.Numerics;

namespace Delegates;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 by static method call
        //Maths.MathOperation op;

        //op = Maths.Add;
        //Console.WriteLine("Add " + op(10, 5));

        //op = Maths.Subtract;
        //Console.WriteLine("Subtract " + op(10, 5));

        //op = Maths.Multiply;
        //Console.WriteLine("Multiply " + op(10, 5));


        // Problem 1 - Part 2
        //EmptyDel.MessagePrinter printer;

        //printer = EmptyDel.WelcomeMessage;
        //printer();

        //printer = EmptyDel.ErrorMessage;
        //printer();

        //printer = EmptyDel.SuccessMessage;
        //printer();


        // Problem 1 - Part 2 Delegate as Method Parameter
        //int result1 = PerformOperation.PerformOp(10, 5, PerformOperation.Add);
        //int result2 = PerformOperation.PerformOp(10, 5, PerformOperation.Subtract);
        //int result3 = PerformOperation.PerformOp(10, 5, PerformOperation.Multiply);

        //Console.WriteLine("Sum " + result1); 
        //Console.WriteLine("Subtract " + result2); 
        //Console.WriteLine("Multiply " + result3); 


        // Problem 1 - Part 3 Multi Cast Delegate
        //MultiOperation.MyDelegate del = MultiOperation.MethodOne;
        //del += MultiOperation.MethodTwo;
        //del += MultiOperation.MethodThree;
        //del();

        // Problem 1 - PArt 4 Anonymous Delegate
        AnonymousOperation.SquareDelegate square = delegate (int x)
        {
            return x * x;
        };

        int result = square(5);
        Console.WriteLine("Square is: " + result);

        Console.ReadKey();

    }
}
