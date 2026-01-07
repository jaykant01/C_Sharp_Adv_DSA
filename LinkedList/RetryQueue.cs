namespace LinkedList;

public interface RetryableTask
{
    void Retry();
}


public class RetryQueue
{
    private class Node
    {
        public RetryableTask task;
        public Node next;

        public Node(RetryableTask task)
        {
            this.task = task;
            this.next = null;
        }
    }

    private Node head; // front of queue

    // Add a failed task to the end
    public void Enqueue(RetryableTask task)
    {
        Node newNode = new Node(task);

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

    // Retry the first failed task (FIFO)
    public void RetryNext()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to retry");
            return;
        }

        head.task.Retry();
        head = head.next;
    }

    // Display pending tasks
    public void DisplayQueue()
    {
        if (head == null)
        {
            Console.WriteLine("Retry queue is empty");
            return;
        }

        Node curr = head;
        Console.WriteLine("Pending tasks in queue:");
        while (curr != null)
        {
            Console.WriteLine($"- {curr.task.GetType().Name}");
            curr = curr.next;
        }
    }
}


class SmsTask : RetryableTask
{
    private string message;
    private string phoneNumber;

    public SmsTask(string phoneNumber, string message)
    {
        this.phoneNumber = phoneNumber;
        this.message = message;
    }

    public void Retry()
    {
        Console.WriteLine($"Retrying SMS to {phoneNumber}: {message}");
    }
}

class EmailTask : RetryableTask
{
    private string recipient;
    private string subject;

    public EmailTask(string recipient, string subject)
    {
        this.recipient = recipient;
        this.subject = subject;
    }

    public void Retry()
    {
        Console.WriteLine($"Retrying Email to {recipient}: {subject}");
    }
}
