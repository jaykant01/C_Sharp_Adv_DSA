namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // Browser History Navigation
        //Navigation nh = new BrowserHistory();
        //nh.AddFirst("github.com");
        //nh.AddFirst("google.com");
        //nh.AddFirst("stackoverflow.com");
        //nh.AddFirst("epicgames.com");

        //BrowserHistory bh = new BrowserHistory();
        //bh.Display();
        //nh.Backward();
        //nh.Backward();
        //nh.Backward();
        //nh.Backward();
        //nh.Forward();
        //nh.Forward();
        //nh.Forward();
        //nh.Forward();
        
        // Music Playlist Queue
        //MusicPlaylist ms = new MusicPlaylist();
        //ms.ListenLast("Change");
        //ms.ListenLast("Go for it");
        //ms.ListenFirst("Brooklyn Baby");
        //ms.ListenFirst("End of Beginning");
        //ms.Display();
        //ms.PlayCurrent();
        //ms.PlayNext();
        //ms.PlayNext();


        // Undo Feature in Text editor
        UndoFeature un = new UndoFeature();
        un.LastIn("Hello ");
        un.LastIn("I'm ");
        un.LastIn("Jaykant");
        un.Display();

        un.Undo();
        un.Display();

        un.Undo();
        un.Display();

        un.Redo();
        un.Display();

        un.Redo();
        un.Display();

        un.Redo();
        un.Display();
        Console.ReadKey();
    }
}
