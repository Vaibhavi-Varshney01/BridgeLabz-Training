using System;
class Split{
    static void Main(){
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        string[,] result = SplitWordsWithLength(input);
        Console.WriteLine("\nWord \t Length");
        Console.WriteLine("----------------");
        for (int i = 0; i < result.GetLength(0); i++){
            Console.WriteLine(result[i, 0] + "\t " + result[i, 1]);
        }
    }
    static string[,] SplitWordsWithLength(string text){
        int wordCount = CountWords(text);
        string[,] data = new string[wordCount, 2];
        string word = "";
        int row = 0;
        for (int i = 0; i < GetLength(text); i++){
            if (text[i] != ' '){
                word += text[i];
            }
            else{
                data[row, 0] = word;
                data[row, 1] = GetLength(word).ToString();
                row++;
                word = "";
            }
        }
        data[row, 0] = word;
        data[row, 1] = GetLength(word).ToString();
        return data;
    }
    static int CountWords(string text){
        int count = 1;
        for (int i = 0; i < GetLength(text); i++){
            if (text[i] == ' ')
                count++;
        }
        return count;
    }
    static int GetLength(string s){
        int len = 0;
        foreach (char c in s){
            len++;
        }
        return len;
    }
}
