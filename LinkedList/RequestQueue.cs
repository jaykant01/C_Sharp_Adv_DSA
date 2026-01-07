namespace LinkedList;

public interface UserRequest
{
    void Serve();
}

public class RequestQueue
{
    private class Node
    {
        public UserRequest request;
        public Node next;

        public Node(UserRequest request)
        {
            this.request = request;
            this.next = null;
        }
    }

    private Node head; // front of queue

    // Add request to the end (FIFO)
    public void EnqueueRequest(UserRequest request)
    {
        Node newNode = new Node(request);

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

    // Serve the next request (remove from front)
    public void ServeNextRequest()
    {
        if (head == null)
        {
            Console.WriteLine("No requests to serve");
            return;
        }

        head.request.Serve();
        head = head.next;
    }

    // Display all pending requests
    public void DisplayQueue()
    {
        if (head == null)
        {
            Console.WriteLine("Request queue is empty");
            return;
        }

        Node curr = head;
        Console.WriteLine("Pending requests in queue:");
        while (curr != null)
        {
            Console.WriteLine($"- {curr.request.GetType().Name}");
            curr = curr.next;
        }
    }
}

class ChatRequest : UserRequest
{
    public string CustomerName { get; }

    public ChatRequest(string customerName)
    {
        CustomerName = customerName;
    }

    public void Serve()
    {
        Console.WriteLine($"Serving chat request for {CustomerName}");
    }
}

class CallRequest : UserRequest
{
    public string CustomerName { get; }

    public CallRequest(string customerName)
    {
        CustomerName = customerName;
    }

    public void Serve()
    {
        Console.WriteLine($"Serving call request for {CustomerName}");
    }
}

class EmailRequest : UserRequest
{
    public string CustomerName { get; }

    public EmailRequest(string customerName)
    {
        CustomerName = customerName;
    }

    public void Serve()
    {
        Console.WriteLine($"Serving email request for {CustomerName}");
    }
}