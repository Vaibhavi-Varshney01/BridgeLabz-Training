using System;
class ReplaceWord{
    static void Main(){
        string sentence = "I love Java";
        string oldWord = "Java";
        string newWord = "CSharp";
        string result = "";
        string word = "";
        for (int i = 0; i < sentence.Length; i++){
            if (sentence[i] != ' ')
                word += sentence[i];
            else{
                result += (word == oldWord ? newWord : word) + " ";
                word = "";
            }
        }
        result += (word == oldWord ? newWord : word);
        Console.WriteLine(result);
    }
}
