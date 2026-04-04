using System;
class SentenceFormatter
{
    static void Main()
    {
        string input = "  hello world.this is a test!how are you?  i am fine. ";
        string result = FormatSentence(input);

        Console.WriteLine("Formatted Paragraph:");
        Console.WriteLine(result);
    }

    static string FormatSentence(string paragraph)
    {
        if (string.IsNullOrWhiteSpace(paragraph))
            return "";

        paragraph = Regex.Replace(paragraph.Trim(), @"\s+", " ");

        // Fix space after punctuation
        paragraph = Regex.Replace(paragraph, @"([.!?])\s*", "$1 ");

        string[] sentences = paragraph.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        char[] punctuations = { '.', '!', '?' };
        string formatted = "";
        int index = 0;

        foreach (string s in sentences)
        {
            string sentence = s.Trim();
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);
            formatted += sentence + punctuations[index] + " ";
            index++;
        }

        return formatted.Trim();
    }
}
