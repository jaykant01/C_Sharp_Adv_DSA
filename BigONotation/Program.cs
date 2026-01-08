using System.Diagnostics;

namespace BigONotation;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1
        //int[] datasetSizes = { 1000, 10000, 1_000_000 };
        //int target = -1;

        //foreach (int size in datasetSizes)
        //{
        //    int[] data = SearchComparison.GenerateData(size);

        //    Console.WriteLine($"\nDataset Size: {size}");

        //    // Linear Search
        //    Stopwatch sw = Stopwatch.StartNew();
        //    SearchComparison.LinearSearch(data, target);
        //    sw.Stop();
        //    Console.WriteLine($"Linear Search Time: {sw.ElapsedMilliseconds} ms");

        //    // Binary Search
        //    Array.Sort(data);

        //    sw.Restart();
        //    SearchComparison.BinarySearch(data, target);
        //    sw.Stop();
        //    Console.WriteLine($"Binary Search Time: {sw.ElapsedMilliseconds} ms");
        //}

        // Problem 2 Sorting Large Data Efficiently
        int[] sizes = { 1000, 10000 };

        foreach (int size in sizes)
        {
            Console.WriteLine($"\nDataset Size: {size}");

            int[] data1 = SortingEfficiently.GenerateData(size);
            int[] data2 = (int[])data1.Clone();
            int[] data3 = (int[])data1.Clone();

            Stopwatch sw = new Stopwatch();

            // Bubble Sort
            sw.Start();
            SortingEfficiently.BubbleSort(data1);
            sw.Stop();
            Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds} ms");

            // Merge Sort
            sw.Restart();
            SortingEfficiently.MergeSort(data2);
            sw.Stop();
            Console.WriteLine($"Merge Sort: {sw.ElapsedMilliseconds} ms");

            // Quick Sort
            sw.Restart();
            SortingEfficiently.QuickSort(data3, 0, data3.Length - 1);
            sw.Stop();
            Console.WriteLine($"Quick Sort: {sw.ElapsedMilliseconds} ms");
        }
        Console.ReadKey();
    }
}
