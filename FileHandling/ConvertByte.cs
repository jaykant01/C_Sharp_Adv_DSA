using System.IO;
using System.Text;

namespace FileHandling;

public class ConvertByte
{
    // Create file
    public void CreateBinaryFile(string filePath)
    {
        // Raw bytes representing "Stranger Things"
        byte[] data =
        {
                83, 116, 114, 97, 110, 103, 101, 114, 32,
                84, 104, 105, 110, 103, 115
            };

        File.WriteAllBytes(filePath, data);
    }

    public void ReadAsCharacters(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        // Byte stream
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            // StreamReader converts bytes to characters
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                int ch;
                while ((ch = reader.Read()) != -1)
                {
                    Console.Write((char)ch);
                }
            }
        }
    }
}
