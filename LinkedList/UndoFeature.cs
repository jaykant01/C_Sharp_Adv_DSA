namespace LinkedList;

public class UndoFeature
{
    public class Node
    {
        public string data;
        public Node next;

        public Node(string data)
        {
            this.data = data;
        }
    }

    private Node head;
    // Redo
    private Node redoHead;
    private Node curr;
    

    public void LastIn(string data)
    {
        Node newNode = new Node(data);

        if(head == null)
        {
            head = newNode;
            return;
        }
        else
        {
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
        redoHead = null;
        
    }

    public void Undo()
    {
        if(head == null)
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        if(head.next == null)
        {
            Node temp = head;
            head = null;

            // Move to redo list
            temp.next = redoHead;
            redoHead = temp;
            return;
        }

        Node secLast = head;
        Node last = head.next;

        while(last.next != null)
        {
            last = last.next;
            secLast = secLast.next;
        }
        secLast.next = null;

        // Move to Redo List
        last.next = redoHead;
        redoHead = last;
    }

    // Redo 
    public void Redo()
    {
        if(redoHead == null)
        {
            Console.WriteLine("Nothing to redo");
            return;
        }

        Node temp = redoHead;
        redoHead = redoHead.next;

        temp.next = null;

        if (head == null)
        {
            head = temp;
        }
        else
        {
            Node curr = head;
            while(curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = temp;
        }
    }

    // Print Text Editor
    public void Display()
    {
        if(head == null)
        {
            Console.WriteLine("Text Editor is Empty");
            return;
        }

        Node curr = head;
        while(curr != null)
        {
            Console.Write(curr.data);
            curr = curr.next;
        }
        Console.WriteLine();
    }
}
