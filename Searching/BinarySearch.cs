namespace Searching;

public class BinarySearch
{
    public int BinaryS()
    {
        int[] arr = {2, 4, 5, 7, 9, 10, 12, 14, 16, 18, 20 };

        int st = 0;
        int end = arr.Length-1;
        int target = Convert.ToInt32(Console.ReadLine());
        while(st <= end)
        {
            int mid = st + (end - st) / 2;

            if (arr[mid] == target)
            {
                return mid;

            }else if (target > arr[mid])
            {
                st = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return -1;
    }
}
