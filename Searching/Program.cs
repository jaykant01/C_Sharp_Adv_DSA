namespace Searching;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Linear Search");
        LinearSearch ls = new LinearSearch();
        Console.WriteLine("Target is at Index: " + ls.LinearS());
        Console.ReadKey();
    }
}
