using System.Text;

namespace FileHandling;

public class ReverseUsingBuilder
{
    public void ReverseString()
    {
        StringBuilder sb = new StringBuilder("Stranger Things");

        Console.WriteLine("original String: " + sb);
        
        for(int i=sb.Length-1; i>=0; i--)
        {
            Console.Write(sb[i]);
        }
    }
}
