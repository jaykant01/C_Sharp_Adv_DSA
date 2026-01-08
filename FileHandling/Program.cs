using System.Runtime.InteropServices;

namespace FileHandling;

class Program
{
    static void Main(string[] args)
    {
        // String builder Problem 1
        ReverseUsingBuilder r = new ReverseUsingBuilder();
        r.ReverseString();

        Console.ReadKey();

    }
}
