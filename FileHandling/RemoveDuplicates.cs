using System.Text;

namespace FileHandling;

public class RemoveDuplicates
{
    public void Duplicate()
    {
        StringBuilder sb = new StringBuilder("Heelloo");

        for(int i=1; i<sb.Length; i++)
        {
            if (sb[i] == sb[i - 1])
            {
                sb.Remove(i, 1);
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
