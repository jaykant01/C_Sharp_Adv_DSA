namespace Sorting;

public class BubbleSort
{
    public static void Bubble()
    {
        int[] marks = { 78, 45, 90, 62, 88, 55 };

        Console.WriteLine("Marks before sorting:");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }

        int n = marks.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }

        Console.WriteLine("\n\nMarks after sorting (Ascending Order):");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
    }
}
