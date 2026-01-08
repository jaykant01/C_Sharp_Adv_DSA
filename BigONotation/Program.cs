using System.Diagnostics;

namespace BigONotation;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        int[] datasetSizes = { 1000, 10000, 1_000_000 };
        int target = -1;

        foreach (int size in datasetSizes)
        {
            int[] data = SearchComparison.GenerateData(size);

            Console.WriteLine($"\nDataset Size: {size}");

            // Linear Search
            Stopwatch sw = Stopwatch.StartNew();
            SearchComparison.LinearSearch(data, target);
            sw.Stop();
            Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");

            // Binary Search
            Array.Sort(data);

            sw.Restart();
            SearchComparison.BinarySearch(data, target);
            sw.Stop();
            Console.WriteLine($"Binary Search Time: {sw.ElapsedMilliseconds} ms");
        }

        Console.ReadKey();
    }
}
