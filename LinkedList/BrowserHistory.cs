namespace LinkedList;

public class Node
{
    public string data {  get; set; }
    public Node next { get; set; }
    public Node prev {  get; set; }


    public Node(string data)
    {
        this.data = data;
    }
}

public class BrowserHistory : Navigation
{
    private Node head { get; set; }
    private Node curr { get; set; }

    // AddPage Method
    public override void AddFirst(string data)
    {
        Node newNode = new Node(data);

        if(curr != null)
        {
            curr.next = newNode;
            newNode.prev = curr;
        }
        curr = newNode;
        Console.WriteLine($"Visited: {curr.data}");
    }

    // Forward page
    public override void Forward()
    {
        if(curr.next != null)
        {
            curr = curr.next;
            Console.WriteLine($"Forward to: {curr.data}");
        }
        else
        {
            Console.WriteLine("No next page");
        }
    }

    // Backward page
    public override void Backward()
    {
        if( curr.prev != null)
        {
            curr = curr.prev;
            Console.WriteLine($"Backward to: {curr.data}");
        }
        else
        {
            Console.WriteLine("No previous page");
        }
    }


    // Display all History
    public void Display()
    {
        Node temp = head;
        while(temp != null)
        {
            Console.WriteLine(temp.data + " ");
            temp = temp.next;
        }
        Console.WriteLine();
    }
}

public abstract class Navigation
{
    public abstract void AddFirst(string item);
    public abstract void Backward();
    public abstract void Forward();
}

