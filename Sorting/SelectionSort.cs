namespace Sorting;

public class SelectionSort
{
    public static void Selection()
    {
        int[] scores = { 72, 88, 64, 95, 81, 70 };

        Console.WriteLine("Exam scores before sorting:");
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }

        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            
            if (minIndex != i)
            {
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        Console.WriteLine("\n\nExam scores after sorting (Ascending Order):");
        foreach (int score in scores)
        {
            Console.Write(score + " ");
        }
    }
}
