using System.IO;
using System.Text;

namespace BigONotation;

public class LargeFileReadingEfficiency
{
    // Using StreamReader
    public static void ReadUsingStreamReader(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                Console.WriteLine("a");
            }
        }
    }

    // Using FileStream
    public static void ReadUsingFileStream(string filePath)
    {
        byte[] buffer = new byte[8192];

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            while (fs.Read(buffer, 0, buffer.Length) > 0)
            {
                // Reading
            }
        }
    }
}
