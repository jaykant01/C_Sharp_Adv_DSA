namespace Searching;

public class SentenceSearch
{
    public string FindSentenceWithWord()
    {
        string[] sentences = {
                "The quick brown fox jumps over the lazy dog.",
                "Linear search is simple but not efficient.",
            };

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine();

        for (int i = 0; i < sentences.Length; i++)
        {

            if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return sentences[i];
            }
        }
        return null;
    }
}
