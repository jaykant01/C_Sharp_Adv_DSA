using LinkedList;

namespace LinkedList;

public interface IOrder
{
    void Process();
}

public class OrderQueue
{
    private class Node
    {
        public IOrder order;
        public Node next;

        public Node(IOrder order)
        {
            this.order = order;
            this.next = null;
        }
    }

    private Node head; // front of queue

    // Add order to end (FIFO)
    public void EnqueueOrder(IOrder order)
    {
        Node newNode = new Node(order);

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

    // Process next order
    public void ProcessNextOrder()
    {
        if (head == null)
        {
            Console.WriteLine("No orders to process");
            return;
        }

        head.order.Process();
        head = head.next;
    }

    // Display pending orders
    public void DisplayOrders()
    {
        if (head == null)
        {
            Console.WriteLine("Order queue is empty");
            return;
        }

        Node curr = head;
        Console.WriteLine("Pending orders:");
        while (curr != null)
        {
            Console.WriteLine($"- {curr.order.GetType().Name}");
            curr = curr.next;
        }
    }
}

class OnlineOrder : IOrder
{
    private int orderId;

    public OnlineOrder(int orderId)
    {
        this.orderId = orderId;
    }

    public void Process()
    {
        Console.WriteLine($"Processing ONLINE order #{orderId}");
    }
}

class OfflineOrder : IOrder
{
    private int orderId;

    public OfflineOrder(int orderId)
    {
        this.orderId = orderId;
    }

    public void Process()
    {
        Console.WriteLine($"Processing OFFLINE order #{orderId}");
    }
}

class SubscriptionOrder : IOrder
{
    private int orderId;

    public SubscriptionOrder(int orderId)
    {
        this.orderId = orderId;
    }

    public void Process()
    {
        Console.WriteLine($"Processing SUBSCRIPTION order #{orderId}");
    }
}
