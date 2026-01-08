namespace BigONotation;

public class SearchComparison
{
    public static int[] GenerateData(int size)
    {
        int[] arr = new int[size];
        for(int i=0; i<size; i++)
        {
            arr[i] = i; 
        }
        return arr;
    }

    public static int LinearSearch(int[] arr, int target)
    {
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(int[] arr, int target)
    {
        int st = 0;
        int end = arr.Length;

        while(st <= end)
        {
            int mid = st + (end - st) / 2;

            if(arr[mid] == target)
            {
                return mid;
            }else if(target >  arr[mid])
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
