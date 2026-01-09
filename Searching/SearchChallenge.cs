namespace Searching;

public class SearchChallenge
{
    public static int FindFirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        bool[] present = new bool[n + 1];

        // Mark existing positive numbers
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0 && nums[i] <= n)
            {
                present[nums[i]] = true;
            }
        }

        // Find the first missing positive
        for (int i = 1; i <= n; i++)
        {
            if (!present[i])
                return i;
        }

        return n + 1;
    }

    public static int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}
