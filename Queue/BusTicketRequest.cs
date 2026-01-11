using System.Collections.Generic;
namespace Queue;

interface ITicketRequest
{
    void ProcessBooking();
}


public class BusTicketRequest : ITicketRequest
{
    public void ProcessBooking()
    {
        Console.WriteLine("Processing bus ticket booking.");
    }
}

class TrainTicketRequest : ITicketRequest
{
    public void ProcessBooking()
    {
        Console.WriteLine("Processing train ticket booking.");
    }
}

class FlightTicketRequest : ITicketRequest
{
    public void ProcessBooking()
    {
        Console.WriteLine("Processing flight ticket booking.");
    }
}



class TicketBookingService
{
    private Queue<ITicketRequest> requestQueue = new Queue<ITicketRequest>();

    public void AddRequest(ITicketRequest request)
    {
        requestQueue.Enqueue(request);
        Console.WriteLine("Ticket request added to queue.");
    }

    public void ProcessNextRequest()
    {
        if (requestQueue.Count == 0)
        {
            Console.WriteLine("No ticket requests to process.");
            return;
        }

        ITicketRequest request = requestQueue.Dequeue();
        request.ProcessBooking();
    }
}
