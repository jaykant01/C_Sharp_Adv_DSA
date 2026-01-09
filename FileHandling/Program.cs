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
        //ReadFile read = new ReadFile();
        //read.FileReader(@"D:\C# All Repo\C_Sharp_ADV_DSA\FileHandling\TextFile.txt");

        //CountWord c = new CountWord();
        //int result = c.FileReader(@"D:\C# All Repo\C_Sharp_ADV_DSA\FileHandling\TextFile.txt", "Steve");
        //Console.WriteLine("Word count: " + result);

        //ConvertByte cv = new ConvertByte();
        //cv.CreateBinaryFile("byte.txt");
        //cv.ReadAsCharacters("byte.txt");


        string path = (@"D:\C# All Repo\C_Sharp_ADV_DSA\FileHandling\TextFile.txt");
        UserInputWriter inputWriter = new UserInputWriter(path);

        // Read user input and write to file
        inputWriter.WriteInputToFile();

        // Read the file and print contents
        inputWriter.ReadFile();

        Console.ReadKey();

    }
}
