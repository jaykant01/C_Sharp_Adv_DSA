namespace Stack;

interface INavigationManager
{
    void Visit(string url);
    void Back();
    void Forward();
    void DisplayCurrent();
}

public class DesktopBrowser : INavigationManager
{
    private Stack<string> backStack = new Stack<string>();
    private Stack<string> forwardStack = new Stack<string>();
    private string currentPage = null;

    public void Visit(string url)
    {
        if (currentPage != null)
            backStack.Push(currentPage);

        currentPage = url;
        forwardStack.Clear();

        Console.WriteLine("Visited: " + currentPage);
    }

    public void Back()
    {
        if (backStack.Count == 0)
        {
            Console.WriteLine("No pages to go back.");
            return;
        }

        forwardStack.Push(currentPage);
        currentPage = backStack.Pop();

        Console.WriteLine("Back to: " + currentPage);
    }

    public void Forward()
    {
        if (forwardStack.Count == 0)
        {
            Console.WriteLine("No pages to go forward.");
            return;
        }

        backStack.Push(currentPage);
        currentPage = forwardStack.Pop();

        Console.WriteLine("Forward to: " + currentPage);
    }

    public void DisplayCurrent()
    {
        Console.WriteLine("Current Page: " + currentPage);
    }
}
