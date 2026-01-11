using System.Collections.Generic;

namespace Queue;

interface IPrintable
{
    void Print();
}


public class TextDocument : IPrintable
{
    private string content;

    public TextDocument(string content)
    {
        this.content = content;
    }

    public void Print()
    {
        Console.WriteLine("Printing text document: " + content);
    }
}

class ImageFile : IPrintable
{
    private string fileName;

    public ImageFile(string fileName)
    {
        this.fileName = fileName;
    }

    public void Print()
    {
        Console.WriteLine("Printing image file: " + fileName);
    }
}

class PrintQueue
{
    private Queue<IPrintable> queue = new Queue<IPrintable>();

    public void AddJob(IPrintable job)
    {
        queue.Enqueue(job);
        Console.WriteLine("Job added to print queue.");
    }

    public void ProcessNextJob()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No print jobs in queue.");
            return;
        }

        IPrintable job = queue.Dequeue();
        job.Print();
    }
}
