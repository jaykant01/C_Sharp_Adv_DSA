namespace Queue;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //PrintQueue printer = new PrintQueue();

        //printer.AddJob(new TextDocument("Hello World"));
        //printer.AddJob(new ImageFile("photo.png"));
        //printer.AddJob(new TextDocument("Exam Notes"));

        //printer.ProcessNextJob();
        //printer.ProcessNextJob();
        //printer.ProcessNextJob();

        // Problem 2
        //TicketBookingService service = new TicketBookingService();

        //service.AddRequest(new BusTicketRequest());
        //service.AddRequest(new TrainTicketRequest());
        //service.AddRequest(new FlightTicketRequest());

        //service.ProcessNextRequest();
        //service.ProcessNextRequest();
        //service.ProcessNextRequest();


        //Problem 3
        //TaskQueue dispatcher = new TaskQueue();

        //dispatcher.AddTask(new FileUploadTask());
        //dispatcher.AddTask(new AnalyticsTask());
        //dispatcher.AddTask(new LogTask());

        //dispatcher.ProcessNextTask();
        //dispatcher.ProcessNextTask();
        //dispatcher.ProcessNextTask();


        // Problem 4
        CallCenterManager manager = new CallCenterManager();

        manager.AddCall(new SupportCall());
        manager.AddCall(new SalesCall());
        manager.AddCall(new SupportCall());

        manager.ProcessNextCall();
        manager.ProcessNextCall();
        manager.ProcessNextCall();


        Console.ReadKey();
    }
}
