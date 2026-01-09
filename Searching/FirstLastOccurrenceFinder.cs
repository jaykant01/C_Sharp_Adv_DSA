namespace Searching;

public class FirstLastOccurrenceFinder
{
    private int[] arr = { 1, 2, 2, 2, 3, 4, 5 };
    private int target = 2;

    public int FindFirstOccurrence()
    {
        int low = 0;
        int high = arr.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                high = mid - 1; 
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    public int FindLastOccurrence()
    {
        int low = 0;
        int high = arr.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                low = mid + 1; 
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    public void PrintResult()
    {
        int first = FindFirstOccurrence();
        int last = FindLastOccurrence();

        Console.WriteLine("First Occurrence Index: " + first);
        Console.WriteLine("Last Occurrence Index: " + last);
    }
}
