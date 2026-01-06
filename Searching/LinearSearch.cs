namespace Searching;

public class LinearSearch
{
    public int LinearS()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i<n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int target = Convert.ToInt32(Console.ReadLine());

        // Linear Search Logic
        for(int i=0; i<n; i++)
        {
            if(arr[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
}
