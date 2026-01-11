namespace Sorting;

public class InsertionSort
{
    public static void Insertion()
    {
        int[] employeeIds = { 1045, 1021, 1098, 1012, 1067, 1033 };

        Console.WriteLine("Employee IDs before sorting:");
        foreach (int id in employeeIds)
        {
            Console.Write(id + " ");
        }

        int n = employeeIds.Length;

        for (int i = 1; i < n; i++)
        {
            int key = employeeIds[i];
            int j = i - 1;

            
            while (j >= 0 && employeeIds[j] > key)
            {
                employeeIds[j + 1] = employeeIds[j];
                j--;
            }

            employeeIds[j + 1] = key;
        }

        Console.WriteLine("\n\nEmployee IDs after sorting (Ascending Order):");
        foreach (int id in employeeIds)
        {
            Console.Write(id + " ");
        }
    }
}
