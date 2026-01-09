namespace FileHandling;

public class UserInputWriter
{
    private string filePath;

    public UserInputWriter(string filePath)
    {
        this.filePath = filePath;
    }

    public void WriteInputToFile()
    {
        Console.WriteLine("Enter text to write to file:");
        string input = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine(input);
        }

        Console.WriteLine("Your input has been written to " + filePath);
    }

    public void ReadFile()
    {
        Console.WriteLine("\nContents of the file:");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
