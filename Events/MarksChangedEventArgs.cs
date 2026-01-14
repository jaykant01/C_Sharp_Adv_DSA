namespace Events;

public class MarksChangedEventArgs
{
    public int OldMarks { get; }
    public int NewMarks { get; }

    public MarksChangedEventArgs(int oldMarks, int newMarks)
    {
        OldMarks = oldMarks;
        NewMarks = newMarks;
    }
}


public class StudentObserver
{
    public void OnMarksChanged(object sender, MarksChangedEventArgs e)
    {
        Console.WriteLine(
            $"Marks changed from {e.OldMarks} to {e.NewMarks}"
        );
    }
}
