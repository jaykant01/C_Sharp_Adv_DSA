namespace LinkedList;

 public abstract class Notification
{
    public string Message { get; }

    protected Notification(string message)
    {
        Message = message;
    }

    public abstract string GetTypeName();
}

public class NotificationFeed
{
    private class Node
    {
        public Notification data;
        public Node next;

        public Node(Notification data)
        {
            this.data = data;
        }
    }

    private Node head; // most recent notification

    // Add at beginning → most recent first
    public void AddNotification(Notification notification)
    {
        Node newNode = new Node(notification);
        newNode.next = head;
        head = newNode;
    }

    // Display feed
    public void DisplayFeed()
    {
        if (head == null)
        {
            Console.WriteLine("No notifications");
            return;
        }

        Console.WriteLine("---- Notification Feed ----");

        Node curr = head;
        while (curr != null)
        {
            Console.WriteLine(
                $"{curr.data.GetTypeName()} Notification: {curr.data.Message}"
            );
            curr = curr.next;
        }
    }
}

    class LikeNotification : Notification
    {
        public LikeNotification(string message) : base(message) { }

        public override string GetTypeName()
        {
            return "Like";
        }
    }

    class CommentNotification : Notification
    {
        public CommentNotification(string message) : base(message) { }

        public override string GetTypeName()
        {
            return "Comment";
        }
    }