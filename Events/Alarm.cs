namespace Events;

public class Alarm
{
    public event Action Triggered;

    public void Start()
    {
        Console.WriteLine("Alarm started...");
        Triggered?.Invoke();
    }
}

public class AlarmHandler
{
    public void OnAlarmTriggered()
    {
        Console.WriteLine("Alarm handled by subscriber");
    }
}