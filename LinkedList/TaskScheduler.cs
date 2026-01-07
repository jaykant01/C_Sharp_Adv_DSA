namespace LinkedList;

public abstract class Task
{
    public int Priority { get; }

    protected Task(int priority)
    {
        Priority = priority;
    }

    public abstract void Execute();
}


public class TaskScheduler
{
    private class Node
    {
        public Task task;
        public Node next;

        public Node(Task task)
        {
            this.task = task;
            this.next = null;
        }
    }

    private Node head;

    // Insert based on priority (higher first)
    public void AddTask(Task task)
    {
        Node newNode = new Node(task);

        if (head == null || task.Priority > head.task.Priority)
        {
            newNode.next = head;
            head = newNode;
            return;
        }

        Node curr = head;
        while (curr.next != null && curr.next.task.Priority >= task.Priority)
        {
            curr = curr.next;
        }

        newNode.next = curr.next;
        curr.next = newNode;
    }

    // Execute highest-priority task
    public void ExecuteNext()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to execute");
            return;
        }

        head.task.Execute();
        head = head.next;
    }

    // Display tasks
    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("Task queue is empty");
            return;
        }

        Node curr = head;
        Console.WriteLine("Scheduled tasks:");
        while (curr != null)
        {
            Console.WriteLine($"- {curr.task.GetType().Name} (Priority {curr.task.Priority})");
            curr = curr.next;
        }
    }
}
class EmailTask1 : Task
{
    private string recipient;

    public EmailTask1(string recipient, int priority) : base(priority)
    {
        this.recipient = recipient;
    }

    public override void Execute()
    {
        Console.WriteLine($"Sending email to {recipient} (Priority {Priority})");
    }
}

class ReportTask : Task
{
    private string reportName;

    public ReportTask(string reportName, int priority) : base(priority)
    {
        this.reportName = reportName;
    }

    public override void Execute()
    {
        Console.WriteLine($"Generating report: {reportName} (Priority {Priority})");
    }
}
