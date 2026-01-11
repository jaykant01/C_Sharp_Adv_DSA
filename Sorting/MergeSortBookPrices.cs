namespace Sorting;

public class MergeSortBookPrices
{
    public static void MergeSort()
    {
        int[] prices = { 499, 299, 799, 199, 649, 349 };

        Console.WriteLine("Book prices before sorting:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }

        Sort(prices, 0, prices.Length - 1);

        Console.WriteLine("\n\nBook prices after sorting (Ascending Order):");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
    }

    
    private static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    
    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            rightArr[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArr[iIndex] <= rightArr[jIndex])
                arr[k++] = leftArr[iIndex++];
            else
                arr[k++] = rightArr[jIndex++];
        }

        while (iIndex < n1)
            arr[k++] = leftArr[iIndex++];

        while (jIndex < n2)
            arr[k++] = rightArr[jIndex++];
    }
}
