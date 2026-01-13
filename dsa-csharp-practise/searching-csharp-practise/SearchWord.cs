using System;
class SearchWord{
    static void Main(){
        string[] sentences =
        {
            "I love coding",
            "C# is powerful",
            "Binary search is fast",
            "Linear search is simple"
        };
        string word = "search";
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word))
            {
                Console.WriteLine("Sentence Found: " + sentences[i]);
                return;
            }
        }

        Console.WriteLine("Word not found in any sentence");
    }
}
