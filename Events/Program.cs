namespace Events;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1 
        //Button button = new Button();
        //ButtonHandler handler = new ButtonHandler();

        //// Subscribe to event
        //button.Click += handler.HandleClick;

        //// Trigger event
        //button.OnClick();


        // Problem 2
        //Notifier notifier = new Notifier();
        //MessageReceiver receiver = new MessageReceiver();

        //// Subscribe to event
        //notifier.MessageSent += receiver.OnMessageReceived;

        //// Trigger event
        //notifier.SendMessage("Hello, this is a custom event message!");


        // Problem 3
        //Alarm alarm = new Alarm();
        //AlarmHandler handler = new AlarmHandler();

        //// Subscribe to event
        //alarm.Triggered += handler.OnAlarmTriggered;
        //Console.WriteLine("Subscribed to event");

        //alarm.Start();

        //// Unsubscribe from event
        //alarm.Triggered -= handler.OnAlarmTriggered;
        //Console.WriteLine("Unsubscribed from event");

        //alarm.Start();


        // Problem 4
        Student student = new Student();
        StudentObserver observer = new StudentObserver();

        // Subscribe to event
        student.MarksChanged += observer.OnMarksChanged;

        student.Marks = 70;
        student.Marks = 85;

        Console.ReadKey();
    }
}
