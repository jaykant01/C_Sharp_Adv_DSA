namespace LinkedList;

public class CallCenterQueue
{
    class Node
    {
        public Ticket data;
        public Node next;

        public Node(Ticket data)
        {
            this.data = data;
        }
    }

    private Node head;

    public void AddTicket(Ticket ticket)
    {
        Node newNode = new Node(ticket);

        if(head == null)
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

    public void HandleTicket()
    {
        if(head == null)
        {
            Console.WriteLine("No tickets in queue");
            return;
        }

        Ticket ticket = head.data;
        head = head.next;

        Console.WriteLine(
            $"Handling ticket for {ticket.CustomerName}"
        );
    }

    public void Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Console.WriteLine(
            $"Next: {head.data.GetType()} ticket for {head.data.CustomerName}"
        );
    }
}


public abstract class Ticket
{
    public int Id { get; }
    public string CustomerName { get; }

    protected Ticket(int id, string customerName)
    {
        Id = id;
        CustomerName = customerName;
    }

    public abstract string GetTypeName();
}

class CallTicket : Ticket
{
    public CallTicket(int id, string name) : base(id, name) { }
    public override string GetTypeName()
    {
        return "Call";
    }
}

class ChatTicket : Ticket
{
    public ChatTicket(int id, string name) : base(id, name) { }
    public override string GetTypeName()
    {
        return "Chat";
    }
}

class EmailTicket : Ticket
{
    public EmailTicket(int id, string name) : base(id, name) { }
    public override string GetTypeName()
    {
        return "Email";
    }
}