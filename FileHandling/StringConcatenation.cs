using System.Text;
using System.Diagnostics;

namespace FileHandling;

public class StringConcatenation
{
    public void Concatenation()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();

        //string[] arr = { " X Jod" };
        string[] arr = new string[100000];

        for (int i = 0; i<arr.Length; i++)
        {
            arr[i] = "i";
        }

        StringBuilder sb = new StringBuilder("Steve");
        foreach (string str in arr)
        {
            sb.Append(str);
        }

        sw.Stop();

        //Console.WriteLine(sb.ToString());
        Console.WriteLine("Time taken (ms): " + sw.ElapsedMilliseconds);
    }
}
