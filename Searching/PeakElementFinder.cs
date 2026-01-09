namespace Searching;

public class PeakElementFinder
{
    private int[] arr = { 1, 3, 20, 4, 1, 0 };

    public int FindPeakElementIndex()
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] < arr[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }

    public void PrintPeak()
    {
        int peakIndex = FindPeakElementIndex();
        Console.WriteLine("Peak Element Index: " + peakIndex);
        Console.WriteLine("Peak Element Value: " + arr[peakIndex]);
    }
}
