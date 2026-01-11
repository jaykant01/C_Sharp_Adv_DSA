namespace HashMap;

public interface IURLStorage
{
    void PutURL(string shortUrl, string longUrl);
    string GetURL(string shortUrl);
}

public class InMemoryURLStorage : IURLStorage
{
    private Dictionary<string, string> urlMap = new Dictionary<string, string>();

    public void PutURL(string shortUrl, string longUrl)
    {
        urlMap[shortUrl] = longUrl;
        Console.WriteLine($"Short URL {shortUrl} mapped to {longUrl}");
    }

    public string GetURL(string shortUrl)
    {
        if (urlMap.TryGetValue(shortUrl, out string longUrl))
        {
            return longUrl;
        }
        Console.WriteLine($"Short URL {shortUrl} not found.");
        return null;
    }
}
