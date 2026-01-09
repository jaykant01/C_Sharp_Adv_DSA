using System.Runtime.InteropServices;

namespace FileHandling;

class Program
{
    static void Main(string[] args)
    {
        // String builder Problem 1
        //ReverseUsingBuilder r = new ReverseUsingBuilder();
        //r.ReverseString();

        //RemoveDuplicates rd = new RemoveDuplicates();
        //rd.Duplicate();

        //StringConcatenation sc = new StringConcatenation();
        //sc.Concatenation();

        // File Handling
        ReadFile read = new ReadFile();
        read.FileReader(@"D:\C# All Repo\C_Sharp_ADV_DSA\FileHandling\TextFile.txt");



        Console.ReadKey();

    }
}
