namespace LinkedList;

public interface INotification
{
    void Send();
}

public class NotificationQueue
{
    private class Node
    {
        public INotification notification;
        public Node next;

        public Node(INotification notification)
        {
            this.notification = notification;
            this.next = null;
        }
    }

    private Node head;

    // Add notification to queue
    public void Add(INotification notification)
    {
        Node newNode = new Node(notification);

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

    // Send all notifications
    public void SendAll()
    {
        if (head == null)
        {
            Console.WriteLine("No notifications to send");
            return;
        }

        Node curr = head;
        while (curr != null)
        {
            curr.notification.Send();
            curr = curr.next;
        }

        head = null;
    }
}


    class EmailNotification : INotification
    {
        private string email;

        public EmailNotification(string email)
        {
            this.email = email;
        }

        public void Send()
        {
            Console.WriteLine($"Sending EMAIL to {email}");
        }
    }

    class SmsNotification : INotification
    {
        private string phone;

        public SmsNotification(string phone)
        {
            this.phone = phone;
        }

        public void Send()
        {
            Console.WriteLine($"Sending SMS to {phone}");
        }
    }

    class PushNotification : INotification
    {
        private string deviceId;

        public PushNotification(string deviceId)
        {
            this.deviceId = deviceId;
        }

        public void Send()
        {
            Console.WriteLine($"Sending PUSH notification to device {deviceId}");
        }
    }