namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Browser History Navigation
        Navigation nh = new BrowserHistory();
        nh.AddFirst("github.com");
        nh.AddFirst("google.com");
        nh.AddFirst("stackoverflow.com");
        nh.AddFirst("epicgames.com");

        BrowserHistory bh = new BrowserHistory();
        bh.Display();
        nh.Backward();
        nh.Backward();
        nh.Backward();
        nh.Backward();
        nh.Forward();
        nh.Forward();
        nh.Forward();
        nh.Forward();
        


        Console.ReadKey();
    }
}
