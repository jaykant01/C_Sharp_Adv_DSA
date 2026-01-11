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
        INavigationManager browser;

        browser = new DesktopBrowser();

        browser.Visit("google.com");
        browser.Visit("github.com");
        browser.Visit("stackoverflow.com");
        browser.Back();
        browser.Back();
        browser.Forward();

        browser.DisplayCurrent();

        Console.ReadKey();
    }
}
