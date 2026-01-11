namespace Stack;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //IExpressionEvaluator evaluator;

        //evaluator = new PostfixEvaluator(); 

        //string expression = "3+5*2";
        //int result = evaluator.Evaluate(expression);

        //Console.WriteLine("Expression: " + expression);
        //Console.WriteLine("Result: " + result);



        //  Problem 2
        //INavigationManager browser;

        //browser = new DesktopBrowser();

        //browser.Visit("google.com");
        //browser.Visit("github.com");
        //browser.Visit("stackoverflow.com");
        //browser.Back();
        //browser.Back();
        //browser.Forward();

        //browser.DisplayCurrent();


        // Problem 3
        //ISyntaxChecker checker;

        //checker = new CStyleSyntaxChecker(); 

        //string code = "{ int x = (10 + 20); }";

        //bool isValid = checker.IsSyntaxValid(code);

        //Console.WriteLine("Code: " + code);
        //Console.WriteLine("Syntax Valid: " + isValid);


        // Problem 4
        DrawingApp app = new DrawingApp();

        app.PerformAction(new DrawLineAction());
        app.PerformAction(new DrawCircleAction());
        app.PerformAction(new EraseAction());

        app.Undo();
        app.Undo();

        Console.ReadKey();
    }
}
