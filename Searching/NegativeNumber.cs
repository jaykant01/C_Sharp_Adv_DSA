namespace Searching;

public class NegativeNumber
{
   public int FindFirstNegative()
   {
        int[] arr = { 3, 7, 0, 2, -5, 4, -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return arr[i];
            }
        }
        return int.MinValue;
    }
}
