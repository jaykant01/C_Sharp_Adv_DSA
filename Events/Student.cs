namespace Events;

public class Student
{
    private int marks;

    // Event using standard .NET pattern
    public event EventHandler<MarksChangedEventArgs> MarksChanged;

    public int Marks
    {
        get { return marks; }
        set
        {
            if (marks != value)
            {
                int oldMarks = marks;
                marks = value;

                OnMarksChanged(oldMarks, marks);
            }
        }
    }

    protected virtual void OnMarksChanged(int oldMarks, int newMarks)
    {
        MarksChanged?.Invoke(
            this,
            new MarksChangedEventArgs(oldMarks, newMarks)
        );
    }
}
