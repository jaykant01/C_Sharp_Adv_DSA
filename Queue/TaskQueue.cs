using System.Collections.Generic;
namespace Queue;

public interface IBackgroundTask
{
    void Execute();
}

class FileUploadTask : IBackgroundTask
{
    public void Execute()
    {
        Console.WriteLine("Executing file upload task.");
    }
}

class AnalyticsTask : IBackgroundTask
{
    public void Execute()
    {
        Console.WriteLine("Executing analytics task.");
    }
}

class LogTask : IBackgroundTask
{
    public void Execute()
    {
        Console.WriteLine("Executing log processing task.");
    }
}

public class TaskQueue
{
    private Queue<IBackgroundTask> queue = new Queue<IBackgroundTask>();

    public void AddTask(IBackgroundTask task)
    {
        queue.Enqueue(task);
        Console.WriteLine("Task added to queue.");
    }

    public void ProcessNextTask()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("No tasks to process.");
            return;
        }

        IBackgroundTask task = queue.Dequeue();
        task.Execute();
    }
}

