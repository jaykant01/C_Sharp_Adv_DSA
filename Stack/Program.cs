namespace Stack;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        IExpressionEvaluator evaluator;

        evaluator = new PostfixEvaluator(); 

        string expression = "3+5*2";
        int result = evaluator.Evaluate(expression);

        Console.WriteLine("Expression: " + expression);
        Console.WriteLine("Result: " + result);

        Console.ReadKey();
    }
}
