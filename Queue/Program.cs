namespace Queue;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        PrintQueue printer = new PrintQueue();

        printer.AddJob(new TextDocument("Hello World"));
        printer.AddJob(new ImageFile("photo.png"));
        printer.AddJob(new TextDocument("Exam Notes"));

        printer.ProcessNextJob();
        printer.ProcessNextJob();
        printer.ProcessNextJob();


        Console.ReadKey();
    }
}
