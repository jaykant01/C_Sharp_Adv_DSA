namespace Searching;

public class MatrixBinarySearch
{
    private int[,] matrix =
        {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

    private int target = 16;

    public bool SearchMatrix()
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int top = 0;
        int bottom = rows - 1;

        while (top <= bottom)
        {
            int midRow = (top + bottom) / 2;

            if (target >= matrix[midRow, 0] && target <= matrix[midRow, cols - 1])
            {  
                return BinarySearchRow(midRow, cols);
            }
            else if (target < matrix[midRow, 0])
            {
                bottom = midRow - 1;
            }
            else
            {
                top = midRow + 1;
            }
        }

        return false;
    }

    private bool BinarySearchRow(int row, int cols)
    {
        int left = 0;
        int right = cols - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (matrix[row, mid] == target)
                return true;
            else if (matrix[row, mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }

    public void PrintResult()
    {
        bool found = SearchMatrix();
        Console.WriteLine(found ? $"Target {target} found in matrix." : $"Target {target} not found in matrix.");
    }
}
