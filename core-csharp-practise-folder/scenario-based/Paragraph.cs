using System;
class ParagraphAnalyzer{
    static void Main()
    {
        string paragraph = "This is a sample paragraph. This paragraph is simple.";

        AnalyzeParagraph(paragraph, "paragraph", "text");
    }

    static void AnalyzeParagraph(string paragraph, string oldWord, string newWord)
    {
        if (string.IsNullOrWhiteSpace(paragraph))
        {
            Console.WriteLine("Paragraph is empty or contains only spaces.");
            return;
        }
        string[] words = paragraph.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Word Count: " + words.Length);

        string longestWord = words[0];
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
                longestWord = word;
        }

        Console.WriteLine("Longest Word: " + longestWord);
        string replacedText = Regex.Replace(paragraph, oldWord, newWord, RegexOptions.IgnoreCase);

        Console.WriteLine("Modified Paragraph:");
        Console.WriteLine(replacedText);
    }
}
