namespace LinkedList;

public interface IExecutable
{
    void Execute();
}

public class JobQueue
{
    private class Node
    {
        public IExecutable job;
        public Node next;

        public Node(IExecutable job)
        {
            this.job = job;
            this.next = null;
        }
    }

    private Node head;

    // Add job to end of queue
    public void EnqueueJob(IExecutable job)
    {
        Node newNode = new Node(job);

        if (head == null)
        {
            head = newNode;
            return;
        }

        Node curr = head;
        while (curr.next != null)
        {
            curr = curr.next;
        }

        curr.next = newNode;
    }

    // Execute the next job (FIFO)
    public void ExecuteNext()
    {
        if (head == null)
        {
            Console.WriteLine("No jobs in queue");
            return;
        }

        head.job.Execute();
        head = head.next;
    }

    // Display pending jobs
    public void DisplayQueue()
    {
        if (head == null)
        {
            Console.WriteLine("Job queue is empty");
            return;
        }

        Node curr = head;
        Console.WriteLine("Pending jobs in queue:");
        while (curr != null)
        {
            Console.WriteLine($"- {curr.job.GetType().Name}");
            curr = curr.next;
        }
    }
}

class DataSyncJob : IExecutable
{
    private string source;

    public DataSyncJob(string source)
    {
        this.source = source;
    }

    public void Execute()
    {
        Console.WriteLine($"Executing Data Sync from {source}");
    }
}

class EmailJob : IExecutable
{
    private string recipient;

    public EmailJob(string recipient)
    {
        this.recipient = recipient;
    }

    public void Execute()
    {
        Console.WriteLine($"Sending email alert to {recipient}");
    }
}

class CleanupJob : IExecutable
{
    private string target;

    public CleanupJob(string target)
    {
        this.target = target;
    }

    public void Execute()
    {
        Console.WriteLine($"Cleaning up {target}");
    }
}