namespace Events;

public class NewsAgency
{
    public event Action<string> NewsPublished;

    public void PublishNews(string news)
    {
        Console.WriteLine("NewsAgency: Publishing news...");
        NewsPublished?.Invoke(news);
    }
}

public class EmailSubscriber
{
    public void ReceiveNews(string news)
    {
        Console.WriteLine("Email Subscriber received: " + news);
    }
}

public class SmsSubscriber
{
    public void ReceiveNews(string news)
    {
        Console.WriteLine("SMS Subscriber received: " + news);
    }
}