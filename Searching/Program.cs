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
        //Console.WriteLine("Binary Search");
        //BinarySearch bs = new BinarySearch();
        //Console.WriteLine("Target is at Index: " + bs.BinaryS());

        // Negative number
        //NegativeNumber nv = new NegativeNumber();

        //int firstNegative = nv.FindFirstNegative();

        //if (firstNegative != int.MinValue)
        //{
        //    Console.WriteLine("First negative number is: " + firstNegative);
        //}
        //else
        //{
        //    Console.WriteLine("No negative numbers found in the array.");
        //}

        // Sentence Searching
        //SentenceSearch ss = new SentenceSearch();
        //string result = ss.FindSentenceWithWord(); 
        //Console.WriteLine(result);


        // Binary search Problems
        //RotatedArray ra = new RotatedArray(); 
        //ra.PrintResult();


        //PeakElementFinder finder = new PeakElementFinder();
        //finder.PrintPeak();


        MatrixBinarySearch search = new MatrixBinarySearch();
        search.PrintResult();

        Console.ReadKey();
    }
}
