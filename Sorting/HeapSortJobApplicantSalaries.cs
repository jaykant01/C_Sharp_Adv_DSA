namespace Sorting;

public class HeapSortJobApplicantSalaries
{
    public static void HeapSort()
    {
        int[] salaries = { 60000, 45000, 80000, 55000, 70000, 50000 };

        Console.WriteLine("Salary demands before sorting:");
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }

        int n = salaries.Length;

        
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        
        for (int i = n - 1; i > 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            Heapify(salaries, i, 0);
        }

        Console.WriteLine("\n\nSalary demands after sorting (Ascending Order):");
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
    }

    // Heapify method
    private static void Heapify(int[] arr, int size, int root)
    {
        int largest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;

        if (left < size && arr[left] > arr[largest])
            largest = left;

        if (right < size && arr[right] > arr[largest])
            largest = right;

        if (largest != root)
        {
            int swap = arr[root];
            arr[root] = arr[largest];
            arr[largest] = swap;

            Heapify(arr, size, largest);
        }
    }
}
