using System.Collections.Generic;
namespace Queue;

public interface ICallRequest
{
    void HandleCall();
}


public class SupportCall : ICallRequest
{
    public void HandleCall()
    {
        Console.WriteLine("Handling support call.");
    }
}

public class SalesCall : ICallRequest
{
    public void HandleCall()
    {
        Console.WriteLine("Handling sales call.");
    }
}

public class CallCenterManager
{
    private Queue<ICallRequest> callQueue = new Queue<ICallRequest>();

    public void AddCall(ICallRequest call)
    {
        callQueue.Enqueue(call);
        Console.WriteLine("Call added to queue.");
    }

    public void ProcessNextCall()
    {
        if (callQueue.Count == 0)
        {
            Console.WriteLine("No calls to process.");
            return;
        }

        ICallRequest nextCall = callQueue.Dequeue();
        nextCall.HandleCall();
    }
}
