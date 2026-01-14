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
        EmptyDel.MessagePrinter printer;

        printer = EmptyDel.WelcomeMessage;
        printer();

        printer = EmptyDel.ErrorMessage;
        printer();

        printer = EmptyDel.SuccessMessage;
        printer();
        
        
        
        Console.ReadKey();

    }
}
