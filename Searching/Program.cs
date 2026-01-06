namespace Searching;

class Program
{
    static void Main(string[] args)
    {
        // Linear Search
        //Console.WriteLine("Linear Search");
        //LinearSearch ls = new LinearSearch();
        //Console.WriteLine("Target is at Index: " + ls.LinearS());


        // Binary Search
        Console.WriteLine("Binary Search");
        BinarySearch bs = new BinarySearch();
        Console.WriteLine("Target is at Index: " + bs.BinaryS());

        Console.ReadKey();
    }
}
