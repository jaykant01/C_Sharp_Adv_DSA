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
        //UndoFeature un = new UndoFeature();
        //un.LastIn("Hello ");
        //un.LastIn("I'm ");
        //un.LastIn("Jaykant");
        //un.Display();

        //un.Undo();
        //un.Display();

        //un.Undo();
        //un.Display();

        //un.Redo();
        //un.Display();

        //un.Redo();
        //un.Display();

        //un.Redo();


        // Customer Service Call Center Queue
        //CallCenterQueue queue = new();
        //queue.AddTicket(new CallTicket(1, "Jay"));
        //queue.AddTicket(new ChatTicket(2, "Will"));
        //queue.AddTicket(new EmailTicket(3, "Steve"));

        //queue.Peek();
        //queue.HandleTicket();
        //queue.HandleTicket();
        //queue.HandleTicket();


        // Train Route Management System
        TrainRoute route = new ExpressRoute();

        route.AddStation("Delhi");
        route.AddStation("Agra");
        route.AddStation("Bhopal");
        route.AddStation("Nagpur");

        route.DisplayRoute();

        route.RemoveStation("Agra");
        route.DisplayRoute();

        route.ReverseRoute();
        route.DisplayRoute();

        Console.ReadKey();
    }
}
