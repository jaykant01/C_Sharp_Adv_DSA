namespace LinkedList;

public class MusicPlaylist
{
    private Node head {  get; set; }
    private Node curr {  get; set; }
    
    // Add Song at beginning
    public void ListenFirst(string data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;

        if (curr == null)
        {
            curr = head;
        }
        
    }

    // Add Song at end
    public void ListenLast(string data)
    {
        Node newNode = new Node(data);

        if(head == null)
        {
            head = newNode;
            curr = head;
            return;
        }
        Node temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
    }

    // Play current song
    public void PlayCurrent()
    {
        if (curr == null)
        {
            Console.WriteLine("Playlist is empty");
            return;
        }

        Console.WriteLine($"Now Playing: {curr.data}");
    }

    // Play next song
    public void PlayNext()
    {
        if (curr == null || curr.next == null)
        {
            Console.WriteLine("No next song available");
            return;
        }

        curr = curr.next;
        PlayCurrent();
    }

    // Remove first song
    public void RemoveFirst()
    {
        if (head == null)
        {
            Console.WriteLine("Playlist is empty");
            return;
        }

        head = head.next;
        curr = head;
    }

    // Display Playlist
    public void Display()
    {
        if(head == null)
        {
            Console.WriteLine("Empty PlayList");
            return;
        }
        Node temp = head;
        while(temp !=  null)
        {
            Console.Write(temp.data);
            Console.WriteLine();
            temp = temp.next;
        }
    }
}
