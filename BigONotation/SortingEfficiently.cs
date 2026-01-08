namespace BigONotation;

public class SortingEfficiently
{
    public static int[] GenerateData(int size)
    {
        Random rnd = new Random();
        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
            arr[i] = rnd.Next();

        return arr;
    }

    // Bubble Sort
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for(int i=0; i<n; i++)
        {
            for(int j=0; j<n-1-i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }  
            }
        }
    }

    // Merge Sort
    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1) return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            arr[k++] = left[i] <= right[j] ? left[i++] : right[j++];
        }

        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];
    }

    // Quick Sort
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
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
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}
