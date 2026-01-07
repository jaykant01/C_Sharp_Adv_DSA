namespace LinkedList;

public class TrainRoute
{
    protected class Node
    {
        public string station;
        public Node next;

        public Node(string station)
        {
            this.station = station;
            this.next = null;
        }
    }

    protected Node head;

    // Add station at end
    public virtual void AddStation(string station)
    {
        Node newNode = new Node(station);

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

    // Remove station by name
    public virtual void RemoveStation(string station)
    {
        if (head == null) return;

        if (head.station == station)
        {
            head = head.next;
            return;
        }

        Node prev = head;
        Node curr = head.next;

        while (curr != null)
        {
            if (curr.station == station)
            {
                prev.next = curr.next;
                return;
            }

            prev = curr;
            curr = curr.next;
        }
    }

    // Reverse train route
    public virtual void ReverseRoute()
    {
        Node prev = null;
        Node curr = head;
        Node next = null;

        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        head = prev;
    }

    // Display route
    public void DisplayRoute()
    {
        if (head == null)
        {
            Console.WriteLine("Route is empty");
            return;
        }

        Node curr = head;
        while (curr != null)
        {
            Console.Write(curr.station + " -> ");
            curr = curr.next;
        }
        Console.WriteLine("END");
    }
}

class ExpressRoute : TrainRoute
{
    public override void AddStation(string station)
    {
        base.AddStation(station);
    }
}

class FreightRoute : TrainRoute
{
    public override void ReverseRoute()
    {
        base.ReverseRoute();
    }
}
