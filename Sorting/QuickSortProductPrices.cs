namespace Sorting;

public class QuickSortProductPrices
{
    public static void QuickSort()
    {
        int[] prices = { 999, 299, 799, 199, 649, 499 };

        Console.WriteLine("Product prices before sorting:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }

        Sort(prices, 0, prices.Length - 1);

        Console.WriteLine("\n\nProduct prices after sorting (Ascending Order):");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
    }

    
    private static void Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            Sort(arr, low, pivotIndex - 1);
            Sort(arr, pivotIndex + 1, high);
        }
    }

    
    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swapTemp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swapTemp;

        return i + 1;
    }
}
