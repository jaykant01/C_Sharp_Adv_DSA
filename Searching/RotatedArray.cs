namespace Searching;

public class RotatedArray
{
    private int[] arr = { 15, 18, 2, 3, 6, 12 };

    public int FindRotationPoint()
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] > arr[high])
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

    public void PrintResult()
    {
        int index = FindRotationPoint();
        Console.WriteLine("Rotation Point Index: " + index);
        Console.WriteLine("Smallest Element: " + arr[index]);
    }
}
