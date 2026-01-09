using System.IO;
namespace FileHandling;

public class ReadFile
{
    public void FileReader(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File Not Found");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    

}
