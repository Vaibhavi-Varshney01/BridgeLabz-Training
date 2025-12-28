using System;
class LongestWord{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        string longestWord = "";
        for (int i = 0; i < words.Length; i++){
            if (words[i].Length > longestWord.Length){
                longestWord = words[i];
            }
        }
        Console.WriteLine("Longest word is: " + longestWord);
    }
}
