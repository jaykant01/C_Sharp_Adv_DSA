namespace Sorting;

public class CountingSortStudentAges
{
    public static void CountingSort()
    {
        int[] ages = { 12, 15, 10, 14, 18, 11, 13, 16, 12, 15 };

        Console.WriteLine("Student ages before sorting:");
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }

        int minAge = 10;
        int maxAge = 18;

        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        // Step 1: Store frequency of each age
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        // Step 2: Compute cumulative frequency
        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in correct position (stable sort)
        for (int i = ages.Length - 1; i >= 0; i--)
        {
            int age = ages[i];
            int index = count[age - minAge] - 1;
            output[index] = age;
            count[age - minAge]--;
        }

        // Copy output back to original array
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }

        Console.WriteLine("\n\nStudent ages after sorting (Ascending Order):");
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }
    }
}
