using System.Text;

namespace FileHandling;

public class StringConcatenation
{
    public void Concatenation()
    {
        string[] arr = { " X Jod" };
        StringBuilder sb = new StringBuilder("Steve");
        foreach (string str in arr)
        {
            sb.Append(str);
        }

        Console.WriteLine(sb.ToString());
    }
}
