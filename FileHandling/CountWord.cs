using System.IO;

namespace FileHandling;

public class CountWord
{
    public int FileReader(string filePath, string word)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File Not Found");
            return 0;
        }

        int count = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;

            while((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(new char[]
                {
                    ' ', ';','.','!','?',',',':'
                }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string w in words)
                {
                    if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
            }
   
        }
        return count;
    }
}
