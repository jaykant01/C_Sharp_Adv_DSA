using System.Text;


namespace BigONotation;

public class StringConcatenationPerformance
{
    // Using string
    public static string UsingString(int count)
    {
        string result = "";

        for (int i = 0; i < count; i++)
        {
            result += "a";
        }

        return result;
    }

    // Using StringBuilder
    public static string UsingStringBuilder(int count)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append("a");
        }

        return sb.ToString();
    }
}
